using System;
using E_GradeBook.common;
using E_GradeBook.Education;

namespace E_GradeBook.Pressentation
{
    //Реализира конзолното управление на учениците 
    public class DisplayStudents
    {
        private readonly int closeOperationId = 6;
        private readonly StudentEducation studentEducation = new StudentEducation();

        public DisplayStudents()
        {
            Input();
        }


        private void ShowMenu()
        {
            Console.WriteLine(new string('-', 168));
            Console.WriteLine(new string(' ', 84) + "MENU STUDENTS" + new string(' ', 84));
            Console.WriteLine(new string('-', 168));
            Console.WriteLine("1. List all Students");
            Console.WriteLine("2. Add new Student");
            Console.WriteLine("3. Update Student");
            Console.WriteLine("4. Fetch Student by ID");
            Console.WriteLine("5. Delete Student by ID");
            Console.WriteLine("6. Exit");
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
                        ListAll();
                        break;
                    case 2:
                        Add();
                        break;
                    case 3:
                        Update();
                        break;
                    case 4:
                        Fetch();
                        break;
                    case 5:
                        Delete();
                        break;
                }
            } while (operation != closeOperationId);
        }

        private void Delete()
        {
            Console.WriteLine("Enter Student ID to delete: ");
            var id = int.Parse(Console.ReadLine());
            studentEducation.Delete(id);
            Console.WriteLine("Done.");
        }

        private void Fetch()
        {
            Console.WriteLine("Enter Student ID to fetch: ");
            var id = int.Parse(Console.ReadLine());
            var student = studentEducation.Get(id);
            if (student != null)
            {
                Console.WriteLine(new string('-', 40));
                Console.WriteLine("IdStudent: " + student.IdStudent);
                Console.WriteLine("FirstName: " + student.FirstName);
                Console.WriteLine("LastName: " + student.LastName);
                Console.WriteLine("IdClass: " + student.IdClass);
                Console.WriteLine(new string('-', 40));
            }
            else
            {
                Console.WriteLine("Student not found!");
            }
        }

        private void Update()
        {
            Console.WriteLine("Enter Students ID to update: ");
            var id = int.Parse(Console.ReadLine());
            var student = studentEducation.Get(id);
            if (student != null)
            {
                Console.WriteLine("Enter FirstName: ");
                student.FirstName = Console.ReadLine();
                Console.WriteLine("Enter LastName: ");
                student.LastName = Console.ReadLine();
                Console.WriteLine("Enter Class: ");
                student.IdClass = int.Parse(Console.ReadLine());
                studentEducation.Update(student);
            }
            else
            {
                Console.WriteLine("Student not found!");
            }
        }

        private void Add()
        {
            var student = new Student();
            Console.WriteLine("Enter FirstName: ");
            student.FirstName = Console.ReadLine();
            Console.WriteLine("Enter LastName: ");
            student.LastName = Console.ReadLine();
            Console.WriteLine("Enter Class: ");
            student.IdClass = int.Parse(Console.ReadLine());
            studentEducation.Add(student);
        }

        //изежда всички ученици
        private void ListAll()
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(new string(' ', 16) + "Students" + new string(' ', 16));
            Console.WriteLine(new string('-', 40));
            var students = studentEducation.GetAll();
            foreach (var item in students)
                Console.WriteLine("{0} {1} {2} {3}", item.IdStudent, item.FirstName, item.LastName, item.IdClass);
        }
    }
}