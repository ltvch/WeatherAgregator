using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherOnArray
{
    static class BussinesLogic
    {
        public static string[][] ImplementArrays()
        {
            string[][] WeathersInYears = new string[4][];
            for (int i = 0; i < WeathersInYears.GetLength(0); i++)
                WeathersInYears[i] = new string[0];
            return WeathersInYears;
        }

        public static string SetWeather()
        {
            Console.Write("Select the weather on a five-point scale: ");
            foreach (string name in Enum.GetNames(typeof(WeatherGradation)))
            {
                Console.Write("{0} ", name);
            }

            string gradation = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(gradation) || Convert.ToInt32(gradation) > 4)
            {
                Console.WriteLine("\nWeather can't be empty or uncorrect! Input Weather once more ...");
                gradation = Console.ReadLine();
            }

            return gradation;
        }

        public static DateTime SetDate()
        {
            Console.Write("Insert Date in format dd/MM/yyyy: ");
            string date = Console.ReadLine();
            DateTime dt;
            while (!DateTime.TryParseExact(date, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out dt))
            {
                Console.WriteLine("Invalid date, please retry");
                date = Console.ReadLine();
            }

            return dt;
        }
    }
}
