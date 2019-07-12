using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebOperaciones.Models;
using WebOperaciones.ConductorWS;
using System.ServiceModel;
using System.ServiceModel.Channels;
using WebOperaciones.Security;

namespace WebOperaciones.Controllers
{
    public class ConductorController : Controller
    {
        // GET: conductor
        public ActionResult Index()
        {
            ConductorModel model = new ConductorModel();
            model.Conductor = new Conductor();
            model.Conductores = new List<Conductor>();
            model.Error = "";
            model.Respuesta = "";

            return View(model);
        }

        public ActionResult Edit(int Id)
        {
            Conductor conductor = new ConductoresClient().ObtenerConductor(Id);
            ConductorModel model = new ConductorModel();
            model.Conductor = conductor;
            model.Conductores = new List<Conductor>();
            model.Error = "";
            model.Respuesta = "";

            return View("Index", model);
        }

        public ActionResult Delete(int Id)
        {
            ConductorModel model = new ConductorModel();
            model.Conductor = new Conductor();
            model.Conductores = new List<Conductor>();

            try
            {
                new ConductoresClient().EliminarConductor(Id);
                model.Respuesta = "Conductor eliminado";
                model.Error = "";
            }
            catch (FaultException error)
            {
                MessageFault fault = error.CreateMessageFault();
                ConductorWS.RepetidoException detail = fault.GetDetail<ConductorWS.RepetidoException>();

                model.Respuesta = "";
                model.Error = detail.descripcion;
            }

            return View("Index", model);
        }

        [HttpGet]
        [SecurityRequired]
        public ActionResult ListarDataList()
        {
            List<Conductor> listaConductores = new ConductoresClient().ListarConductor().ToList();

            return PartialView("ListaPartial", listaConductores);
        }

        [HttpPost]
        public ActionResult Grabar(int id, int dni_conductor, string des_nombres, string des_apellido, 
                                string fecha_ingreso, string categoria_licencia,
                                string nro_licencia, string tx_estado, string direccion)
        {
            try
            {
                Conductor conductorAGrabar = new Conductor()
                {
                    dni_conductor = dni_conductor,
                    des_nombres = des_nombres,
                    des_apellido = des_apellido,
                    fecha_ingreso = DateTime.Parse(fecha_ingreso),
                    categoria_licencia = categoria_licencia,
                    nro_licencia = nro_licencia,
                    tx_estado = tx_estado,
                    direccion = direccion
                };

                Conductor conductor = null;
                if (id == 0)
                {
                    conductor = new ConductoresClient().CrearConductor(conductorAGrabar);
                }
                else
                {
                    conductor = new ConductoresClient().ModificarConductor(conductorAGrabar);
                }

                if (conductor != null)
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
                ConductorWS.RepetidoException detail = fault.GetDetail<ConductorWS.RepetidoException>();

                return Json(detail.descripcion, JsonRequestBehavior.AllowGet);
            }
        }
    }
}