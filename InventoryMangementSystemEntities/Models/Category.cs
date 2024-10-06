using System;
using System.ComponentModel.DataAnnotations;

namespace InventoryMangementSystemEntities.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        [Display(Name = "Category name")]
        [Required(ErrorMessage = "Name cannot be empty")]
        public string CategoryName { get; set; }

        [StringLength(150)]
        [Display(Name = "Category description")]
        public string? CategoryDescription { get; set; }

        public ICollection<Product> Products { get; set; } = new List<Product>();

        public DateTime CreatedDate { get; set; } = DateTime.Now;
        [StringLength(100)]
        public string CreatedBy { get; set; }  
    }
}
