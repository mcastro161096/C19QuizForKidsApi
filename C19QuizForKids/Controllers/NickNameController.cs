using C19QuizForKids.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C19QuizForKids.Controllers
{
    public class NickNameController : Controller
    {
        protected readonly MyContext _context;
        public NickNameController(MyContext context)
        {
            _context = context;
        }

        // GET: NickNameController
        public ActionResult Index()
        {
            return View();
        }

        // GET: NickNameController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: NickNameController/Create
        public ActionResult Create(string nickName)
        {
            return View();
        }

        // POST: NickNameController/Create
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

        // GET: NickNameController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: NickNameController/Edit/5
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

        // GET: NickNameController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: NickNameController/Delete/5
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
