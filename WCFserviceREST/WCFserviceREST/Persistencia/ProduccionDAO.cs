using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WCFserviceREST.Dominio;

namespace WCFserviceREST.Persistencia
{
    public class ProduccionDAO
    {

        public string CadenaConexion = "Data Source=DESKTOP-VEOBI30; Initial Catalog=BD_Operaciones;Integrated Security=SSPI;";

        public Produccion_ Crear(Produccion_ produccionACrear)
        {
            Produccion_ produccionCreado = null;
            string sql = "INSERT INTO produccion VALUES (@dni_conductor,@id_bus,@can_ingreso,@fecha)";
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    //comando.Parameters.Add(new SqlParameter("@id_produccion", produccionACrear.Id_produccion));
                    comando.Parameters.Add(new SqlParameter("@dni_conductor", produccionACrear.Dni_conductor));
                    comando.Parameters.Add(new SqlParameter("@id_bus", produccionACrear.Id_bus));
                    comando.Parameters.Add(new SqlParameter("@can_ingreso", produccionACrear.Can_ingreso));
                    comando.Parameters.Add(new SqlParameter("@fecha", produccionACrear.Fecha));
                    comando.ExecuteNonQuery();
                }
            }
            produccionCreado = Obtener(produccionACrear.Id_produccion);
            return produccionCreado;
        }
        public Produccion_ Obtener(int Id_produccion)
        {
            Produccion_ produccionEncontrado = null;
            string sql = "SELECT * FROM produccion WHERE id_produccion=@id_produccion";
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))

                {
                    comando.Parameters.Add(new SqlParameter("@id_produccion", Id_produccion));
                    using (SqlDataReader resultado = comando.ExecuteReader())
                    {
                        if (resultado.Read())
                        {
                            produccionEncontrado = new Produccion_()
                            {

                                Id_produccion = (int)resultado["id_produccion"],
                                Dni_conductor = (int)resultado["dni_conductor"],
                                Id_bus = (int)resultado["id_bus"],
                                Can_ingreso = (decimal)resultado["can_ingreso"],
                                Fecha = (string)resultado["fecha"]

                            };
                        }
                    }
                }

            }
            return produccionEncontrado;

        }

        public Produccion_ Modificar(Produccion_ produccionAModificar)
        {
            Produccion_ produccionModificado = null;
            string sql = "UPDATE produccion SET dni_conductor=@dni_conductor,id_bus=@id_bus,can_ingreso=@can_ingreso,fecha=@fecha WHERE id_produccion=@id_produccion;";
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {

                    comando.Parameters.Add(new SqlParameter("@id_produccion", produccionAModificar.Id_produccion));
                    comando.Parameters.Add(new SqlParameter("@dni_conductor", produccionAModificar.Dni_conductor));
                    comando.Parameters.Add(new SqlParameter("@id_bus", produccionAModificar.Id_bus));
                    comando.Parameters.Add(new SqlParameter("@can_ingreso", produccionAModificar.Can_ingreso));
                    comando.Parameters.Add(new SqlParameter("@fecha", produccionAModificar.Fecha));
                    comando.ExecuteNonQuery();
                }
            }
            produccionModificado = Obtener(produccionAModificar.Id_produccion);

            return produccionModificado;

        }
        public void Eliminar(int id_produccion)
        {

            string sql = "DELETE FROM produccion WHERE id_produccion=@id_produccion";
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("@id_produccion", id_produccion));
                    comando.ExecuteNonQuery();
                }
            }
        }
        public List<Produccion_> Listar()
        {
            List<Produccion_> produccionEncontrados = new List<Produccion_>();
            Produccion_ produccionEncontrado = null;
            string sql = "SELECT * from produccion";
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    using (SqlDataReader resultado = comando.ExecuteReader())
                    {
                        while (resultado.Read())
                        {
                            produccionEncontrado = new Produccion_()
                            {

                                Id_produccion = (int)resultado["id_produccion"],
                                Dni_conductor = (int)resultado["dni_conductor"],
                                Id_bus = (int)resultado["id_bus"],
                                Can_ingreso = (decimal)resultado["can_ingreso"],
                                Fecha = (string)resultado["fecha"]
                            };
                            produccionEncontrados.Add(produccionEncontrado);
                        }
                    }
                }
            }
            return produccionEncontrados;
        }


    }
}