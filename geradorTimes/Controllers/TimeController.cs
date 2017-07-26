using geradorTimes.DAO;
using geradorTimes.Models;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace geradorTimes.Controllers
{
    public class TimeController : Controller
    {
        // GET: Time
        public ActionResult Index()
        {
            TimeDAO dao = new TimeDAO();
            IList<Jogador> times = dao.ListaTimeJogador();
            return View(times);
        }

        public ActionResult SortearTime()
        {
            TimeDAO dao = new TimeDAO();
            var jogadores  = dao.ListaTimeJogador();

            decimal QtdTimes = jogadores.Count / 5;

            return RedirectToAction("Index");
        }
    }
}