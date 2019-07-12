using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WCFserviceREST.Dominio;
using WCFserviceREST.Errores;
using WCFserviceREST.Persistencia;

namespace WCFserviceREST
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Produccion" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Produccion.svc o Produccion.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Produccion : IProduccion
    {
        private ProduccionDAO produccionDAO = new ProduccionDAO();

        public Produccion_ CrearProduccion(Produccion_ produccionAcrear)
        {
            Produccion_ produccionExistente = produccionDAO.Obtener(produccionAcrear.Id_produccion);
            if (produccionExistente != null)
            //if (produccionDAO.Obtener(produccionAcrear.Id_produccion) != null)  // ya existe
            {
                throw new WebFaultException<DuplicadoException>(new DuplicadoException()
                {
                    Codigo = 102,
                    Descripcion = "La produccion ya existe",
                }, HttpStatusCode.Conflict);
            }
            return produccionDAO.Crear(produccionAcrear);
        }

        public void EliminarProduccion(string id_produccion)
        {
            produccionDAO.Eliminar(int.Parse(id_produccion));
        }

        public List<Produccion_> ListarProduccion()
        {
            return produccionDAO.Listar();
        }

        public Produccion_ ModificarProduccion(Produccion_ produccionAModificar)
        {
            return produccionDAO.Modificar(produccionAModificar);
        }

        public Produccion_ ObtenerProduccion(string id_produccion)
        {
            return produccionDAO.Obtener(int.Parse(id_produccion));
        }
    }
}
