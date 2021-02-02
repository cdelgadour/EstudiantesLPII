using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EstudiantesLPII.Models;

namespace EstudiantesLPII.Controllers
{
    public class CarrerasController : Controller
    {
        // GET: Carreras
        public ActionResult GetCarreras()
        {
            Carreras obj = new Carreras();
            obj.ID_Carrera = 1;
            obj.Cod_Carrera = "255/3-15-15";
            obj.Nom_Carerra = "Ingenieria en Sistemas Computacionales";
            obj.ID_Dept = 1;

            return View(obj);
        }
    }
}