using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Repaso.Entidad
{
    public class Estudiantes
    {   [Key]
        public int EstudianteID { get; set; }
        public string Nombre { get; set; }
        public string  Observaciones { get; set; }
        public decimal Monto { get; set; }
        public DateTime Fecha { get; set; }

        public Estudiantes()
        {
            this.EstudianteID = 0;
            this.Nombre = string.Empty;
            this.Observaciones = string.Empty;
            this.Monto = 0;
            this.Fecha = DateTime.Now;
        }

        public Estudiantes(int estudianteID, string nombre, string observaciones, decimal monto)
        {
            this.EstudianteID = estudianteID;
            this.Nombre = nombre;
            this.Observaciones = observaciones;
            this.Monto = monto;
            Fecha  = DateTime.Now;
        }
    }
}
