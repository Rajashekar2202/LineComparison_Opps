using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComaprison_0pps
{
    public class LineComparisonUC2
    {

        int x1, x2, y1, y2;
        int a1, a2, b1, b2;

        public void EqualOrNot()
        {
            Double distance_a, distance_b;
            x1 = 2; y1 = 3; x2 = 4; y2 = 6;
            a1 = 2; a2 = 3; b1 = 4; b2 = 6;
            distance_a = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine("Calculate length1: " + distance_a);
            distance_b = Math.Sqrt(Math.Pow((a1 - a2), 2) + Math.Pow((b1 - b2), 2));
            Console.WriteLine("Calculate length2: " + distance_b);
            if (distance_a == distance_b)
            {
                Console.WriteLine("Lines are Equal");
            }
            else
            {
                Console.WriteLine("Line are not Equal");
            }
        }
    }
}
