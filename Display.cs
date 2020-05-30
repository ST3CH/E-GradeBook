using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Class1
{
    private void Head()
    {
        Console.WriteLine("    ______     ______               __     ____              __  ");
        Console.WriteLine("   / ____/    / ____/________ _____/ /__  / __ )____  ____  / /__");
        Console.WriteLine("  / __/______/ / __/ ___/ __ `/ __  / _ \\/ __  / __ \\/ __ \\/ //_/");
        Console.WriteLine(" / /__/_____/ /_/ / /  / /_/ / /_/ /  __/ /_/ / /_/ / /_/ / ,<   ");
        Console.WriteLine("/_____/     \\____/_/   \\__,_/\\__,_/\\___/_____/\\____/\\____/_/|_|  ");
    }
    private void ShowMenu()
    {
        Console.WriteLine(new string('-', 40));
        Console.WriteLine(new string(' ', 18) + "MENU" + new string(' ', 18));
        Console.WriteLine(new string('-', 40));
        Console.WriteLine("1. Enter student name or id");
        Console.WriteLine("2. Add new entry student");
        Console.WriteLine("3. Update entry");
        Console.WriteLine("4. Fetch entry by student name or StudentID");
        Console.WriteLine("5. Delete entry by student name or StudentID");
        Console.WriteLine("5. Delete entry by student name or StudentID");
        Console.WriteLine("6. Enter grade and grade letter to see the program");
        Console.WriteLine("7. Add new entry student");
        Console.WriteLine("8. Update entry");
        Console.WriteLine("9. Fetch entry by student name or StudentID");
        Console.WriteLine("10. Delete entry by student name or StudentID");
        Console.WriteLine("11. Delete entry by student name or StudentID");
        Console.WriteLine("12. Exit");
    }
	
}
