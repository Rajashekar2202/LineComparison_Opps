using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComaprison_0pps
{
    public class LineComparisonUC4
    {
        public int x1, x2, y1, y2, a1, a2, b1, b2;

        public double line_a;
        public double line_b;
        public void length_line()
        {
            Console.WriteLine("Enter x, y coordinates of the line_a :");

            Console.WriteLine("Enter value of x1");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter vale of x2");
            x2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter vale of y1");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter vale of y2");
            y2 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter a, b coordinates of the line_b :");

            Console.WriteLine("Enter value of a1");
            a1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value of a2");
            a2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter vale of b1");
            b1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter vale of b2 ");
            b2 = Convert.ToInt32(Console.ReadLine());

            double line_a = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine("Length of Line_a is:: " + line_a);

            double Line_b = Math.Sqrt(Math.Pow((a2 - a1), 2) + Math.Pow((b2 - b1), 2));
            Console.WriteLine("Length of Line_2 is: " + Line_b);
            Console.ReadLine();
        }

        public void EqualOrNot()
        {
            bool equal_result = line_a.Equals(line_b);

            if (equal_result == true)
                Console.WriteLine("Length of line_a and line_b are Equal");
            else
                Console.WriteLine("Length of line_a and line_b are Not Equal");
            Console.ReadKey();
        }

        public void Comparision()
        {
            double Differene = line_a.CompareTo(line_b);
            if (Differene < 0)
            {
                Console.WriteLine("Length of line_a is less than line_b");
            }
            if (Differene > 0)
            {
                Console.WriteLine("Length of line_a is greater than line_b");
            }
            if (Differene == 0)
            {
                Console.WriteLine("Length of line_a is equal to line_b");
            }
            Console.ReadKey();
        }
    }
}
    
