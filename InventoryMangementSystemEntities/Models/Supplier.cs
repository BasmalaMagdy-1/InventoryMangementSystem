using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryMangementSystemEntities.Models
{
    public class Supplier
    {
        public int Id { get; set; }
        [StringLength(50)]
        public string SupplierName { get; set; }
        [StringLength(20)]
        public string PhoneNumber { get; set; }
        [StringLength(150)]
        public string Email { get; set; }
        public List<Product> Products { get; set; }
    }
}
