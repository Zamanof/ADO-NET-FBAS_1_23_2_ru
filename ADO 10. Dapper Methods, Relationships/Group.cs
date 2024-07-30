namespace ADO_10._Dapper_Methods__Relationships;

public partial class Group
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int Id_Faculty { get; set; }

    public virtual ICollection<Student> Students { get; set; } = new List<Student>();
    public override string ToString()
    {
        return Name;
    }
}
