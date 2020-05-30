namespace E_GradeBook.common
{
    public class GradesQ
    {
        private int idGrade;
        private string idStudent;
        private int idValueGrades;
        private string subjectID;


        public GradesQ()
        {
        }


        public GradesQ(int idGrade, string idStudent, string subjectID, int idValueGrades)
        {
            IdGrade = idGrade;

            IdStudent = idStudent;
            SubjectID = subjectID;
            IdValueGrades = idValueGrades;
        }

        public int IdGrade { get; set; }
        public string SubjectID { get; set; }
        public string IdStudent { get; set; }
        public int IdValueGrades { get; set; }
    }
}