using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCFServiceTEST
{
    class RecordConductor
    {
   
        public int Id_Record { get; set; }
      
        public int Dni_Conductor { get; set; }

        public string Nu_Licencia { get; set; }

        public string Nombre { get; set; }
  
        public string Apellido { get; set; }
     
        public string Tx_Direccion { get; set; }

        public int Id_Sat { get; set; }
      
        public string Tx_Calificacion { get; set; }
    
        public string Tx_Infraccion { get; set; }
    
        public string Tx_Sancion { get; set; }
   
        public int Nu_Puntos { get; set; }

        public decimal Nu_Condescuento { get; set; }
   
        public string Fecha_Inscripcion { get; set; }
       
        public string Tx_Estado { get; set; }
    }
}
