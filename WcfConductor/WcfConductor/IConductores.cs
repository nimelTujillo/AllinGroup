using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WcfConductor.Dominio;
using WcfConductor.Errores;

namespace WcfConductor
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IConductores" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IConductores
    {
            [FaultContract(typeof(RepetidoException))]
            [OperationContract]
            Conductor CrearConductor(Conductor conductorACrear);
            [OperationContract]
            Conductor ObtenerConductor(int id);
            [OperationContract]
            Conductor ModificarConductor(Conductor conductorAModificar);
            [OperationContract]
            void EliminarConductor(int id);
            [OperationContract]
            void EliminarInactivos(int id);
            [OperationContract]
            List<Conductor> ListarConductor();

    }
}
