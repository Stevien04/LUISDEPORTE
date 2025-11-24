using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public static class clsConexion_CD
    {
        private static readonly string connectionString = @"server = David; 
                                                            database= PRUEBADEPORTE; 
                                                            integrated security = true";

        //METODO PARA ENGLOBAR A TODOS LAS CLASES LA CADENA DE CONEXION
        public static SqlConnection mtdObtenerConexion()
        {
            return new SqlConnection(connectionString);
        }
    }
}