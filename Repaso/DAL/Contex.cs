using Repaso.Entidad;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace Repaso.DAL
{
    public class Contex :DbContext
    {
        public DbSet<NotasCredito> Notas { get; set; }

        public Contex() : base("ConnStr")
        {
        }
    }
}
