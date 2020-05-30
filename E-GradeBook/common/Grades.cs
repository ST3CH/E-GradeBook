namespace E_GradeBook.common
{
    public class Grades
    {
        private int idGrade;
        private int idStudent;
        private int idValueGrades;
        private int subjectID;


        public Grades()
        {
        }

        public Grades(int idGrade, int idStudent, int subjectID, int idValueGrades)
        {
            IdGrade = idGrade;
            IdStudent = idStudent;
            SubjectID = subjectID;
            IdValueGrades = idValueGrades;
        }

        public int IdGrade { get; set; }
        public int SubjectID { get; set; }
        public int IdStudent { get; set; }
        public int IdValueGrades { get; set; }
    }
}