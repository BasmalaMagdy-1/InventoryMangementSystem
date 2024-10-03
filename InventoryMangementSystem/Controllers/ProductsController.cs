using InventoryMangementSystem.Intefaces;
using InventoryMangementSystemEntities.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace InventoryMangementSystem.Controllers
{
    public class ProductsController : Controller
    {
       private  IGenericRepository<Product> _ProductRepository;
        private IGenericRepository<Category> _CategoryRepository;
        private IGenericRepository<Supplier> _SupplierRepository;

        private IWebHostEnvironment _environment;
        private IUploudFile _uploadFile;
        public ProductsController(IGenericRepository<Product> ProductRepository, IGenericRepository<Category> categoryRepository, IWebHostEnvironment environment, IUploudFile uploadFile, IGenericRepository<Supplier> supplierRepository)
        {
            _ProductRepository = ProductRepository;
            _CategoryRepository = categoryRepository;
            _environment = environment;
            _uploadFile = uploadFile;
            _SupplierRepository = supplierRepository;
        }
        // GET: ProductsController
        public async Task<ActionResult> Index()
        {
            var products = await _ProductRepository.GetAllAsync(inculdes: new[] { "category", "supplier" });

         

            return View("ProductsList", products);
        }
        public async Task<ActionResult> Filter(string filter)
        {
            IEnumerable<Product> products = new List<Product>();
            if (string.IsNullOrEmpty(filter))
            {
                products = await _ProductRepository.GetAllAsync(inculdes: new[] { "category", "supplier" });
            }
            else
            {
                ViewBag.filter = filter;
                
                    if (filter == "low")
                    {
                    products = await _ProductRepository.GetAllAsync(p => p.StockQuantity <= p.LowStockThreshold && p.StockQuantity >0, inculdes: new[] { "category", "supplier" });
                    }
                    else if (filter == "out")
                    {
                    products = await _ProductRepository.GetAllAsync(p => p.StockQuantity == 0, inculdes: new[] { "category", "supplier" });
                    }
                else
                {
                    products = await _ProductRepository.GetAllAsync(inculdes: new[] { "category", "supplier" });
                }
             
            }
           return PartialView("_ProductsCards",products);
        }


        // GET: ProductsController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            var product = await _ProductRepository.GetByIdAsync(id);
            product.category = await _CategoryRepository.GetByIdAsync(product.categoryId);
            product.supplier = await _SupplierRepository.GetByIdAsync(product.supplierId);
            return View(product);
        }

        // GET: ProductsController/Create
        public async Task<ActionResult> Create()
        {
            var categories = await _CategoryRepository.GetAllAsync();
            ViewBag.categoryList = categories;
            ViewBag.supplierList = await _SupplierRepository.GetAllAsync();
            return View();
        }

        // POST: ProductsController/Create
        [HttpPost]        
        public async Task<ActionResult> Create(Product item)
        {
            try
            {

                if (item.ImageFile != null)
                {
                    string FilePath = await _uploadFile.UploadFileAsync("\\img\\product\\", item.ImageFile);
                    item.ProductImage = FilePath;
                }

                await _ProductRepository.AddAsync(item);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductsController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            var categories = await _CategoryRepository.GetAllAsync();
            var product = await _ProductRepository.GetByIdAsync(id);
            ViewBag.categoryList = categories;
            ViewBag.supplierList = await _SupplierRepository.GetAllAsync();
            return View(product);
        }

        // POST: ProductsController/Edit/5
        [HttpPost]
        public async Task<ActionResult> Edit(int id, Product item)
        {
            try
            {
                if (item.ImageFile != null)
                {
                    string FilePath = await _uploadFile.UploadFileAsync("\\img\\product\\", item.ImageFile);
                    item.ProductImage = FilePath;
                }
                

                await _ProductRepository.UpdateAsync(item);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductsController/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            var product = await _ProductRepository.GetByIdAsync(id);
            product.category = await _CategoryRepository.GetByIdAsync(product.categoryId);
            product.supplier = await _SupplierRepository.GetByIdAsync(product.supplierId);
            return View(product);
        }

        // POST: ProductsController/Delete/5
        [HttpPost]
        public async Task<ActionResult> Delete(int id, Product item)
        {
            try
            {
                await _ProductRepository.DeleteAsync(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    
        

}
}
