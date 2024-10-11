using InventoryMangementSystem.Intefaces;
using InventoryMangementSystemEntities.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InventoryMangementSystem.Controllers
{
    [Authorize]

    public class StockLevelsController : Controller
    {
        private IGenericRepository<StockLevel> _stockLevelRepository;

        public StockLevelsController(IGenericRepository<StockLevel> stockLevelRepository)
        {
            _stockLevelRepository = stockLevelRepository;
        }

        // GET: StockLevelsController
        public ActionResult Index()
        {
            return View();
        }

        // GET: StockLevelsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: StockLevelsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StockLevelsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StockLevelsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: StockLevelsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StockLevelsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: StockLevelsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
