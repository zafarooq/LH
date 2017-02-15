using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ListerHaigh.Repositories;
using ListerHaigh.Models;
namespace ListerHaigh.Web.Controllers
{
    //[Authorize]
    public class DepartmentController : Controller
    {
        private readonly IDepartmentManager _departmentManager;
        public DepartmentController(IDepartmentManager departmentManager) 
        {
            this._departmentManager = departmentManager;
        }
        
        public ActionResult Index()
        {
            var departments = _departmentManager.FindAll();
            return View(departments);
        }


        public ActionResult Create() 
        {
            return View(new DepartmentModel() { Enabled = true });
        }
        [HttpPost]
        public ActionResult Create(DepartmentModel model) 
        {
            if (ModelState.IsValid)
            {
                _departmentManager.Save(model);
            }
            else 
            {
                ModelState.AddModelError("", "Fix error below.");

                return View("Create", model);
            }
            return RedirectToAction("Index", new { saved = "y" });
        }

        public ActionResult Update(int id) 
        {
            var department = _departmentManager.FindById(id);
            return View(department);
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Update(DepartmentModel model)
        {
            if (ModelState.IsValid) 
            {
                _departmentManager.Update(model);
            }
            else
            {
                ModelState.AddModelError("", "Please fix the errors below.");
                return View("Update", model);
            }

            return RedirectToAction("Index", new { saved = "y" });
        }

    }
}
