using System;
using System.Collections;
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
        public static string AgregarExamen(string Nombre, string Descripcion, string Metodo)
        {
            if (Metodo == "Stored Procedure")
            {
                using (BdiExamenEntities db = new BdiExamenEntities())
                {
                    var resultado = db.spAgregar(Nombre, Descripcion).ToList();
                    var primero = resultado.First();
                    string msj = string.Format("Codigo : {0} \nMensaje : {1}", primero.codigo_retorno, primero.mensaje_retorno);
                    return msj;
                }
            }
            else if(Metodo == "Web Service")
            {
                ServiceReference1.ExamenServClient servicio = new ServiceReference1.ExamenServClient();
                var retorno = servicio.AgregarExamen(Nombre, Descripcion);
                string msj = string.Format("Codigo : {0} \nMensaje : {1}", retorno.Respuesta, retorno.Mensaje);
                return msj;
            }
            else
            {
                return "Metodo no valido";
            }
        }
        public static string ActualizarExamen(string Id, string Nombre, string Descripcion, string Metodo)
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
            if (Metodo == "Stored Procedure")
            {
                using (BdiExamenEntities db = new BdiExamenEntities())
                {
                    var resultado = db.spActualizar(IdInt, Nombre, Descripcion).ToList();
                    var primero = resultado.First();
                    string msj = string.Format("Codigo : {0} \nMensaje : {1}", primero.codigo_retorno, primero.mensaje_retorno);
                    return msj;
                }
            }
            else if (Metodo == "Web Service")
            {
                ServiceReference1.ExamenServClient servicio = new ServiceReference1.ExamenServClient();
                var retorno = servicio.ActualizarExamen(IdInt, Nombre, Descripcion);
                string msj = string.Format("Codigo : {0} \nMensaje : {1}", retorno.Respuesta, retorno.Mensaje);
                return msj;
            }
            else
            {
                return "Metodo no valido";
            }

        }
        public static string EliminarExamen(string Id, string Metodo)
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
            if (Metodo == "Stored Procedure")
            {
                using (BdiExamenEntities db = new BdiExamenEntities())
                {
                    var resultado = db.spEliminar(IdInt).ToList();
                    var primero = resultado.First();
                    string msj = string.Format("Codigo : {0} \nMensaje : {1}", primero.codigo_retorno, primero.mensaje_retorno);
                    return msj;
                }
            }
            else if (Metodo == "Web Service")
            {
                ServiceReference1.ExamenServClient servicio = new ServiceReference1.ExamenServClient();
                var retorno = servicio.EliminarExamen(IdInt);
                string msj = string.Format("Codigo : {0} \nMensaje : {1}", retorno.Respuesta, retorno.Mensaje);
                return msj;
            }
            else
            {
                return "Metodo no valido";
            }
        }

        public static List<Examen> ConsultarExamen(string Nombre, string Descripcion, string Metodo)
        {
            List<Examen> senddata = new List<Examen>();

            if (Metodo == "Stored Procedure")
            {
                using (BdiExamenEntities db = new BdiExamenEntities())
                {
                    var resultado = db.spConsultar(Nombre, Descripcion).ToList();
                    foreach (var item in resultado)
                    {
                        senddata.Add(new Examen(item.idExamen, item.Nombre, item.Descripcion));
                    }
                    return senddata;
                }
            }
            else if (Metodo == "Web Service")
            {
                ServiceReference1.ExamenServClient servicio = new ServiceReference1.ExamenServClient();
                var retorno = servicio.ConsultarExamen(Nombre, Descripcion);
                foreach (var item in retorno)
                {
                    senddata.Add(new Examen(item.idExamen, item.Nombre, item.Descripcion));
                }
                return senddata;
            }
            else
            {
                return null;
            }
        }






    }
}
