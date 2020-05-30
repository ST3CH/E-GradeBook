using System.Collections.Generic;
using E_GradeBook.common;
using E_GradeBook.Data;

namespace E_GradeBook.Education
{
    //Описва логиката на клас StudentData
    public class StudentEducation
    {
        private readonly StudentData manager = new StudentData();

        public List<Student> GetAll()
        {
            return manager.GetAll();
        }

        public Student Get(int id)
        {
            return manager.Get(id);
        }

        public void Add(Student student)
        {
            manager.Add(student);
        }

        public void Update(Student student)
        {
            manager.Update(student);
        }

        public void Delete(int id)
        {
            manager.Delete(id);
        }
    }
}