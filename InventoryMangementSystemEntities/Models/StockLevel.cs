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

        [ForeignKey(nameof(Product))]
        public int ProductId { get; set; }
        public Product? Product { get; set; }

        public int QuantityChange { get; set; }

        public DateTime ChangeDate { get; set; }

        public string ChangeType { get; set; }
    }
}
