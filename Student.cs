using System;

public class Class1
{
    class Student
    {
        private int idStudent;
        private string firstName;
        private string lastName;
        private int idClass;

        public int IdStudent { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int IdClass { get; set; }

        public Student()
        {

        }

        public Student(int idStudent, string firstName, string lastName, int idClass)
        {
            this.idStudent = idStudent;
            this.firstName = firstName;
            this.lastName = lastName;
            this.idClass = idClass;
        }
    }
}
