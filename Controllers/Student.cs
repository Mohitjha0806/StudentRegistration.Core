using Microsoft.AspNetCore.Mvc;
using StudentRegistration.Core.Models;
using StudentRegistration.Core.Data;
using StudentRegistration.Core.Models.Entites;


namespace StudentRegistration.Core.Controllers
{
    public class Student : Controller
    {
        private readonly ApplicationDbContext dbContext;

        public Student(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult StudentReg()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> StudentReg(AddStudentViewModel viewModel)
        {
            var studentReg = new StudentReg
            {
                StudentName = viewModel.StudentName,
                Age = viewModel.Age,
                Email = viewModel.Email,
                MobileNumber = viewModel.MobileNumber,
                Country = viewModel.Country,
                State = viewModel.State,
                City = viewModel.City,
                Address = viewModel.Address,

            };
            await dbContext.StudentReg.AddAsync(studentReg);
            await dbContext.SaveChangesAsync();
            try

            {
                ViewData["Message"] = "Data Inserted Successfully";
                return View();
            }
            catch (Exception)
            {
                ViewData["ErrorMessage"] = "Data Not Inserted";
                throw;
            }

        }




        public IActionResult Dashboard()
        {
            return View();
        }



    }
}
