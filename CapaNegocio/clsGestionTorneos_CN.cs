using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class clsGestionTorneos_CN
    {
        private clsGestionTorneos_CD ObjGestionTorneos = new clsGestionTorneos_CD();

        public int mtdCrearTorneoCN(int idCreador, string nombreTorneo, string descripcion)
        {
            return ObjGestionTorneos.mtdCrearTorneoCD(idCreador, nombreTorneo, descripcion);
        }

        public DataTable mtdListarTorneosPorCreadorCN(int idCreador)
        {
            return ObjGestionTorneos.mtdListarTorneosPorCreadorCD(idCreador);
        }

        public bool mtdModificarTorneoCN(int idTorneo, int idCreador, string nombreTorneo, string descripcion)
        {
            return ObjGestionTorneos.mtdModificarTorneoCD(idTorneo, idCreador, nombreTorneo, descripcion);
        }

        public bool mtdEliminarTorneoCN(int idTorneo, int idCreador)
        {
            return ObjGestionTorneos.mtdEliminarTorneoCD(idTorneo, idCreador);
        }

        public DataTable mtdBuscarEquiposCN(string filtroUsuario, string filtroEquipo)
        {
            return ObjGestionTorneos.mtdBuscarEquiposActivosCD(filtroUsuario, filtroEquipo);
        }

        public bool mtdInvitarEquipoATorneoCN(int idTorneo, int idEquipo, int idUsuarioInvitador)
        {
            return ObjGestionTorneos.mtdInvitarEquipoATorneoCD(idTorneo, idEquipo, idUsuarioInvitador);
        }

        public bool mtdAgregarEquipoATorneoCN(int idTorneo, int idEquipo)
        {
            return ObjGestionTorneos.mtdAgregarEquipoATorneoCD(idTorneo, idEquipo);
        }

        public DataTable mtdListarEquiposPorTorneoCN(int idTorneo)
        {
            return ObjGestionTorneos.mtdListarEquiposPorTorneoCD(idTorneo);
        }

        public DataTable mtdListarInvitacionesTorneoPorUsuarioCN(int idUsuarioInvitado)
        {
            return ObjGestionTorneos.mtdListarInvitacionesTorneoPorUsuarioCD(idUsuarioInvitado);
        }

        public bool mtdResponderInvitacionTorneoCN(int idInvitacion, string nuevoEstado)
        {
            return ObjGestionTorneos.mtdResponderInvitacionTorneoCD(idInvitacion, nuevoEstado);
        }
    }
}
