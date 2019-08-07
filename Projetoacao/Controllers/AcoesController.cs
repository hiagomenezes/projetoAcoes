using Projetoacao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projetoacao.Controllers
{
    public class AcoesController : Controller
    {
        // GET: Acoes
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Lista(FormCollection form)
        {
            Acoes obj = new Acoes();
            obj.NomeFaculdade = Convert.ToString(form["NomeFaculdade"]);
            obj.LocalFaculdade = Convert.ToString(form["LocalFaculdade"]);
            obj.InicioAcao =Convert.ToString (form["InicioAcao"]);
            obj.TerminoAcao = Convert.ToString(form["TerminoAcao"]);
            obj.QuantFunc = Convert.ToString(form["QuantFunc"]);
            obj.QuantCartao = Convert.ToString(form["QuantCartao"]);


            return View(obj);
        }
    }
}