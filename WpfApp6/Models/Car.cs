using System;
using System.Collections.Generic;

namespace WpfApp6.Models;

public partial class Car
{
    public int CarId { get; set; }

    public string Model { get; set; } = null!;

    public string Status { get; set; } = null!;

    public decimal Price { get; set; }

    public int Fuel { get; set; }

    public int Mileage { get; set; }

    public virtual ICollection<Accident> Accidents { get; } = new List<Accident>();

    public virtual ICollection<Parking> Parkings { get; } = new List<Parking>();
}
