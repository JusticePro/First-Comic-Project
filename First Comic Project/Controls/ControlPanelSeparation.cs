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
    public partial class ControlPanelSeparation : UserControl
    {
        private UserControl separator;

        public ControlPanelSeparation()
        {
            InitializeComponent();
        }

        public SeparatorSelection getSelector()
        {
            return (SeparatorSelection)separator;
        }

        /// <summary>
        /// Set separator panel. Null is NONE.
        /// </summary>
        /// <param name="control"></param>
        void setSeparatorControl(UserControl control)
        {
            // If control is null, it is "NONE" separator. This is removing the selector.
            if (control != null)
            {
                if (!(control is SeparatorSelection))
                {
                    throw new Exception("Control is not a separation selection.");
                }
            }

            // If an item is present, remove it.
            if (separator != null)
            {
                separatingGroupBox.Controls.Remove(separator);
            }

            // Add the control if it isn't null.
            if (control != null)
            {
                separatingGroupBox.Controls.Add(control);
                control.Location = new Point(3, 43);
            }

            separator = control;
        }

        private void ControlPanelSeparation_Load(object sender, EventArgs e)
        {
            separatorSelectionMode.SelectedIndex = 0;
            setSeparatorControl(null);
        }

        private void separatorSelectionMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (separatorSelectionMode.SelectedIndex)
            {
                case 0:
                    setSeparatorControl(null);
                    break;
            }
        }
    }
}
