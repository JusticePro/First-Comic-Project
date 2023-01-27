using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace First_Comic_Project.Controls.Episode
{
    public partial class ControlList : UserControl, EpisodeSelection
    {
        private const string ERROR_MESSAGE = "Format as a comma separated list of integers.\n" +
            "Example: \"42,31,2\" or \"11, 60, 3\".";

        public ControlList()
        {
            InitializeComponent();
        }

        public IEnumerable<int> getEpisodes()
        {
            try
            {
                // Remove spaces and starting whitespace.
                string text = richTextBox.Text.Trim().Replace(" ", "");
                string[] list = text.Split(',');

                List<int> episodes = new List<int>();

                foreach (string str in list)
                {
                    int id;

                    // If is not a number, skip.
                    if (!int.TryParse(str, out id))
                    {
                        MessageBox.Show(ERROR_MESSAGE);
                        return null;
                    }
                    episodes.Add(id);
                }

                return episodes;
            }catch (Exception e)
            {
                MessageBox.Show(ERROR_MESSAGE);
                return null;
            }
            return null;
        }
    }
}
