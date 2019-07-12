using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WcfConductor.Dominio;
using WcfConductor.Errores;
using WcfConductor.Persistencia;

namespace WcfConductor
{
     public class Conductores : IConductores
     {
        private ConductorDAO conductorDAO = new ConductorDAO();
        public Conductor CrearConductor(Conductor conductorACrear)
        {
            if (conductorDAO.Obtener(conductorACrear.dni_conductor) != null)
            {
                throw new FaultException<RepetidoException>(
                    new RepetidoException()
                    {
                        codigo = "11111111",
                        descripcion = "El conductor ya existe"
                    },
                    new FaultReason("Error al intentar crear"));
            }
            return conductorDAO.Crear(conductorACrear);
        }

        public void EliminarConductor(int id)
        {
            conductorDAO.Eliminar(id);
        }
        public void EliminarInactivos(int id)
        {
            conductorDAO.Eliminar(id);
        }
        public List<Conductor> ListarConductor()
        {
            return conductorDAO.Listar();
        }

        public Conductor ModificarConductor(Conductor conductorAModificar)
        {
            return conductorDAO.Modificar(conductorAModificar);
        }

        public Conductor ObtenerConductor(int id)
        {
            return conductorDAO.Obtener(id);
        }
    }
}
