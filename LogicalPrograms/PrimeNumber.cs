using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class PrimeNumber
    {
        public static bool GetPrimeNumber(int number)
        {
            if (number == 0 || number == 1)   // 0 and 1 is not a prime number
                return false;
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }
        public static void TakingInput()
        {
            Console.WriteLine("Enter number to know is it a prime number or not");
            int primeNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(GetPrimeNumber(primeNumber) ? " prime number" : " not a prime number"); //if Method returns true then it will execute 1st statement otherwise 2nd statement
        }
    }
}
