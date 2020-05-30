using System.Collections.Generic;
using System.Data.SqlClient;
using E_GradeBook.common;

namespace E_GradeBook.Data
{ //Този клас служи за достъп до учениците в базата данни
    public class StudentData
    {
        //Тази подпрограма връща всички ученици, които са в базата (ID на ученика, име и фамилия,клас)
        public List<Student> GetAll()
        {
            var studentList = new List<Student>();
            using (var connection = Database.GetConnection())
            {
                var command = new SqlCommand("SELECT * FROM student", connection);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var student = new Student(
                            reader.GetInt32(0),
                            reader.GetString(1),
                            reader.GetString(2),
                            reader.GetInt32(3)
                        );

                        studentList.Add(student);
                    }
                }

                connection.Close();
            }

            return studentList;
        }

        //Тази подпрограма връща ученик по подадено ID (ID на ученика, име и фамилия,клас)
        public Student Get(int id)
        {
            Student student = null;
            using (var connection = Database.GetConnection())
            {
                var command = new SqlCommand("SELECT * FROM student WHERE IdStudent=@id", connection);
                command.Parameters.AddWithValue("id", id);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                        student = new Student(
                            reader.GetInt32(0),
                            reader.GetString(1),
                            reader.GetString(2),
                            reader.GetInt32(3)
                        );
                }

                connection.Close();
            }

            return student;
        }

        //Тази подпрограма добавя ученик (име, фамилия, клас)
        public void Add(Student student)
        {
            using (var connection = Database.GetConnection())
            {
                var command =
                    new SqlCommand(
                        "INSERT INTO student (FirstName, LastName, IdClass) VALUES(@firstName, @lastName, @idClass)",
                        connection);
                command.Parameters.AddWithValue("firstName", student.FirstName);
                command.Parameters.AddWithValue("lastName", student.LastName);
                command.Parameters.AddWithValue("idClass", student.IdClass);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        //Тази подпрограма актуализира таблица student в базата за ученик по подадено Id
        public void Update(Student student)
        {
            using (var connection = Database.GetConnection())
            {
                var command =
                    new SqlCommand(
                        "UPDATE student SET FirstName=@firstName, LastName=@lastName, IdClass=@idClass WHERE IdStudent=@id",
                        connection);
                command.Parameters.AddWithValue("id", student.IdStudent);
                command.Parameters.AddWithValue("firstName", student.FirstName);
                command.Parameters.AddWithValue("lastName", student.LastName);
                command.Parameters.AddWithValue("idClass", student.IdClass);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        //Изтрива данните за ученик с подадено Id  в таблиза student в базата
        public void Delete(int id)
        {
            using (var connection = Database.GetConnection())
            {
                var command = new SqlCommand("DELETE student WHERE IdStudent=@id", connection);
                command.Parameters.AddWithValue("id", id);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}