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
    public class MontoExoneradoBLL
    {
        public static bool Guardar(MontoExonerado Monto)
        {
            bool paso = false;
            try
            {
                ContextoMonto Contex = new ContextoMonto();
                if(Contex.Monto.Add(Monto)!=null)
                {
                    Contex.SaveChanges();
                    paso = true;
                }
                
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        public static bool Modificar(MontoExonerado Monto)
        {
            bool paso = false;
            try
            {

                ContextoMonto contex = new ContextoMonto();

                contex.Entry(Monto).State = EntityState.Modified;
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
                ContextoMonto contex = new ContextoMonto();

                var Monto = contex.Monto.Find(EstudianteId);

               if(contex.Monto.Remove(Monto)!=null)
                {
                    contex.SaveChanges();

                    paso = true;
                }
               
            }
            catch (Exception)
            {
                throw;
            }

            return paso;
        }

        public static MontoExonerado Buscar(int montoid)
        {
            MontoExonerado MontoID = new MontoExonerado();

            try
            {
                ContextoMonto contex = new ContextoMonto();
                MontoID = contex.Monto.Find(montoid);
            }
            catch (Exception)
            {
                throw;
            }

            return MontoID;
        }

        public static List<MontoExonerado> GetList()
        {
            List<MontoExonerado> Monto = new List<MontoExonerado>();
            try
            {
                ContextoMonto contex = new ContextoMonto();
                Monto = contex.Monto.ToList();
            }
            catch (Exception)
            {
                throw;
            }

            return Monto;
        }
    }
}
