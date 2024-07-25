﻿namespace ADO_08._Read_data._Explicit_loading;

internal class Student
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }

    public int GroupId {  get; set; }
    public Group? Group { get; set; }
    public override string ToString()
    {
        return $"{FirstName} {LastName}";
    }
}
