using System.ComponentModel.DataAnnotations;

namespace VirginMegastoreApp.Models
{
    public class Review
    {
        [Key]
        public int ReviewID { get; set; }

        [Required]
        public DateTime ReviewDate { get; set; } = DateTime.Now;//default value

        [Required]
        [Range(minimum:1,  maximum:5)]
        public int Rating { get; set; }

        public string? Comment { get; set; }

        [Required]
        public int? Product_ID { get; set; }
        public Product? product { get; set; } //each review is for a single product

        public string? AppUserID { get; set; }
    }
}
