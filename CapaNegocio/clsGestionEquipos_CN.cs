using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class clsGestionEquipos_CN
    {
        private clsGestionEquipos_CD ObjGestionEquipos = new clsGestionEquipos_CD();

        public void mtdCrearEquipoCN(int IDCreador, string NombreEquipo, string Descripcion)
        {
            ObjGestionEquipos.mtdCrearEquipoCD(IDCreador, NombreEquipo, Descripcion);
        }

        public DataTable mtdListarEquiposPorUsuarioCD(int IDCreador)
        {
            DataTable tbEquipos = new DataTable();
            tbEquipos = ObjGestionEquipos.mtdListarEquiposPorUsuarioCD(IDCreador);
            return tbEquipos;
        }

        public void mtdInvitarUsuarioEquipo_CN(int IdEquipo, int IdUsuarioInvitado, int IdUsuarioEmisor)
        {
            ObjGestionEquipos.mtdInvitarUsuarioEquipo_CD(IdEquipo, IdUsuarioInvitado, IdUsuarioEmisor);
        }

        public bool mtdModificarEquipoCN(int IDEquipo, int IDCreador, string NombreEquipo, string Descripcion, bool Estado)
        {
            return ObjGestionEquipos.mtdModificarEquipoCD(IDEquipo, IDCreador, NombreEquipo, Descripcion,Estado);
        }

        public bool mtdEliminarEquipoCN(int IDEquipo)
        {
            return ObjGestionEquipos.mtdEliminarEquipoCD(IDEquipo);
        }

        public DataTable mtdListarInvitacionesPorUsuarioCN(int idUsuarioInvitado)
        {
            return ObjGestionEquipos.mtdListarInvitacionesPorUsuarioCD(idUsuarioInvitado);
        }

        public bool mtdResponderInvitacionCN(int idInvitacion, string nuevoEstado)
        {
            return ObjGestionEquipos.mtdResponderInvitacionEquipoCD(idInvitacion, nuevoEstado);
        }

        public DataTable mtdListarIntegrantesEquipoCN(int idEquipo)
        {
            return ObjGestionEquipos.mtdListarIntegrantesEquipoCD(idEquipo);
        }

    }
}
