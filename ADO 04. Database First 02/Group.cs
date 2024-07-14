﻿using System;
using System.Collections.Generic;

namespace ADO_04._Database_First_02;

public partial class Group
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int IdFaculty { get; set; }

    public virtual Faculty IdFacultyNavigation { get; set; } = null!;

    public virtual ICollection<Student> Students { get; set; } = new List<Student>();
}
