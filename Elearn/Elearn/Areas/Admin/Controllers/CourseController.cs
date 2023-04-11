using Elearn.Data;
using Elearn.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Elearn.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CourseController : Controller
    {
        private readonly AppDbContext _context;

        public CourseController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<Course> courses = await _context.Courses.Include(m => m.Images).Include(m => m.CourseHost).Where(m => !m.SoftDelete).ToListAsync();

            return View(courses);
        }
        public async Task<IActionResult> Detail(int? id)
        {
          
            if (id == null) return BadRequest();
            Course? course = await _context.Courses.Include(m => m.Images).Include(m => m.CourseHost).FirstOrDefaultAsync(m => m.Id == id);
            if (course == null) return NotFound();
            return View(course);
        }


        
        [HttpGet]

        public IActionResult Create()   
        {

            return View();
        }


        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return BadRequest();
            Course? course = await _context.Courses.Include(m => m.Images).Include(m => m.CourseHost).FirstOrDefaultAsync(m => m.Id == id);

            if (course == null) return NotFound();
            return View(course);

        }
    }
}
