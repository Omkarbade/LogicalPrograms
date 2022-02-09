using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class DayOfWeeks
    {
        //Static Variables
        static int month, day, year, x, y, m, d;

        static DayOfWeeks() //Constructor to initialize values
        {
            Console.WriteLine("Enter month like 1 for jan, 2 for feb so on");
            month = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter year: ");
            year = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Day: ");
            day = int.Parse(Console.ReadLine());
        }

        public int Day()  //Method to get day using formula
        {
            y = year - (14 - month) / 12;
            x = y + y / 4 - y / 100 + y / 400;
            m = month + 12 * ((14 - month) / 12) - 2;
            d = (day + x + 31 * m / 12) % 7;
            return d;
        }
    }
}