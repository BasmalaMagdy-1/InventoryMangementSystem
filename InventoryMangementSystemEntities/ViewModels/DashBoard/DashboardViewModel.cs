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
        public int TotalProducts { get; set; }
        public int TotalSuppliers { get; set; }
        public int TotalCategories { get; set; }
        public int TotalLowStockProducts { get; set; }
       
    }
}
