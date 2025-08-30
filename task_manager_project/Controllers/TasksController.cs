using Microsoft.AspNetCore.Mvc;
using task_manager_project.Data;
using task_manager_project.Models;

namespace task_manager_project.Controllers
{
    public class TasksController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TasksController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index(string status)
        {
            var tasks = _context.Tasks.AsQueryable();

            if (!string.IsNullOrEmpty(status) && status != "All")
            {
                tasks = tasks.Where(t => t.Status == status);
            }

            var taskList = tasks.ToList();

            ViewBag.TotalTasks = _context.Tasks.Count();
            ViewBag.CompletedTasks = _context.Tasks.Count(t => t.Status == "Completed");
            ViewBag.PendingTasks = _context.Tasks.Count(t => t.Status == "Pending");
            ViewBag.CurrentFilter = status ?? "All"; // store selected filter

            return View(taskList);
        }


        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(TaskItem task)
        {
            if (ModelState.IsValid)
            {
                _context.Tasks.Add(task);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(task);
        }

        public IActionResult Edit(int id)
        {
            var task = _context.Tasks.Find(id);
            return View(task);
        }

        [HttpPost]
        public IActionResult Edit(TaskItem task)
        {
            if (ModelState.IsValid)
            {
                _context.Tasks.Update(task);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(task);
        }

        public IActionResult Delete(int id)
        {
            var task = _context.Tasks.Find(id);
            return View(task);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var task = _context.Tasks.Find(id);
            _context.Tasks.Remove(task);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult MarkComplete(int id)
        {
            var task = _context.Tasks.Find(id);
            if (task != null)
            {
                task.Status = "Completed";
                _context.SaveChanges();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
