using System;
using E_GradeBook.Pressentation;

namespace E_GradeBook
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.ForegroundColor
                = ConsoleColor.DarkYellow;
            Console.WriteLine(new string('-', 168));
            Console.WriteLine("    ______     ______               __     ____              __  ");
            Console.WriteLine("   / ____/    / ____/________ _____/ /__  / __ )____  ____  / /__");
            Console.WriteLine("  / __/______/ / __/ ___/ __ `/ __  / _ \\/ __  / __ \\/ __ \\/ //_/");
            Console.WriteLine(" / /__/_____/ /_/ / /  / /_/ / /_/ /  __/ /_/ / /_/ / /_/ / ,<   ");
            Console.WriteLine("/_____/     \\____/_/   \\__,_/\\__,_/\\___/_____/\\____/\\____/_/|_|  ");
            Console.WriteLine(new string('-', 168));

            Console.ForegroundColor
                = ConsoleColor.Gray;

            //повиква основният интерфейс
            var d = new Display();
        }
    }
}