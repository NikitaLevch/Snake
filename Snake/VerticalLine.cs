using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLine
    {
        List<Point> plist;
        public VerticalLine(int xTop, int xBottom, int x, char sym)
        {
            plist = new List<Point>();

            for (int y = xTop; y <= xBottom; y++)
            {
                Point p = new Point(x, y, sym);
                plist.Add(p);
            }
        }

        public void DrawLine()
        {
            foreach (Point p in plist)
            {
                p.Draw();
            }
        }
    }
}
