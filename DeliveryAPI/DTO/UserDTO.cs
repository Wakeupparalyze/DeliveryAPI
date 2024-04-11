using Delivery;

namespace DeliveryAPI.DTO
{
    public class UserDTO
    {
        public int Id { get; set; }

        public string Login { get; set; } = null!;

        public string Password { get; set; } = null!;

        public string Name { get; set; } = null!;

        public string Lastname { get; set; } = null!;

        public DateTime? CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public int RoleId { get; set; }

        public string Role { get; set; }
    }
}
