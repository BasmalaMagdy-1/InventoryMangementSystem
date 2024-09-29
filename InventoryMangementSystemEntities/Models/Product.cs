using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryMangementSystemEntities.Models
{
    public class Product
    {
        public int Id { get; set; }
        [StringLength(50)]
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        [StringLength(250)]
        public string? ProductImage { get; set; }
        [Display(Name = "Reorder Level")]

        public int LowStockThreshold { get; set; } 
        public int StockQuantity { get; set; }

        [ForeignKey(nameof(category))]
        public int categoryId { get; set; }
        public Category? category { get; set; }
        [ForeignKey(nameof(supplier))]
        public int supplierId { get; set; }
        public Supplier? supplier { get; set; }
        public List<StockLevel> StockLevels { get; set; }
        [NotMapped]
        public IFormFile? ImageFile { get; set; }


    }
}
