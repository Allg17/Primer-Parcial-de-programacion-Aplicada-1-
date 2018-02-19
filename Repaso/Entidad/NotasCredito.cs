using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Repaso.Entidad
{
    public class NotasCredito
    {
        [Key]
        public int NotasID { get; set; }
        public int EstudianteID { get; set; }
        public string Observaciones { get; set; }
        public decimal Monto { get; set; }
        public DateTime Fecha { get; set; }
        public decimal PctBeca { get; set; }
        public decimal MontoAsignatura { get; set; }
        //public int MontoExonerado { get; set; }

        public NotasCredito()
        {
            this.EstudianteID = 0;
            this.NotasID = 0;
            this.Observaciones = string.Empty;
            this.Monto = 0;
            this.Fecha = DateTime.Now;
            this.MontoAsignatura = 0;
            this.PctBeca = 0;
            //this.MontoExonerado = 0;
        }

        public NotasCredito(int notasID, int estudianteID, string observaciones, decimal monto, DateTime fecha, decimal pctBeca, decimal montoAsignatura)
        {
            NotasID = notasID;
            EstudianteID = estudianteID;
            Observaciones = observaciones;
            Monto = monto;
            Fecha = fecha;
            PctBeca = pctBeca;
            MontoAsignatura = montoAsignatura;
            //MontoExonerado = Montoexonerado;, int Montoexonerado
        }
    }
}
