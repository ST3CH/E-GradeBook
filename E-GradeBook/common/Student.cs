namespace E_GradeBook.common
{
    public class Student
    {
        private string firstName;
        private int idClass;
        private int idStudent;
        private string lastName;

        public Student()
        {
        }

        public Student(int idStudent, string firstName, string lastName, int idClass)
        {
            IdStudent = idStudent;
            FirstName = firstName;
            LastName = lastName;
            IdClass = idClass;
        }

        public int IdStudent { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int IdClass { get; set; }
    }
}