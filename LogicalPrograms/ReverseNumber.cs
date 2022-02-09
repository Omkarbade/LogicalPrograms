using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class ReverseNumber
    {
        public static void GetRevNumber()
        {

            Console.WriteLine("Enter number to reverse: "); //Asking user for input
            int number = Convert.ToInt32(Console.ReadLine());
            int reverse = 0;    //Local Variable
            while (number > 0) //repeating loop 
            {
                int reminder = number % 10;             //remainder using modules
                reverse = (reverse * 10) + reminder;
                number /= 10;
            }
            Console.WriteLine("Reverse number is: " + reverse); // printing output
        }
    }
}
