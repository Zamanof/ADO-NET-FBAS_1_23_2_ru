using System.ComponentModel.DataAnnotations.Schema;

namespace ADO_07._Fluent_API;


internal class Student
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public int GroupId {  get; set; }
    public Group Group { get; set; } // navigation property
}
