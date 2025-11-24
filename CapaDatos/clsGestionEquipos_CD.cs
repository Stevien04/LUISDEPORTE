using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class clsGestionEquipos_CD
    {
        //METODO PARA QUE EL USUARIO CREE UN ESPACIO DE EQUIPO
        public void mtdCrearEquipoCD(int IDCreador, string NombreEquipo, string Descripcion)
        {
            using (SqlConnection connection = clsConexion_CD.mtdObtenerConexion())
            {
                connection.Open();

                //INSERTAR DATOS PARA CREAR EL EQUIPO
                string query_I_Equipo = @"INSERT INTO tbEquipo (IDCreador, NombreEquipo, Descripcion)
                                        VALUES (@IDCreador, @NombreEquipo, @Descripcion);";

                using (SqlCommand cmd_I_Equipo = new SqlCommand(query_I_Equipo, connection))
                {
                    cmd_I_Equipo.Parameters.AddWithValue("@IDCreador", IDCreador);
                    cmd_I_Equipo.Parameters.AddWithValue("@NombreEquipo", NombreEquipo);
                    cmd_I_Equipo.Parameters.AddWithValue("@Descripcion", Descripcion);

                    cmd_I_Equipo.ExecuteNonQuery();
                }
            }
        }


        //METODO PARA LISTAR LOS EQUIPOS CREADOS POR EL USUARIO
        public DataTable mtdListarEquiposPorUsuarioCD(int IDCreador)
        {
            DataTable tbEquipos = new DataTable();

            using (SqlConnection connection = clsConexion_CD.mtdObtenerConexion())
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand("sp_ListarEquiposPorUsuario", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@IDCreador", IDCreador);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            tbEquipos.Load(reader);
                        }
                    }
                }
            }

            return tbEquipos;
        }

        public bool mtdModificarEquipoCD(int IDEquipo, int IDCreador, string NombreEquipo, string Descripcion, bool Estado)
        {
            bool respuesta = false;

            using (SqlConnection connection = clsConexion_CD.mtdObtenerConexion())
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand("sp_ModificarEquipo", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@IDEquipo", IDEquipo);
                    cmd.Parameters.AddWithValue("@NombreEquipo", NombreEquipo);
                    cmd.Parameters.AddWithValue("@Descripcion", Descripcion);
                    cmd.Parameters.AddWithValue("@Estado", Estado);

                    respuesta = cmd.ExecuteNonQuery() > 0;
                }
            }

            return respuesta;
        }


        public void mtdInvitarUsuarioEquipo_CD(int IdEquipo, int IdUsuarioInvitado, int IdUsuarioEmisor)
        {
            using (SqlConnection connection = clsConexion_CD.mtdObtenerConexion())
            {
                connection.Open();

                string queryInvitarUsuario = @"INSERT INTO tbInvitacionEquipo (IdEquipo, IdUsuarioInvitado, IdUsuarioEmisor)
                                               VALUES (@IdEquipo, @IdUsuarioInvitado, @IdUsuarioEmisor);";

                using (SqlCommand cmdInvitarUsuario = new SqlCommand(queryInvitarUsuario, connection))
                {
                    cmdInvitarUsuario.Parameters.AddWithValue("@IdEquipo", IdEquipo);
                    cmdInvitarUsuario.Parameters.AddWithValue("@IdUsuarioInvitado", IdUsuarioInvitado);
                    cmdInvitarUsuario.Parameters.AddWithValue("@IdUsuarioEmisor", IdUsuarioEmisor);

                    cmdInvitarUsuario.ExecuteNonQuery();
                }
            }
        }

        public bool mtdEliminarEquipoCD(int IDEquipo)
        {
            bool respuesta = false;

            using (SqlConnection connection = clsConexion_CD.mtdObtenerConexion())
            {
                connection.Open();

                string queryEliminar = @"UPDATE tbEquipo
                                          SET Estado = 0,
                                              FechaModificacion = GETDATE()
                                          WHERE IDEquipo = @IDEquipo;";

                using (SqlCommand cmd = new SqlCommand(queryEliminar, connection))
                {
                    cmd.Parameters.AddWithValue("@IDEquipo", IDEquipo);

                    respuesta = cmd.ExecuteNonQuery() > 0;
                }
            }

            return respuesta;
        }
    }
}
