using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal static class GraphicsExtensions
    {
        private static int pointWidth = 2;
        private static Pen pointPen = new Pen(Color.LightSlateGray, pointWidth);

        public static void DrawPoint(this Graphics g, Point p, bool highlight = true)
        {
            //if (pen == null)
            var pen = pointPen;

            //if (highlight && NeoGebra.MousePos.IsCloseToPoint(p))
            //    g.DrawEllipse(hlPointPen,
            //        p.X - hlPointWidth / 2,
            //        p.Y - hlPointWidth / 2,
            //        hlPointWidth, hlPointWidth);

            g.DrawEllipse(pen,
                p.X - pointWidth / 2,
                p.Y - pointWidth / 2,
                pointWidth, pointWidth);

            //if (NeoGebra.Debug)
            //    g.DrawString($"{p.X}, {p.Y}",
            //        new Font("Arial", 10),
            //        new SolidBrush(Color.Black),
            //        new Point((int)p.X + 5, (int)p.Y + 5));
        }
    }
}
