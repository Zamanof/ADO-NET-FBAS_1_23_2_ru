// read relational data
// Eager loading    (жадная загрузка)
// Explicit loading (явная загрузка)
// Lazy loading     (ленивая загрузка)

using ADO_08._Read_Data._LazyLoading;

using ApplicationContext db = new ApplicationContext();
#region Add data
//List<Student> students = new List<Student>() {
//new Student()
//{
//    FirstName = "Salam",
//    LastName = "Salamzade",
//    Age = 52
//},
//new Student()
//{
//    FirstName = "Ali",
//    LastName = "Aliyev",
//    Age = 25
//}
//};

//db.Groups.Add(new Group() { Name = "FBMS_1", Students = students });


//List<Student> students1 = new List<Student>() {
//new Student()
//{
//    FirstName = "Zaman",
//    LastName = "Nadirov",
//    Age = 44
//},
//new Student()
//{
//    FirstName = "Ismail",
//    LastName = "Atilla",
//    Age = 61
//}
//};

//db.Groups.Add(new Group() { Name = "FBMS_2", Students = students1 });


//db.SaveChanges();
#endregion

var groups = db.Groups.ToList();

foreach (var group in groups)
{
    Console.WriteLine(group);
    foreach (var student in group.Students)
    {
        Console.WriteLine($"        {student}");
    }
    
}

Console.ReadLine();
var groups1 = db.Groups.ToList();

foreach (var group in groups1)
{
    Console.WriteLine(group);
    foreach (var student in group.Students)
    {
        Console.WriteLine($"        {student}");
    }

}
