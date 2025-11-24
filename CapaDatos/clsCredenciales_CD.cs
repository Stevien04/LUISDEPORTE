using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class clsCredenciales_CD
    {
        //METODO QUE VERIFICA SI EXISTE LAS CREDENCIALES CON LAS CUALES SE QUIERE INGRESAR AL SISTEMA
        public bool mtdCValidarCredencialesCD(string NombreUsuario, string Clave)
        {
            using (SqlConnection connection = clsConexion_CD.mtdObtenerConexion())
            {
                connection.Open();

                string query = @"SELECT * FROM tbUsuario 
                                 WHERE NombreUsuario = @NombreUsuario AND Clave = @Clave";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NombreUsuario", NombreUsuario);
                    command.Parameters.AddWithValue("@Clave", Clave);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            //SI EXISTE UNA FILA RETORNARA TRUE
                            return reader.HasRows;
                        }
                        else { return false; }
                        
                    }
                }
            }
        }

        //OBTENER LOS DATOS DEL USUARIO
        public (int idUsuario, string nombreUsuario) mtdObtenerUsuarioCD(string NombreUsuario, string Clave)
        {
            using (SqlConnection connection = clsConexion_CD.mtdObtenerConexion())
            {
                connection.Open();

                string query = @"SELECT IdUsuario, NombreUsuario 
                                 FROM tbUsuario 
                                 WHERE NombreUsuario = @NombreUsuario AND Clave = @Clave";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NombreUsuario", NombreUsuario);
                    command.Parameters.AddWithValue("@Clave", Clave);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int idUsuario = reader.GetInt32(reader.GetOrdinal("IdUsuario"));
                            string nombreUsuario = reader.GetString(reader.GetOrdinal("NombreUsuario"));
                            return (idUsuario, nombreUsuario);
                        }
                        else
                        {
                            return (0, null);
                        }
                    }
                }
            }
        }
    }
}
