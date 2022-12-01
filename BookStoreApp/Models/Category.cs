using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace VirginMegastoreApp.Models
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        [Required]
        [MaxLength(50)]
        public string? CategoryName { get; set; }
        [ForeignKey("CategoryID")]
        public ICollection<Product>? Products { get; set; }
    }
}
