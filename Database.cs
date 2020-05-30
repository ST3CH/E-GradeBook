using System;

public class Class1
{
    public static class Database
    {
        private static string connectionString = "Server=DESKTOP-HTJ8O9J\\SQLEXPRESS; Database=E-Gradebook; Integrated Security=true";
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
