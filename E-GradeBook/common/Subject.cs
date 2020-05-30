namespace E_GradeBook.common
{
    public class Subject
    {
        private int idSubject;
        private string subject1;

        public Subject()
        {
        }

        public Subject(int idSubject, string subject1)
        {
            this.idSubject = idSubject;
            this.subject1 = subject1;
        }

        public int IdSubject { get; set; }
        public string Subject1 { get; set; }
    }
}