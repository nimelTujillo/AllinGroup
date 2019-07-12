using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Web.Script.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WCFServicesTest
{
    [TestClass]
    public class UnitTest1
    {
        public int Fecha { get; private set; }
        public int Id_produccion { get; private set; }
        public int Dni_conductor { get; private set; }
        public int Id_bus { get; private set; }
        public int Can_ingreso { get; private set; }
        public string Descripcion { get; private set; }

        [TestMethod]
        public void Test1CrearProduccion()
        {
            JavaScriptSerializer js = new JavaScriptSerializer();
            Produccion_ produccionACrear = new Produccion_();
            {
                Id_produccion = 2;
                Dni_conductor = 10102034;
                Id_bus = 2;
                Can_ingreso = 500;
                Fecha = 7 - 7 - 2019;
            };
            string postdata = js.Serialize(produccionACrear);
            byte[] data = Encoding.UTF8.GetBytes(postdata);
            HttpWebRequest request = (HttpWebRequest)WebRequest.
                Create("http://localhost:21420/Produccion.svc/produccion");
            request.Method = "POST";
            request.ContentLength = data.Length;
            request.ContentType = "application/json";
            var requestStream = request.GetRequestStream();
            requestStream.Write(data, 0, data.Length);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string tramaJson = reader.ReadToEnd();
            Produccion_ produccionCreado = js.Deserialize<Produccion_>(tramaJson);
            Assert.AreEqual(2, produccionCreado.Id_produccion);
            Assert.AreEqual(10102034, produccionCreado.Dni_conductor);
            Assert.AreEqual(2, produccionCreado.Id_bus);
            Assert.AreEqual(500, produccionCreado.Can_ingreso);
            Assert.AreEqual(7 - 7 - 2019, produccionCreado.Fecha);
        }

        [TestMethod]
        public void Test1CrearProduccionDuplicado()
        {
            JavaScriptSerializer js = new JavaScriptSerializer();
            Produccion_ produccionACrear = new Produccion_();
            {
                Id_produccion = 2;
                Dni_conductor = 10102034;
                Id_bus = 2;
                Can_ingreso = 500;
                Fecha = 7 - 7 - 2019;
            };
            string postdata = js.Serialize(produccionACrear);
            byte[] data = Encoding.UTF8.GetBytes(postdata);
            HttpWebRequest request = (HttpWebRequest)WebRequest.
                Create("http://localhost:21420/Produccion.svc/produccion");
            request.Method = "POST";
            request.ContentLength = data.Length;
            request.ContentType = "application/json";
            var requestStream = request.GetRequestStream();
            requestStream.Write(data, 0, data.Length);
            HttpWebResponse response = null;
            try
            {
                response = (HttpWebResponse)request.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream());
                string tramaJson = reader.ReadToEnd();
                Produccion_ produccionCreado = js.Deserialize<Produccion_>(tramaJson);
                Assert.AreEqual(2, produccionCreado.Id_produccion);
                Assert.AreEqual(10102034, produccionCreado.Dni_conductor);
                Assert.AreEqual(2, produccionCreado.Id_bus);
                Assert.AreEqual(500, produccionCreado.Can_ingreso);
                Assert.AreEqual(7 - 7 - 2019, produccionCreado.Fecha);
            }
            catch (WebException e)
            {
                HttpStatusCode codigo = ((HttpWebResponse)e.Response).StatusCode;
                StreamReader reader = new StreamReader(e.Response.GetResponseStream());
                string trataJson = reader.ReadToEnd();
                DuplicadoException error = js.Deserialize<DuplicadoException>(trataJson);

                Assert.AreEqual(HttpStatusCode.Conflict, codigo);
                Assert.AreEqual("Producción Duplicado", error, Descripcion);

            }

        }
    

        [TestMethod]
        public void Test2ObtenerProduccion()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.
                Create("http://localhost:21420/Produccion.svc/produccion/2");
            request.Method = "GET";
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string tramaJson = reader.ReadToEnd();
            JavaScriptSerializer js = new JavaScriptSerializer();
            Produccion_ produccionObtenido = js.Deserialize<Produccion_>(tramaJson);
            Assert.AreEqual(2, produccionObtenido.Id_produccion);
            Assert.AreEqual(10102035, produccionObtenido.Dni_conductor);
            Assert.AreEqual(2, produccionObtenido.Id_bus);
            Assert.AreEqual(177, produccionObtenido.Can_ingreso);
            Assert.AreEqual(7 - 7 - 2019, produccionObtenido.Fecha);

        }

        [TestMethod]
        public void Test3ModificarProduccion()
        {
            JavaScriptSerializer js = new JavaScriptSerializer();
            Produccion_ produccionACrear = new Produccion_();
            {
                Id_produccion = 2;
                Dni_conductor = 10102034;
                Id_bus = 2;
                Can_ingreso = 750;
                Fecha = 7 - 7 - 2019;
            };
            string postdata = js.Serialize(produccionACrear);
            byte[] data = Encoding.UTF8.GetBytes(postdata);
            HttpWebRequest request = (HttpWebRequest)WebRequest.
                Create("http://localhost:21420/Produccion.svc/produccion");
            request.Method = "PUT";
            request.ContentLength = data.Length;
            request.ContentType = "application/json";
            var requestStream = request.GetRequestStream();
            requestStream.Write(data, 0, data.Length);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string tramaJson = reader.ReadToEnd();
            Produccion_ produccionCreado = js.Deserialize<Produccion_>(tramaJson);
            Assert.AreEqual(2, produccionCreado.Id_produccion);
            Assert.AreEqual(10102034, produccionCreado.Dni_conductor);
            Assert.AreEqual(2, produccionCreado.Id_bus);
            Assert.AreEqual(750, produccionCreado.Can_ingreso);
            Assert.AreEqual(7 - 7 - 2019, produccionCreado.Fecha);
        }
        [TestMethod]
        public void Test4EliminarProduccion()
        {

            HttpWebRequest request = (HttpWebRequest)WebRequest.
                Create("http://localhost:21420/Produccion.svc/produccion/2");
            request.Method = "DELETE";
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            HttpWebRequest request2 = (HttpWebRequest)WebRequest.
                Create("http://localhost:21420/Produccion.svc/produccion/2");
            request2.Method = "GET";
            HttpWebResponse response2 = (HttpWebResponse)request2.GetResponse();
            StreamReader reader = new StreamReader(response2.GetResponseStream());
            string tramaJson = reader.ReadToEnd();
            JavaScriptSerializer js = new JavaScriptSerializer();
            Produccion_ produccionObtenido = js.Deserialize<Produccion_>(tramaJson);
            Assert.IsNull(produccionObtenido);
        }

        [TestMethod]
        public void Test5ListarProduccion()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.
               Create("http://localhost:21420/Produccion.svc/produccion");
            request.Method = "GET";
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string tramaJson = reader.ReadToEnd();
            JavaScriptSerializer js = new JavaScriptSerializer();
            List<Produccion_> produccionObtenidos = js.Deserialize<List<Produccion_>>(tramaJson);
            Assert.AreEqual(2, produccionObtenidos.Count);

        }
    }
}
