using System;
using System.Collections.Generic;

namespace Delivery;

public partial class Dish
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public decimal Price { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<DishProduct> DishProducts { get; set; } = new List<DishProduct>();

    public virtual ICollection<OrderDish> OrderDishes { get; set; } = new List<OrderDish>();
}
