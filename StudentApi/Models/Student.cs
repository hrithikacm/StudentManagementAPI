using System;
using System.Collections.Generic;

namespace StudentApi.Models;

public partial class Student
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int Age { get; set; }

    public string? Email { get; set; }

    public string? Department { get; set; }
}
