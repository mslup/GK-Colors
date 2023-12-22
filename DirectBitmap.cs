using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    public class DirectBitmap : IDisposable
    {
        // https://stackoverflow.com/questions/24701703/c-sharp-faster-alternatives-to-setpixel-and-getpixel-for-bitmaps-for-windows-f?fbclid=IwAR1mLB-HaMFHUOq8X6GstgGexO_MFZ2PlhWtaOk9nhXE6yZHQ5I-8WNQ7Y4
        public Bitmap Bitmap { get; private set; }
        public Int32[] Bits { get; private set; }
        public bool Disposed { get; private set; }
        public int Height { get; private set; }
        public int Width { get; private set; }

        protected GCHandle BitsHandle { get; private set; }

        public DirectBitmap(int width, int height)
        {
            Width = width;
            Height = height;

            Clear();
        }

        public DirectBitmap(Image image, int width, int height) : this(width, height)
        {
            if (image == null)
                return;

            using (var g = Graphics.FromImage(Bitmap))
                g.DrawImage(image, 0, 0, Width, Height);
        }

        public void Clear()
        {
            Bits = new Int32[Width * Height];
            BitsHandle = GCHandle.Alloc(Bits, GCHandleType.Pinned);
            Bitmap = new Bitmap(Width, Height, Width * 4, PixelFormat.Format32bppPArgb, BitsHandle.AddrOfPinnedObject());
        }

        public void SetFilled()
        {
            for (int i = 0; i < Width; ++i)
                for (int j = 0; j < Height; ++j)
                    SetPixel(i, j, Color.White);
        }

        public void SetPixel(int x, int y, Color colour)
        {
            int index = x + (y * Width);
            int col = colour.ToArgb();

            Bits[index] = col;
        }

        public Color GetPixel(int x, int y)
        {
            int index = x + (y * Width);
            int col = Bits[index];
            Color result = Color.FromArgb(col);

            return result;
        }

        public bool IsPixelColored(int x, int y)
        {
            return Bits[x + (y * Width)] == Color.White.ToArgb();
        }

        public void Dispose()
        {
            if (Disposed) return;
            Disposed = true;
            Bitmap.Dispose();
            BitsHandle.Free();
        }


    }
}
