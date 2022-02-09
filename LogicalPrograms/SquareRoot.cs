using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class SquareRoot
    {
        /// <summary>
        ///implementing newton's method
        /// </summary>
        public static void FindingSqrt()
        {
            Console.WriteLine("Enter a number: ");
            int c = int.Parse(Console.ReadLine());
            double t = c;
            double epsilon = 1e-15;

            if (t > 0)  //checking negative number
            {

                while (Math.Abs(t - c / t) > epsilon * t)  //check condition till (t - c/t) becomes less then (epsilon * t)
                {
                    t = (t + c / t) / 2.0;  //formula for square root
                }
                Console.WriteLine("Absoulte square root is: " + t);
            }
            else
                Console.WriteLine("Enter positive number");
        }
    }
}
