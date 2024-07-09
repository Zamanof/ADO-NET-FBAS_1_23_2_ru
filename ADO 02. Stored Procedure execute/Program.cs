using System.Data.SqlClient;

//using (SqlConnection conn = new SqlConnection(@"Server = (localdb)\MSSQLLocalDB; 
//    Integrated Security = SSPI; Database = Library;"))
//{
//    conn.Open();
//    SqlCommand cmd = new(@"
//CREATE PROCEDURE getBookCount
//@AuthorId int, @BookCount int OUTPUT
//AS
//BEGIN
//    SELECT  @BookCount = COUNT(*)
//    FROM Authors AS A
//    JOIN Books AS B
//    ON A.Id = B.Id_Author
//    WHERE A.Id = @AuthorId
//END
//", conn);
//    cmd.ExecuteNonQuery();
//}

using (SqlConnection conn = new SqlConnection(@"Server = (localdb)\MSSQLLocalDB; 
    Integrated Security = SSPI; Database = Library;"))
{
    conn.Open();
    SqlCommand cmd = new("getBookCount", conn);
    cmd.CommandType = System.Data.CommandType.StoredProcedure;
    cmd.Parameters.Add("@AuthorId", System.Data.SqlDbType.Int).Value = Console.ReadLine();
    SqlParameter bookCount = new("@BookCount", System.Data.SqlDbType.Int);
    bookCount.Direction = System.Data.ParameterDirection.Output;
    cmd.Parameters.Add(bookCount);
    cmd.ExecuteNonQuery();
    Console.WriteLine(cmd.Parameters["@BookCount"].Value);
}
