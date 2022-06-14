using Employee_accounting.Models;
using Microsoft.AspNetCore.Mvc;

namespace Employee_accounting.Controllers
{
    public class UserController : Controller
    {
        public static List<UserModel> userModels = Database.userModels.OrderBy(e => e.Id).ToList();

        [HttpGet]
        public IActionResult AddEmployee()
        {
            var employee = new UserModel
            {
               Id = userModels.Count + 1
            };
            return View(employee);
        }
        
        [HttpPost]
        public IActionResult AddEmployee(UserModel employee)
        {
            if (ModelState.IsValid)
            {
                userModels.Add(employee);
                return RedirectToAction("Employees");
            }
            return View(employee);
        }
        
        public IActionResult Employees(string sortOrder)
        {
            var employee = from e in userModels select e;
            switch(sortOrder)
            {
                case "name_desc":
                    employee = userModels.OrderBy(u => u.Surname);
                    break;
                case "dep_desc":
                    employee = userModels.OrderBy(u => u.Department);
                    break;
                case "id_desc":
                    employee = userModels.OrderBy(u => u.Id);
                    break;
                default:
                    employee = userModels.OrderBy(u => u.Id);
                    break;
            }
            return View(employee.ToList());
        }


        public IActionResult Departments()
        {
            var onlydepartments = userModels.DistinctBy(e => e.Department).ToList();
            return View(onlydepartments);
        }

    }
}
