using Employee_accounting.Models;
using Microsoft.AspNetCore.Mvc;

namespace Employee_accounting.Controllers
{
    public class UserController : Controller
    {
        public static List<UserModel> userModels = Database.userModels.OrderBy(x => x.Id).ToList();

        [HttpGet]
        public IActionResult AddUser()
        {
            var user = new UserModel
            {
               Id = userModels.Count + 1
            };
            return View(user);
        }
        
        [HttpPost]
        public IActionResult AddUser(UserModel user)
        {
            if (ModelState.IsValid)
            {
                userModels.Add(user);
                return RedirectToAction("Employees");
            }
            return View(user);
        }
        
        public IActionResult Employees(string sortOrder)
        {
            ViewBag.IDSortParm = String.IsNullOrEmpty(sortOrder) ? "id_desc" : "";
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewBag.DepartmentSortParm = String.IsNullOrEmpty(sortOrder) ? "dep_desc" : "";
            var user = from u in userModels select u;
            switch(sortOrder)
            {
                case "name_desc":
                    user = userModels.OrderBy(u => u.Surname);
                    break;
                case "dep_desc":
                    user = userModels.OrderBy(u => u.Department);
                    break;
                case "id_desc":
                    user = userModels.OrderBy(u => u.Id);
                    break;
                default:
                    user = userModels.OrderBy(u => u.Id);
                    break;
            }
            return View(user.ToList());
        }


        public IActionResult Departments()
        {
            var onlydepartments = userModels.DistinctBy(u => u.Department).ToList();
            return View(onlydepartments);
        }

    }
}
