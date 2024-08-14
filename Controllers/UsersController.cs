using Microsoft.AspNetCore.Mvc;
using MESS.Models;
using MESS.Data;
using System.Linq;


namespace MESS.Controllers
{
    public class UsersController:Controller
    {
        private readonly ApplicationDbContext _context;

        public UsersController(ApplicationDbContext context)
        {
            _context=context;
        }

        public IActionResult Create()
        {
            return View();  
        }


        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Create(User user)
        {
            if(ModelState.IsValid)
            {
                _context.Add(user);
                _context.SaveChanges();
                
                return RedirectToAction(nameof(Index));
            }
            return View(user);


        }



public IActionResult Index()
    {
        var users = _context.Users.ToList();
        return View(users);
    }

    }
}