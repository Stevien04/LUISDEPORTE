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

                string queryListar = @"SELECT IDEquipo, NombreEquipo, Descripcion, FechaRegistro, FechaModificacion
                                            FROM tbEquipo
                                            WHERE IDCreador = @IDCreador AND Estado = 1
                                            ORDER BY FechaRegistro DESC;";

                using (SqlCommand cmd = new SqlCommand(queryListar, connection))
                {

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

                string queryModificar = @"UPDATE tbEquipo
                                           SET NombreEquipo = @NombreEquipo,
                                               Descripcion = @Descripcion,
                                               Estado = @Estado,
                                               FechaModificacion = GETDATE()
                                           WHERE IDEquipo = @IDEquipo AND IDCreador = @IDCreador;";

                using (SqlCommand cmd = new SqlCommand(queryModificar, connection))
                {
                    cmd.Parameters.AddWithValue("@IDEquipo", IDEquipo);
                    cmd.Parameters.AddWithValue("@IDCreador", IDCreador);
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

                string queryInvitarUsuario = @"INSERT INTO tbInvitacionEquipo (IdEquipo, IdUsuarioInvitador, IdUsuarioCreador, Estado, FechaEnvio)
                                               VALUES (@IdEquipo, @IdUsuarioInvitado, @IdUsuarioEmisor, @Estado, GETDATE());";

                using (SqlCommand cmdInvitarUsuario = new SqlCommand(queryInvitarUsuario, connection))
                {
                    cmdInvitarUsuario.Parameters.AddWithValue("@IdEquipo", IdEquipo);
                    cmdInvitarUsuario.Parameters.AddWithValue("@IdUsuarioInvitado", IdUsuarioInvitado);
                    cmdInvitarUsuario.Parameters.AddWithValue("@IdUsuarioEmisor", IdUsuarioEmisor);
                    cmdInvitarUsuario.Parameters.AddWithValue("@Estado", "Pendiente");

                    cmdInvitarUsuario.ExecuteNonQuery();
                }
            }
        }

        public DataTable mtdListarInvitacionesPorUsuarioCD(int idUsuarioInvitado)
        {
            DataTable tbInvitaciones = new DataTable();

            using (SqlConnection connection = clsConexion_CD.mtdObtenerConexion())
            {
                connection.Open();

                string queryListarInvitaciones = @"SELECT ie.IdInvitacion,
                                                       e.NombreEquipo,
                                                       u.NombreUsuario AS UsuarioEmisor,
                                                       ie.Estado,
                                                       ie.FechaEnvio
                                                FROM tbInvitacionEquipo ie
                                                INNER JOIN tbEquipo e ON ie.IdEquipo = e.IDEquipo
                                                INNER JOIN tbUsuario u ON ie.IdUsuarioCreador = u.IDUsuario
                                                WHERE ie.IdUsuarioInvitador = @IdUsuarioInvitado
                                                ORDER BY ie.FechaEnvio DESC";

                using (SqlCommand cmd = new SqlCommand(queryListarInvitaciones, connection))
                {
                    cmd.Parameters.AddWithValue("@IdUsuarioInvitado", idUsuarioInvitado);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            tbInvitaciones.Load(reader);
                        }
                    }
                }
            }

            return tbInvitaciones;
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
