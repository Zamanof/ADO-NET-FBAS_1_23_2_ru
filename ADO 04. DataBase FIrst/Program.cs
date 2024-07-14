using ADO_04._DataBase_FIrst;
// Database First




using (LibraryContext db = new())
{
    //var author = db.Authors.FirstOrDefault();
    //Console.WriteLine(author);
    var authors = db.Authors.ToList();
    authors.ForEach(a => Console.WriteLine(a));
}
