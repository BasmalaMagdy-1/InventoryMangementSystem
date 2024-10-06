using InventoryMangementSystemEntities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryMangementSystemEntities.ViewModels.DashBoard
{
    public class DashboardViewModel
    {
        public int TotalSuppliers { get; set; }
        public int outOfStockProducts { get; set; }
        public int LowStockProducts { get; set; }
        public IEnumerable<Product> ProductsStockLevels { get; set; } = Enumerable.Empty<Product>();
        public IEnumerable<Product> RecentlyAddedProducts { get; set; } = Enumerable.Empty<Product>();

    }
}
