using geradorTimes.DAO;
using geradorTimes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace geradorTimes.Controllers
{
    public class JogadorController : Controller
    {
        // GET: Jogador
        public ActionResult Index()
        {
            JogadorDAO dao = new JogadorDAO();
            dao.Lista();
            IList<Jogador> jogadores = dao.Lista();
            return View(jogadores);
        }

        public ActionResult Formulario()
        {
            ViewBag.Jogador = new Jogador();
            return View();
        }

        public ActionResult Adiciona(Jogador jogador)
        {
            JogadorDAO dao = new JogadorDAO();
            dao.Adiciona(jogador);
            return RedirectToAction("Index");
        }
    }
}