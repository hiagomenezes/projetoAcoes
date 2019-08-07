using Projetoacao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projetoacao.Controllers
{
    public class LoginController : Controller
    {

        public ActionResult Login()
        {


            return View();
        }


        // GET: Login
        [HttpPost]
        public ActionResult Login(FormCollection form)
        {
            Login obj = new Login();
            obj.Usuario = "hiago@itecnologia.com.br";
            obj.Senha = "123";

       if(obj.Usuario == form["email"] && obj.Senha == form["senha"])
            {
                ViewBag.mensagem = "sucesso !";
                return RedirectToAction("Index", "Acoes");
            }
            else
            {
                ViewBag.mensagem = "Error !";
            }
            
            return View();
        }
    }
}