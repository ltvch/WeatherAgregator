
namespace WeatherOnArrays
{
    static class UI
    {
        public static void BuildTitle(string title)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine();
            Console.WriteLine(new string('#', title.Length + 4));
            Console.WriteLine($"# {title} #");
            Console.WriteLine(new string('#', title.Length + 4));
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void ShowArray(string[][] WeathersInYears, int count)
        {
            Console.WriteLine("\nYou pressed Escape so see all value from Weather Agregator: ");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Год {0} Месяц {1} День {2} Погода {3}", WeathersInYears[0][i], WeathersInYears[1][i], WeathersInYears[2][i], WeathersInYears[3][i]);
            }
        }
    }
}
