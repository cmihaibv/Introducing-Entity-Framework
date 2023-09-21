using System.ComponentModel.DataAnnotations;

namespace IntroducingEntityFramework.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public string? Address { get; set; }

        public ICollection<Order> Orders { get; set; } = null!;
    }
}
