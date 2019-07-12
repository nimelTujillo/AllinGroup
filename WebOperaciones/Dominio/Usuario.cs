using System;
using WCFSeguridad.Dominio;

namespace WebOperaciones.Dominio
{
    public class Usuario
    {
        public Usuario() { }

        public int Dni { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string UsuLogin { get; set; }
        public string ContraLogin { get; set; }
        public string Estado { get; set; }

        public static implicit operator Usuario(WCFSeguridad.Dominio.Usuario v)
        {
            throw new NotImplementedException();
        }
    }
}