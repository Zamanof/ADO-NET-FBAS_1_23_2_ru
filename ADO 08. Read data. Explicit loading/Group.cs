namespace ADO_08._Read_data._Explicit_loading;

internal class Group
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Student> Students { get; set; } = [];

    public override string ToString()
    {
        return Name;
    }
}
