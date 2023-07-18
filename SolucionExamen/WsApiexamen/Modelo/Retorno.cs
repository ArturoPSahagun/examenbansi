using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WsApiexamen.Modelo
{
    [DataContract]
    public class Retorno
    {
        private bool Res;
        [DataMember]
        public bool Respuesta
        {
            get { return Res; }
            set { Res = value; }
        }
        private string Msj;
        [DataMember]
        public string Mensaje
        {
            get { return Msj; }
            set { Msj = value; }
        }
        public Retorno(bool res, string mensaje)
        {
            Res = res;
            Msj = mensaje;
        }
    }
}