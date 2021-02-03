using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EstudiantesLPII.Models
{
    public class Seccion
    {
        public int ID_Seccion { get; set; }
        public int ID_Materia { get; set; }
        public int ID_Maestro { get; set; }
        public int ID_Facultad { get; set; }
        public int Num_Seccion { get; set; }
        public string Nom_Materia { get; set; }

    }
}