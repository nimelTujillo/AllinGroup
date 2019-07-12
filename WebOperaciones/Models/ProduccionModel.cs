using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebOperaciones.Dominio;

namespace WebOperaciones.Models
{
    public class ProduccionModel
    {
        public Produccion Produccion { get; set; }
        public List<Produccion> Producciones { get; set; }

        public string Respuesta { get; set; }
        public string Error { get; set; }
    }
}