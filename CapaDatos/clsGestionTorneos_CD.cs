using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class clsGestionTorneos_CD
    {
        public int mtdCrearTorneoCD(int idCreador, string nombreTorneo, string descripcion)
        {
            using (SqlConnection connection = clsConexion_CD.mtdObtenerConexion())
            {
                connection.Open();

                string queryInsertar = @"INSERT INTO tbTorneos (IdCreador, NombreTorneo, Descripcion, FechaCreacion)
                                        VALUES (@IdCreador, @NombreTorneo, @Descripcion, GETDATE());
                                        SELECT CAST(SCOPE_IDENTITY() AS INT);";

                using (SqlCommand cmd = new SqlCommand(queryInsertar, connection))
                {
                    cmd.Parameters.AddWithValue("@IdCreador", idCreador);
                    cmd.Parameters.AddWithValue("@NombreTorneo", nombreTorneo);
                    cmd.Parameters.AddWithValue("@Descripcion", descripcion);

                    object result = cmd.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : 0;
                }
            }
        }

        public DataTable mtdListarTorneosPorCreadorCD(int idCreador)
        {
            DataTable tbTorneos = new DataTable();

            using (SqlConnection connection = clsConexion_CD.mtdObtenerConexion())
            {
                connection.Open();

                string queryListar = @"SELECT IdTorneos, NombreTorneo, Descripcion, FechaCreacion
                                       FROM tbTorneos
                                       WHERE IdCreador = @IdCreador
                                       ORDER BY FechaCreacion DESC";

                using (SqlCommand cmd = new SqlCommand(queryListar, connection))
                {
                    cmd.Parameters.AddWithValue("@IdCreador", idCreador);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        tbTorneos.Load(reader);
                    }
                }
            }

            return tbTorneos;
        }

        public bool mtdModificarTorneoCD(int idTorneo, int idCreador, string nombreTorneo, string descripcion)
        {
            bool respuesta;

            using (SqlConnection connection = clsConexion_CD.mtdObtenerConexion())
            {
                connection.Open();

                string queryModificar = @"UPDATE tbTorneos
                                           SET NombreTorneo = @NombreTorneo,
                                               Descripcion = @Descripcion
                                           WHERE IdTorneos = @IdTorneo AND IdCreador = @IdCreador";

                using (SqlCommand cmd = new SqlCommand(queryModificar, connection))
                {
                    cmd.Parameters.AddWithValue("@IdTorneo", idTorneo);
                    cmd.Parameters.AddWithValue("@IdCreador", idCreador);
                    cmd.Parameters.AddWithValue("@NombreTorneo", nombreTorneo);
                    cmd.Parameters.AddWithValue("@Descripcion", descripcion);

                    respuesta = cmd.ExecuteNonQuery() > 0;
                }
            }

            return respuesta;
        }

        public bool mtdEliminarTorneoCD(int idTorneo, int idCreador)
        {
            bool respuesta;

            using (SqlConnection connection = clsConexion_CD.mtdObtenerConexion())
            {
                connection.Open();

                string queryEliminar = @"DELETE FROM tbTorneos
                                          WHERE IdTorneos = @IdTorneo AND IdCreador = @IdCreador";

                using (SqlCommand cmd = new SqlCommand(queryEliminar, connection))
                {
                    cmd.Parameters.AddWithValue("@IdTorneo", idTorneo);
                    cmd.Parameters.AddWithValue("@IdCreador", idCreador);

                    respuesta = cmd.ExecuteNonQuery() > 0;
                }
            }

            return respuesta;
        }

        public DataTable mtdBuscarEquiposActivosCD(string filtroUsuario, string filtroEquipo)
        {
            DataTable tbEquipos = new DataTable();

            using (SqlConnection connection = clsConexion_CD.mtdObtenerConexion())
            {
                connection.Open();

                string queryBuscar = @"SELECT e.IDEquipo, e.NombreEquipo, u.NombreUsuario AS Creador
                                        FROM tbEquipo e
                                        INNER JOIN tbUsuario u ON e.IDCreador = u.IDUsuario
                                        WHERE e.Estado = 1
                                          AND (@FiltroUsuario = '' OR u.NombreUsuario LIKE '%' + @FiltroUsuario + '%')
                                          AND (@FiltroEquipo = '' OR e.NombreEquipo LIKE '%' + @FiltroEquipo + '%')
                                        ORDER BY e.NombreEquipo";

                using (SqlCommand cmd = new SqlCommand(queryBuscar, connection))
                {
                    cmd.Parameters.AddWithValue("@FiltroUsuario", filtroUsuario ?? string.Empty);
                    cmd.Parameters.AddWithValue("@FiltroEquipo", filtroEquipo ?? string.Empty);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        tbEquipos.Load(reader);
                    }
                }
            }

            return tbEquipos;
        }

        public bool mtdAgregarEquipoATorneoCD(int idTorneo, int idEquipo)
        {
            bool respuesta;

            using (SqlConnection connection = clsConexion_CD.mtdObtenerConexion())
            {
                connection.Open();

                string queryInsertar = @"IF NOT EXISTS (SELECT 1 FROM TorneoEquipos WHERE idTorneo = @IdTorneo AND idEquipo = @IdEquipo)
                                        BEGIN
                                            INSERT INTO TorneoEquipos (idTorneo, idEquipo, FechaUnion)
                                            VALUES (@IdTorneo, @IdEquipo, GETDATE());
                                        END";

                using (SqlCommand cmd = new SqlCommand(queryInsertar, connection))
                {
                    cmd.Parameters.AddWithValue("@IdTorneo", idTorneo);
                    cmd.Parameters.AddWithValue("@IdEquipo", idEquipo);

                    respuesta = cmd.ExecuteNonQuery() > 0;
                }
            }

            return respuesta;
        }

        public DataTable mtdListarEquiposPorTorneoCD(int idTorneo)
        {
            DataTable tbEquipos = new DataTable();

            using (SqlConnection connection = clsConexion_CD.mtdObtenerConexion())
            {
                connection.Open();

                string queryListar = @"SELECT e.IDEquipo, e.NombreEquipo, te.FechaUnion
                                        FROM TorneoEquipos te
                                        INNER JOIN tbEquipo e ON te.idEquipo = e.IDEquipo
                                        WHERE te.idTorneo = @IdTorneo
                                        ORDER BY te.FechaUnion DESC";

                using (SqlCommand cmd = new SqlCommand(queryListar, connection))
                {
                    cmd.Parameters.AddWithValue("@IdTorneo", idTorneo);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        tbEquipos.Load(reader);
                    }
                }
            }

            return tbEquipos;
        }
    }
}
