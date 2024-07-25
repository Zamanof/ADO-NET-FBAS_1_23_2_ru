using ADO_06._Entity_relationships;
using Microsoft.EntityFrameworkCore;

using StudentContext db = new();

//Student student = new Student()
//{
//    FirstName = "Julius",
//    LastName = "Caesar",
//    BirthDay = new DateTime(12, 12, 12)
//};
//StudentCard yuliyCard = new StudentCard()
//{
//    StartDate = new DateTime(30, 1, 1),
//    EndDate = new DateTime(34, 12, 31),
//    Student = student
//};
//db.StudentCards.Add(yuliyCard);
//db.SaveChanges();

var studentCards = db.StudentCards.Include(x=> x.Student).ToList();
Console.WriteLine(studentCards[0]);
Console.WriteLine(studentCards[0].Student);

