using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using WebOperaciones.Dominio;
using WebOperaciones.Models;
using WebOperaciones.Security;

namespace WebOperaciones.Controllers
{
    public class ProduccionController : Controller
    {
        public ActionResult Index()
        {
            ProduccionModel model = new ProduccionModel();
            model.Produccion = new Produccion();
            model.Producciones = new List<Produccion>();
            model.Error = "";
            model.Respuesta = "";

            return View(model);
        }

        public ActionResult Edit(int Id)
        {
            Produccion produccion = new Produccion(); // BusesClient().ObtenerMovilidad(Id);
            //var obj = new {
            //    id_produccion = Id.ToString()
            //};

            //JavaScriptSerializer js = new JavaScriptSerializer();
            //string postdata = js.Serialize(obj);
            //byte[] data = Encoding.UTF8.GetBytes(postdata);
            //HttpWebRequest request = (HttpWebRequest)WebRequest.
            //    Create("http://localhost:21420/Produccion.svc/Produccion");
            //request.Method = "PUT";
            //request.ContentLength = data.Length;
            //request.ContentType = "application/json";
            //var requestStream = request.GetRequestStream();
            //requestStream.Write(data, 0, data.Length);
            //HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            //StreamReader reader = new StreamReader(response.GetResponseStream());
            //string tramaJson = reader.ReadToEnd();
            //produccion = js.Deserialize<Produccion>(tramaJson);

            ProduccionModel model = new ProduccionModel();
            model.Produccion = produccion;
            model.Producciones = new List<Produccion>();
            model.Error = "";
            model.Respuesta = "";

            return View("Index", model);
        }

        public ActionResult Delete(int Id)
        {
            ProduccionModel model = new ProduccionModel();
            model.Produccion = new Produccion();
            model.Producciones = new List<Produccion>();

            HttpWebRequest request = (HttpWebRequest)WebRequest.
               Create("http://localhost:21420/Produccion.svc/Produccion/" + Id.ToString());
            request.Method = "DELETE";
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string tramaJson = reader.ReadToEnd();
            model.Respuesta = "Producción eliminado";
            model.Error = "";

            return View("Index", model);
        }

        [HttpGet]
        [SecurityRequired]
        public ActionResult ListarDataList()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.
                Create("http://localhost:21420/Produccion.svc/Produccion");
            request.Method = "GET";
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string tramaJson = reader.ReadToEnd();
            JavaScriptSerializer js = new JavaScriptSerializer();
            List<Produccion> listaProducciones = js.Deserialize<List<Produccion>>(tramaJson);

            return PartialView("ListaPartial", listaProducciones);
        }

        [HttpPost]
        public ActionResult Grabar(int id, int dni_conductor, int id_bus, 
                                    decimal can_ingreso, string fecha)
        {

            JavaScriptSerializer js = new JavaScriptSerializer();
            Produccion produccionAGrabar = new Produccion()
            {
                Id_produccion = id,
                Dni_conductor = dni_conductor,
                Id_bus = id_bus,
                Can_ingreso = can_ingreso,
                Fecha = fecha
            };

            Produccion produccion = null;
            if (id == 0)
            {
                string postdata = js.Serialize(produccionAGrabar);
                byte[] data = Encoding.UTF8.GetBytes(postdata);
                HttpWebRequest request = (HttpWebRequest)WebRequest.
                    Create("http://localhost:21420/Produccion.svc/Produccion");
                request.Method = "POST";
                request.ContentLength = data.Length;
                request.ContentType = "application/json";
                var requestStream = request.GetRequestStream();
                requestStream.Write(data, 0, data.Length);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream());
                string tramaJson = reader.ReadToEnd();
                produccion = js.Deserialize<Produccion>(tramaJson);
            }
            else
            {
                string postdata = js.Serialize(produccionAGrabar);
                byte[] data = Encoding.UTF8.GetBytes(postdata);
                HttpWebRequest request = (HttpWebRequest)WebRequest.
                    Create("http://localhost:21420/Produccion.svc/Produccion");
                request.Method = "PUT";
                request.ContentLength = data.Length;
                request.ContentType = "application/json";
                var requestStream = request.GetRequestStream();
                requestStream.Write(data, 0, data.Length);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream());
                string tramaJson = reader.ReadToEnd();
                produccion = js.Deserialize<Produccion>(tramaJson);
            }

            if (produccion != null)
            {
                return Json("Success", JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json("Datos incorrectos", JsonRequestBehavior.AllowGet);
            }
        }
    }
}