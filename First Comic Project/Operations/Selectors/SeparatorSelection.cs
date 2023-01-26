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
        bool isWhitespace(Color color);
    }

    public class SeperatorUtils
    {
        static bool isEqual(Color color1, Color color2)
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
