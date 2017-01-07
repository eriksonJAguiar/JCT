using CCT.Horarios.BLL.Entities;
using CCT.Horarios.DTO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CCT.Horarios.WEB.Controllers
{
    public class CampusController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Listar()
        {
            ViewBag.Titulo = "Lista de Campus";
            var campus = new CampusBLL().List();
            return View(campus);
        }

        public ActionResult Cadastrar()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(CampusDTO dadosTela)
        {
            var campus = new CampusBLL().Insert(dadosTela);
            return RedirectToAction("Listar");
        }

        public ActionResult Editar()
        {

            return View();
        }

    }
}