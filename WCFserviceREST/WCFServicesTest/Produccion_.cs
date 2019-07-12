using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WCFServicesTest
{
    
    public class Produccion_
    {
        
        public int Id_produccion { get; set; }
        
        public int Dni_conductor { get; set; }
        
        public int Id_bus { get; set; }
       
        public decimal Can_ingreso { get; set; }
        
        public string Fecha { get; set; }
    }
}
