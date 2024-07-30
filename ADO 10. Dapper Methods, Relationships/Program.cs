using ADO_10._Dapper_Methods__Relationships;
using Dapper;
using Microsoft.Data.SqlClient;
using System.Data;

IDbConnection db = new SqlConnection(@"Server=(localdb)\MSSQLLocalDB;Initial Catalog=Library;Integrated Security=SSPI;");


#region ExecuteScalar
//var result = 
//    db.ExecuteScalar<int>("SELECT COUNT(*) FROM Books");
//Console.WriteLine(result);

//var book = db
//    .QueryFirstOrDefault<Book>(@"SELECT * FROM Books WHERE Name LIKE @Name",
//    new
//    {
//        @Name = "%Visual%"
//    });
//Console.WriteLine(book);
#endregion

#region QuerySingleOrDefault, QuerySingle, QueryFirstOrDefault, QueryFirst
//var book1 = db
//    .QueryFirstOrDefault<Book>(@"SELECT * FROM Books WHERE Name LIKE @Name",
//    new
//    {
//        @Name = "Self-Teaching FrontPage 2000"
//    });
//Console.WriteLine(book1);

//var book2 = db
//    .QuerySingleOrDefault<Book>(@"SELECT * FROM Books WHERE Name LIKE @Name",
//    new
//    {
//        @Name = "Self-Teaching FrontPage 2000"
//    });
//Console.WriteLine(book2);
#endregion

#region QueryMultiple, Read, ReadFirstOrDefault, ReadSingle, ReadSingleOrDefault
//var sql = @"SELECT * FROM Authors WHERE FirstName=@FirstName;
//SELECT * FROM Books WHERE Id=@Id";

//var results = db.QueryMultiple(sql, new { @FirstName = "Mark", @Id = 3});

//var authors = results.Read<Author>().ToList();
//var books = results.Read<Book>().ToList();

//authors.ForEach(Console.WriteLine);
//Console.WriteLine();
//books.ForEach(Console.WriteLine);
#endregion

#region SpecificColumns
//var sql = "SELECT Id, FirstName FROM Authors";
//var authors = db.Query<Author>(sql).ToList();
//authors.ForEach(Console.WriteLine);


#endregion

#region OneToMany
//var sql =
//@"SELECT * 
//FROM Students AS S 
//JOIN Groups AS G ON S.Id_Group = G.Id";
//var results = db.Query<Student, Group, Student>(sql, (s, g) =>
//{
//    s.Group = g;
//    return s;
//}).ToList();

//results.ForEach(Console.WriteLine);
#endregion

#region ManyToMany
IDbConnection db1 = new SqlConnection(@"Server=(localdb)\MSSQLLocalDB;
Database=ManyToMany; 
Integrated Security=SSPI");
var sql =
    @"SELECT * 
FROM SocialNetworks AS SN
JOIN SocialNetworkUser AS SNU ON SN.Id=SNU.SocialNetworksId  
JOIN Users AS U ON U.Id = SNU.UsersId";
var results = db1.Query<SocialNetwork, User, SocialNetwork>(sql, (s, u) =>
{
    s.Users.Add(u);
    return s;
});
foreach (var sn in results)
{
    Console.WriteLine(sn.Name);
    foreach (var user in sn.Users)
    {
        Console.WriteLine($"    {user}");
    }
}
#endregion


