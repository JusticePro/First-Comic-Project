using First_Comic_Project.Operations.Selectors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace First_Comic_Project.Controls.Episode
{
    public partial class ControlRange : UserControl, EpisodeSelection
    {
        public ControlRange()
        {
            InitializeComponent();
        }

        public IEnumerable<int> getEpisodes()
        {
            if (spinnerEpisodeStart.Value > spinnerEpisodeEnd.Value)
            {
                MessageBox.Show("End episode is larger than start episode");
                return null;
            }

            int size = (int)(spinnerEpisodeEnd.Value - spinnerEpisodeStart.Value) + 1;
            int[] range = new int[size];

            for (int i = 0; i < size; i++)
            {
                range[i] = (int)spinnerEpisodeStart.Value + i;
            }
            
            return range;
        }
    }
}
