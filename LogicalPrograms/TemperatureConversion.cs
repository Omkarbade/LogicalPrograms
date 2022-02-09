using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class TemperatureConversion
    {
        //static variable
        public static int temperature;
        /// <summary>
        ///Converting temerature in celsius and Fahrenheit using formulas
        /// </summary>
        public static void TempConversion()
        {
            Console.WriteLine("Enter Temperature");
            temperature = Convert.ToInt32(Console.ReadLine());
            int celTemp = (temperature - 32) * 5 / 9;      //converting temperature in Celsius and storing it in Local var celTemp
            Console.WriteLine("Given Temperature in Celsius: " + celTemp + "\x00b0C");
            int fahTemp = (temperature * 9 / 5) + 32;     //converting temperature in Fahrenheit and storing it in Local var fahTemp
            Console.WriteLine("Given Temperature in Fahrenheit: " + fahTemp + "\x00b0F");
        }
    }
}
