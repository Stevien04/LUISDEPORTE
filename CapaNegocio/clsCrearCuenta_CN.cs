using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class clsCrearCuenta_CN
    {
        private clsCrearCuenta_CD ObjCrearCuenta = new clsCrearCuenta_CD();

        //METODO PARA CREAR UN CUENTA
        public void mtdCrearCuentaCN(string Nombres,
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
            ObjCrearCuenta.mtdCrearCuentaCD(Nombres,
                                            ApellidoPaterno,
                                            ApellidoMaterno,
                                            IDTipoDocumento,
                                            Documento,
                                            FechaNacimiento,
                                            Telefono,
                                            Correo,
                                            Genero,
                                            NombreUsuario,
                                            Clave);
        }

        //METODO PARA LISTAR TODOS LOS TIPOS DE DATOS
        public DataTable mtdListarTipoDocumentoActivosCD()
        {
            DataTable tbTipoDocumento = new DataTable();
            tbTipoDocumento = ObjCrearCuenta.mtdListarTipoDocumentoActivosCD();
            return tbTipoDocumento;
        }
    }
}
