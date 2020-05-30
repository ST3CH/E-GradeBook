using System;

public class Class1
{
	public Class1()
	{
        public List<Student> GetAll()
        {
            var productList = new List<Product>();
            using (var connection = Database.GetConnection())
            {
                var command = new SqlCommand("SELECT * FROM product", connection);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var product = new Product(
                            reader.GetInt32(0),
                            reader.GetString(1),
                            reader.GetDecimal(2),
                            reader.GetInt32(3)
                        );

                        productList.Add(product);
                    }

                }
                connection.Close();
            }

            return productList;
        }
    }
}
