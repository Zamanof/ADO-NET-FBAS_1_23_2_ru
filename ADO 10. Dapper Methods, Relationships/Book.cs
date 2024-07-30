namespace ADO_10._Dapper_Methods__Relationships;

internal class Book
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int Pages { get; set; }

    public int YearPress { get; set; }

    public int Id_Themes { get; set; }

    public int Id_Category { get; set; }

    public int Id_Author { get; set; }

    public int Id_Press { get; set; }

    public string? Comment { get; set; }

    public int Quantity { get; set; }

    //public virtual Author IdAuthorNavigation { get; set; } = null!;

    //public virtual Category IdCategoryNavigation { get; set; } = null!;

    //public virtual Press IdPressNavigation { get; set; } = null!;

    //public virtual Theme IdThemesNavigation { get; set; } = null!;

    //public virtual ICollection<SCard> SCards { get; set; } = new List<SCard>();

    //public virtual ICollection<TCard> TCards { get; set; } = new List<TCard>();
    public override string ToString()
    {
        return $"{Id}. {Name} {YearPress}";
    }
}
