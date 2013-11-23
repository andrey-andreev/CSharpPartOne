using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09InTheCircleOutTheRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write an expression that checks for given point (x, y) if it is within the circle 
            //K( (1,1), 3) and out of the rectangle R(top=1, left=-1, width=6, height=2).
            Console.WriteLine("Enter \"x\" coordinate:");
            int x = int.Parse (Console.ReadLine());
            Console.WriteLine("Enter \"y\" coordinate:");
            int y = int.Parse (Console.ReadLine());
            sbyte xCircleCenter = 1;
            sbyte yCircleCenter = 1;
            sbyte circleRadius = 3;
            sbyte x1Rectangle = 1;
            sbyte y1Rectangle = -1;
            sbyte x2Rectangle = 7;
            sbyte y2Rectangle = -3;
            bool withinCircle = false;
            bool withinRectagle = false;
            if (((x - xCircleCenter) * (x - xCircleCenter) + (y - yCircleCenter)*(y - yCircleCenter) <= circleRadius * circleRadius))
            {
                withinCircle = true;
            }
            if (((x >= x1Rectangle) && (x <= x2Rectangle)) && (y >= y2Rectangle) && ((y <= y1Rectangle)))
            {
                withinRectagle = true;
            }
            Console.Write (withinCircle ? "The given coordinates are within the circle and" : "The given coordinates are out of the circle and");
            Console.WriteLine (withinRectagle ? " within the rectangle." : " out of the rectagle.");
        }
    }
}
