using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WCFRecordConductorService.Dominio;

namespace WCFRecordConductorService.Persistencia
{
    public class RecordConductorDAO
    {
        public string CadenaConexion = "Data Source=(local); Initial Catalog=BDOperaciones;Integrated Security=SSPI;";

        public RecordConductor Obtener(int dni_recordConductor)
        {
            RecordConductor recordConductorEncontrado = null;
            string sql = "SELECT R.ID_RECORD AS IDRECORD, R.DNI_CONDUCTOR DNICONDUCTOR, C.NU_LICENCIA LICENCIA, UPPER(C.NOMBRE) NOMBRE, UPPER(C.APELLIDO) APELLIDO, C.TX_DIRECCION DIRECCION, R.ID_SAT IDSAT, S.TX_CALIFICACION CALIFICACION, S.TX_INFRACCION INFRACCION, S.TX_SANCION SANCION, S.NU_PUNTOS PUNTOS, S.NU_CONDESCUENTO MONTOAPAGAR, CONVERT(VARCHAR(10),R.FECHA_INSCRIPCION, 103) FECHADESANCION, R.TX_ESTADO ESTADO FROM   BDOPERACIONES.OPERACION.SAT S INNER  JOIN BDRecordConductor.sisrec.recordConductor R ON     S.IDMULTA = R.ID_SAT INNER  JOIN BDOPERACIONES.OPERACION.CONDUCTOR C ON     R.DNI_CONDUCTOR = C.DNI WHERE  R.TX_ESTADO = 'Activo' AND    S.NU_PUNTOS > 0 AND    S.TX_ESTADO = 'Activo' AND    R.DNI_CONDUCTOR = @dni_recordConductor ORDER  BY R.DNI_CONDUCTOR ASC; ";
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("@dni_recordConductor", dni_recordConductor));
                    using (SqlDataReader resultado = comando.ExecuteReader())
                    {
                        if (resultado.Read())
                        {
                            recordConductorEncontrado = new RecordConductor()
                            {


                                Id_Record = (int)resultado["IDRECORD"],
                                Dni_Conductor = (int)resultado["DNICONDUCTOR"],
                                Nu_Licencia = (string)resultado["LICENCIA"],
                                Nombre = (string)resultado["NOMBRE"],
                                Apellido = (string)resultado["APELLIDO"],
                                Tx_Direccion = (string)resultado["DIRECCION"],
                                Id_Sat = (int)resultado["IDSAT"],
                                Tx_Calificacion = (string)resultado["CALIFICACION"],
                                Tx_Infraccion = (string)resultado["INFRACCION"],
                                Tx_Sancion = (string)resultado["SANCION"],
                                Nu_Puntos = (int)resultado["PUNTOS"],
                                Nu_Condescuento = (decimal)resultado["MONTOAPAGAR"],
                                Fecha_Inscripcion = (string)resultado["FECHADESANCION"],
                                Tx_Estado = (string)resultado["ESTADO"]
                            };
                        }
                    }
                }

            }
            return recordConductorEncontrado;
        }
        public List<RecordConductor> Listar()
        {
            List<RecordConductor> recordConductorEncontrados = new List<RecordConductor>();
            RecordConductor recordConductorEncontrado = null;
            string sql = "SELECT R.ID_RECORD AS IDRECORD, R.DNI_CONDUCTOR DNICONDUCTOR, C.NU_LICENCIA LICENCIA, UPPER(C.NOMBRE) NOMBRE, UPPER(C.APELLIDO) APELLIDO, C.TX_DIRECCION DIRECCION, R.ID_SAT IDSAT, S.TX_CALIFICACION CALIFICACION, S.TX_INFRACCION INFRACCION, S.TX_SANCION SANCION, S.NU_PUNTOS PUNTOS, S.NU_CONDESCUENTO MONTOAPAGAR, CONVERT(VARCHAR(10),R.FECHA_INSCRIPCION, 103) FECHADESANCION, R.TX_ESTADO ESTADO FROM   BDOPERACIONES.OPERACION.SAT S INNER  JOIN BDRecordConductor.sisrec.recordConductor R ON     S.IDMULTA = R.ID_SAT INNER  JOIN BDOPERACIONES.OPERACION.CONDUCTOR C ON     R.DNI_CONDUCTOR = C.DNI WHERE  R.TX_ESTADO = 'Activo' AND    S.NU_PUNTOS > 0 AND    S.TX_ESTADO = 'Activo' ORDER  BY R.DNI_CONDUCTOR ASC; ";
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    using (SqlDataReader resultado = comando.ExecuteReader())
                    {
                        while (resultado.Read())
                        {
                            recordConductorEncontrado = new RecordConductor()
                            {

                                Id_Record = (int)resultado["IDRECORD"],
                                Dni_Conductor = (int)resultado["DNICONDUCTOR"],
                                Nu_Licencia = (string)resultado["LICENCIA"],
                                Nombre = (string)resultado["NOMBRE"],
                                Apellido = (string)resultado["APELLIDO"],
                                Tx_Direccion = (string)resultado["DIRECCION"],
                                Id_Sat = (int)resultado["IDSAT"],
                                Tx_Calificacion = (string)resultado["CALIFICACION"],
                                Tx_Infraccion = (string)resultado["INFRACCION"],
                                Tx_Sancion = (string)resultado["SANCION"],
                                Nu_Puntos = (int)resultado["PUNTOS"],
                                Nu_Condescuento = (decimal)resultado["MONTOAPAGAR"],
                               Fecha_Inscripcion = (string)resultado["FECHADESANCION"],
                                Tx_Estado = (string)resultado["ESTADO"]
                            };
                            recordConductorEncontrados.Add(recordConductorEncontrado);
                        }
                    }
                }
            }
            return recordConductorEncontrados;
        }
    }
}