using C19QuizForKids.Application;
using C19QuizForKids.Context;
using C19QuizForKids.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C19QuizForKids.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NicknameController : Controller
    {
        protected readonly MyContext _context;
        public NicknameController(MyContext context)
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

       

        // POST: NickNameController/Create
        [HttpPost]
        public ActionResult Create(Jogador nickname)
        {
            try
            {
                NicknameApplication nicknameApplication = new NicknameApplication(_context);
                return Ok(nicknameApplication.Salvar(nickname));
            }
            catch
            {
                return BadRequest();
            }
        }

        // GET: NickNameController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: NickNameController/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        // GET: NickNameController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: NickNameController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
