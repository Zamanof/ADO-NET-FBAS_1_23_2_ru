﻿namespace ADO_04._DataBase_FIrst;

internal class Author
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public override string ToString()
    {
        return $"{Id}. {FirstName} {LastName}";
    }
}