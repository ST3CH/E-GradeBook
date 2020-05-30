using System;

namespace E_GradeBook.Pressentation
{
    //съчетава конзолните управления на класовете DisplayGrades и DisplayStudents 
    public class Display
    {
        private readonly int closeOperationId = 4;

        public Display()
        {
            Input();
        }

        private void ShowMenu()
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(new string(' ', 18) + "MENU" + new string(' ', 18));
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("1. Students");
            Console.WriteLine("2. Grades");
            Console.WriteLine("3. Configurations Students & Grades");
            Console.WriteLine("4. Exit");
        }

        private void Input()
        {
            var operation = -1;
            do
            {
                ShowMenu();
                operation = int.Parse(Console.ReadLine());
                switch (operation)
                {
                    case 1:
                        var d = new DisplayStudents();
                        break;
                    case 2:
                        var de = new DisplayGrades();
                        break;
                    case 3:
                        break;
                }
            } while (operation != closeOperationId);
        }
    }
}