using System;
using System.Drawing;
using System.Drawing.Drawing2D;


namespace RefactorMe
{
    class Draw
    {
        static float x, y;
        static Graphics graphics;

        public static void Initialize(Graphics newGraphics)
        {
            graphics = newGraphics;
            graphics.SmoothingMode = SmoothingMode.None;
            graphics.Clear(Color.Black);
        }

        public static void SetPosition(float x0, float y0)
        {
            x = x0;
            y = y0;
        }

        public static void MakeIt(Pen pen, double length, double angle)
        {
            //Делает шаг длиной length в направлении angle и рисует пройденную траекторию
            var x1 = (float)(x + length * Math.Cos(angle));
            var y1 = (float)(y + length * Math.Sin(angle));
            graphics.DrawLine(pen, x, y, x1, y1);
            x = x1;
            y = y1;
        }

        public static void Change(double length, double angle)
        {
            x = (float)(x + length * Math.Cos(angle));
            y = (float)(y + length * Math.Sin(angle));
        }
    }

    public class ImpossibleSquare
    {
        private static readonly float sideLength = 0.375f;
        private static readonly float sideWidth = 0.04f;

        public static void Draw(int width, int height, double turnAngle, Graphics graphics)
        {
            // turnAngle пока не используется, но будет использоваться в будущем
            RefactorMe.Draw.Initialize(graphics);

            var size = Math.Min(width, height);

            var diagonalLength = Math.Sqrt(2) * (size * sideLength + size * sideWidth) / 2;
            var x0 = (float)(diagonalLength * Math.Cos(Math.PI / 4 + Math.PI)) + width / 2f;
            var y0 = (float)(diagonalLength * Math.Sin(Math.PI / 4 + Math.PI)) + height / 2f;

            RefactorMe.Draw.SetPosition(x0, y0);

            //Рисуем 1-ую сторону
            DrawSide(Pens.Yellow, size, 0);

            //Рисуем 2-ую сторону
            DrawSide(Pens.Yellow, size, -Math.PI / 2);

            //Рисуем 3-ю сторону
            DrawSide(Pens.Yellow, size, Math.PI);

            //Рисуем 4-ую сторону
            DrawSide(Pens.Yellow, size, Math.PI / 2);
        }

        private static void DrawSide(Pen pen, int size, double angle)
        {
            RefactorMe.Draw.MakeIt(pen, size * sideLength, angle);
            RefactorMe.Draw.MakeIt(pen, size * sideWidth * Math.Sqrt(2), angle + Math.PI / 4);
            RefactorMe.Draw.MakeIt(pen, size * sideLength, angle + Math.PI);
            RefactorMe.Draw.MakeIt(pen, size * sideLength - size * sideWidth, angle + Math.PI / 2);

            RefactorMe.Draw.Change(size * sideWidth, angle - Math.PI);
            RefactorMe.Draw.Change(size * sideWidth * Math.Sqrt(2), angle + 3 * Math.PI / 4);
        }
    }
}