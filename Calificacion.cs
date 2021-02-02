using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Estudiantes.Models
{
    public class Calificacion
    {

        [Key]
        int ID_Calificacion;
        int Nota;
        int ID_Estudiante;
        int ID_Materia;

        public int ID_Calificacion1 { get => ID_Calificacion; set => ID_Calificacion = value; }
        public int Nota1 { get => Nota; set => Nota = value; }
        public int ID_Estudiante1 { get => ID_Estudiante; set => ID_Estudiante = value; }
        public int ID_Materia1 { get => ID_Materia; set => ID_Materia = value; }
    }
}
