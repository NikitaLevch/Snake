using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {          
        static void Main(string[] args)
        {
            //Point p1 = new Point(1, 2, '!');
            //Point p2 = new Point(3, 4, '@');
            //Point p3 = new Point(5, 6, '#');
            //Point p4 = new Point(7, 8, '$');
            //List<Point> plist = new List<Point>();
            //plist.Add(p1);
            //plist.Add(p2);
            //plist.Add(p3);
            //plist.Add(p4);
            HorizontalLine line1 = new HorizontalLine(0,10,0,'*');
            line1.DrawLine();
            VerticalLine line2 = new VerticalLine(0,10,0,'*');
            line2.DrawLine();
            Console.ReadKey();
        }
    }
}
      
        
        
      
    


























