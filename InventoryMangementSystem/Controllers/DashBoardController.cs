using InventoryMangementSystem.Intefaces;
using InventoryMangementSystemEntities.Models;
using InventoryMangementSystemEntities.ViewModels.DashBoard;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace InventoryMangementSystem.Controllers
{

    public class DashBoardController : Controller
    {

        private IGenericRepository<Product> _ProductRepository;
        private IGenericRepository<Category> _CategoryRepository;
        private IGenericRepository<Supplier> _SupplierRepository;

        public DashBoardController(IGenericRepository<Supplier> supplierRepository, IGenericRepository<Product> ProductRepository, IGenericRepository<Category> CategoryRepository)
        {
            _SupplierRepository = supplierRepository;
            _ProductRepository = ProductRepository;
            _CategoryRepository = CategoryRepository;
        }


        // GET: DashBoardController
        public async Task<ActionResult> Index()
        {

            var lowStockProducts = await _ProductRepository.GetAllAsync(p => p.StockQuantity <= p.LowStockThreshold);
            var totalProducts = await _ProductRepository.GetAllAsync();
            var totalSuppliers = await _SupplierRepository.GetAllAsync();
            var totalCategories = await _CategoryRepository.GetAllAsync();




            var dashboardViewModel = new DashboardViewModel
            {

                TotalProducts = totalProducts.Count(),
                TotalLowStockProducts = lowStockProducts.Count(),
                TotalSuppliers = totalSuppliers.Count(),
                TotalCategories = totalCategories.Count()
            };
            return View("DashBoard",dashboardViewModel);
        }

    }
}
