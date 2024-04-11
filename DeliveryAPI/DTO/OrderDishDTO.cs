namespace DeliveryAPI.DTO
{
    public class OrderDishDTO
    {
        public int Id { get; set; }

        public int DishId { get; set; }

        public int OrderId { get; set; }

        public int Count { get; set; }

        public DateTime? CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public string Dish { get; set; }

        public string Order { get; set; }
    }
}
