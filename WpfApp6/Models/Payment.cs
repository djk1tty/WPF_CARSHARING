using System;
using System.Collections.Generic;

namespace WpfApp6.Models;

public partial class Payment
{
    public int PaymentId { get; set; }

    public int UserId { get; set; }

    public string PaymentType { get; set; } = null!;

    public decimal SumPayment { get; set; }

    public virtual User User { get; set; } = null!;
}
