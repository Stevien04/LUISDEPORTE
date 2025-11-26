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

        public bool mtdEliminarTorneoCD(int idTorneo, int idCreador, out string mensajeError)
        {
            bool respuesta;
            mensajeError = string.Empty;

            using (SqlConnection connection = clsConexion_CD.mtdObtenerConexion())
            {
                connection.Open();

                string queryValidarEquipos = @"SELECT COUNT(*)
                                               FROM TorneoEquipos
                                               WHERE idTorneo = @IdTorneo";

                using (SqlCommand cmdValidar = new SqlCommand(queryValidarEquipos, connection))
                {
                    cmdValidar.Parameters.AddWithValue("@IdTorneo", idTorneo);

                    int cantidadEquipos = Convert.ToInt32(cmdValidar.ExecuteScalar());

                    if (cantidadEquipos > 0)
                    {
                        mensajeError = "No se puede eliminar el torneo porque tiene equipos registrados.";
                        return false;
                    }
                }

                string queryEliminar = @"DELETE FROM tbTorneos
                                          WHERE IdTorneos = @IdTorneo AND IdCreador = @IdCreador";

                using (SqlCommand cmd = new SqlCommand(queryEliminar, connection))
                {
                    cmd.Parameters.AddWithValue("@IdTorneo", idTorneo);
                    cmd.Parameters.AddWithValue("@IdCreador", idCreador);

                    respuesta = cmd.ExecuteNonQuery() > 0;
                }
            }

            if (!respuesta && string.IsNullOrEmpty(mensajeError))
            {
                mensajeError = "No se pudo eliminar el torneo.";
            }

            return respuesta;
        }

        public bool mtdEliminarTorneoCD(int idTorneo, int idCreador)
        {
            return mtdEliminarTorneoCD(idTorneo, idCreador, out _);
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

        public bool mtdInvitarEquipoATorneoCD(int idTorneo, int idEquipo, int idUsuarioInvitador)
        {
            bool respuesta;

            using (SqlConnection connection = clsConexion_CD.mtdObtenerConexion())
            {
                connection.Open();

                string queryInsertar = @"IF NOT EXISTS (SELECT 1 FROM TorneoEquipos WHERE idTorneo = @IdTorneo AND idEquipo = @IdEquipo)
                                        BEGIN
                                            IF NOT EXISTS (SELECT 1 FROM tbInvitacionTorneo WHERE IdTorneo = @IdTorneo AND IdEquipo = @IdEquipo AND Estado = 'Pendiente')
                                            BEGIN
                                                INSERT INTO tbInvitacionTorneo (IdTorneo, IdEquipo, IdUsuarioInvitador, Estado, FechaEnvio)
                                                VALUES (@IdTorneo, @IdEquipo, @IdUsuarioInvitador, 'Pendiente', GETDATE());
                                            END
                                        END";

                using (SqlCommand cmd = new SqlCommand(queryInsertar, connection))
                {
                    cmd.Parameters.AddWithValue("@IdTorneo", idTorneo);
                    cmd.Parameters.AddWithValue("@IdEquipo", idEquipo);
                    cmd.Parameters.AddWithValue("@IdUsuarioInvitador", idUsuarioInvitador);

                    respuesta = cmd.ExecuteNonQuery() > 0;
                }
            }

            return respuesta;
        }

        public DataTable mtdListarInvitacionesTorneoPorUsuarioCD(int idUsuarioInvitado)
        {
            DataTable tbInvitaciones = new DataTable();

            using (SqlConnection connection = clsConexion_CD.mtdObtenerConexion())
            {
                connection.Open();

                string queryListar = @"SELECT it.IdInvitacionTorneo,
                                               t.NombreTorneo,
                                               e.NombreEquipo,
                                               u.NombreUsuario AS UsuarioInvitador,
                                               it.Estado,
                                               it.FechaEnvio
                                        FROM tbInvitacionTorneo it
                                        INNER JOIN tbTorneos t ON it.IdTorneo = t.IdTorneos
                                        INNER JOIN tbEquipo e ON it.IdEquipo = e.IDEquipo
                                        INNER JOIN tbUsuario u ON it.IdUsuarioInvitador = u.IDUsuario
                                        WHERE e.IDCreador = @IdUsuarioInvitado
                                        ORDER BY it.FechaEnvio DESC";

                using (SqlCommand cmd = new SqlCommand(queryListar, connection))
                {
                    cmd.Parameters.AddWithValue("@IdUsuarioInvitado", idUsuarioInvitado);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        tbInvitaciones.Load(reader);
                    }
                }
            }

            return tbInvitaciones;
        }

        public bool mtdResponderInvitacionTorneoCD(int idInvitacion, string nuevoEstado)
        {
            bool respuesta = false;

            using (SqlConnection connection = clsConexion_CD.mtdObtenerConexion())
            {
                connection.Open();

                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        string queryActualizar = @"UPDATE tbInvitacionTorneo
                                                     SET Estado = @Estado,
                                                         FechaRespuesta = GETDATE()
                                                     WHERE IdInvitacionTorneo = @IdInvitacion";

                        using (SqlCommand cmdActualizar = new SqlCommand(queryActualizar, connection, transaction))
                        {
                            cmdActualizar.Parameters.AddWithValue("@Estado", nuevoEstado);
                            cmdActualizar.Parameters.AddWithValue("@IdInvitacion", idInvitacion);

                            respuesta = cmdActualizar.ExecuteNonQuery() > 0;
                        }

                        if (respuesta && nuevoEstado.Equals("Aceptada", StringComparison.OrdinalIgnoreCase))
                        {
                            int idTorneo = 0;
                            int idEquipo = 0;

                            string queryDatos = @"SELECT IdTorneo, IdEquipo
                                                   FROM tbInvitacionTorneo
                                                   WHERE IdInvitacionTorneo = @IdInvitacion";

                            using (SqlCommand cmdDatos = new SqlCommand(queryDatos, connection, transaction))
                            {
                                cmdDatos.Parameters.AddWithValue("@IdInvitacion", idInvitacion);

                                using (SqlDataReader reader = cmdDatos.ExecuteReader())
                                {
                                    if (reader.Read())
                                    {
                                        idTorneo = Convert.ToInt32(reader["IdTorneo"]);
                                        idEquipo = Convert.ToInt32(reader["IdEquipo"]);
                                    }
                                }
                            }

                            if (idTorneo != 0 && idEquipo != 0)
                            {
                                string queryInsertarEquipo = @"IF NOT EXISTS (SELECT 1 FROM TorneoEquipos WHERE idTorneo = @IdTorneo AND idEquipo = @IdEquipo)
                                                              BEGIN
                                                                  INSERT INTO TorneoEquipos (idTorneo, idEquipo, FechaUnion)
                                                                  VALUES (@IdTorneo, @IdEquipo, GETDATE());
                                                              END";

                                using (SqlCommand cmdInsertar = new SqlCommand(queryInsertarEquipo, connection, transaction))
                                {
                                    cmdInsertar.Parameters.AddWithValue("@IdTorneo", idTorneo);
                                    cmdInsertar.Parameters.AddWithValue("@IdEquipo", idEquipo);

                                    cmdInsertar.ExecuteNonQuery();
                                }
                            }
                        }

                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }

            return respuesta;
        }

        public int mtdGenerarEnfrentamientosCD(int idTorneo)
        {
            int enfrentamientosCreados = 0;

            using (SqlConnection connection = clsConexion_CD.mtdObtenerConexion())
            {
                connection.Open();

                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        List<int> equipos = new List<int>();

                        string queryEquipos = "SELECT idEquipo FROM TorneoEquipos WHERE idTorneo = @IdTorneo ORDER BY idEquipo";

                        using (SqlCommand cmdEquipos = new SqlCommand(queryEquipos, connection, transaction))
                        {
                            cmdEquipos.Parameters.AddWithValue("@IdTorneo", idTorneo);

                            using (SqlDataReader reader = cmdEquipos.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    equipos.Add(Convert.ToInt32(reader["idEquipo"]));
                                }
                            }
                        }

                        for (int i = 0; i < equipos.Count; i++)
                        {
                            for (int j = i + 1; j < equipos.Count; j++)
                            {
                                int equipo1 = equipos[i];
                                int equipo2 = equipos[j];

                                string queryExiste = @"SELECT COUNT(1)
                                                        FROM tbEnfrentamientos
                                                        WHERE IdTorneo = @IdTorneo
                                                          AND ((IdEquipo1 = @IdEquipo1 AND IdEquipo2 = @IdEquipo2)
                                                            OR (IdEquipo1 = @IdEquipo2 AND IdEquipo2 = @IdEquipo1))";

                                bool existeEnfrentamiento = false;

                                using (SqlCommand cmdExiste = new SqlCommand(queryExiste, connection, transaction))
                                {
                                    cmdExiste.Parameters.AddWithValue("@IdTorneo", idTorneo);
                                    cmdExiste.Parameters.AddWithValue("@IdEquipo1", equipo1);
                                    cmdExiste.Parameters.AddWithValue("@IdEquipo2", equipo2);

                                    existeEnfrentamiento = Convert.ToInt32(cmdExiste.ExecuteScalar()) > 0;
                                }

                                if (!existeEnfrentamiento)
                                {
                                    string queryInsertar = @"INSERT INTO tbEnfrentamientos (IdTorneo, IdEquipo1, IdEquipo2, FechaProgramada, Estado, EstadoEncuentro)
                                                            VALUES (@IdTorneo, @IdEquipo1, @IdEquipo2, NULL, 'Pendiente', 'Pendiente')";

                                    using (SqlCommand cmdInsertar = new SqlCommand(queryInsertar, connection, transaction))
                                    {
                                        cmdInsertar.Parameters.AddWithValue("@IdTorneo", idTorneo);
                                        cmdInsertar.Parameters.AddWithValue("@IdEquipo1", equipo1);
                                        cmdInsertar.Parameters.AddWithValue("@IdEquipo2", equipo2);

                                        enfrentamientosCreados += cmdInsertar.ExecuteNonQuery();
                                    }
                                }
                            }
                        }

                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }

            return enfrentamientosCreados;
        }

        public DataTable mtdListarEnfrentamientosPorTorneoCD(int idTorneo)
        {
            DataTable tbEnfrentamientos = new DataTable();

            using (SqlConnection connection = clsConexion_CD.mtdObtenerConexion())
            {
                connection.Open();

                string queryListar = @"SELECT e.IdEnfrentamiento,
                                              e.IdEquipo1,
                                              e.IdEquipo2,
                                              eq1.NombreEquipo AS Equipo1,
                                              eq2.NombreEquipo AS Equipo2,
                                              e.MarcadorEquipo1,
                                              e.MarcadorEquipo2,
                                              e.FechaProgramada,
                                              e.Estado,
                                              e.EstadoEncuentro
                                       FROM tbEnfrentamientos e
                                       INNER JOIN tbEquipo eq1 ON e.IdEquipo1 = eq1.IDEquipo
                                       INNER JOIN tbEquipo eq2 ON e.IdEquipo2 = eq2.IDEquipo
                                       WHERE e.IdTorneo = @IdTorneo
                                       ORDER BY e.FechaProgramada, e.IdEnfrentamiento";

                using (SqlCommand cmd = new SqlCommand(queryListar, connection))
                {
                    cmd.Parameters.AddWithValue("@IdTorneo", idTorneo);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        tbEnfrentamientos.Load(reader);
                    }
                }
            }

            return tbEnfrentamientos;
        }
    }
}
