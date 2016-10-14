using System.Collections.Generic;
using System.Drawing;

namespace PixelFix
{

    /// <summary>
    /// This class contains the settings of the pixel rotation function.
    /// </summary>
    class RotatorSettings
    {
        public static List<Color> ColorList = new List<Color>();
        public static int RotationInterval = 40; // Milliseconds
        public static int RotationDuration = 1 * 60 * 1000 * 60; // 1 Minute
    }
}
