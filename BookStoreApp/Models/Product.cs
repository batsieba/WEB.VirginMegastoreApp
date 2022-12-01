using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VirginMegastoreApp.Models
{
    public class Product
    {
        [Key]
        public int Product_ID { get; set; }

        [Required]
        
        public string? Product_Name { get; set; }

        [Required]
        public double? Price { get; set; }

        [Required]
        public string? Description { get; set; }


        [StringLength(100)]
        public string? CoverPhoto { get; set; }

        [NotMapped]
        [Display(Name = "Cover Photo")]
        public IFormFile? ImageFile { get; set; }

        [Required]
        [Display(Name = "Category ID")]
        public int? CategoryID { get; set; }
        public Category? Category { get; set; }

        [ForeignKey("Product_ID")]
        public ICollection<Review>? Reviews { get; set; } // a book has many reviews
    }
}
