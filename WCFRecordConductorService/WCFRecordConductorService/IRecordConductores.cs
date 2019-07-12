using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WCFRecordConductorService.Dominio;
using WCFRecordConductorService.Errores;

namespace WCFRecordConductorService
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IRecordConductores" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IRecordConductores
    {
        //CREAR
        //[WebInvoke(Method = "POST", UriTemplate = "RecordConductores", ResponseFormat = WebMessageFormat.Json)]
        //MODIFICAR
        //[WebInvoke(Method = "PUT", UriTemplate = "RecordConductores", ResponseFormat = WebMessageFormat.Json)]
        //ELIMINAR
        //[WebInvoke(Method = "DELETE", UriTemplate = "RecordConductores/{dni_recordConductor}", ResponseFormat = WebMessageFormat.Json)]
        [FaultContract(typeof(RepetidoException))]
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "RecordConductores/{dni_recordConductor}", ResponseFormat = WebMessageFormat.Json)]
        RecordConductor ObtenerRecordConductor(string dni_recordConductor);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "RecordConductores", ResponseFormat = WebMessageFormat.Json)]
        List<RecordConductor> ListarRecordConductor();
    }
}
