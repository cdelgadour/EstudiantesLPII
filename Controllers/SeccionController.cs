using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EstudiantesLPII.Models;

namespace EstudiantesLPII.Controllers
{
    public class SeccionController : Controller
    {
        // GET: Seccion
        public ActionResult GetSeccion()
        {
            var secciones = new List<Seccion>()
            {
                new Seccion(){ID_Seccion = 1, Num_Seccion = 1, ID_Materia = 1, ID_Maestro = 1, Nom_Materia = "Simulacion de Sistemas",  ID_Facultad = 1 },
                new Seccion(){ID_Seccion = 2, Num_Seccion = 2, ID_Materia = 1, ID_Maestro = 1, Nom_Materia = "Simulacion de Sistemas",  ID_Facultad = 1 }

            };

            return View(secciones);

        }
    }
}