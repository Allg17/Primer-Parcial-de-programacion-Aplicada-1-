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
    public class EstudiantesBLL
    {
        public static bool Guardar(Estudiantes estudiante)
        {
            bool paso = false;
            try
            {
                Contexto Contex = new Contexto();
                Contex.Estudiante.Add(estudiante);
                Contex.SaveChanges();
                paso = true;
            }
            catch(Exception)
            {
                throw;
            }
            return paso;
        }

        public static bool Modificar(Estudiantes estudiante)
        {
            bool paso = false;

            try
            {
                Contexto contex = new Contexto();


                contex.Entry(estudiante).State = EntityState.Modified;
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

        public static bool Eliminar(int EstudianteId)
        {
            bool paso = false;

            try
            {
                Contexto contex = new Contexto();

                var estudiante = contex.Estudiante.Find(EstudianteId);

                contex.Estudiante.Remove(estudiante);
                contex.SaveChanges();

                paso = true;
            }
            catch (Exception)
            {
                throw;
            }

            return paso;
        }

        public static Estudiantes Buscar(int EstudianteId)
        {
            Estudiantes estudiante = new Estudiantes();

            try
            {
                Contexto contex = new Contexto();
                estudiante = contex.Estudiante.Find(EstudianteId);
            }
            catch (Exception)
            {
                throw;
            }

            return estudiante;
        }

        public static List<Estudiantes> GetList(Expression<Func<Estudiantes, bool>> criterioBusqueda)
        {
            List<Estudiantes> estudiante = new List<Estudiantes>();
            try
            {
                Contexto contex = new Contexto();
                estudiante = contex.Estudiante.Where(criterioBusqueda).ToList();
            }
            catch (Exception)
            {
                throw;
            }

            return estudiante;
        }
    }
}
