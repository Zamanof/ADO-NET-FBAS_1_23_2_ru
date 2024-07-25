namespace ADO_06._Entity_relationships._One_To_Many;

internal class Student
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDay { get; set; }

    public override string ToString()
    {
        return $"{FirstName} {LastName} - {BirthDay.ToShortDateString()}";
    }
}
