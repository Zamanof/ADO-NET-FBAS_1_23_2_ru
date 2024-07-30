namespace ADO_10._Dapper_Methods__Relationships;


public partial class Student
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public int Id_Group { get; set; }

    public int Term { get; set; }
    public  Group Group { get; set; } = null!;
    public override string ToString()
    {
        return $"{FirstName} {LastName} -> {Group}";
    }

}
