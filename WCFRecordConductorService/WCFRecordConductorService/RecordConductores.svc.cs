using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WCFRecordConductorService.Dominio;
using WCFRecordConductorService.Persistencia;

namespace WCFRecordConductorService
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "RecordConductores" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione RecordConductores.svc o RecordConductores.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class RecordConductores : IRecordConductores
    {
        private RecordConductorDAO recordConductorDAO = new RecordConductorDAO();
        public List<RecordConductor> ListarRecordConductor()
        {
            return recordConductorDAO.Listar();
        }

        public RecordConductor ObtenerRecordConductor(string dni_recordConductor)
        {
            return recordConductorDAO.Obtener(int.Parse(dni_recordConductor));
        }
    }
}
