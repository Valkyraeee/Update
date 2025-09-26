using Microsoft.AspNetCore.Mvc;
using MyFirstApplication.Data;
using MyFirstApplication.Models;

namespace MyFirstApplication.Controllers
{
    public class LockerRequestController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LockerRequestController(ApplicationDbContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            var requests = _context.LockerRequests.ToList();
            return View(requests);
        }


        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(LockerRequest lockerRequest, IFormFile? AttachedStudyLoad)
        {
            if (ModelState.IsValid)
            {

                if (AttachedStudyLoad != null && AttachedStudyLoad.Length > 0)
                {
                    var filePath = Path.Combine("wwwroot/uploads", AttachedStudyLoad.FileName);
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        AttachedStudyLoad.CopyTo(stream);
                    }
                    lockerRequest.AttachedStudyLoad = "/uploads/" + AttachedStudyLoad.FileName;
                }

                _context.LockerRequests.Add(lockerRequest);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(lockerRequest);
        }
    }
}
