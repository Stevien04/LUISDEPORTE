using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class clsUsuario_CN
    {
        private clsUsuario_CD ObjUsuario = new clsUsuario_CD();

        public DataTable mtdBuscarUsuariosActivosCN(string NombreUsuario, int IDUsuarioActual)
        {
            DataTable tbUsuarios = new DataTable();
            tbUsuarios = ObjUsuario.mtdBuscarUsuariosActivosCD(NombreUsuario,IDUsuarioActual);
            return tbUsuarios;
        }
    }
}
