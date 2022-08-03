﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GlobalTrans.Controllers
{
    public class InsuranceController : Controller
    {
        // GET: InsuranceController
        public ActionResult Index()
        {
            return View();
        }

        // GET: InsuranceController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: InsuranceController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: InsuranceController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: InsuranceController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: InsuranceController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: InsuranceController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: InsuranceController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
