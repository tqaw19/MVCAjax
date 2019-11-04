using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DOMAIN;
using SERVICE;
using MVCAJAX.Models;

namespace MVCAJAX.Controllers
{
    public class StudentController : Controller
    {
        private StudentService service = new StudentService();

        // GET: Student
        public ActionResult IndexRazor()
        {
            var model = (from c in service.Get()
                         select new StudentModel
                         {
                             ID = c.StudentID,
                             Address = c.StudentAddress,
                             Name = c.StudentName
                         }).ToList();

            return View(model);
        }

        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetStudent(string id)
        {
            return Json(service.Get(), JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult CreateStudent(Student std)
        {
            service.Insert(std);
            string message = "SUCCESS";
            return Json(new { Message = message, JsonRequestBehavior.AllowGet });
        }
    }
}