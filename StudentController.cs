using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ajax_Json_Jquery.Models;

namespace Ajax_Json_Jquery.Controllers
{
    public class StudentController : Controller
    {
        private CodeFirstDBEntities stud;
        public StudentController()
        {
            stud = new CodeFirstDBEntities();
        }
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetData()
        {
            var c = stud.students.ToList();
            if(c != null)
            {
                return Json(c, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new student(), JsonRequestBehavior.AllowGet);
            }
        }
    }
}