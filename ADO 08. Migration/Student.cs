namespace ADO_08._Migration;

internal class Student
{
    public int Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public int Age { get; set; }
    public string? Email { get; set; }
    public bool? Gender { get; set; }

    public DateTime? BirthDate { get; set; }

    public override string ToString()
    {
        return $"{FirstName} {LastName}";
    }
}
