using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_Comic_Project.Operations.Selectors
{
    public class WhitespaceSelector : SeparatorSelection
    {
        /// <summary>
        /// This selector detects if the color is exactly white.
        /// </summary>
        /// <param name="color">The color to check if it is whitespace.</param>
        /// <returns>If color is white (255,255,255).</returns>
        public bool isWhitespace(Color color)
        {
            return SeperatorUtils.isEqual(color, Color.FromArgb(255, 255, 255));
        }
    }
}
