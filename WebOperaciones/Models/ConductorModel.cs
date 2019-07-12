using System;
using System.Collections.Generic;
using WebOperaciones.ConductorWS;

namespace WebOperaciones.Models
{
    public class ConductorModel
    {
        public Conductor Conductor { get; set; }
        public List<Conductor> Conductores { get; set; }

        public string Respuesta { get; set; }
        public string Error { get; set; }
    }
}