﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class PaintBrush
    {
        public Point Position;
        public int Radius;

        public PaintBrush(int r)
        {
            Position = new Point(0, 0);
            Radius = r;
        }

        public void PaintOnBitmap(DirectBitmap bitmap, bool erase)
        {
            int iStart = Math.Max(Position.X - Radius, 0);
            int jStart = Math.Max(Position.Y - Radius, 0);
            int iEnd = Math.Min(Position.X + Radius, bitmap.Width - 1);
            int jEnd = Math.Min(Position.Y + Radius, bitmap.Height - 1);

            for (int i = iStart; i <= iEnd; i++)
            //Parallel.For(iStart, iEnd, i =>
            {
                for (int j = jStart; j <= jEnd; j++)
                //Parallel.For(jStart, jEnd, j =>
                {
                    if (IsInsideCircle(i, j))
                        bitmap.SetPixel(i, j, erase ? Color.Black : Color.White);
                }
                //);
            }
            //);
        }

        private bool IsInsideCircle(int x, int y) =>
            (x - Position.X) * (x - Position.X) + (y - Position.Y) * (y - Position.Y) <= Radius * Radius;
    }
}
