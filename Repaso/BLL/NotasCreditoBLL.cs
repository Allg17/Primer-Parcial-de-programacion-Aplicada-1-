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
    public class NotasCreditoBLL
    {
      

        public static bool Guardar(NotasCredito Notas)
        {
            bool paso = false;
            try
            {
                Contex Contex = new Contex();
                var estudiante = BLL.EstudiantesBLL.Buscar(Notas.EstudianteID);
                estudiante.Monto += Notas.Monto;
                BLL.EstudiantesBLL.Modificar(estudiante);
                Contex.Notas.Add(Notas);
                Contex.SaveChanges();
                paso = true;
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }
        public static decimal CalcularPCT(decimal pct)
        {
            pct /= 100;
            return pct;
        }

        public static decimal CalcularMonto(decimal PCT, decimal Monto)
        {
            NotasCredito Nota = new NotasCredito();

            decimal pctbeca = 0, MontoFinal = 0;
            pctbeca = PCT / 100;

            MontoFinal = pctbeca * Monto;
            return MontoFinal;

        }

        public static bool Eliminar(int EstudianteId)
        {
            bool paso = false;

            try
            {
                Contex contex = new Contex();

                var nota = contex.Notas.Find(EstudianteId);
                var estudiante = BLL.EstudiantesBLL.Buscar(nota.EstudianteID);
                estudiante.Monto -= nota.Monto;
                BLL.EstudiantesBLL.Modificar(estudiante);
                contex.Notas.Remove(nota);
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
                var estudiante = BLL.EstudiantesBLL.Buscar(nota.EstudianteID);
                var notas = Buscar(nota.NotasID);
                estudiante.Monto -= notas.Monto;
                BLL.EstudiantesBLL.Modificar(estudiante);

                contex.Entry(nota).State = EntityState.Modified;

                estudiante.Monto += nota.Monto;
                BLL.EstudiantesBLL.Modificar(estudiante);
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
