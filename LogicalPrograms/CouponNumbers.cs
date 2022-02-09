using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class CouponNumbers
    {
        //static variables
        static int Num, random, value, count = 0, distinct = 0;
        //static Construtor
        static CouponNumbers()
        {
            Console.WriteLine("Enter a distinct Value: ");
            Num = Convert.ToInt32(Console.ReadLine());
        }
        public int GenerateDistinctCoupon()   //Method To Get all Distinct Coupon
        {
            bool[] arr = new bool[Num];  //bool Array
            while (distinct < Num)       //Checking Condition and repeating loop
            {
                random = new Random().Next(Num);
                value = random;
                Console.WriteLine(value + " ");
                if (!arr[value])
                {
                    distinct++;
                    arr[value] = true;
                    Console.WriteLine(arr[value] + " ");
                }
                count++;
            }
            return count;
        }
    }
}
