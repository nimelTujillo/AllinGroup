using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WCFServices.Dominio
{
    [DataContract]
    public class Movilidad
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Placa { get; set; }
        [DataMember]
        public string Clase { get; set; }
        [DataMember]
        public string Marca { get; set; }
        [DataMember]
        public string Modelo { get; set; }
        [DataMember]
        public string Color { get; set; }
        [DataMember]
        public int Motor { get; set; }
        [DataMember]
        public int Asientos { get; set; }
        [DataMember]
        public int Puertas { get; set; }
        [DataMember]
        public DateTime FeInscripcion { get; set; }
        [DataMember]
        public string Año { get; set; }
        [DataMember(IsRequired =false)]
        public string Estado { get; set; }


    }
}