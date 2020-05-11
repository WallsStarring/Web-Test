using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web_Test.Controllers
{
    public class NortwindController : Controller
    {
        // GET: Nortwind
        public ActionResult Index()
        {
            return View();
        }

        // GET: Nortwind/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Nortwind/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Nortwind/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Nortwind/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Nortwind/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Nortwind/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Nortwind/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}