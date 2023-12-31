﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WsApiexamen.Modelo;

namespace WsApiexamen
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IExamenServ
    {

        [OperationContract]
        Retorno AgregarExamen(string Nombre, string Descripcion);

        [OperationContract]
        Retorno ActualizarExamen(int Id, string Nombre, string Descripcion);

        [OperationContract]
        Retorno EliminarExamen(int Id);

        [OperationContract]
        IEnumerable<tblExamen> ConsultarExamen(string Nombre, string Descripcion);


    }

}
