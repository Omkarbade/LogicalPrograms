using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class MonthlyPayment
    { 
        //static variables
        static int P, Y, R, r, payment, n;

        //static Constructor
        static MonthlyPayment()
        {
            Console.WriteLine("Enter principle amount: ");
            P = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter No for year to paid off: ");
            Y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter rate of Interest: ");
            R = Convert.ToInt32(Console.ReadLine());
        }
        public static void CalPayment()   //Method to compute payment formulas
        {
            n = Y * 12;
            r = R / (12 * 100);
            payment = P * r / 1 - (1 + r) ^ (-n);
            Console.WriteLine("Your monthly interest:{0}, Total Interest:{1} , Total Amount:{2} ", payment, (payment * n), (P + payment * n));
        }
    }
}
