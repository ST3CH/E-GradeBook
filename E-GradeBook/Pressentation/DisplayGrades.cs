using System;
using E_GradeBook.common;
using E_GradeBook.Education;

namespace E_GradeBook.Pressentation
{
    //Реализира конзолното управление на оценките на учениците по учебни предмети
    public class DisplayGrades
    {
        private readonly int closeOperationId = 6;
        private readonly GradesManagement gradesManagement = new GradesManagement();

        public DisplayGrades()
        {
            Input();
        }

        private void ShowMenu()
        {
            Console.WriteLine(new string('-', 168));
            Console.WriteLine(new string(' ', 84) + "MENU GRADES" + new string(' ', 84));
            Console.WriteLine(new string('-', 168));
            Console.WriteLine("1. List all Gradess");
            Console.WriteLine("2. Add new Grades");
            Console.WriteLine("3. Update Grades");
            Console.WriteLine("4. Fetch Grades by ID");
            Console.WriteLine("5. Delete Grades by ID");
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
            Console.WriteLine("Enter Grades ID to delete: ");
            var id = int.Parse(Console.ReadLine());
            gradesManagement.Delete(id);
            Console.WriteLine("Done.");
        }

        private void Fetch()
        {
            Console.WriteLine("Enter Grades ID to fetch: ");
            var id = int.Parse(Console.ReadLine());
            var student = gradesManagement.Get(id);
            if (student != null)
            {
                Console.WriteLine(new string('-', 40));
                Console.WriteLine("IdGrades: " + student.IdGrade);

                Console.WriteLine("Enter Id student: " + student.IdStudent);
                Console.WriteLine("Enter Id Subject: " + student.SubjectID);
                Console.WriteLine("Enter grade: " + student.IdValueGrades);
                Console.WriteLine(new string('-', 40));
            }
            else
            {
                Console.WriteLine("Grades not found!");
            }
        }


        private void Update()
        {
            Console.WriteLine("Enter Gradess ID to update: ");
            var id = int.Parse(Console.ReadLine());
            var student = gradesManagement.Get(id);
            if (student != null)
            {
                Console.WriteLine("Enter Id student: ");
                student.IdStudent = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Id Subject: ");
                student.SubjectID = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter grade: ");
                student.IdValueGrades = int.Parse(Console.ReadLine());
                gradesManagement.Update(student);
            }
            else
            {
                Console.WriteLine("Grades not found!");
            }
        }

        private void Add()
        {
            var student = new Grades();
            Console.WriteLine("Enter Id Subject: ");
            student.SubjectID = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Id Student: ");
            student.IdStudent = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter grade: ");
            student.IdValueGrades = int.Parse(Console.ReadLine());
            gradesManagement.Add(student);
        }

        private void ListAll()
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(new string(' ', 16) + "Grades" + new string(' ', 16));
            Console.WriteLine(new string('-', 40));
            var students = gradesManagement.GetAll();
            foreach (var item in students)
                Console.WriteLine("{0} {1} {2} {3}", item.IdGrade, item.SubjectID, item.IdStudent, item.IdValueGrades);
        }
    }
}