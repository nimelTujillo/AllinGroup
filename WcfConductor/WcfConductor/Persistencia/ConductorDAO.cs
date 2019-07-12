using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WcfConductor.Dominio;

namespace WcfConductor.Persistencia
{
    public class ConductorDAO
    {
        private string CadenaConexion = "Data Source=DESKTOP-VEOBI30; Initial Catalog=BD_Operaciones; Integrated Security=SSPI;";

          public Conductor Crear(Conductor conductorACrear)
        {
               Conductor conductorCreado = null;
            string sql = "INSERT INTO conductor VALUES ( @dni_conductor, @des_nombres, @des_apellido, @fecha_ingreso, @categoria_licencia, @nro_licencia, @tx_estado, @direccion)";
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                   /*-- comando.Parameters.Add(new SqlParameter("@id", conductorACrear.Id));--*/
                    comando.Parameters.Add(new SqlParameter("@dni_conductor", conductorACrear.dni_conductor));
                    comando.Parameters.Add(new SqlParameter("@des_nombres", conductorACrear.des_nombres));
                    comando.Parameters.Add(new SqlParameter("@des_apellido", conductorACrear.des_apellido));
                    comando.Parameters.Add(new SqlParameter("@fecha_ingreso", conductorACrear.fecha_ingreso));
                    comando.Parameters.Add(new SqlParameter("@categoria_licencia", conductorACrear.categoria_licencia));
                    comando.Parameters.Add(new SqlParameter("@nro_licencia", conductorACrear.nro_licencia));
                    comando.Parameters.Add(new SqlParameter("@tx_estado", conductorACrear.tx_estado));
                    comando.Parameters.Add(new SqlParameter("@direccion", conductorACrear.direccion));
                    comando.ExecuteNonQuery();
                }
            }
            conductorCreado = Obtener(conductorACrear.dni_conductor);
            return conductorCreado;

        }
          public Conductor Obtener(int id)
        {
            Conductor conductorEncontrado = null;
            string sql = "SELECT * FROM conductor WHERE dni_conductor = @id";
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("@id", id));
                    using (SqlDataReader resultado = comando.ExecuteReader())
                    {
                        if (resultado.Read())
                        {
                            conductorEncontrado = new Conductor()
                            {
                                dni_conductor = (int)resultado["dni_conductor"],
                                des_nombres = (string)resultado["des_nombres"],
                                des_apellido = (string)resultado["des_apellido"],
                                fecha_ingreso = (DateTime)resultado["fecha_ingreso"],
                                categoria_licencia = (string)resultado["categoria_licencia"],
                                nro_licencia = (string)resultado["nro_licencia"],
                                tx_estado = (string)resultado["tx_estado"],
                                direccion = (string)resultado["direccion"]

                            };
                        }
                    }
                }
            }
            return conductorEncontrado;
        }
        public Conductor Modificar(Conductor conductorAModificar)
        {
            Conductor conductorModificado = null;
            string sql = "UPDATE conductor SET  des_nombres=@des_nombres, des_apellido=@des_apellido, fecha_ingreso=@fecha_ingreso, categoria_licencia=@categoria_licencia, nro_licencia=@nro_licencia, tx_estado=@tx_estado, direccion = @direccion WHERE dni_conductor=@id ";
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("@dni_conductor", conductorAModificar.dni_conductor));
                    comando.Parameters.Add(new SqlParameter("@des_nombres", conductorAModificar.des_nombres));
                    comando.Parameters.Add(new SqlParameter("@des_apellido", conductorAModificar.des_apellido));
                    comando.Parameters.Add(new SqlParameter("@fecha_ingreso", conductorAModificar.fecha_ingreso));
                    comando.Parameters.Add(new SqlParameter("@categoria_licencia", conductorAModificar.categoria_licencia));
                    comando.Parameters.Add(new SqlParameter("@nro_licencia", conductorAModificar.nro_licencia));
                    comando.Parameters.Add(new SqlParameter("@tx_estado", conductorAModificar.tx_estado));
                    comando.Parameters.Add(new SqlParameter("@direccion", conductorAModificar.direccion));
                    comando.Parameters.Add(new SqlParameter("@id", conductorAModificar.dni_conductor));

                    comando.ExecuteNonQuery();
                }
            }
            conductorModificado = Obtener(conductorAModificar.dni_conductor);
            return conductorModificado;
        }
        public void Eliminar(int id)
        {
            string sql = "DELETE FROM conductor WHERE id_conductor= @id";
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("@id", id));
                    comando.ExecuteNonQuery();
                }
            }
        }
        public void EliminarInactivos(int id)
        {
            string sql = "DELETE FROM conductor WHERE dni_conductor = @id AND tx_estado = @estado";
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("@id", id));
                    comando.ExecuteNonQuery();
                }
            }
        }

        public List<Conductor> Listar()
        {
            List<Conductor> conductorEncontrados = new List<Conductor>();
            Conductor conductorEncontrado = null;
            string sql = "SELECT * from conductor";
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    using (SqlDataReader resultado = comando.ExecuteReader())
                    {
                        while (resultado.Read())
                        {
                            conductorEncontrado = new Conductor()
                            {
                                dni_conductor = (int)resultado["dni_conductor"],
                                des_nombres = (string)resultado["des_nombres"],
                                des_apellido = (string)resultado["des_apellido"],
                                fecha_ingreso = (DateTime)resultado["fecha_ingreso"],
                                categoria_licencia = (string)resultado["categoria_licencia"],
                                nro_licencia = (string)resultado["nro_licencia"],
                                tx_estado = (string)resultado["tx_estado"],
                                direccion = (string)resultado["direccion"]
                        
                            };
                            conductorEncontrados.Add(conductorEncontrado);
                        }
                    }
                }
            }

            return conductorEncontrados;
        }
    }

}