namespace ADO_04._Entity_start;

internal class Student
{
    public int Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set;}
    public DateTime BirthDate { get; set; }

    public override string ToString()
    {
        return @$"-----------{Id}-----------
FirstName:      {FirstName}
LastName:       {LastName}
Birthday:       {BirthDate.ToShortDateString()}
{new string('-', 25)}";
    }
}
