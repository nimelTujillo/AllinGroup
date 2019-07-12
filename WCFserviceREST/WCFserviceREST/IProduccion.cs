using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WCFserviceREST.Dominio;

namespace WCFserviceREST
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IProduccion" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IProduccion
    {
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "Produccion", ResponseFormat = WebMessageFormat.Json)]

        Produccion_ CrearProduccion(Produccion_ produccionAcrear);
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Produccion/{id_produccion}", ResponseFormat = WebMessageFormat.Json)]

        Produccion_ ObtenerProduccion(string id_produccion);//aqui string
        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "Produccion", ResponseFormat = WebMessageFormat.Json)]

        Produccion_ ModificarProduccion(Produccion_ produccionAModificar);
        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "Produccion/{id_produccion}", ResponseFormat = WebMessageFormat.Json)]

        void EliminarProduccion(string id_produccion); //aqui string
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Produccion", ResponseFormat = WebMessageFormat.Json)]
        List<Produccion_> ListarProduccion();
    }
}

