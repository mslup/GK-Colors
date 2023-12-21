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

        private Dictionary<int, int> RedBins;
        private Dictionary<int, int> GreenBins;
        private Dictionary<int, int> BlueBins;

        private int pixelCount;

        public ColorHistogram(DirectBitmap bmp)
        {
            RedBins = new Dictionary<int, int>();
            GreenBins = new Dictionary<int, int>();
            BlueBins = new Dictionary<int, int>();

            for (int i = 0; i < 256; i++)
            {
                RedBins[i] = 0;
                GreenBins[i] = 0;
                BlueBins[i] = 0;
            }

            pixelCount = bmp.Width * bmp.Height;
            CalculateHistogram(bmp);
        }

        private void CalculateHistogram(DirectBitmap bmp)
        {
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    Color col = bmp.GetPixel(i, j);

                    int r = col.R;
                    int g = col.G;
                    int b = col.B;

                    RedBins[r]++;
                    GreenBins[g]++;
                    BlueBins[b]++;
                }
            }
        }

        public void DrawHistogram(Graphics g, HistogramColor type, int width, int height)
        {
            Dictionary<int, int> bins;
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

            int max = bins.Values.Max();
            Pen pen = new Pen(new SolidBrush(col));

            for (int i = 0; i < 255; ++i)
            {
                g.DrawLine(pen, i, height, i, height - (int)((1.0 * bins[i] / max) * height));
            }

        }
    }
}
