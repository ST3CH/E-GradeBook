using System.Collections.Generic;
using System.Data.SqlClient;
using E_GradeBook.common;

namespace E_GradeBook.Data
{
    //Този клас служи за достъп до оценките в базата данни
    public class GradesData
    {
        //Тази подпрограма връща името на ученик, оценките му по предмети, по подадено ID от таблица grades на базата
        public List<GradesQ> GetAll()
        {
            var gradesList = new List<GradesQ>();
            using (var connection = Database.GetConnection())
            {
                var command = new SqlCommand(
                    "SELECT grades.idGrades, student.firstName,subject.Subject, grades.idValueGrades FROM grades join subject on grades.SubjectId=subject.idSubject join student on grades.idStudent=student.idStudent ",
                    connection);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var grades = new GradesQ(
                            reader.GetInt32(0),
                            reader.GetString(1),
                            reader.GetString(2),
                            reader.GetInt32(3)
                        );

                        gradesList.Add(grades);
                    }
                }

                connection.Close();
            }

            return gradesList;
        }

        ////Тази подпрограма връща обект Grades (ID на ученика, ID на предмета,ID на стойността на оценкта), по подадено ID на оценката в таблица grades
        public Grades Get(int id)
        {
            Grades grades = null;
            using (var connection = Database.GetConnection())
            {
                var command = new SqlCommand("SELECT * FROM grades WHERE IdGrades=@id", connection);
                command.Parameters.AddWithValue("id", id);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                        grades = new Grades(
                            reader.GetInt32(0),
                            reader.GetInt32(1),
                            reader.GetInt32(2),
                            reader.GetInt32(3)
                        );
                }

                connection.Close();
            }

            return grades;
        }

        // Тази подпрограма добавя обект Grades( ID на предмета,ID на ученика, ID на стойността на оценкта)
        public void Add(Grades grades)
        {
            using (var connection = Database.GetConnection())
            {
                var command =
                    new SqlCommand(
                        "INSERT INTO Grades (SubjectID, IdStudent, IdValueGrades) VALUES(@IdStudent, @subjectID,  @IdValueGrades)",
                        connection);
                command.Parameters.AddWithValue("subjectID", grades.SubjectID);
                command.Parameters.AddWithValue("idStudent", grades.IdStudent);

                command.Parameters.AddWithValue("idValueGrades", grades.IdValueGrades);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        //Тази подпрограма актуализира обект Grades (ID на ученика, ID на предмета,ID на стойността на оценкта), по подадено ID на оценката
        public void Update(Grades grades)
        {
            using (var connection = Database.GetConnection())
            {
                var command =
                    new SqlCommand(
                        "UPDATE grades SET IdStudent=@idStudent, SubjectID=@subjectID,  IdValueGrades=@idValueGrades WHERE idGrades=@id",
                        connection);
                command.Parameters.AddWithValue("id", grades.IdGrade);
                command.Parameters.AddWithValue("idStudent", grades.IdStudent);
                command.Parameters.AddWithValue("subjectID", grades.SubjectID);

                command.Parameters.AddWithValue("idValueGrades", grades.IdValueGrades);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        //Тази подпрограма изтрива обект Grades по подадено ID на оценката
        public void Delete(int id)
        {
            using (var connection = Database.GetConnection())
            {
                var command = new SqlCommand("DELETE grades WHERE idGrades=@id", connection);
                command.Parameters.AddWithValue("id", id);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}