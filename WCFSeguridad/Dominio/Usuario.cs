
namespace WCFSeguridad.Dominio
{
    using System.Runtime.Serialization;

    [DataContract]
    public class Usuario
    {
        [DataMember]
        public int dni_usuario { get; set; }
        [DataMember]
        public string nombre { get; set; }
        [DataMember]
        public string apellido { get; set; }
        [DataMember]
        public string email { get; set; }
        [DataMember]
        public string usu_login { get; set; }
        [DataMember]
        public string pass_login { get; set; }
        [DataMember]
        public string tx_estado { get; set; }
    }
}