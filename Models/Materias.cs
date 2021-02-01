using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EstudiantesLPII.Models
{
    public class Materias
    {
        public int ID_Materia { get; set; }
        public string Nombre_Materia { get; set; }
        public int Prerequisito_Materia { get; set; }
        public int Estatus { get; set; }
    }
}