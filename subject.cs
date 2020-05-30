using System;

public class Class1
{

    class Subject
    {
        public int idSubject;
        public string subject;

        public int IdSubject { get; set; }
        public string Subject { get; set; }        
    }

    public Subject()
    {

    }
    public Subject(int IdSubject, string Subject)
    {
        this.idSubject = IdSubject;
        this.subject = Subject;
       
    }

}
