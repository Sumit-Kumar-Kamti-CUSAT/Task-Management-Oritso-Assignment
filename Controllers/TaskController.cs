using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Task_Management_Oritso_Assignment.Data;
using Task_Management_Oritso_Assignment.Models;

namespace Task_Management_Oritso_Assignment.Controllers
{
    public class TaskController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TaskController(ApplicationDbContext context)
        {
            _context = context;
        }


        private List<SelectListItem> GetStatusList()
        {
            return new List<SelectListItem>
            {
                new SelectListItem { Text = "Pending", Value = "Pending" },
                new SelectListItem { Text = "In Progress", Value = "In Progress" },
                new SelectListItem { Text = "Completed", Value = "Completed" },
                new SelectListItem { Text = "On Hold", Value = "On Hold" }
            };
        }
        public async Task<IActionResult> Index(string searchString)
        {
            var tasks = _context.Tasks.AsQueryable();

            if (!string.IsNullOrWhiteSpace(searchString))
            {
                tasks = tasks.Where(t =>
                    t.Title.Contains(searchString) ||
                    t.Description.Contains(searchString));
            }

            return View(await tasks.ToListAsync());
        }
        public IActionResult Create()
        {
            ViewBag.StatusList = GetStatusList();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TaskModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    model.CreatedOn = model.LastUpdatedOn = DateTime.Now;
                    model.CreatedBy = model.LastUpdatedBy = "Admin";

                    _context.Add(model);
                    await _context.SaveChangesAsync();

                    TempData["SuccessMessage"] = "Task created successfully!";
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    foreach (var entry in ModelState)
                    {
                        var key = entry.Key;
                        var errors = entry.Value.Errors;
                        foreach (var error in errors)
                        {
                            Console.WriteLine($"Field: {key}, Error: {error.ErrorMessage}");
                        }
                    }

                    TempData["ErrorMessage"] = "Please correct the errors and try again.";
                }
            }
            catch (Exception ex)
            {

                TempData["ErrorMessage"] = $"Error while creating task: {ex.Message}";
            }

            ViewBag.StatusList = GetStatusList();
            return View(model);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var task = await _context.Tasks.FindAsync(id);
            if (task == null)
                return NotFound();

            ViewBag.StatusList = GetStatusList();
            return View(task);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(TaskModel model)
        {
            if (ModelState.IsValid)
            {
                model.LastUpdatedOn = DateTime.Now;
                model.LastUpdatedBy = "Admin";

                _context.Update(model);
                await _context.SaveChangesAsync();

                TempData["SuccessMessage"] = "Task updated successfully!";
                return RedirectToAction(nameof(Index));
            }

            ViewBag.StatusList = GetStatusList();
            return View(model);
        }


        public async Task<IActionResult> Delete(int id)
        {
            var task = await _context.Tasks.FindAsync(id);
            return task == null ? NotFound() : View(task);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var task = await _context.Tasks.FindAsync(id);
            if (task != null)
            {
                _context.Tasks.Remove(task);
                await _context.SaveChangesAsync();
                TempData["SuccessMessage"] = "Task deleted successfully!";
            }

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(int id)
        {
            var task = await _context.Tasks.FindAsync(id);
            return task == null ? NotFound() : View(task);
        }
    }
}