using System;
using System.Collections.Generic;

namespace WpfApp6.Models;

public partial class User
{
    public int UserId { get; set; }

    public string FName { get; set; } = null!;

    public string LName { get; set; } = null!;

    public string EMail { get; set; } = null!;

    public DateOnly BirthDate { get; set; }

    public string Sex { get; set; } = null!;

    public string? Login { get; set; }

    public string? Password { get; set; }

    public virtual ICollection<DriveHistory> DriveHistories { get; } = new List<DriveHistory>();

    public virtual ICollection<Payment> Payments { get; } = new List<Payment>();
}
