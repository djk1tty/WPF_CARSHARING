using System;
using System.Collections.Generic;

namespace WpfApp6.Models;

public partial class Parking
{
    public int ParkingId { get; set; }

    public int CarId { get; set; }

    public string Adress { get; set; } = null!;

    public TimeOnly ParkingTime { get; set; }

    public decimal ParkingPrice { get; set; }

    public virtual Car Car { get; set; } = null!;
}
