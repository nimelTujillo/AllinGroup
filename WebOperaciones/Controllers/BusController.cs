using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Web;
using System.Web.Mvc;
using WebOperaciones.BusWS;
using WebOperaciones.Models;
using WebOperaciones.Security;

namespace WebOperaciones.Controllers
{
    public class BusController : Controller
    {
        // GET: Bus
        public ActionResult Index()
        {
            BusModel model = new BusModel();
            model.Bus = new Movilidad();
            model.Buses = new List<Movilidad>();
            model.Error = "";
            model.Respuesta = "";

            return View(model);
        }

        public ActionResult Edit(int Id)
        {
            Movilidad bus = new BusesClient().ObtenerMovilidad(Id);
            BusModel model = new BusModel();
            model.Bus = bus;
            model.Buses = new List<Movilidad>();
            model.Error = "";
            model.Respuesta = "";

            return View("Index", model);
        }

        public ActionResult Delete(int Id)
        {
            BusModel model = new BusModel();
            model.Bus = new Movilidad();
            model.Buses = new List<Movilidad>();

            try
            {
                string respuesta = new BusesClient().EliminarMovilidad(Id);
                model.Respuesta = "Bus eliminado";
                model.Error = "";
            }
            catch (FaultException error)
            {
                MessageFault fault = error.CreateMessageFault();
                BusWS.RepetidoException detail = fault.GetDetail<BusWS.RepetidoException>();

                model.Respuesta = "";
                model.Error = detail.descripcion;
            }

            return View("Index", model);
        }

        [HttpGet]
        [SecurityRequired]
        public ActionResult ListarDataList()
        {
            List<Movilidad> listaBuses = new BusesClient().ListarMovilidad().ToList();

            return PartialView("ListaPartial", listaBuses);
        }

        [HttpPost]
        public ActionResult Grabar(int id, string placa, string clase, string marca, string modelo, 
                                string color, int motor, int asientos, int puertas, string fecinscripcion, 
                                string anio, string estado)
        {
            try
            {
                Movilidad busAGrabar = new Movilidad()
                {
                    Id = id,
                    Placa = placa,
                    Clase = clase,
                    Marca = marca,
                    Modelo = modelo,
                    Color = color,
                    Motor = motor,
                    Asientos = asientos,
                    Puertas = puertas,
                    FeInscripcion = DateTime.Parse(fecinscripcion),
                    Año = anio,
                    Estado = estado
                };

                Movilidad bus = null;
                if (busAGrabar.Id == 0)
                {
                    bus = new BusesClient().CrearMovilidad(busAGrabar);
                }
                else
                {
                    bus = new BusesClient().ModificarMovilidad(busAGrabar);
                }
                                
                if (bus != null)
                {
                    return Json("Success", JsonRequestBehavior.AllowGet);
                }
                else
                {
                    return Json("Datos incorrectos", JsonRequestBehavior.AllowGet);
                }
            }
            catch (FaultException error)
            {
                MessageFault fault = error.CreateMessageFault();
                BusWS.RepetidoException detail = fault.GetDetail<BusWS.RepetidoException>();

                return Json(detail.descripcion, JsonRequestBehavior.AllowGet);
            }
        }


        [HttpPost]
        public ActionResult EnviarCorreo(string correo, string asunto, string mensaje)
        {
            try
            {
                new BusesClient().EnviarCorreoAsync(correo, asunto, mensaje, null, "");

                return Json("Success", JsonRequestBehavior.AllowGet);
            }
            catch (Exception error)
            {
                return Json(error.Message, JsonRequestBehavior.AllowGet);
            }
        }

    }
}