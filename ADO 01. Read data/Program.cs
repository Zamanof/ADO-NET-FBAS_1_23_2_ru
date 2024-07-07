using System.Data.SqlClient;

string connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=Library;Integrated Security=SSPI;";

#region Read Data
//SqlConnection sqlConnection = new SqlConnection(connectionString);
//SqlDataReader reader = null;
//SqlCommand cmd = null;
//try
//{
//    sqlConnection.Open();
//    cmd = new(@"SELECT * FROM Authors");
//    cmd.Connection = sqlConnection;
//    reader = cmd.ExecuteReader();
//    while (reader.Read())
//    {
//        Console.WriteLine($"{reader[0]}. {reader[1]} {reader[2]}");
//    }
//}
//finally
//{
//    sqlConnection.Dispose();
//}

//using (SqlConnection connection = new(connectionString))
//{
//    connection.Open();
//    SqlCommand cmd = new(@"SELECT * FROM Authors", connection);
//    SqlDataReader reader = cmd.ExecuteReader();
//    while (reader.Read())
//    {
//        Console.WriteLine($"{reader[0]}. {reader[1]} {reader[2]}");
//    }
//}

//using SqlConnection connection = new(connectionString);
//{
//    connection.Open();
//    SqlCommand cmd = new(@"SELECT * FROM Authors", connection);
//    SqlDataReader reader = cmd.ExecuteReader();
//    while (reader.Read())
//    {
//        Console.WriteLine($"{reader["Id"]}. {reader["FirstName"]} {reader["LastName"]}");
//    }
//}


//using SqlConnection connection = new(connectionString);
//{
//    connection.Open();
//    SqlCommand cmd = new(@"SELECT * FROM Authors", connection);
//    SqlDataReader reader = cmd.ExecuteReader();

//    for (int i = 0; i < reader.FieldCount; i++)
//    {
//        Console.Write($"{reader.GetName(i)}    \t\t");
//    }
//    Console.WriteLine();
//    while (reader.Read())
//    {
//        Console.WriteLine(new string('-', 50));
//        for (int i = 0; i < reader.FieldCount; i++)
//        {
//            Console.Write($"{reader[i]}     \t\t");
//        }
//        Console.WriteLine();
//    }
//}
Console.WriteLine(1 + "1" + 2);
#endregion