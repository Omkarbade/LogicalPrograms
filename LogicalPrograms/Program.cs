using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to LogicalPrograms");

            Program obj = new Program();
            obj.LogicalMethod();
            Console.ReadLine();
        }
        public void LogicalMethod()
        {
            bool CONTINUE = true;
            while (CONTINUE)
            {
                Console.WriteLine("Choose your option");
                Console.WriteLine("1.FibonacciSeries 2.Perfect Number 3.Prime Number 4.Reverse Number");
                Console.WriteLine("5.CouponNumber 6.StopWatch 7.DaysofWeeks 8.Temperature Conversion");
                Console.WriteLine("9.Monthly Payment 10.Square root 0.Exit");
                int Choose = int.Parse(Console.ReadLine());
                switch (Choose)
                {
                    case 1:
                        FibonacciSeries.FindFibonacciSeries();
                        break;
                    case 2:
                        PerfectNumber.FindPerfectNumber();
                        break;
                    case 3:
                        PrimeNumber.TakingInput();
                        break;
                    case 4:
                        ReverseNumber.GetRevNumber();
                        break;
                    case 5:
                        CouponNumbers couponNumbers = new CouponNumbers();
                        int count = couponNumbers.GenerateDistinctCoupon();
                        Console.WriteLine("No of Distinct Coupons Generated: " + count);
                        break;
                    case 6:
                        StopWatch.GetElapsedTime();
                        break;
                    case 7:
                        {
                            DayOfWeeks dayOfWeek = new DayOfWeeks();
                            int day = dayOfWeek.Day();
                            switch (day)
                            {
                                case 0:
                                    Console.WriteLine("Day is Sunday");
                                    break;
                                case 1:
                                    Console.WriteLine("Day is Monday");
                                    break;
                                case 2:
                                    Console.WriteLine("Day is Tuesday");
                                    break;
                                case 3:
                                    Console.WriteLine("Day is Wednesday");
                                    break;
                                case 4:
                                    Console.WriteLine("Day is Thursday");
                                    break;
                                case 5:
                                    Console.WriteLine("Day is Friday");
                                    break;
                                case 6:
                                    Console.WriteLine("Day is Saturday");
                                    break;
                            }
                            break;
                        }
                    case 8:
                        TemperatureConversion.TempConversion();
                        break;
                    case 9:
                        MonthlyPayment.CalPayment();
                        break;
                    case 10:
                        SquareRoot.FindingSqrt();
                        break;

                    case 0:
                        break;

                    default:
                        CONTINUE = false;
                        break;
                }
            }
        }
    }
}
