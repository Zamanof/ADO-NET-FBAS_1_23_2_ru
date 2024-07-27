// Dapper ORM

using ADO_09._Dapper_ORM;
using System.Data.SqlClient;

IAuthorRepository repo = new AuthorRepository(new SqlConnection(), 
            @"Server=(localdb)\MSSQLLocalDB;Initial Catalog=Library;Integrated Security=SSPI;");
//var author = repo.Add(new Author() { FirstName= "Antoine", LastName= "de Saint-Exupery" });
//Console.WriteLine(author);
//Console.WriteLine(repo.Add(new Author() { FirstName = "Victor", LastName = "Hugo" }));

//repo.Remove(15);

var author = new Author() { Id=16, FirstName = "Mark", LastName = "Zuckerberg" };
var updateAuthor = repo.Update(author);
Console.WriteLine(updateAuthor);
Console.WriteLine();
var authors = repo.GetAll().ToList();
foreach (var a in authors)
{
    Console.WriteLine(a);
}

//Console.WriteLine(repo.GetById(15));


