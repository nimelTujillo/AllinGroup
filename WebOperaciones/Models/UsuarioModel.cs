using System.Collections.Generic;
using WebOperaciones.Dominio;

namespace WebOperaciones.Models
{
    public class UsuarioModel
    {
        public Usuario Usuario { get; set; }
        public List<Usuario> Usuarios { get; set; }

        public string Respuesta { get; set; }
        public string Error { get; set; }
    }
}