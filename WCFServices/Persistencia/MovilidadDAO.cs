using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WCFServices.Dominio;

namespace WCFServices.Persistencia
{
    public class MovilidadDAO
    {
        private string CadenaConexion = "Data Source=DESKTOP-VEOBI30; Initial Catalog = BD_Operaciones; Integrated Security=SSPI;";

        public Movilidad Crear(Movilidad movilidadACrear)
        {
            Movilidad movilidadCreado = null;
            string sql = "INSERT INTO bus VALUES (@placa, @clase, @marca, @modelo, @color, @motor, @asientos, @puertas, @feinscripcion, @año, @estado )";
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                   /*-- comando.Parameters.Add(new SqlParameter("@id", movilidadACrear.Id));--*/
                    comando.Parameters.Add(new SqlParameter("@placa", movilidadACrear.Placa));
                    comando.Parameters.Add(new SqlParameter("@clase", movilidadACrear.Clase));
                    comando.Parameters.Add(new SqlParameter("@marca", movilidadACrear.Marca));
                    comando.Parameters.Add(new SqlParameter("@modelo", movilidadACrear.Modelo));
                    comando.Parameters.Add(new SqlParameter("@color", movilidadACrear.Color));
                    comando.Parameters.Add(new SqlParameter("@motor", movilidadACrear.Motor));
                    comando.Parameters.Add(new SqlParameter("@asientos", movilidadACrear.Asientos));
                    comando.Parameters.Add(new SqlParameter("@puertas", movilidadACrear.Puertas));
                    comando.Parameters.Add(new SqlParameter("@feinscripcion", movilidadACrear.FeInscripcion));
                    comando.Parameters.Add(new SqlParameter("@año", movilidadACrear.Año));
                    comando.Parameters.Add(new SqlParameter("@estado", movilidadACrear.Estado));
                    comando.ExecuteNonQuery();
                }
            }
            movilidadCreado = ObtenerPorPlaca(movilidadACrear.Placa);
            return movilidadCreado;
        }
        public Movilidad Obtener(int id)
        {
            Movilidad movilidadEncontrado = null;
            string sql = "SELECT * FROM bus WHERE id_bus = @id";
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
                            movilidadEncontrado = new Movilidad()
                            {
                                Id = (int)resultado["id_bus"],
                                Placa = (string)resultado["nu_placa"],
                                Clase = (string)resultado["tx_clase"],
                                Marca = (string)resultado["tx_marca"],
                                Modelo = (string)resultado["tx_modelo"],
                                Color = (string)resultado["tx_color"],
                                Motor = (int)resultado["nu_motor"],
                                Asientos = (int)resultado["nu_asientos"],
                                Puertas = (int)resultado["nu_puertas"],
                                FeInscripcion = (DateTime)resultado["fecha_inscripcion"],
                                Año = (string)resultado["año_fabricacion"],
                                Estado = (string)resultado["tx_estado"]

                            };
                        }
                    }
                }
            }
            return movilidadEncontrado;
        }

        public Movilidad ObtenerPorPlaca(string placa)
        {
            Movilidad movilidadEncontrado = null;
            string sql = "SELECT * FROM bus WHERE nu_placa = @placa";
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("@placa", placa));
                    using (SqlDataReader resultado = comando.ExecuteReader())
                    {
                        if (resultado.Read())
                        {
                            movilidadEncontrado = new Movilidad()
                            {
                                Id = (int)resultado["id_bus"],
                                Placa = (string)resultado["nu_placa"],
                                Clase = (string)resultado["tx_clase"],
                                Marca = (string)resultado["tx_marca"],
                                Modelo = (string)resultado["tx_modelo"],
                                Color = (string)resultado["tx_color"],
                                Motor = (int)resultado["nu_motor"],
                                Asientos = (int)resultado["nu_asientos"],
                                Puertas = (int)resultado["nu_puertas"],
                                FeInscripcion = (DateTime)resultado["fecha_inscripcion"],
                                Año = (string)resultado["año_fabricacion"],
                                Estado = (string)resultado["tx_estado"]

                            };
                        }
                    }
                }
            }
            return movilidadEncontrado;
        }

        public Movilidad Modificar(Movilidad movilidadAModificar)
        {
            Movilidad movilidadModificado = null;
            string sql = "UPDATE bus SET nu_placa=@placa, tx_clase=@clase, tx_marca=@marca, tx_modelo=@modelo, tx_color=@color, nu_motor=@motor, nu_asientos=@asientos, nu_puertas = @puertas, fecha_inscripcion = @feinscripcion, año_fabricacion = @año, tx_estado =@estado WHERE id_bus=@id ";
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("@placa", movilidadAModificar.Placa));
                    comando.Parameters.Add(new SqlParameter("@clase", movilidadAModificar.Clase));
                    comando.Parameters.Add(new SqlParameter("@marca", movilidadAModificar.Marca));
                    comando.Parameters.Add(new SqlParameter("@modelo", movilidadAModificar.Modelo));
                    comando.Parameters.Add(new SqlParameter("@color", movilidadAModificar.Color));
                    comando.Parameters.Add(new SqlParameter("@motor", movilidadAModificar.Motor));
                    comando.Parameters.Add(new SqlParameter("@asientos", movilidadAModificar.Asientos));
                    comando.Parameters.Add(new SqlParameter("@puertas", movilidadAModificar.Puertas));
                    comando.Parameters.Add(new SqlParameter("@feinscripcion", movilidadAModificar.FeInscripcion));
                    comando.Parameters.Add(new SqlParameter("@año", movilidadAModificar.Año));
                    comando.Parameters.Add(new SqlParameter("@estado", movilidadAModificar.Estado));
                    comando.Parameters.Add(new SqlParameter("@id", movilidadAModificar.Id));
                    comando.ExecuteNonQuery();
                }
            }
            movilidadModificado = Obtener(movilidadAModificar.Id);
            return movilidadModificado;
        }
        public string Eliminar(int id)
        {
            string sql = "DELETE FROM bus WHERE id_bus = @id";
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("@id", id));
                    comando.ExecuteNonQuery();
                }
            }
            return "OK";
        }
        //public void EliminarInactivos(int id)
        //{
        //    string sql = "DELETE FROM bus WHERE id_bus = @id AND tx_estado = @estado";
        //    using (SqlConnection conexion = new SqlConnection(CadenaConexion))
        //    {
        //        conexion.Open();
        //        using (SqlCommand comando = new SqlCommand(sql, conexion))
        //        {
        //            comando.Parameters.Add(new SqlParameter("@id", id));
        //            comando.ExecuteNonQuery();
        //        }
        //    }
        //}

        public List<Movilidad> Listar()
        {
            List<Movilidad> movilidadEncontrados = new List<Movilidad>();
            Movilidad movilidadEncontrado = null;
            string sql = "SELECT * from bus";
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    using (SqlDataReader resultado = comando.ExecuteReader())
                    {
                        while (resultado.Read())
                        {
                            movilidadEncontrado = new Movilidad()
                            {
                                Id = (int)resultado["id_bus"],
                                Placa = (string)resultado["nu_placa"],
                                Clase = (string)resultado["tx_clase"],
                                Marca = (string)resultado["tx_marca"],
                                Modelo = (string)resultado["tx_modelo"],
                                Color = (string)resultado["tx_color"],
                                Motor = (int)resultado["nu_motor"],
                                Asientos = (int)resultado["nu_asientos"],
                                Puertas = (int)resultado["nu_puertas"],
                                FeInscripcion = (DateTime)resultado["fecha_inscripcion"],
                                Año = (string)resultado["año_fabricacion"],
                                Estado = (string)resultado["tx_estado"]
                            };
                            movilidadEncontrados.Add(movilidadEncontrado);
                        }
                    }
                }
            }

            return movilidadEncontrados;
        }
    }
}