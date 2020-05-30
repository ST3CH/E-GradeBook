using System.Data.SqlClient;

namespace E_GradeBook.Data
{ //Статичен клас за достъп до базата данни, съхранявана в SQL Server Management Studio
    public static class Database
    {
        private static readonly string connectionString =
            "Server=DESKTOP-HTJ8O9J\\SQLEXPRESS; Database=E-Gradebook; Integrated Security=true";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}