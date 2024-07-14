using ADO_04._Entity_start;
// Entity Framework Core

// Database First
// Code First
// Model First


#region AddData
//using (StudentContext db = new StudentContext())
//{
//    Student student = new()
//    {
//        FirstName = "Jason",
//        LastName = "Statham",
//        BirthDate = new DateTime(1967, 7, 26)
//    };
//    db.Students.Add(student);
//    Student student2 = new()
//    {
//        FirstName = "Angelina",
//        LastName = "Jolie",
//        BirthDate = new DateTime(1975, 6, 4)
//    };
//    db.Students.Add(student2);
//    db.Students.Add(new Student()
//    {
//        FirstName = "Nadir",
//        LastName = "Zamanov",
//        BirthDate = new DateTime(1880, 10, 7)
//    });
//    db.SaveChanges();
//}

#endregion

#region ReadData
//using(var db = new StudentContext())
//{
//    var student = db.Students.FirstOrDefault();
//    Console.WriteLine(student);
//}
#endregion

#region AddDatas
//using(StudentContext db = new())
//{
//List<Student> students = [
//    new Student(){
//        FirstName = "Johnny",
//        LastName = "Depp",
//        BirthDate = new DateTime(1963, 6, 9),
//    },
//    new Student(){
//        FirstName = "Capitain Jack",
//        LastName = "Sparrow",
//        BirthDate = new DateTime(1963, 6, 9),
//    },
//    new Student(){
//        FirstName = "Natiq",
//        LastName = "Aliyev",
//        BirthDate = new DateTime(1986, 6, 9),
//    },
//    new Student(){
//        FirstName = "Ali Muhammad",
//        LastName = "Novruzov",
//        BirthDate = new DateTime(2001, 1, 15),
//    },
//    new Student(){
//        FirstName = "Elvin",
//        LastName = "Azimov",
//        BirthDate = new DateTime(2006, 9, 1),
//    }
//    ];
////foreach(Student student in students)
////{
////    db.Students.Add(student);
////}
//db.AddRange(students);
//db.SaveChanges();
//}
#endregion

#region ReadDatas
//using (var db = new StudentContext())
//{
//var students = db.Students.ToList();
//foreach (var student in students)
//{
//    Console.WriteLine(student);
//}
//var youngStudents = db.Students.Where(s => s.BirthDate.Year >= 1980).ToList();
//foreach (var student in youngStudents)
//{
//    Console.WriteLine(student);
//}
//}
#endregion

#region DeleteData
//using StudentContext db = new StudentContext();
//db.Remove(db.Students.FirstOrDefault(s=> s.FirstName == "Angelina"));
//db.SaveChanges();
#endregion

#region DeleteDatas
//using StudentContext db = new StudentContext();
//var studentsForRemove = db.Students.Where(s => s.BirthDate.Year >= 1980);
//db.RemoveRange(studentsForRemove);
//db.SaveChanges();
#endregion

#region MyRegion
//using StudentContext db = new();
//var student = db.Students.FirstOrDefault(s => s.FirstName == "Nadir");
//if (student != null)
//{
//    student.BirthDate = new DateTime(1980, 10, 7);
//}
//db.Students.Update(student);
//db.SaveChanges();
#endregion

//using StudentContext db = new StudentContext();
//db.Database.EnsureDeleted();