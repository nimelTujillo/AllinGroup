using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using WebOperaciones.Dominio;
using WebOperaciones.Models;
using WebOperaciones.Security;

namespace WebOperaciones.Controllers
{
    public class UsuarioController : Controller
    {
        public ActionResult Index()
        {
            UsuarioModel model = new UsuarioModel();
            model.Usuario = new Usuario();
            model.Usuarios = new List<Usuario>();
            model.Error = "";
            model.Respuesta = "";

            return View(model);
        }

        public ActionResult Edit(int Id)
        {
            Usuario usuario = new Usuario(); // BusesClient().ObtenerMovilidad(Id);
            UsuarioModel model = new UsuarioModel();
            model.Usuario = usuario;
            model.Usuarios = new List<Usuario>();
            model.Error = "";
            model.Respuesta = "";

            return View("Index", model);
        }

        public ActionResult Delete(int Id)
        {
            UsuarioModel model = new UsuarioModel();
            model.Usuario = new Usuario();
            model.Usuarios = new List<Usuario>();

            HttpWebRequest request = (HttpWebRequest)WebRequest.
               Create("http://localhost:54776/Usuarios.svc/Usuarios/87654321");
            request.Method = "DELETE";
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string tramaJson = reader.ReadToEnd();
            model.Respuesta = "Bus eliminado";
            model.Error = "";

            return View("Index", model);
        }

        [HttpGet]
        [SecurityRequired]
        public ActionResult ListarDataList()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.
                Create("http://localhost:54776/Usuarios.svc/Usuarios");
            request.Method = "GET";
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string tramaJson = reader.ReadToEnd();
            JavaScriptSerializer js = new JavaScriptSerializer();
            List<Usuario> listaUsuarios = js.Deserialize<List<Usuario>>(tramaJson);

            return PartialView("ListaPartial", listaUsuarios);
        }

        [HttpPost]
        public ActionResult Grabar(int id, int dni, string nombre, string apellidos, string email,
                                string login, string contrasenia, string estado)
        {

            JavaScriptSerializer js = new JavaScriptSerializer();
            Usuario usuarioAGrabar = new Usuario()
            {
                Dni = dni,
                Nombre = nombre,
                Apellido = apellidos,
                Email = email,
                UsuLogin = login,
                ContraLogin = contrasenia,
                Estado = estado
            };
           
            Usuario usuario = null;
            if (id == 0)
            {
                string postdata = js.Serialize(usuarioAGrabar);
                byte[] data = Encoding.UTF8.GetBytes(postdata);
                HttpWebRequest request = (HttpWebRequest)WebRequest.
                    Create("http://localhost:54776/Usuarios.svc/Usuarios");
                request.Method = "POST";
                request.ContentLength = data.Length;
                request.ContentType = "application/json";
                var requestStream = request.GetRequestStream();
                requestStream.Write(data, 0, data.Length);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream());
                string tramaJson = reader.ReadToEnd();
                usuario = js.Deserialize<Usuario>(tramaJson);
            }
            else
            {
                string postdata = js.Serialize(usuarioAGrabar);
                byte[] data = Encoding.UTF8.GetBytes(postdata);
                HttpWebRequest request = (HttpWebRequest)WebRequest.
                    Create("http://localhost:54776/Usuarios.svc/Usuarios");
                request.Method = "PUT";
                request.ContentLength = data.Length;
                request.ContentType = "application/json";
                var requestStream = request.GetRequestStream();
                requestStream.Write(data, 0, data.Length);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream());
                string tramaJson = reader.ReadToEnd();
                usuario = js.Deserialize<Usuario>(tramaJson);
            }

            if (usuario != null)
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
