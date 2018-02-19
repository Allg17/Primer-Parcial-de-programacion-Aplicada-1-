using Repaso.Entidad;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace Repaso.DAL
{
    public class ContextoMonto : DbContext 
    {
        public DbSet<MontoExonerado> Monto { get; set; }

        public ContextoMonto() : base("ConeStr")
        {
        }
    }
}
