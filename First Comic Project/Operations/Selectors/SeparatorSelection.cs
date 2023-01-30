using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_Comic_Project.Operations.Selectors
{
    public interface SeparatorSelection
    {
        /// <summary>
        /// This is used by the Separator when it finds whitespace. This chooses what whitespace is defined as.
        /// </summary>
        /// <param name="color">The color of the pixel the Separator is looking at.</param>
        /// <returns>Is the color whitespace.</returns>
        bool isWhitespace(Color color);

        /// <summary>
        /// Called before an operation. This is used to make sure that the separator is correctly setup.
        /// </summary>
        /// <returns>Is the separator ready to execute.</returns>
        bool validate();
    }

    public class SeparatorUtils
    {
        public static bool isEqual(Color color1, Color color2)
        {
            if (color1.A != color2.A)
            {
                return false;
            }

            if (color1.R != color2.R)
            {
                return false;
            }

            if (color1.G != color2.G)
            {
                return false;
            }

            if (color1.B != color2.B)
            {
                return false;
            }

            return true;
        }
    }
}
