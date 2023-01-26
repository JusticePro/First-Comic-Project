using First_Comic_Project.Operations.Selectors;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_Comic_Project.Operations
{
    class Separator
    {

        /// <summary>
        /// Separates the panels of a comic strip.
        /// </summary>
        /// <param name="color">The color of the whitespace to cut out.</param>
        public static List<Image> separatePanels(Image image, SeparatorSelection seperatorSelector)
        {
            List<int[]> regions = getRegions(image, seperatorSelector);
            List<Image> images = new List<Image>();

            foreach (int[] region in regions)
            {
                Image img = cropImage(image, region[0], region[1]);

                if (img == null)
                {
                    continue;
                }

                images.Add(img);
            }

            if (images.Count == 0)
            {
                images.Add(image);
            }

            return images;
        }

        /// <summary>
        /// Crop an image based on the starting Y and the ending Y.
        /// </summary>
        /// <returns>The cropped image.</returns>
        static Image cropImage(Image image, int rowStart, int rowEnd)
        {
            if (rowEnd - rowStart == 0)
                return null;
            
            Bitmap bmpImage = new Bitmap(image);
            Bitmap i = bmpImage.Clone(new Rectangle(0, rowStart, image.Width, rowEnd - rowStart), bmpImage.PixelFormat);

            bmpImage.Dispose();

            return i;
        }

        /// <summary>
        /// Get the regions of the image which aren't whitespace.
        /// </summary>
        /// <param name="image"></param>
        /// <returns>A list of two int arrays. The first int is the start of the region. The second is the end of the region.</returns>
        static List<int[]> getRegions(Image image, SeparatorSelection separatorSelector)
        {
            List<int[]> regions = new List<int[]>();
            Bitmap map = new Bitmap(image);

            // Null means there isn't a region currently.
            int[] currentRegion = null;

            for (int y = 0; y < image.Height; y++)
            {
                // Start of row.
                bool isEmpty = true;

                for (int x = 0; x < image.Width; x++)
                {
                    // Is the pixel not whitespace?
                    if (!separatorSelector.isWhitespace(map.GetPixel(x, y)))
                    {
                        isEmpty = false; // Then the row isn't empty.
                        break; // End scanning the row.
                    }
                }

                if (!isEmpty)
                {
                    // Has the region not been started yet?
                    if (currentRegion == null)
                    {
                        // Create the region and set the start of the region to Y.
                        currentRegion = new int[2];
                        currentRegion[0] = y;
                    }
                }else
                {
                    // Is a region being written?
                    if (currentRegion != null)
                    {
                        // The last row was the last row in the region.
                        currentRegion[1] = y-1;
                        regions.Add(currentRegion);

                        currentRegion = null; // Stop writing a region.
                    }
                }

                // End of row.
            }

            return regions;
        }

    }
}
