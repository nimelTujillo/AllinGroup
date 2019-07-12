using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebOperaciones.Dominio
{
    public class Produccion
    {
        public int Id_produccion { get; set; }

        public int Dni_conductor { get; set; }

        public int Id_bus { get; set; }

        public decimal Can_ingreso { get; set; }

        public string Fecha { get; set; }
    }
}