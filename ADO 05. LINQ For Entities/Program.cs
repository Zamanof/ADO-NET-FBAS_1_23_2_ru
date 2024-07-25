// LINQ for Entities
using ADO_05._LINQ_For_Entities;
using Microsoft.EntityFrameworkCore;

using LibraryContext db = new LibraryContext();

//var authors = (from author in db.Authors
//              where author.Id > 3
//              select author).ToList();
//foreach (var author in authors)
//{
//    Console.WriteLine(author);
//}
#region Where
//db.Authors.Where(a=>a.Id > 3).ToList().ForEach(Console.WriteLine);      
#endregion

#region EF.Functions.Like()
//var authors = db.Authors.Where(a=>a.LastName.EndsWith("ov")).ToList();
//authors.ForEach(Console.WriteLine);

//db.Authors.Where(a=> EF.Functions.Like(a.LastName, "[^M]%ov"))
//    .ToList()
//    .ForEach(Console.WriteLine);

#endregion

#region Find, FirstOrDefault, SingleOrDefault
//var author = db.Authors.Find(3);
//Console.WriteLine(author);

//author = db.Authors.FirstOrDefault(a => a.FirstName == "Olga");
//if (author != null) Console.WriteLine(author);
//else Console.WriteLine("Author not found");

//author = db.Authors.SingleOrDefault(a => a.FirstName == "Mark");
//if (author != null) Console.WriteLine(author);
//else Console.WriteLine("Author not found");

#endregion

#region All, Any
//Console.WriteLine(db.Authors.All(a=> a.FirstName.Length > 3));
//Console.WriteLine(db.Authors.Any(a=> a.FirstName == "Nadir"));
#endregion

#region Select
//var authors = db.Authors.Select(a => new
//{
//    Id = a.Id,
//    FullName = a.FirstName + " " + a.LastName,
//    Books = a.Books
//});
//foreach (var author in authors)
//{
//    Console.WriteLine($"{author.Id} {author.FullName}");
//    foreach (var book in author.Books)
//    {
//        Console.WriteLine($"    {book}");
//    }
//}
#endregion

#region OrderBy, ThenBy
//var authors = db.Authors
//    .OrderBy(a=>a.FirstName)
//    .ThenByDescending(a => a.LastName)
//    .ToList();
///*
//    SELECT Id, FirstName, LastName
//    FROM Authors
//    ORDER BY FirstName, Lastname DESC

// */
//authors.ForEach(Console.WriteLine);

#endregion

#region Join
//var books = db.Books.Join(db.Authors, b => b.IdAuthor, a => a.Id, (b, a) => new
//{
//    Name = b.Name,
//    Author = a.LastName + " " + a.FirstName
//}).ToList();
///*
//SELECT B.[Name], A.FirstName + ' ' + A.LastName As Author
//FROM Books AS B
//JOIN Authors AS A
//ON B.Id_Author = A.Id 
// */
//books.ForEach(b=> Console.WriteLine($"BookName: {b.Name}\nAuthor: {b.Author}\n"));
#endregion


/*
LINQ For Entities

All
Any
Average
Contains
Count
First
FirstOrDefault
Single
SingleOrDefault
Select
Where
OrderBy
OrderByDescending
ThenBy
ThenByDescending
Join
LeftJoin
GroupBy
Except
Union
Intersect
Sum
Max
Min
Take
TakeWhile
TakeLast
Skip
SkipWhile
SkipLast
ToList
*/