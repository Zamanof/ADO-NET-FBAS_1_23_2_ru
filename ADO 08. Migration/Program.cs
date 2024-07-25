// Migration

using ADO_08._Migration;

using ApllicationContext db = new();

//Student student = new Student()
//{
//    FirstName = "John",
//    LastName = "Doe"
//};

//db.Students.Add(student);
//db.SaveChanges();

//db.Students.Add(new Student() { FirstName = "Nadir", LastName = "Zamanov" });
//db.SaveChanges();

var students = db.Students.ToList();
students.ForEach(Console.WriteLine);

