using ELearningPlatform.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace ELearningPlatform.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        // GET: About
        public IActionResult About()
        {
            return View();
        }

        // GET: Contact
        public IActionResult Contact()
        {
            return View();
        }

        // POST: Contact
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Contact([Bind("Name,Email,Subject,MessageText")] ELearningPlatform.Models.ContactMessage model)
        {
            if (ModelState.IsValid)
            {
                model.SubmittedAt = DateTime.UtcNow;
                _context.Add(model);
                await _context.SaveChangesAsync();
                TempData["SuccessMessage"] = "Thank you! Your message has been sent securely to the administration team.";
                return RedirectToAction(nameof(Contact));
            }
            return View(model);
        }
    }
}
