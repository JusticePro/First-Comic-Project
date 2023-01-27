using First_Comic_Project.Controls.Episode;
using First_Comic_Project.Operations.Selectors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace First_Comic_Project.Controls
{
    public partial class ControlPanelGathering : UserControl, EpisodeSelection
    {
        public UserControl episodeSelection;

        public ControlPanelGathering()
        {
            InitializeComponent();
        }

        public IEnumerable<int> getEpisodes()
        {
            return ((EpisodeSelection)episodeSelection).getEpisodes();
        }

        private void ControlPanelGathering_Load(object sender, EventArgs e)
        {
            episodeSelectionMode.SelectedIndex = 0;
            setEpisodeControl(new ControlSingle());
        }

        void setEpisodeControl(UserControl control)
        {
            if (!(control is EpisodeSelection))
            {
                throw new Exception("Control is not an episode selection.");
            }

            // If an item is present, remove it.
            if (episodeSelection != null)
            {
                gatheringGroupBox.Controls.Remove(episodeSelection);
            }

            gatheringGroupBox.Controls.Add(control);
            control.Location = new Point(3, 43);

            episodeSelection = control;
        }

        private void episodeSelectionMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (episodeSelectionMode.SelectedIndex)
            {
                case 0:
                    setEpisodeControl(new ControlSingle());
                    break;

                case 1:
                    setEpisodeControl(new ControlRange());
                    break;

                case 2:
                    setEpisodeControl(new ControlList());
                    break;
            }
        }
    }
}
