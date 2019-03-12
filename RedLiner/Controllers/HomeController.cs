using RedLiner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RedLiner.Controllers
{
    public class HomeController : Controller
    {
        ProjectDB empDB = new ProjectDB();
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult List()
        {
            return Json(empDB.ListAll(), JsonRequestBehavior.AllowGet);
        }
        public JsonResult Add(Project emp)
        {
            return Json(empDB.Add(emp), JsonRequestBehavior.AllowGet);
        }
        public JsonResult GetbyID(int Id)
        {
            var Employee = empDB.ListAll().Find(x => x.Id.Equals(Id));
            return Json(Employee, JsonRequestBehavior.AllowGet);
        }
        public JsonResult Update(Project emp)
        {
            return Json(empDB.Update(emp), JsonRequestBehavior.AllowGet);
        }
        public JsonResult Delete(int Id)
        {
            return Json(empDB.Delete(Id), JsonRequestBehavior.AllowGet);
        }

        
    }
}