using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WCFServices.Dominio;
using WCFServices.Errores;

namespace WCFServices
{
    [ServiceContract]
    public interface IBuses
    {
        [FaultContract(typeof(RepetidoException))]
        [OperationContract]
        Movilidad CrearMovilidad(Movilidad movilidadACrear);
        [OperationContract]
        Movilidad ObtenerMovilidad(int id);
        [OperationContract]
        Movilidad ModificarMovilidad(Movilidad movilidadAModificar);
        [OperationContract]
        string EliminarMovilidad(int id);
        //[OperationContract]
        //void EliminarInactivos(int id);
        [OperationContract]
        List<Movilidad> ListarMovilidad();

        [OperationContract]
        void EnviarCorreo(string correo, string asunto, string mensaje, byte[] archivo = null, string nombreArchivo = "");
    }
}
