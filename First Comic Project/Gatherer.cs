using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace First_Comic_Project
{
    public class Gatherer
    {
        /// <summary>
        /// The prefix for the Webtoon comic which the episode ID is placed afterwards.
        /// Default: "https://www.webtoons.com/en/sf/space-boy/ep-1/viewer?title_no=400&episode_no=".
        /// </summary>
        //public const string webtoonURLPrefix = "https://www.webtoons.com/en/sf/space-boy/ep-1/viewer?title_no=400&episode_no=";
        public static string webtoonURLPrefix
        {
            get
            {
                return Form1.instance.urlBox.Text;
            }
        }

        /// <summary>
        /// Get the comic strip of a Spaceboy episode from its id.
        /// </summary>
        /// <param name="id">The ID of the Spaceboy episode</param>
        /// <returns>An image of the episode.</returns>
        public static Image getComic(int id)
        {
            return downloadImage(webtoonURLPrefix + id);
        }

        /// <summary>
        /// Downloads the images from the URL of a comic episode, stacks them, and returns the final episode photo.
        /// </summary>
        static Image downloadImage(string pageUrl)
        {
            List<Image> images = new List<Image>();

            foreach (string imageUrl in getImagesUrls(pageUrl))
            {
                images.Add(readImage(imageUrl, pageUrl));
            }
            
            return stackImages(images);
        }

        /// <summary>
        /// Reads an image from an Image URL.
        /// Referer is the page you are reading the image from. (Required to avoid security).
        /// </summary>
        static Image readImage(string imageUrl, string referer)
        {
            WebClient client = new WebClient();

            // This handles the anti-piracy security.
            client.Headers.Add("Referer", referer);

            Stream stream = client.OpenRead(imageUrl);
            Bitmap bitmap;
            bitmap = new Bitmap(stream);

            stream.Flush();
            stream.Close();
            client.Dispose();

            if (bitmap != null)
            {
                return bitmap;
            }

            return null;
        }

        /// <summary>
        /// Takes a <c>List</c> of <c>Image</c>s and stacks them on top of each other.
        /// </summary>
        static Image stackImages(List<Image> images)
        {
            Size imageSize = getImageSize(images);

            Bitmap image = new Bitmap(imageSize.Width, imageSize.Height);
            Graphics g = Graphics.FromImage(image);

            int y = 0;

            foreach (Image img in images)
            {
                g.DrawImage(img, 0, y);
                y += img.Height;
            }

            return image;
        }


        /// <summary>
        /// Takes a collection of images and finds how large the final photo must be.
        /// </summary>
        static Size getImageSize(List<Image> images)
        {
            int width = 0;
            int height = 0;

            foreach (Image image in images)
            {
                if (image.Width > width)
                {
                    width = image.Width;
                }

                height += image.Height;
            }

            return new Size(width, height);
        }

        /// <summary>
        /// Returns a list of the URLs to the images from the URL of a comic episode.
        /// </summary>
        static List<string> getImagesUrls(string pageUrl)
        {
            WebClient client = new WebClient();

            client.Headers["user-agent"] = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/109.0.0.0 Safari/537.36";
            string page = client.DownloadString(pageUrl);
            List<string> imageUrls = new List<string>();

            string imgElements = page
                .Split(new string[] { "<div class=\"viewer_img _img_viewer_area \" id=\"_imageList\">" }, StringSplitOptions.None)[1]
                .Split(new string[] { "</div>" }, StringSplitOptions.None)[0]
                .Replace("	", "");

            string[] sources = imgElements.Split(new string[] { "<img src=\"" }, StringSplitOptions.None);

            foreach (string src in sources)
            {
                if (src.Trim().Equals(""))
                {
                    continue;
                }

                string[] s = src.Split(new string[] { "data-url=\"" }, StringSplitOptions.RemoveEmptyEntries);

                // s[s.Length - 1] - Because just putting in 1 cause an error.
                string source = s[s.Length - 1].Split('"')[0];
                imageUrls.Add(source);
            }

            return imageUrls;
        }

    }
}
