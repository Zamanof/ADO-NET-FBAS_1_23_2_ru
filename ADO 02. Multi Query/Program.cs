using System.Data.SqlClient;

string connectionString = 
    @"Server = (localdb)\MSSQLLocalDB; 
    Integrated Security = SSPI; Database = Library";

using (SqlConnection conn = new(connectionString))
{
    SqlDataReader reader = null;
    conn.Open();
    SqlCommand cmd = new SqlCommand(@"
SELECT *
FROM Authors;

SELECT Id, Pages, Name
FROM Books;
", conn);

    reader = cmd.ExecuteReader();

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
