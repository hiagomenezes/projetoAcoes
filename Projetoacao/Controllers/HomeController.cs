using Projetoacao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projetoacao.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Cadastrar()
        {
            
            return View();
        }

        public ActionResult ListaAcoes()
        {
            Acoes obj = new Acoes();
            obj.NomeFaculdade = "hiago";

            return View(obj);
        }

        public ActionResult Index()
        {
            ViewBag.mensagem = "bom dia";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}