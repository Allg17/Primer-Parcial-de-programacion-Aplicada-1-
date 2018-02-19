using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Repaso.Entidad
{
    public class MontoExonerado
    {
        [Key]
        public int ID { get; set; }
        public int IdEstudiantes { get; set; }
        public int MontoAnterior { get; set; }
        public int MontoExonerados { get; set; }

        public MontoExonerado(int idEstudiantes, int montoAnterior, int montoExonerados)
        {
            this.IdEstudiantes = idEstudiantes;
            this.MontoAnterior = montoAnterior;
            this.MontoExonerados = montoExonerados;
        }

        public MontoExonerado()
        {
            this.IdEstudiantes = 0;
            this.MontoAnterior = 0;
            this.MontoExonerados = 0;
        }
    }
}
