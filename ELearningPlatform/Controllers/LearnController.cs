using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ELearningPlatform.Data;
using System.Linq;
using System.Threading.Tasks;

namespace ELearningPlatform.Controllers
{
    public class LearnController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LearnController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Learn
        public async Task<IActionResult> Index()
        {
            return View(await _context.Courses.ToListAsync());
        }

        // GET: Learn/CourseOverview/5
        public async Task<IActionResult> CourseOverview(int id)
        {
            var course = await _context.Courses
                .Include(c => c.Topics)
                .FirstOrDefaultAsync(c => c.Id == id);

            if (course == null) return NotFound();

            return View(course);
        }

        // GET: Learn/Topic/Course/5/Topic/10
        public async Task<IActionResult> Topic(int courseId, int? topicId)
        {
            var course = await _context.Courses
                .Include(c => c.Topics)
                .FirstOrDefaultAsync(c => c.Id == courseId);

            if (course == null)
            {
                return NotFound();
            }

            // Ensure the course actually has topics
            if (!course.Topics.Any())
            {
                ViewBag.CourseTitle = course.Title;
                return View("NoTopics"); // A view showing "No topics yet"
            }

            var allTopics = course.Topics.OrderBy(t => t.Id).ToList();
            
            Models.Topic currentTopic;
            
            if (topicId.HasValue)
            {
                currentTopic = allTopics.FirstOrDefault(t => t.Id == topicId.Value);
                if (currentTopic == null) return NotFound();
            }
            else
            {
                currentTopic = allTopics.First();
            }

            ViewBag.AllTopics = allTopics;
            ViewBag.CourseTitle = course.Title;
            ViewBag.CourseId = course.Id;

            return View(currentTopic);
        }
    }
}
