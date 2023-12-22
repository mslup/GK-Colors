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
        public List<Point> vertices;

        public Polygon()
        {
            vertices = new List<Point>();
        }

        public void DrawUnfinishedPolygon(Graphics g, Point point)
        {
            foreach (Point p in vertices) 
            {
                g.DrawPoint(p);
            }
        }

        public void FillPolygon(Graphics g)
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

            g.FillPath(new SolidBrush(Color.Black), new GraphicsPath(points, types));//, FillMode.Winding));
        }
    }
}
