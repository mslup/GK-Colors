using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class Polygon
    {
        private static int lineWidth = 2;
        private static Pen linePen = new Pen(Color.PeachPuff, lineWidth);

        public List<Point> vertices;

        public Polygon()
        {
            vertices = new List<Point>();
        }

        public void DrawUnfinishedPolygon(Graphics g, Point point)
        {
            Point? prev = null;
            // todo: move linepen out of here as well
            foreach (Point p in vertices) 
            {
                g.DrawPoint(p);
                if (prev != null)
                    g.DrawLine(linePen, (Point)prev, p);
                prev = p;
            }
            if (prev != null)
                g.DrawLine(linePen, (Point)prev, point);
        }

        public void FillPolygon(Graphics g, bool erase)
        {
            Point[] points = new Point[vertices.Count];
            byte[] types = new byte[vertices.Count];
            int it = 0;
            foreach (Point point in vertices)
            {
                points[it] = point;
                types[it] = 1;
                it++;
            }

            g.FillPath(new SolidBrush(erase ? Color.Black : Color.White), new GraphicsPath(points, types));//, FillMode.Winding));
        }
    }
}
