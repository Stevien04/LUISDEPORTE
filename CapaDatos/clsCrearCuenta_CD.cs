using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CapaDatos
{
    public class clsCrearCuenta_CD
    {
        //METODO NECESARIO PARA REGISTRAR UN NUEVO USUARIO AL SISTEMA
        public void mtdCrearCuentaCD(string Nombres,
                                     string ApellidoPaterno,
                                     string ApellidoMaterno,
                                     int IDTipoDocumento,
                                     string Documento,
                                     DateTime FechaNacimiento,
                                     string Telefono,
                                     string Correo,
                                     string Genero,
                                     //DATOS DEL USUARIO
                                     string NombreUsuario,
                                     string Clave)
        {
            using (SqlConnection connection = clsConexion_CD.mtdObtenerConexion())
            {
                connection.Open();

                // https://es.stackoverflow.com/questions/145602/obtener-id-despues-de-insertar-un-registro-en-sqlserver
                //INSERTAR LOS DATOS DE LA TABLA PERSONA
                string queryPersona = @"INSERT INTO tbPersona (Nombres, ApellidoPaterno, ApellidoMaterno, IDTipoDocumento, Documento, FechaNacimiento, Telefono, Correo, Genero)
                                        VALUES (@Nombres, @ApellidoPaterno, @ApellidoMaterno, @IDTipoDocumento, @Documento, @FechaNacimiento, @Telefono, @Correo, @Genero);
                                        SELECT SCOPE_IDENTITY();";

                //CREAMOS UNA VARIALBE PARA GUARDAR LA ID GENERADA
                int IDPersona;

                using (SqlCommand cmdPersona = new SqlCommand(queryPersona, connection))
                {
                    cmdPersona.Parameters.AddWithValue("@Nombres", Nombres);
                    cmdPersona.Parameters.AddWithValue("@ApellidoPaterno", ApellidoPaterno);
                    cmdPersona.Parameters.AddWithValue("@ApellidoMaterno", ApellidoMaterno);
                    cmdPersona.Parameters.AddWithValue("@IDTipoDocumento", IDTipoDocumento);
                    cmdPersona.Parameters.AddWithValue("@Documento", Documento);
                    cmdPersona.Parameters.AddWithValue("@FechaNacimiento", FechaNacimiento);
                    cmdPersona.Parameters.AddWithValue("@Telefono", Telefono);
                    cmdPersona.Parameters.AddWithValue("@Correo", Correo);
                    cmdPersona.Parameters.AddWithValue("@Genero", Genero);

                    IDPersona = Convert.ToInt32(cmdPersona.ExecuteScalar());
                }

                //INSERTAR LOS DATOS DE LA TABLA USUARIO
                string queryUsuario = @"INSERT INTO tbUsuario (IDPersona, NombreUsuario, Clave)
                                        VALUES (@IDPersona, @NombreUsuario, @Clave);";

                using (SqlCommand cmdUsuario = new SqlCommand(queryUsuario, connection))
                {
                    cmdUsuario.Parameters.AddWithValue("@IDPersona", IDPersona);
                    cmdUsuario.Parameters.AddWithValue("@NombreUsuario", NombreUsuario);
                    cmdUsuario.Parameters.AddWithValue("@Clave", Clave);

                    cmdUsuario.ExecuteNonQuery();
                }
            }
        }

        public DataTable mtdListarTipoDocumentoActivosCD()
        {
            DataTable tbTipoDocumento = new DataTable();

            using (SqlConnection connection = clsConexion_CD.mtdObtenerConexion())
            {

                string queryTipoDocActivo = @"SELECT IDTipoDocumento, TipoDocumento FROM tbTipoDocumento 
                                              WHERE Estado = 1";

                using (SqlCommand cmdTipoDocActivo = new SqlCommand(queryTipoDocActivo, connection))
                {
                    connection.Open();

                    using (SqlDataReader reader = cmdTipoDocActivo.ExecuteReader())
                    {
                        tbTipoDocumento.Load(reader);
                    }
                }
            }

            return tbTipoDocumento;
        }
    }
}
