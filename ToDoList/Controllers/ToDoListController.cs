using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ToDoList.Data;
using ToDoList.Models;

namespace ToDoList.Controllers
{
    public class ToDoListController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<User> _userManager;

        public ToDoListController(UserManager<User> userManager, ApplicationDbContext context)
        {
            _userManager = userManager;
            _context = context;
        }

        [Authorize]
        [HttpGet]
        public IActionResult CreateToDoTask()
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> CreateToDoTask(ToDoTask toDoTask)
        {
            if (!ModelState.IsValid || toDoTask == null)
            {
                return View();
            }

            var user = await _userManager.GetUserAsync(User);
            var item = new ToDoTask
            {
                Title = toDoTask.Title,
                DeadLine = toDoTask.DeadLine,
                UserId = Convert.ToString(user.Id)
            };

            await _context.Tasks.AddAsync(item);
            await _context.SaveChangesAsync();
            return RedirectToAction("ToDoListTabel");
        }

        [Authorize]
        public async Task<IActionResult> ToDoListTabel()
        {
            var user = await _userManager.GetUserAsync(User);
            var toDoItems = await _context.Tasks.Where(t => t.UserId == user.Id).ToListAsync();

            return View(toDoItems);
        }

        [Authorize]
        public async Task<IActionResult> DeleteTask(int id)
        {
            var item = await _context.Tasks.FindAsync(id);
            if (item != null)
            {
                _context.Tasks.Remove(item);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction("ToDoListTabel");
        }
    }
}
