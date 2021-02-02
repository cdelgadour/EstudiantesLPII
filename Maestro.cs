using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace Estudiantes.Models
{
    public class Maestro
    {
        [Key]
        public int ID_maestro { get; set; }
        public int Nom_Maestro { get; set; }
        public int Apell_Maestro { get; set; }
        public int Matri_Maestro { get; set; }
        public int Mail_Maestro { get; set; }
        public int ID_Materia { get; set; }

    }
}
