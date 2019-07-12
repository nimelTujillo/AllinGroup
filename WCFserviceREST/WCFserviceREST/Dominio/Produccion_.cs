using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WCFserviceREST.Dominio
{
    [DataContract]
    public class Produccion_
    {
        [DataMember]
        public int Id_produccion { get; set; }

        [DataMember]
        public int Dni_conductor { get; set; }

        [DataMember]
        public int Id_bus { get; set; }

        [DataMember]
        public decimal Can_ingreso { get; set; }

        [DataMember(IsRequired =false)]
        public string Fecha { get; set; }
    }
}