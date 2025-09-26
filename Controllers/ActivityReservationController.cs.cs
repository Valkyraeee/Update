using Microsoft.AspNetCore.Mvc;
using MyFirstApplication.Data;
using MyFirstApplication.Models;

namespace MyFirstApplication.Controllers
{
    public class ActivityReservationController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ActivityReservationController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var reservations = _context.ActivityReservations.ToList();
            return View(reservations);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ActivityReservation reservation)
        {
            if (ModelState.IsValid)
            {
                _context.ActivityReservations.Add(reservation);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(reservation);
        }
    }
}
