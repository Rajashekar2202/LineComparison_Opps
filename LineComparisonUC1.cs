using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComaprison_0pps
{
    internal class LineComparisonUC1
    {
        public void Distance()
        {
            int x1 = 1, y1 = 1, x2 = 3, y2 = 3;
            double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            Console.WriteLine("Calculate the distance of give cartisian :" + distance);
        }
    }
}
