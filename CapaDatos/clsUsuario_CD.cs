using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class clsUsuario_CD
    {
        public DataTable mtdBuscarUsuariosActivosCD(string NombreUsuario, int IDUsuarioActual)
        {
            DataTable tbUsuario = new DataTable();

            using (SqlConnection connection = clsConexion_CD.mtdObtenerConexion())
            {
                string queryBuscarUsuarios = @"SELECT IDUsuario, NombreUsuario
                                               FROM tbUsuario
                                               WHERE NombreUsuario LIKE @NombreUsuario + '%'
                                               AND IDUsuario <> @IDUsuarioActual
                                               AND Estado = 1;";

                using (SqlCommand cmdBuscarUsuarios = new SqlCommand(queryBuscarUsuarios, connection))
                {
                    cmdBuscarUsuarios.Parameters.AddWithValue("@NombreUsuario", NombreUsuario);
                    cmdBuscarUsuarios.Parameters.AddWithValue("@IDUsuarioActual", IDUsuarioActual);

                    connection.Open();

                    using (SqlDataReader reader = cmdBuscarUsuarios.ExecuteReader())
                    {
                        tbUsuario.Load(reader);
                    }
                }
            }
            return tbUsuario;
        }
    }
}
