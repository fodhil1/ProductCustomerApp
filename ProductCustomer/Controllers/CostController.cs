using Microsoft.AspNetCore.Mvc;
using ProductCustomer.Data;
using ProductCustomer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductCustomer.Controllers
{
    public class CostController : Controller
    {
        private readonly ApplicationDbContext _db;

        public CostController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Cost> objectList = _db.Costs;
            return View(objectList);

        }


        public IActionResult Create()
        {
            return View();
        }
        //This is for create a new product cost
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Cost obj)
        {
            if (ModelState.IsValid)
            {
                if (ModelState.IsValid) { }
                _db.Costs.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);

        }


        //Get Deleting
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.Costs.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        //This is created for Post deleting the product cost
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? id)
        {
            var obj = _db.Costs.Find(id);
            if(obj == null)
            {
                return NotFound();
            }
            
             _db.Costs.Remove(obj);
             _db.SaveChanges();
             return RedirectToAction("Index");

        }


        ///////      ///////////////

        //Get Update
        public IActionResult Update(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.Costs.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdatePost(Cost obj)
        {
            if (ModelState.IsValid)
            {
                if (ModelState.IsValid) { }
                _db.Costs.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);

        }



    }
}
