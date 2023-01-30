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

namespace First_Comic_Project.Controls.Separator
{
    public partial class ControlBrightness : UserControl, SeparatorSelection
    {
        private int ceiling = 0;
        private int floor = 0;

        public ControlBrightness()
        {
            InitializeComponent();
        }

        public bool isWhitespace(Color color)
        {
            /*
             * We look for black swans first. If we do that, we don't necessarily have to go through all three variables.
             */

            // Is Red NOT in range.
            if (!(color.R <= ceiling && color.R >= floor))
                return false;

            // Is Green NOT in range.
            if (!(color.G <= ceiling && color.G >= floor))
                return false;

            // Is Blue NOT in range.
            if (!(color.B <= ceiling && color.B >= floor))
                return false;

            // Therefore RGB is in range.
            return true;
        }

        public bool validate()
        {
            if (spinnerFloor.Value > spinnerCeiling.Value)
            {
                MessageBox.Show("Floor is higher than ceiling.");
                return false;
            }

            // Take snapshots so that they don't change during the operation.
            ceiling = (int)spinnerCeiling.Value;
            floor = (int)spinnerFloor.Value;
            return true;
        }
    }
}
