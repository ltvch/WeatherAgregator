using System;

namespace WeatherOnArrays
{
    internal static class BussinesLogic
    {
        public static string[][] ImplementArrays()
        {
            string[][] WeathersInYears = new string[4][];
            for (int i = 0; i < WeathersInYears.GetLength(0); i++)
            {
                WeathersInYears[i] = new string[0];
            }

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
            DateTime dt = default(DateTime);
      
                Console.Write("Insert Date in format dd/MM/yyyy: ");
                string date = Console.ReadLine();

                while (!DateTime.TryParseExact(date, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out dt))
                {
                    Console.WriteLine("Invalid date, please retry");
                    date = Console.ReadLine();
                }                    
            return dt;
        }

        public static void InsertInArray(string title, string[][] WeathersInYears)
        {
            UI.BuildTitle(title);

            DateTime dt = BussinesLogic.SetDate();
            string gradation = BussinesLogic.SetWeather();

            Array.Resize(ref WeathersInYears[0], WeathersInYears[0].GetLength(0) + 1);
            WeathersInYears[0][WeathersInYears[0].GetLength(0) - 1] = dt.Year.ToString();

            Array.Resize(ref WeathersInYears[1], WeathersInYears[1].Length + 1);
            WeathersInYears[1][WeathersInYears[0].Length - 1] = dt.Month.ToString();

            Array.Resize(ref WeathersInYears[2], WeathersInYears[2].Length + 1);
            WeathersInYears[2][WeathersInYears[0].Length - 1] = dt.Day.ToString();

            Array.Resize(ref WeathersInYears[3], WeathersInYears[3].Length + 1);
            WeathersInYears[3][WeathersInYears[0].Length - 1] = gradation;
        }
    }
}
