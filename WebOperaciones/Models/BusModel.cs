using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebOperaciones.BusWS;

namespace WebOperaciones.Models
{
    public class BusModel
    {
        public Movilidad Bus { get; set; }
        public List<Movilidad> Buses { get; set; }

        public string Respuesta { get; set; }
        public string Error { get; set; }
    }
}