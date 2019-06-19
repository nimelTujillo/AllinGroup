using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.ServiceModel;
using System.ServiceModel.Channels;

namespace WCFServicesTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test1CrearBusesOk()
        {
            BusesWS.BusesClient proxy = new BusesWS.BusesClient();
            BusesWS.Movilidad busesCreado = proxy.CrearMovilidad(new BusesWS.Movilidad()
            {
                Id = 3,
                Placa = "EPE-2013",
                Clase = "OMNIBUS",
                Marca = "VOLVO",
                Modelo = "OP-256",
                Color = "ROJO",
                Motor = 4523,
                Asientos = 25,
                Puertas = 2,
                FeInscripcion = DateTime.Parse("2019-02-25"),
                Año = "2019",
                Estado = "Activo"
            });
            Assert.AreEqual(3, busesCreado.Id);
            Assert.AreEqual("EPE-2013", busesCreado.Placa);
            Assert.AreEqual("OMNIBUS", busesCreado.Clase);
            Assert.AreEqual("VOLVO", busesCreado.Marca);
            Assert.AreEqual("OP-256", busesCreado.Modelo);
            Assert.AreEqual("ROJO", busesCreado.Color);
            Assert.AreEqual(4523, busesCreado.Motor);
            Assert.AreEqual(25, busesCreado.Asientos);
            Assert.AreEqual(2, busesCreado.Puertas);
            Assert.AreEqual(DateTime.Parse("2019-02-25"), busesCreado.FeInscripcion);
            Assert.AreEqual("2019", busesCreado.Año);
            Assert.AreEqual("Activo", busesCreado.Estado);
        }
        [TestMethod]
        public void Test2CrearBusesRepetido()
        {
            BusesWS.BusesClient proxy = new BusesWS.BusesClient();
            try
            { 
                BusesWS.Movilidad busesCreado = proxy.CrearMovilidad(new BusesWS.Movilidad()
                {
                    Id = 111,
                    Placa = "EPE-2013",
                    Clase = "OMNIBUS",
                    Marca = "VOLVO",
                    Modelo = "OP-256",
                    Color = "ROJO",
                    Motor = 4523,
                    Asientos = 25,
                    Puertas = 2,
                    FeInscripcion = DateTime.Parse("2019-02-25"),
                    Año = "2019",
                    Estado = "Activo"
                });
            } catch (FaultException<BusesWS.RepetidoException> error)
            {
                Assert.AreEqual("Error al intentar crear", error.Reason.ToString());
                Assert.AreEqual(error.Detail.codigo, "101");
                Assert.AreEqual(error.Detail.descripcion, "El bus ya existe");
            }
        }

        [TestMethod]
        public void Test1EliminarBusesOk()
        {
            BusesWS.BusesClient proxy = new BusesWS.BusesClient();
            try
            {
                string respuesta = proxy.EliminarMovilidad(1);

                Assert.AreEqual("OK", respuesta);
            } 
            //catch (FaultException<BusesWS.RepetidoException> errora)
            //{
            //    Assert.AreEqual("Error al intentar eliminar", error.Reason.ToString());
            //    Assert.AreEqual(error.Detail.codigo, "102");
            //    Assert.AreEqual(error.Detail.descripcion, "La movilidad está ACTIVA, no se puede eliminar");
            //}
            catch (FaultException error)
            {
                MessageFault fault = error.CreateMessageFault();
                BusesWS.RepetidoException detail = fault.GetDetail<BusesWS.RepetidoException>();

                Assert.AreEqual("Error al intentar eliminar", error.Reason.ToString());
                Assert.AreEqual(detail.codigo, "102");
                Assert.AreEqual(detail.descripcion, "La movilidad está ACTIVA, no se puede eliminar");
            }
        }
    }
}
