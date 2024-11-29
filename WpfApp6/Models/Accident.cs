using System;
using System.Collections.Generic;

namespace WpfApp6.Models;

public partial class Accident
{
    public int AccidentsId { get; set; }

    public int CarId { get; set; }

    public string Report { get; set; } = null!;

    public string Damage { get; set; } = null!;

    public DateOnly Date { get; set; }

    public virtual Car Car { get; set; } = null!;
}
