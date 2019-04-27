using System;

namespace WeatherOnArrays
{
    class Program
    {
        private static void Main(string[] args)
        {
            string title = "Insert Year, Month, Day and Weather on 5 balls range.";
            string[][] WeathersInYears = BussinesLogic.ImplementArrays();
            ConsoleKeyInfo input;
            int count = 0;

            Console.WriteLine("\n\tEnter the data until you press Esc\n");

            //todo
            // add update and delete values like "rows" in arrays
            do
            {
                BussinesLogic.InsertInArray(title, WeathersInYears);
                input = Console.ReadKey();
                count++;
            } while (input.Key != ConsoleKey.Escape);
            
            UI.ShowArray(WeathersInYears, count);

            Console.WriteLine("\nPress any key to continue..");
            Console.ReadKey();
        }
    }
}
