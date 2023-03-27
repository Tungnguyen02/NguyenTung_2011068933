using NguyenTung_8933.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using NguyenTung_8933.ViewModels;

namespace NguyenTung_8933.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _dbContext;

        public HomeController()
        {
            _dbContext = new ApplicationDbContext();
        }
        public ActionResult Index()
        {
            var upcommigCourses = _dbContext.Course
                .Include(c => c.Lecturer)
                .Include(c => c.Category)
                .Where(c => c.DateTime > DateTime.Now);
            var viewModel = new CoursesViewModel
            {
                UpcommingCourses = upcommigCourses,
                ShowAction = User.Identity.IsAuthenticated
            };
            return View(viewModel);
        }
    

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}