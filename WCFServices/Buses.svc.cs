using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WCFServices.Dominio;
using WCFServices.Errores;
using WCFServices.Persistencia;

namespace WCFServices
{

    public class Buses : IBuses
    {
        private MovilidadDAO movilidadDAO = new MovilidadDAO();
        public Movilidad CrearMovilidad(Movilidad movilidadACrear)
        {
            if (movilidadDAO.ObtenerPorPlaca(movilidadACrear.Placa) != null)
            {
                throw new FaultException<RepetidoException>(
                    new RepetidoException()
                    {
                        codigo = "101",
                        descripcion = "La movilidad ya existe"
                    },
                    new FaultReason("Error al intentar crear"));
            }
            return movilidadDAO.Crear(movilidadACrear);
        }

        public string EliminarMovilidad(int id)
        {
            Movilidad movilidadAEliminar = movilidadDAO.Obtener(id);
            if (movilidadAEliminar != null)
            {
                if (movilidadAEliminar.Estado.ToLower().Equals("activo"))
                {
                    throw new FaultException<RepetidoException>(
                    new RepetidoException()
                    {
                        codigo = "102",
                        descripcion = "La movilidad está ACTIVA, no se puede eliminar"
                    },
                    new FaultReason("Error al intentar eliminar"));
                }
            }
            return movilidadDAO.Eliminar(id);
        }

        //public void EliminarInactivos(int id)
        //{
        //    movilidadDAO.Eliminar(id);
        //}
        public List<Movilidad> ListarMovilidad()
        {
            return movilidadDAO.Listar();
        }

        public Movilidad ModificarMovilidad(Movilidad movilidadAModificar)
        {
            return movilidadDAO.Modificar(movilidadAModificar);
        }

        public Movilidad ObtenerMovilidad(int id)
        {
            return movilidadDAO.Obtener(id);
        }

        public void EnviarCorreo(string correo, string asunto, string mensaje, byte[] archivo = null, string nombreArchivo = "")
        {
            var instMail = new Mail("smtp.gmail.com", "aqonotifications@gmail.com", "AqoN2017%");
            instMail.ValorDelReceptor(correo, asunto, mensaje);
            if (archivo != null && nombreArchivo.Length > 0)
                instMail.AgregarArchivoByte(archivo, nombreArchivo);
            instMail.EnviarEmail();
        }
    }
}
