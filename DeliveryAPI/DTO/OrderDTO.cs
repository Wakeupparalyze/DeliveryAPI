namespace DeliveryAPI.DTO
{
    public class OrderDTO
    {
        public int Id { get; set; }

        public string Status { get; set; } = null!;

        public string Address { get; set; } = null!;

        public DateTime CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }
    }
}
