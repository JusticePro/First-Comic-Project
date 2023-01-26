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

namespace First_Comic_Project.Controls.Episode
{
    public partial class ControlSingle : UserControl, EpisodeSelection
    {
        public ControlSingle()
        {
            InitializeComponent();
        }

        public IEnumerable<int> getEpisodes()
        {
            return new int[] { (int)spinnerEpisode.Value };
        }
    }
}
