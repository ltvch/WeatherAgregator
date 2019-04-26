using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherOnArray
{
    static class UI
    {
        public static void BuildTitle(string title)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(new string('#', title.Length + 4));
            Console.WriteLine($"# {title} #");
            Console.WriteLine(new string('#', title.Length + 4));
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void StartMessage()
        {
            
        }
    }
}
