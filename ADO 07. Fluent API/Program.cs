// Entity Models. Annotations

using ADO_07._Fluent_API;

using ApplicationContext db = new();
Student student = new Student()
{
    FirstName = "Ali",
    LastName = "Aliyev"
};
//db.Students.Add(student);
Group group = new()
{
    GroupName = "1_23_2_ru",
    GroupRating = 10,
    CourseYear = 3,
    Students = new List<Student>()
    {
        student
    }
};
db.Groups.Add(group);
Departament departament = new()
{
    DepartamentName = "Programming"
};
db.Departaments.Add(departament);
Faculty faculty = new()
{
    FacultyName = ".NET programming"
};
db.Faculties.Add(faculty);
Teacher teacher = new()
{
    FirstName = "Nadir",
    LastName = "Zamanov",
    BirthDay = new DateTime(1980, 10, 7),
    Salary = 1563200,
    Bonus = 1000000,
    Email = "Zamanov@itstep.org"
};
Teacher teacher2 = new()
{
    FirstName = "Qadir",
    LastName = "Qamanov",
    BirthDay = new DateTime(1980, 10, 7),
    Salary = 1563200,
    Bonus = 1000000,
    Email = "Qamanov@itstep.org"
};
db.Teachers.AddRange(teacher, teacher2);
db.SaveChanges();
