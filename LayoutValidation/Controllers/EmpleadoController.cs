using LayoutValidation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LayoutValidation.Controllers
{
    public class EmpleadoController : Controller
    {
        Models.EmpleadoService es;
        public EmpleadoController()
        {

             es = new EmpleadoService();
        }


        public ActionResult Index()
        {
            return View(es.ListarTodos());
        }

        public ActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Crear(Empleado empleado)
        {

            if (ModelState.IsValid)
            {
                es.Crear(empleado);
                return RedirectToAction("Index");
            }

            return View(empleado);
        }


    }
}