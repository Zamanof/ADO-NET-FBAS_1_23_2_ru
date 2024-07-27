using ADO_04._Database_First_02;

using LibraryContext db = new();

var watch = System.Diagnostics.Stopwatch.StartNew();

var authors = db.Authors.ToList();

//foreach (var author in authors)
//    Console.WriteLine(author);

watch.Stop();

var elapsedTime = watch.ElapsedMilliseconds;
Console.WriteLine(elapsedTime);