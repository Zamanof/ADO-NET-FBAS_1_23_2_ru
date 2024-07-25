using ADO_06._Entity_relationships._One_To_Many;
using Microsoft.EntityFrameworkCore;

using GroupsContext db = new();

//List<Student> students = [
//    new Student(){
//        FirstName = "Johnny",
//        LastName = "Depp",
//        BirthDay = new DateTime(1963, 6, 9),
//    },
//    new Student(){
//        FirstName = "Capitain Jack",
//        LastName = "Sparrow",
//        BirthDay = new DateTime(1963, 6, 9),
//    },
//    new Student(){
//        FirstName = "Natiq",
//        LastName = "Aliyev",
//        BirthDay = new DateTime(1986, 6, 9),
//    },
//    new Student(){
//        FirstName = "Ali Muhammad",
//        LastName = "Novruzov",
//        BirthDay = new DateTime(2001, 1, 15),
//    },
//    new Student(){
//        FirstName = "Elvin",
//        LastName = "Azimov",
//        BirthDay = new DateTime(2006, 9, 1),
//    }
//    ];
//Group group = new()
//{
//    Name = "FBAS_1_23_2_ru",
//    Students = students
//};
//db.Groups.Add(group);
//Group ninjasGroup = new()
//{
//    Name = "TeenageMutantNinjaTurtles",
//    Students = [
//        new Student(){
//            FirstName = "Leonardo",
//            LastName = "Splinterov",
//            BirthDay= new DateTime(1984, 1, 13)
//        },
//        new Student(){
//            FirstName = "Michelangelo",
//            LastName = "Splinterov",
//            BirthDay= new DateTime(1984, 1, 13)
//        },
//        new Student(){
//            FirstName = "Donatello",
//            LastName = "Splinterov",
//            BirthDay= new DateTime(1984, 1, 13)
//        },
//        new Student(){
//            FirstName = "Raphael",
//            LastName = "Splinterov",
//            BirthDay= new DateTime(1984, 1, 13)
//        },
//        ]
//};
//db.Groups.Add(ninjasGroup);
//db.SaveChanges();

var groups = db.Groups.Include(x=> x.Students).ToList();

foreach (var group in groups)
{
    Console.WriteLine(group);
    foreach (var student in group.Students)
    {
        Console.WriteLine($"        {student}");
    }
}


