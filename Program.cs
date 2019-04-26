using System;

namespace WeatherOnArray
{
    internal class Program
    {

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
            {
                for (int j = 0; j < minCols; j++)
                {
                    newArray[i, j] = original[i, j];
                }
            }

            return newArray;
        }

        private static void Main(string[] args)
        {
            string title = "Insert Year, Month, Day and Weather on 5 balls range.";
            string[][] WeathersInYears = BussinesLogic.ImplementArrays();
            /*

          Console.WriteLine("\n\tEnter the data until you press Esc\n");
          do
          {
              while (!Console.KeyAvailable)
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
          } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        */

            Console.WriteLine("\n\tEnter the data until you press Esc\n");
            do
            {
                while (!Console.KeyAvailable)
                {
                    InsertInArray(title, WeathersInYears, Console.ReadKey(true).Key);
                }
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
            
           // InsertInArray(title, WeathersInYears);
           // InsertInArray(title, WeathersInYears);
           // InsertInArray(title, WeathersInYears);


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
            for (int i = 0; i < WeathersInYears.Length; i++)
            {
                Console.WriteLine("Год {0} Месяц {1} День {2} Погода {3}", WeathersInYears[0][i], WeathersInYears[1][i], WeathersInYears[2][i], WeathersInYears[3][i]);
            }

            Console.WriteLine("\nPress any key to continue..");
            Console.ReadKey();
        }

        private static void InsertInArray(string title, string[][] WeathersInYears, ConsoleKey key)
        {
            if (key == ConsoleKey.Escape)
                return;

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

        private static void YessNo()
        {
            do
            {
                while (!Console.KeyAvailable)
                {
                    Insert();
                    break;
                }
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }

        private static void Insert()
        {

            while (!(Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Escape))
            {                
                Console.WriteLine("You chose {0}!", "Lol");
                Console.ReadKey();
            }          
        }

    }
}
