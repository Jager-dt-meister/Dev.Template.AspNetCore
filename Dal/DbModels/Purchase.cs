using System;
using System.Collections.Generic;

namespace Dal.DbModels;

public partial class Purchase
{
    public int Id { get; set; }

    public int? ClientId { get; set; }

    public DateTime? Date { get; set; }
}
