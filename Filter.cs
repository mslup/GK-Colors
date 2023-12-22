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
        private float[,] matrix;
        private int divisor;
        private int offset;

        public Filter()
        {
            matrix = new float[3, 3]
            {
                { 0, -1, 0 },
                { -1, 6, -1 },
                { 0, -1, 0 }
            };
            divisor = 1;
            offset = 0;
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

                    R += (int)(matrix[i + 1, j + 1] * image.GetPixel(X, Y).R);
                    G += (int)(matrix[i + 1, j + 1] * image.GetPixel(X, Y).G);
                    B += (int)(matrix[i + 1, j + 1] * image.GetPixel(X, Y).B);
                }
            }

            // offset, divisor
            return Color.FromArgb(
                Math.Clamp(R, 0, 255), 
                Math.Clamp(G, 0, 255), 
                Math.Clamp(B, 0, 255));
        }

     
    }
}
