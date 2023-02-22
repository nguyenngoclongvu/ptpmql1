using Microsoft.AspNetCore.Mvc;

namespace ptpmql.Controllers
{
    public class EmployeeController : Controller
    {

        public IActionResult Index()
    {
        return View();
        
    }
        public IActionResult Links()
    {
        return View();
    }
    }
}