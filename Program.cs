using System;
using System.Text.RegularExpressions;

namespace WeatherOnArray
{
    internal class Program
    {
        enum WeatherGradation
        {
            Sunny,
            Cloudy,
            Overcast,
            Wet,
            Rainy
        }

        public static string[] Add(string[] array, string newValue)
        {
            int newLength = array.Length + 1;

            string[] result = new string[newLength];

            for (int i = 0; i < array.Length; i++)
            {
                result[i] = array[i];
            }

            result[newLength - 1] = newValue;

            return result;
        }

        public static string[] RemoveAt(string[] array, int index)
        {
            int newLength = array.Length - 1;

            if (newLength < 1)
            {
                return array;//probably want to do some better logic for removing the last element
            }

            //this would also be a good time to check for "index out of bounds" and throw an exception or handle some other way
            string[] result = new string[newLength];
            int newCounter = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i == index)//it is assumed at this point i will match index once only
                {
                    continue;
                }
                result[newCounter] = array[i];
                newCounter++;
            }

            return result;
        }

        private static T[,] ResizeArray<T>(T[,] original, int rows, int cols)
        {
            var newArray = new T[rows, cols];
            int minRows = Math.Min(rows, original.GetLength(0));
            int minCols = Math.Min(cols, original.GetLength(1));
            for (int i = 0; i < minRows; i++)
                for (int j = 0; j < minCols; j++)
                    newArray[i, j] = original[i, j];
            return newArray;
        }

        private static void Main(string[] args)
        {
            string title = "Insert Year, Month, Day and Weather on 5 balls range.";
            string[][] WeathersInYears = new string[4][];
            WeathersInYears[0] = new string[0];
            WeathersInYears[1] = new string[0];
            WeathersInYears[2] = new string[0];
            WeathersInYears[3] = new string[0];

            #region INSERT Value
            Console.WriteLine(new string('#', title.Length + 4));
            Console.WriteLine($"# {title} #");
            Console.WriteLine(new string('#', title.Length + 4));

            Console.Write("Insert Date in format dd/MM/yyyy: ");
            string date = Console.ReadLine();
            DateTime dt;
            while (!DateTime.TryParseExact(date, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out dt))
            {
                Console.WriteLine("Invalid date, please retry");
                date = Console.ReadLine();
            }

            Console.Write("Select the weather on a five-point scale: ");
            foreach (string name in Enum.GetNames(typeof(WeatherGradation)))
            {
                Console.Write("{0} ", name);
            }

            string gradation = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(gradation) || Convert.ToInt32(gradation) > 4)
            {
                Console.WriteLine("\nWeather can't be empty or uncorrect! Input your lastName once more ...");
                gradation = Console.ReadLine();
            }

            #endregion
            /*
            Add(WeathersInYears[0], dt.Year.ToString());
            Add(WeathersInYears[1], dt.Month.ToString());
            Add(WeathersInYears[2], dt.Day.ToString());
            Add(WeathersInYears[3], gradation);
            */

            /*
            NewMethod(WeathersInYears[0], dt.Year.ToString());
            NewMethod(WeathersInYears[1], dt.Month.ToString());
            NewMethod(WeathersInYears[2], dt.Day.ToString());
            NewMethod(WeathersInYears[3], gradation);
            */
 
            Array.Resize(ref WeathersInYears[0], WeathersInYears[0].GetLength(0) + 1);
            WeathersInYears[0][WeathersInYears[0].GetLength(0) - 1] = dt.Year.ToString();

            Array.Resize(ref WeathersInYears[1], WeathersInYears[1].Length + 1);
            WeathersInYears[1][WeathersInYears[0].Length - 1] = dt.Month.ToString();

            Array.Resize(ref WeathersInYears[2], WeathersInYears[2].Length + 1);
            WeathersInYears[2][WeathersInYears[0].Length - 1] = dt.Day.ToString();

            Array.Resize(ref WeathersInYears[3], WeathersInYears[3].Length + 1);
            WeathersInYears[3][WeathersInYears[0].Length - 1] = gradation;
            

            //for (var i = 0; i < WeathersInYears.GetLength(0); i++)
            //{

         //       WeathersInYears[0][0] = dt.Year.ToString();
         //       WeathersInYears[1][0] = dt.Month.ToString();
         //       WeathersInYears[2][0] = dt.Day.ToString();
         //       WeathersInYears[3][0] = gradation;
            //}
         
            /*
            for (int i = 0; i < WeathersInYears.Length; i++)
            {
                for (int j = 0; j < WeathersInYears[i].Length; j++)
                {
                    WeathersInYears[i][0] = dt.Year.ToString();
                    WeathersInYears[i][0] = dt.Month.ToString();
                    WeathersInYears[i][0] = dt.Day.ToString();
                    WeathersInYears[i][0] = gradation;
                }
            }
            */
            for (int i = 0; i <=0; i++)
            {
                Console.WriteLine("Год {0} Месяц {1} День {2} Погода {3}", WeathersInYears[0][i], WeathersInYears[1][i], WeathersInYears[2][i], WeathersInYears[3][i]);
            }

            Console.WriteLine("\nPress any key to continue..");
            Console.ReadKey();
        }
    }
}
