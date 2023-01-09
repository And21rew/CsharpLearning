using System;
using System.Drawing;

namespace Fractals
{
    internal static class DragonFractalTask
    {
        public static void DrawDragonFractal(Pixels pixels, int iterationsCount, int seed)
        {
            var random = new Random(seed);
            double x = 1, y = 0;
            double angle45 = Math.PI / 4;
            double angle135 = 3 * Math.PI / 4;

            for (int i = 0; i < iterationsCount; i++)
            {
                if (random.Next(2) == 0)
                {
                    var _x = (x * Math.Cos(angle45) - y * Math.Sin(angle45)) / Math.Sqrt(2);
                    var _y = (x * Math.Sin(angle45) + y * Math.Cos(angle45)) / Math.Sqrt(2);
                    x = _x;
                    y = _y;
                }
                else
                {
                    var _x = (x * Math.Cos(angle135) - y * Math.Sin(angle135)) / Math.Sqrt(2) + 1;
                    var _y = (x * Math.Sin(angle135) + y * Math.Cos(angle135)) / Math.Sqrt(2);
                    x = _x;
                    y = _y;
                }
                pixels.SetPixel(x, y);
            }
        }
    }
}