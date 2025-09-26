using Microsoft.AspNetCore.Mvc;
using MyFirstApplication.Data;
using MyFirstApplication.Models;

namespace MyFirstApplication.Controllers
{
    public class GatePassController : Controller
    {
        private readonly ApplicationDbContext _context;

        public GatePassController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Index (List all GatePass records)
        public IActionResult Index()
        {
            var gatePasses = _context.GatePasses.ToList();
            return View(gatePasses);
        }

        // GET: Create form
        public IActionResult Create()
        {
            return View();
        }

        // POST: Save new GatePass
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(GatePass gatePass)
        {
            if (ModelState.IsValid)
            {
                _context.GatePasses.Add(gatePass); // ✅ FIXED
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(gatePass);
        }
    }
}
