using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class PerfectNumber
    {
        public static void FindPerfectNumber()
        {
            Console.WriteLine("Enter a number know perfect number"); //printing message on console to take input from user
            int num = int.Parse(Console.ReadLine());                 //int.parse is used to convert string into integer.
            int sum = 0;                                             //Local variable.
            for (int i = 1; i <= num / 2; i++)
            {
                if (num % i == 0)                           //using for loop to iterate loop and get sum of all the perfect divisible number.
                    sum += i;
            }
            if (sum == num)
                Console.WriteLine(num + "," + " Is a Perfect Number.");
            else
                Console.WriteLine(num + "," + " Is a not Perfect Number.");
        }
    }
}
