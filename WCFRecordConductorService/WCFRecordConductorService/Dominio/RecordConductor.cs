using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WCFRecordConductorService.Dominio
{
    [DataContract]
    public class RecordConductor
    {
        [DataMember]
        public int Id_Record { get; set; }
        [DataMember]
        public int Dni_Conductor { get; set; }
        [DataMember]
        public string Nu_Licencia { get; set; }
        [DataMember]
        public string Nombre { get; set; }
        [DataMember]
        public string Apellido { get; set; }
        [DataMember]
        public string Tx_Direccion { get; set; }
        [DataMember]
        public int Id_Sat { get; set; }
        [DataMember]
        public string Tx_Calificacion { get; set; }
        [DataMember]
        public string Tx_Infraccion { get; set; }
        [DataMember]
        public string Tx_Sancion { get; set; }
        [DataMember]
        public int Nu_Puntos { get; set; }
        [DataMember]
        public decimal Nu_Condescuento { get; set; }
        [DataMember]
        public string Fecha_Inscripcion { get; set; }
        [DataMember]
        public string Tx_Estado { get; set; }

    }
}