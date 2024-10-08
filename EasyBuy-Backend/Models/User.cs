namespace EasyBuy_Backend.Models
{
    public class User
    {
        public int Id { get; set; }

        public required string Name { get; set; }

        public required string Email { get; set; }

        public string? Phone { get; set; }

        public string Password { get; set; }
    }
}
