using JQuery.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JQuery.WebUI.Controllers
{
    public class EmpresaController : Controller
    {
        private IJQueryRepository repository;
        public EmpresaController(IJQueryRepository ijqRepository)
        {
            this.repository = ijqRepository;
        }
        public ActionResult Index()
        {
            return View(repository.Empresas);
        }
        public ActionResult Ejercicio1()
        {
            return View();
        }
        public ActionResult Ejercicio2()
        {
            return View();
        }
        public ActionResult Ejercicio3()
        {
            return View();
        }
        public ActionResult Ejercicio4()
        {
            return View();
        }
        public ActionResult Ejercicio5()
        {
            return View();
        }
        public ActionResult Ejercicio6()
        {
            return View();
        }
    }
}