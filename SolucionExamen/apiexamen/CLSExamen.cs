using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace apiexamen
{
    public class CLSExamen
    {
        public static string AgregarExamen(string Nombre, string Descripcion)
        {
            using (BdiExamenEntities db = new BdiExamenEntities())
            {
                var resultado = db.spAgregar(Nombre, Descripcion).ToList();
                var primero = resultado.First();
                string msj = string.Format("Codigo : {0} \nMensaje : {1}", primero.codigo_retorno, primero.mensaje_retorno);
                return msj;
            }
        }
        public static string ActualizarExamen(string Id, string Nombre, string Descripcion)
        {
            int IdInt;
            //validacion
            try
            {
                IdInt = Int32.Parse(Id);
            }
            catch
            {
                return "La Id ingresada no es un numero";
            }
            using (BdiExamenEntities db = new BdiExamenEntities())
            {
                var resultado = db.spActualizar(IdInt, Nombre, Descripcion).ToList();
                var primero = resultado.First();
                string msj = string.Format("Codigo : {0} \nMensaje : {1}", primero.codigo_retorno, primero.mensaje_retorno);
                return msj;
            }
        }
        public static string EliminarExamen(string Id)
        {
            int IdInt;
            //validacion
            try
            {
                IdInt = Int32.Parse(Id);
            }
            catch
            {
                return "La Id ingresada no es un numero";
            }
            using (BdiExamenEntities db = new BdiExamenEntities())
            {
                var resultado = db.spEliminar(IdInt).ToList();
                var primero = resultado.First();
                string msj = string.Format("Codigo : {0} \nMensaje : {1}", primero.codigo_retorno, primero.mensaje_retorno);
                return msj;
            }
        }

        public static List<Examen> ConsultarExamen(string Nombre, string Descripcion)
        {
            using (BdiExamenEntities db = new BdiExamenEntities())
            {
                var resultado = db.spConsultar(Nombre, Descripcion).ToList();
                List<Examen> senddata = new List<Examen>();
                foreach (var item in resultado)
                {
                    senddata.Add(new Examen(item.idExamen, item.Nombre, item.Descripcion));
                }
                return senddata;
            }
        }






    }
}
