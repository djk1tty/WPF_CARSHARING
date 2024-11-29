using System;
using System.Collections.Generic;

namespace WpfApp6.Models;

public partial class DriveHistory
{
    public int DriveHistoryId { get; set; }

    public int UserId { get; set; }

    public DateOnly Date { get; set; }

    public decimal TotalPrice { get; set; }

    public TimeOnly TripDuration { get; set; }

    public string Route { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
