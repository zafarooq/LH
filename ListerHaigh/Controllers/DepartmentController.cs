using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ListerHaigh.Repositories;
using ListerHaigh.Models;

namespace ListerHaigh.Controllers
{
    public class DepartmentController : Controller
    {   
        private readonly IDepartmentManager _departmentManager;
        public DepartmentController(IDepartmentManager departmentManager)
        {
            this._departmentManager = departmentManager;
            
        }
        public ActionResult Index()
        {
            var departments = _departmentManager.GetAll();
            return View(departments);
        }
        [HttpGet]
        public ActionResult Create() 
        {
            return View(new DepartmentModel() { Enabled = true });
        }

        [HttpPost]
        public ActionResult Create(DepartmentModel model) 
        {
            if (ModelState.IsValid)
            {
                _departmentManager.Add(model);
            }
            else 
            {   
                return View("Create", model);
            }
            return RedirectToAction("Index", new { saved = "y" });
        }
        [HttpGet]
        public ActionResult Update(int id) 
        {
            return View(_departmentManager.GetById(id));
        }
        [HttpPost]
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
