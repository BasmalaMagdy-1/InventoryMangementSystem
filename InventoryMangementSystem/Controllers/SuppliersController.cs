using InventoryMangementSystem.Intefaces;
using InventoryMangementSystemEntities.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Core.Types;

namespace InventoryMangementSystem.Controllers
{
    public class SuppliersController : Controller
    {
        private IGenericRepository<Supplier> _SupplierRepository;
        public SuppliersController(IGenericRepository<Supplier> SupplierRepository)
        {
            _SupplierRepository = SupplierRepository;
        }

        // GET: SuppliersController
        public async Task<ActionResult> Index()
        {
            var suppliers = await _SupplierRepository.GetAllAsync();
            return View("SuppliersList", suppliers);
        }

        // GET: SuppliersController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            var supplier = await _SupplierRepository.GetByIdAsync(id);
            return View(supplier);
        }

        // GET: SuppliersController/Create
        public ActionResult Create()
        {
            return View("AddNewSupplier");
        }

        // POST: SuppliersController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Supplier item)
        {
            try
            {
                var Isexists = _SupplierRepository.GetAllAsync().Result.Any(s => s.SupplierName == item.SupplierName);
                if (Isexists == true)
                {
                    ViewBag.ExistsError = "Supplier Already exists";
                    return View("AddNewSupplier");
                }
                await _SupplierRepository.AddAsync(item);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View("AddNewSupplier");
            }

        }

        // GET: SuppliersController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            var supplier = await _SupplierRepository.GetByIdAsync(id);
            return View(supplier);
        }



        // POST: SuppliersController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, Supplier item)
        {
            try
            {

                await _SupplierRepository.UpdateAsync(item);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }


        // GET: CategoriesController/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            var supplier = await _SupplierRepository.GetByIdAsync(id);
            return View(supplier);
        }

        // POST: CategoriesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
         public async Task<ActionResult> Delete(int id, IFormCollection collection)
            {
            try
            {
                await _SupplierRepository.DeleteAsync(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
             }

    }
}
