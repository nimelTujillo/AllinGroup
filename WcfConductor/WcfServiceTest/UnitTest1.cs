using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.ServiceModel;

namespace WcfServiceTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test1CrearConductoresOk()
        {
  ConductoresWS.ConductoresClient proxy = new ConductoresWS.ConductoresClient();
            ConductoresWS.Conductor conductoresCreado = proxy.CrearConductor(new ConductoresWS.Conductor()
        {
                dni_conductor = 22222222,
                des_nombres = "David",
                des_apellido = "Zapata Alvarez",
                fecha_ingreso = DateTime.Parse("2019-02-25"),
                categoria_licencia = "AIII",
                nro_licencia = "Q22222222",
                tx_estado = "ACTIVO",
                direccion = "XXXXXXXXXXXXXXXX"

            });

            Assert.AreEqual(22222222, conductoresCreado.dni_conductor);
            Assert.AreEqual("David", conductoresCreado.des_nombres);
            Assert.AreEqual("Zapata Alvarez", conductoresCreado.des_apellido);
            Assert.AreEqual(DateTime.Parse("2019-02-25"), conductoresCreado.fecha_ingreso);
            Assert.AreEqual("AIII", conductoresCreado.categoria_licencia);
            Assert.AreEqual("Q22222222", conductoresCreado.nro_licencia);
            Assert.AreEqual("ACTIVO", conductoresCreado.tx_estado);
            Assert.AreEqual("XXXXXXXXXXXXXXXX", conductoresCreado.direccion);
        }
        [TestMethod]
        public void Test2CrearConductoresRepetido()
        {
            ConductoresWS.ConductoresClient proxy = new ConductoresWS.ConductoresClient();
            try
            { 
                ConductoresWS.Conductor conductoresCreado = proxy.CrearConductor(new ConductoresWS.Conductor()
                {

                dni_conductor = 22222222,
                des_nombres = "David",
                des_apellido = "Zapata Alvarez",
                fecha_ingreso = DateTime.Parse("2019-02-25"),
                categoria_licencia = "AIII",
                nro_licencia = "Q22222222",
                tx_estado = "ACTIVO",
                direccion = "XXXXXXXXXXXXXXXX"

                });
            } catch (FaultException<ConductoresWS.RepetidoException> error)
            {
                Assert.AreEqual("Error al intentar crear", error.Reason.ToString());
                Assert.AreEqual(error.Detail.codigo, "222222222");
                Assert.AreEqual(error.Detail.descripcion, "El conductor ya existe");

                 }
            }
    }
}
