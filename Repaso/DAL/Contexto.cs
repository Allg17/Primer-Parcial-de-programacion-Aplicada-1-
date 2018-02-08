using Repaso.Entidad;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace Repaso.DAL
{
    public class Contexto : DbContext
    {
        public Contexto() : base("ConStr")
        {

        }
        public DbSet<Estudiantes> Estudiante { get; set; }
    }
    
}
