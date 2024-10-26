using Microsoft.AspNetCore.Mvc;

namespace StudentRegistration.Core.Controllers
{
    public class Student : Controller
    {
        public IActionResult StudentReg()
        {
            return View();
        }

        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
