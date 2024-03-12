using System.ComponentModel.DataAnnotations;

namespace NormalCrude.Models
{
    public class Customer : Membarship
    {
        public int Id { get; set; }
        [Required]
        [DataType(DataType.Text)]
        public string CustomerName { get; set; }
        [Required]
        [DataType(DataType.Text)]
        public string Feedback { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        public double Price { get; set; }
        
    }
}
