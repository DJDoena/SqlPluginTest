using System;
using System.Collections.Generic;

namespace DatabaseLayer.Models;

public partial class Table
{
    public int Id { get; set; }

    public string? SomeText { get; set; }
}
