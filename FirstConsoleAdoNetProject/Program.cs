using System.Data.SqlClient;

namespace FirstConsoleAdoNetProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //sql injection
            //ado.net
            //connectionstring c# application and sql server
            SqlConnectionStringBuilder stringBuilder = new SqlConnectionStringBuilder();
            stringBuilder.DataSource = "Localhost";
            stringBuilder.InitialCatalog = "MyCourseDb";
            stringBuilder.IntegratedSecurity = true;

            string connectionString = stringBuilder.ConnectionString;
            //string connectionString = "Data Source = Localhost;Initial Catalog = MyCourseDb;Integrated Security = true;";
            //Console.WriteLine(connectionString);

            //SqlConnection sqlConnection = new SqlConnection(connectionString);
            //sqlConnection.Open();
            //string text = "Select * from Students";

            //SqlCommand command = new SqlCommand(text,sqlConnection);


            //sqlConnection.Close();
            //sqlConnection.Dispose();

            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    connection.Open();

            //    string query = @"Insert into Categories (Name)
            //            values ('Mebel')";

            //    using(SqlCommand command = new SqlCommand(query,connection))
            //    {
            //        command.ExecuteNonQuery();

            //        Console.WriteLine("Category Added");
            //    }
            //}

            //Console.WriteLine("Kateqoriya adını daxil edin");
            //string categoryName = Console.ReadLine();

            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    connection.Open();

            //    string query = $@"Insert into Categories (Name)
            //            values ('{categoryName}')";

            //    using (SqlCommand command = new SqlCommand(query, connection))
            //    {
            //        command.ExecuteNonQuery();

            //        Console.WriteLine("Category Added");
            //    }
            //}


            #region Sql injection
            #region With Injection
            //Console.WriteLine("Add Student Name");
            //string studentName = Console.ReadLine();

            //Console.WriteLine("Add Student Lastname");
            //string studentLastName = Console.ReadLine();

            //Console.WriteLine("Add Student Email");
            //string studentEmail = Console.ReadLine();

            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    connection.Open();

            //    string query = $@"Insert into Students
            //                (Firstname,LastName,Email)
            //            values ('{studentName}','{studentLastName}','{studentEmail}')";

            //    using (SqlCommand command = new SqlCommand(query, connection))
            //    {
            //        command.ExecuteNonQuery();

            //        Console.WriteLine("Student succesfully Added");
            //    }
            //}
            #endregion

            #region Without Injection
            //Console.WriteLine("Add Student Name");
            //string studentName = Console.ReadLine();

            //Console.WriteLine("Add Student Lastname");
            //string studentLastName = Console.ReadLine();    

            //Console.WriteLine("Add Student Email");
            //string studentEmail = Console.ReadLine();

            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    connection.Open();

            //    string query = $@"Insert into Students
            //                (Firstname,LastName,Email)
            //            values (@studentName,@studentLastName,@studentEmail)";

            //    using (SqlCommand command = new SqlCommand(query, connection))
            //    {
            //        command.Parameters.AddWithValue("@studentName", studentName);
            //        command.Parameters.AddWithValue("@studentLastName", studentLastName);
            //        command.Parameters.AddWithValue("@studentEmail", studentEmail);

            //        command.ExecuteNonQuery();

            //        Console.WriteLine("Student succesfully Added");
            //    }
            //}
            #endregion
            #endregion


            #region GetById
            //Console.WriteLine("Add Student Id");
            //int studentId = Convert.ToInt32(Console.ReadLine());
            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    connection.Open();

            //    string query = $@"Select * from Students where id=@id";

            //    using (SqlCommand command = new SqlCommand(query, connection))
            //    {
            //        command.Parameters.AddWithValue("@id", studentId);

            //        SqlDataReader reader = command.ExecuteReader();


            //        if (reader.Read())
            //        {
            //            string name = reader.GetString(1);
            //            string surName = reader.GetString(2);
            //            string email = reader.GetString(3);
            //            Console.WriteLine($"{name} {surName} {email}");
            //        }
            //    }
            //}
            #endregion

            #region GetAll
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = $@"Select * from Students";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();

                   while (reader.Read())
                    {
                        string name = reader["Firstname"].ToString();
                        string surName = reader["LastName"].ToString();
                        string email = reader["Email"].ToString();

                        Console.WriteLine($"{name} {surName} {email}");
                    }
                }
            }
            #endregion


        }
    }
}
