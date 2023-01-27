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
    public partial class ControlStatic : UserControl, SeparatorSelection
    {
        /// <summary>
        /// This is the color for the whitespace.
        /// Defaults to white (#FFF)
        /// </summary>
        private Color staticColor = Color.White;

        public ControlStatic()
        {
            InitializeComponent();
        }

        public bool isWhitespace(Color color)
        {
            return SeparatorUtils.isEqual(staticColor, color);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Color color = colorDialog1.Color;

                // Set the static color.
                staticColor = color;

                // Update the button's color.
                button1.BackColor = color;
            }
        }
    }
}
