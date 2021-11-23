using C19QuizForKids.Application;
using C19QuizForKids.Context;
using C19QuizForKids.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace C19QuizForKids.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RankingController : Controller
    {
        protected readonly MyContext _context;
        public RankingController(MyContext context)
        {
            _context = context;
        }


        // GET: RankingController
        public ActionResult Index()
        {
            return View();
        }

        // GET: RankingController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: RankingController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RankingController/Create
        [HttpPost]
        
        public ActionResult Create(Ranking ranking)
        {
            try
            {
                RankingApplication rankingApplication = new RankingApplication(_context);
                rankingApplication.Salvar(ranking);
                return Ok();
            }
            catch
            {
                return View();
            }
        }

        // GET: RankingController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

       
        // GET: RankingController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }


    }
}
