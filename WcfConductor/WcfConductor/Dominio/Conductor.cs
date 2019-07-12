using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfConductor.Dominio
{
     [DataContract]
    public class Conductor
    {
 
        [DataMember]
        public int dni_conductor { get; set; }

        [DataMember]
        public string des_nombres { get; set; }

        [DataMember]
        public string des_apellido { get; set; }

        [DataMember]
        public DateTime fecha_ingreso { get; set; }

        [DataMember]
        public string categoria_licencia { get; set; }

        [DataMember]
        public string nro_licencia { get; set; }

        [DataMember]
        public string tx_estado { get; set; }

        [DataMember]
        public string direccion { get; set; }
    }
}