using System;
using System.Collections.Generic;

namespace Dal.DbModels;

public partial class Client
{
    public int Id { get; set; }

    public string Name { get; set; }

    public DateTime? Birth { get; set; }

    public DateTime? RegDate { get; set; }
}
