using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WCFServices.Dominio
{
    [DataContract]
    public class Usuario
    {
        [DataMember]
        public int Dni { get; set; }
        [DataMember]
        public string Nombre { get; set; }
        [DataMember]
        public string Apelllido { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public string UsuLogin { get; set; }
        [DataMember]
        public string ContraLogin { get; set; }
        [DataMember(IsRequired =false)]
        public string Estado { get; set; }
    }
}