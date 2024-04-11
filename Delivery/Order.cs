using System;
using System.Collections.Generic;

namespace Delivery;

public partial class Order
{
    public int Id { get; set; }

    public string Status { get; set; } = null!;

    public string Address { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<OrderDish> OrderDishes { get; set; } = new List<OrderDish>();
}
