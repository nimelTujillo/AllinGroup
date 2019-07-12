using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Web.Script.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace WCFServiceTEST
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test2ObtenerRecordConductor()
        {
  
            HttpWebRequest request = (HttpWebRequest)WebRequest.
                Create("http://localhost:6183/RecordConductores.svc/RecordConductores/12345683");
            request.Method = "GET";
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string tramaJson = reader.ReadToEnd();
            JavaScriptSerializer js = new JavaScriptSerializer();
            RecordConductor recordConductorObtenido = js.Deserialize<RecordConductor>(tramaJson);
            Assert.AreEqual(232, recordConductorObtenido.Id_Record);
            Assert.AreEqual("20140", recordConductorObtenido.Nu_Licencia);
            Assert.AreEqual("RAIMON", recordConductorObtenido.Nombre);
            Assert.AreEqual("LOPEZ ATKINSON", recordConductorObtenido.Apellido);
            Assert.AreEqual(31, recordConductorObtenido.Id_Sat);
            Assert.AreEqual("Muy Grave", recordConductorObtenido.Tx_Calificacion);
            Assert.AreEqual("Utilizar las placas de exhibición, rotativa o transitoria en vehículos a los que no se encuentren asignadas.", recordConductorObtenido.Tx_Infraccion);
            Assert.AreEqual("Multa", recordConductorObtenido.Tx_Sancion);
            Assert.AreEqual(50, recordConductorObtenido.Nu_Puntos);
            Assert.AreEqual("17/08/2018", recordConductorObtenido.Fecha_Inscripcion);
            Assert.AreEqual("Activo", recordConductorObtenido.Tx_Estado);
        }
        [TestMethod]
        public void Test5ListarRecordConductor()
        {

            HttpWebRequest request = (HttpWebRequest)WebRequest.
                Create("http://localhost:6183/RecordConductores.svc/RecordConductores");
            request.Method = "GET";
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string tramaJson = reader.ReadToEnd();
            JavaScriptSerializer js = new JavaScriptSerializer();
            List<RecordConductor> recordsConductoresObtenido = js.Deserialize< List<RecordConductor>>(tramaJson);
            Assert.AreEqual(211, recordsConductoresObtenido.Count);
        }
    }
}
