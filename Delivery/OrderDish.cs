using System;
using System.Collections.Generic;

namespace Delivery;

public partial class OrderDish
{
    public int Id { get; set; }

    public int DishId { get; set; }

    public int OrderId { get; set; }

    public int Count { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Dish Dish { get; set; } = null!;

    public virtual Order Order { get; set; } = null!;
}
