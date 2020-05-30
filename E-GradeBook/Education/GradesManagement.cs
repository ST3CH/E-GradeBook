using System.Collections.Generic;
using E_GradeBook.common;
using E_GradeBook.Data;

namespace E_GradeBook.Education

{
    //Описва логиката на клас GradesData
    public class GradesManagement
    {
        private readonly GradesData manager = new GradesData();

        public List<GradesQ> GetAll()
        {
            return manager.GetAll();
        }

        public Grades Get(int id)
        {
            return manager.Get(id);
        }

        public void Add(Grades grades)
        {
            manager.Add(grades);
        }

        public void Update(Grades grades)
        {
            manager.Update(grades);
        }

        public void Delete(int id)
        {
            manager.Delete(id);
        }
    }
}