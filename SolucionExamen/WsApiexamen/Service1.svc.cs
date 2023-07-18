using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WsApiexamen.Modelo;

namespace WsApiexamen
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class ExamenServ : IExamenServ
    {


        public Retorno AgregarExamen(string Nombre, string Descripcion)
        {
            using (BdiExamenEntities db = new BdiExamenEntities())
            {
                try
                {
                    tblExamen nuevo = new tblExamen();
                    nuevo.Nombre = Nombre;
                    nuevo.Descripcion = Descripcion;
                    db.tblExamen.Add(nuevo);
                    db.SaveChanges();
                    return new Retorno(true);
                }
                catch (Exception e)
                {
                    return new Retorno(false, e.Message);
                }
            }
        }

        public Retorno ActualizarExamen(int Id, string Nombre, string Descripcion)
        {
            using (BdiExamenEntities db = new BdiExamenEntities())
            {
                try
                {
                    tblExamen objetivo = db.tblExamen.Find(Id);
                    if(objetivo == null)
                    {
                        return new Retorno(false, "No hay registro con ese ID");
                    }
                    objetivo.Nombre = Nombre;
                    objetivo.Descripcion = Descripcion;
                    db.Entry(objetivo).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    return new Retorno(true);
                }
                catch (Exception e)
                {
                    return new Retorno(false, e.Message);
                }
            }
        }

        public Retorno EliminarExamen(int Id)
        {
            using (BdiExamenEntities db = new BdiExamenEntities())
            {
                try
                {
                    tblExamen objetivo = db.tblExamen.Find(Id);
                    if (objetivo == null)
                    {
                        return new Retorno(false, "No hay registro con ese ID");
                    }
                    db.tblExamen.Remove(objetivo);
                    db.Entry(objetivo).State = System.Data.Entity.EntityState.Deleted;
                    db.SaveChanges();
                    return new Retorno(true);
                }
                catch (Exception e)
                {
                    return new Retorno(false, e.Message);
                }
            }
        }

        public IEnumerable<tblExamen> ConsultarExamen(string Nombre, string Descripcion)
        {
            using (BdiExamenEntities db = new BdiExamenEntities())
            {
                List<tblExamen> Rows = db.tblExamen.Where(r => r.Nombre == Nombre || r.Descripcion == Descripcion).ToList();
                return Rows;
            }
        }

    }
}
