using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryMangementSystemEntities.Models
{
    public class StockLevel
    {
        public int Id { get; set; }
        [ForeignKey(nameof(product))]
        public int productId { get; set; }
        public Product? product { get; set; }
        public int QuantityChange { get; set; }
        public DateTime changeDate { get; set; }
        public string changeType { get; set; }
    }
}
