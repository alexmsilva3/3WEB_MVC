using _3WEB.Models;
using _3WEB.Servicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;

namespace _3WEB.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //TempData["warning"] = "Mensagem de warning!!";
            //TempData["error"] = "Mensagem de erro!!";
            //TempData["info"] = "Ops! Não conseguimos enviar sua mensagem";
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Index(Model_Mail email)
        {
            await ServicoEmail.EnviarEmailDuplo(email);
            TempData["success"] = "Mensagem enviada!";
            return View();

        }

        public ActionResult Servicos()
        {
            return View();
        }
    }
}