using System.Data.SqlClient;

#region SQL Injection
// SQL Injection
//using (SqlConnection conn = new SqlConnection(@"Server = (localdb)\MSSQLLocalDB; 
//    Integrated Security = SSPI; Database = Library;"))
//{
//    conn.Open();
//    string id = Console.ReadLine()!;
//    SqlCommand cmd = new(@$"SELECT * FROM Authors WHERE Id = {id}", conn);
//    SqlDataReader reader = cmd.ExecuteReader();
//    do
//    {
//        for (int i = 0; i < reader.FieldCount; i++)
//        {
//            Console.Write($"{reader.GetName(i)}     \t\t");
//        }
//        Console.WriteLine();
//        while (reader.Read())
//        {
//            for (int i = 0; i < reader.FieldCount; i++)
//            {
//                Console.Write($"{reader[i]}     \t\t");
//            }
//            Console.WriteLine();
//        }
//        Console.WriteLine("\n\n");

//    } while (reader.NextResult());

//}
#endregion


using (SqlConnection conn = new SqlConnection(@"Server = (localdb)\MSSQLLocalDB; 
    Integrated Security = SSPI; Database = Library;"))
{
    conn.Open();
    string id = Console.ReadLine()!;
    //SqlParameter parameter = new SqlParameter();
    //parameter.ParameterName = "@id";
    //parameter.SqlDbType = System.Data.SqlDbType.Int;
    //parameter.Value = id;
    SqlCommand cmd = new(@"SELECT * FROM Authors WHERE Id > @id AND FirstName NOT LIKE @name" , conn);
    cmd.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;
    cmd.Parameters.Add("@name", System.Data.SqlDbType.NVarChar).Value = Console.ReadLine();
    SqlDataReader reader = cmd.ExecuteReader();
    do
    {
        for (int i = 0; i < reader.FieldCount; i++)
        {
            Console.Write($"{reader.GetName(i)}     \t\t");
        }
        Console.WriteLine();
        while (reader.Read())
        {
            for (int i = 0; i < reader.FieldCount; i++)
            {
                Console.Write($"{reader[i]}     \t\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine("\n\n");

    } while (reader.NextResult());

}
