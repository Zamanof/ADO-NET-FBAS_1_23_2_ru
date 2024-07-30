namespace ADO_04._Database_First_02;

public partial class Author
{
    public int Id { get; set; }
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public virtual ICollection<Book> Books { get; set; } = new List<Book>();
    public override string ToString()
    {
        return $@"Id:{Id}. FirstName: {FirstName} LastName: {LastName}";
    }
}
