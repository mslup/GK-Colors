using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class ColorHistogram
    {
        public enum HistogramColor
        {
            RED, GREEN, BLUE
        };

        private int[] RedBins;
        private int[] GreenBins;
        private int[] BlueBins;

        public ColorHistogram(DirectBitmap bmp)
        {
            RedBins = new int[256];
            GreenBins = new int[256];
            BlueBins = new int[256];

            CalculateHistogram(bmp);
        }

        public void CalculateHistogram(DirectBitmap bmp)
        {
            //Parallel.For(0, 256, i =>
            for (int i = 0; i < 256; i++)
            {
                RedBins[i] = 0;
                GreenBins[i] = 0;
                BlueBins[i] = 0;
            }
            //);

            //Parallel.For(0, bmp.Width, i =>
            for (int i = 0; i < bmp.Width; i++)
            {
                //Parallel.For(0, bmp.Height, j =>
                for (int j = 0; j < bmp.Height; j++) 
                {
                    Color col = bmp.GetPixel(i, j);

                    RedBins[col.R]++;
                    GreenBins[col.G]++;
                    BlueBins[col.B]++;
                }
                //);
            }
            //);
        }

        public void DrawHistogram(Graphics g, HistogramColor type, int width, int height)
        {
            int[] bins;
            Color col;

            switch (type)
            {
            case HistogramColor.RED:
                bins = RedBins;
                col = Color.Red;
                break;
            case HistogramColor.GREEN:
                bins = GreenBins;
                col = Color.Green;
                break;
            case HistogramColor.BLUE:
                bins = BlueBins;
                col = Color.Blue;
                break;
            default:
                return;
            }

            int max = bins.Max();
            Pen pen = new Pen(new SolidBrush(col));

            for (int i = 0; i < 256; ++i)
            {
                g.DrawLine(pen, i, height, i, height - (int)((1.0 * bins[i] / max) * height));
            }

        }
    }
}
