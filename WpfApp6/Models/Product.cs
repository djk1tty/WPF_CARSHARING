using System;
using System.Collections.Generic;

namespace WpfApp6.Models;

public partial class Product
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int Price { get; set; }

    public int Amount { get; set; }

    public double Rating { get; set; }
}
