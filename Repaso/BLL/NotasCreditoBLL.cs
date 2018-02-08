using Repaso.DAL;
using Repaso.Entidad;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Repaso.BLL
{
    class NotasCreditoBLL
    {
        public static bool Guardar(NotasCredito estudiante)
        {
            bool paso = false;
            try
            {
                Contex Contex = new Contex();
                Contex.Notas.Add(estudiante);
                Contex.SaveChanges();
                paso = true;
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        public static bool Eliminar(int EstudianteId)
        {
            bool paso = false;

            try
            {
                Contex contex = new Contex();

                var estudiante = contex.Notas.Find(EstudianteId);

                contex.Notas.Remove(estudiante);
                contex.SaveChanges();

                paso = true;
            }
            catch (Exception)
            {
                throw;
            }

            return paso;
        }

        public static NotasCredito Buscar(int EstudianteId)
        {
            NotasCredito NotaCredito = new NotasCredito();

            try
            {
                Contex contex = new Contex();
                NotaCredito = contex.Notas.Find(EstudianteId);
            }
            catch (Exception)
            {
                throw;
            }

            return NotaCredito;
        }

        public static List<NotasCredito> GetList(Expression<Func<NotasCredito, bool>> criterioBusqueda)
        {
            List<NotasCredito> NotaCredito = new List<NotasCredito>();
            try
            {
                Contex contex = new Contex();
                NotaCredito = contex.Notas.Where(criterioBusqueda).ToList();
            }
            catch (Exception)
            {
                throw;
            }

            return NotaCredito;
        }


        public static bool Modificar(NotasCredito nota)
        {
            bool paso = false;

            try
            {
                Contex contex = new Contex();

                contex.Entry(nota).State = EntityState.Modified;
                if (contex.SaveChanges() > 0)
                {
                    paso = true;
                }

            }
            catch (Exception)
            {
                throw;
            }

            return paso;
        }
    }
}
