using Employee_accounting.Models;
using Microsoft.AspNetCore.Mvc;

namespace Employee_accounting.Controllers
{
    public class UserController : Controller
    {
        private readonly Database database;

        public UserController(Database database) // getting database from containers
        {
            this.database = database;
        }

        [HttpGet]
        public IActionResult AddEmployee()
        {
            var employee = new UserModel
            {
               Id = database.Users.Count + 1
            };
            return View(employee);
        }
        
        [HttpPost]
        public IActionResult AddEmployee(UserModel employee)
        {
            if (ModelState.IsValid)
            {
                database.Users.Add(employee);
                return RedirectToAction("Employees");
            }
            return View(employee);
        }
        
        public IActionResult Employees(string sortOrder)
        {
            return View(sortOrder switch
            {
                "name_desc" => database.Users.OrderBy(e => e.Surname),
                "dep_desc"  => database.Users.OrderBy(e => e.Department),
                "id_desc"   => database.Users.OrderBy(e => e.Id),
                _           => database.Users.OrderBy(e => e.Id),
            });
        }

        public IActionResult Departments()
        {
            var onlydepartments = database.Users.DistinctBy(e => e.Department);
            return View(onlydepartments);
        }

    }
}
