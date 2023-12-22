using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class Filter
    {
        public float[,] Matrix;
        public float Divisor;
        public int Offset;

        public Filter(float m00, float m01, float m02,
            float m10, float m11, float m12,
            float m20, float m21, float m22,
            float divisor = 0)
        {
            Matrix = new float[3, 3]
            {
                { m00, m01, m02 },
                { m10, m11, m12 },
                { m20, m21, m22 }
            };
            if (divisor != 0)
                Divisor = divisor;
            else
                CalculateDivisor();
            Offset = 0;
        }

        public void CalculateDivisor()
        {
            Divisor = 0;
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    Divisor += Matrix[i, j];

            if (Divisor == 0)
                Divisor = 1;

            //Divisor = Math.Abs(Divisor);
        }

        public Color Apply(ref DirectBitmap image, int x, int y)
        {
            int R, G, B;
            R = G = B = 0;

            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    int X = Math.Clamp(x + i, 0, image.Width);
                    int Y = Math.Clamp(y + j, 0, image.Height);

                    R += (int)(Matrix[i + 1, j + 1] * image.GetPixel(X, Y).R);
                    G += (int)(Matrix[i + 1, j + 1] * image.GetPixel(X, Y).G);
                    B += (int)(Matrix[i + 1, j + 1] * image.GetPixel(X, Y).B);
                }
            }

            R = (int)(R / Divisor) + Offset;
            G = (int)(G / Divisor) + Offset;
            B = (int)(B / Divisor) + Offset;

            return Color.FromArgb(
                Math.Clamp(R, 0, 255),
                Math.Clamp(G, 0, 255),
                Math.Clamp(B, 0, 255));
        }

        public static Filter Identity =>
            new Filter(0, 0, 0,
                       0, 1, 0,
                       0, 0, 0);

        public static Filter EdgeDetection =>
            new Filter(-1, -1, -1,
                       -1, 8, -1,
                       -1, -1, -1, 1);

        public static Filter Sharpen =>
            new Filter(0, -1, 0,
                       -1, 5, -1,
                        0, -1, 0);

        public static Filter BoxBlur =>
            new Filter(1, 1, 1,
                       1, 1, 1,
                       1, 1, 1);

        public static Filter GaussBlur =>
            new Filter(1, 2, 1,
                       2, 4, 2,
                       1, 2, 1);

        public static Filter SculptSE =>
            new Filter(-1, -1,  0,
                       -1,  1,  1,
                        0,  1,  1);

    }
}
