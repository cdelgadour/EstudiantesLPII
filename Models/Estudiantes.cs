using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EstudiantesLPII.Models
{
    public class Estudiantes
    {
		public int ID_Estudiante { get; set; }
		public string Nombre_Estudiante { get; set; }
		public string Apellido_Estudiante { get; set; }
		public int Matricula_Estudiante { get; set; }
		public int Carrera_Estudiante { get; set; }
		public int Estatus_Estudiante { get; set; }
	}
}