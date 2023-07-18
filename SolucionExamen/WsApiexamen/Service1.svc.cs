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
                    return new Retorno(true, "");
                }
                catch (Exception e)
                {
                    return new Retorno(false, e.Message);
                }
            }
        }

        public IEnumerable<tblExamen> Consultar()
        {
            using(BdiExamenEntities db = new BdiExamenEntities()) { 
            
                return db.tblExamen.AsNoTracking().ToList();
            
            
            }
        }
    }
}
