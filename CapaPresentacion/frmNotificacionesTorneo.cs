using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmNotificacionesTorneo : Form
    {
        private readonly clsGestionTorneos_CN _gestionTorneos = new clsGestionTorneos_CN();
        private readonly int _idUsuarioActual = clsSesionUsuario_CN.idUsuario;

        public frmNotificacionesTorneo()
        {
            InitializeComponent();
            mtdActualizarEstadoBotones();
        }

        private void frmNotificacionesTorneo_Load(object sender, EventArgs e)
        {
            mtdCargarInvitaciones();
            mtdActualizarEstadoBotones();
        }

        private void mtdCargarInvitaciones()
        {
            DataTable invitaciones = _gestionTorneos.mtdListarInvitacionesTorneoPorUsuarioCN(_idUsuarioActual);

            if (invitaciones == null || invitaciones.Rows.Count == 0)
            {
                dgvNotificacionesTorneo.DataSource = null;
                return;
            }

            dgvNotificacionesTorneo.DataSource = invitaciones;

            if (dgvNotificacionesTorneo.Columns.Contains("IdInvitacionTorneo"))
            {
                dgvNotificacionesTorneo.Columns["IdInvitacionTorneo"].Visible = false;
            }

            dgvNotificacionesTorneo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNotificacionesTorneo.ClearSelection();
        }

        private int? mtdObtenerIdInvitacionSeleccionada()
        {
            if (dgvNotificacionesTorneo.CurrentRow == null || dgvNotificacionesTorneo.CurrentRow.Cells["IdInvitacionTorneo"] == null)
            {
                return null;
            }

            if (int.TryParse(dgvNotificacionesTorneo.CurrentRow.Cells["IdInvitacionTorneo"].Value.ToString(), out int idInvitacion))
            {
                return idInvitacion;
            }

            return null;
        }

        private void mtdActualizarEstadoBotones()
        {
            bool haySeleccion = dgvNotificacionesTorneo.CurrentRow != null && dgvNotificacionesTorneo.CurrentRow.Index >= 0;
            btnAceptar.Enabled = haySeleccion;
            btnRechazar.Enabled = haySeleccion;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int? idInvitacion = mtdObtenerIdInvitacionSeleccionada();

            if (!idInvitacion.HasValue)
            {
                MessageBox.Show("Seleccione una invitación para continuar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                bool resultado = _gestionTorneos.mtdResponderInvitacionTorneoCN(idInvitacion.Value, "Aceptada");

                if (resultado)
                {
                    MessageBox.Show("Invitación aceptada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mtdCargarInvitaciones();
                }
                else
                {
                    MessageBox.Show("No fue posible actualizar la invitación seleccionada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al aceptar la invitación: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRechazar_Click(object sender, EventArgs e)
        {
            int? idInvitacion = mtdObtenerIdInvitacionSeleccionada();

            if (!idInvitacion.HasValue)
            {
                MessageBox.Show("Seleccione una invitación para continuar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult confirmacion = MessageBox.Show("¿Seguro que desea rechazar la invitación seleccionada?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion != DialogResult.Yes)
            {
                return;
            }

            try
            {
                bool resultado = _gestionTorneos.mtdResponderInvitacionTorneoCN(idInvitacion.Value, "Rechazada");

                if (resultado)
                {
                    MessageBox.Show("Invitación rechazada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mtdCargarInvitaciones();
                }
                else
                {
                    MessageBox.Show("No fue posible actualizar la invitación seleccionada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al rechazar la invitación: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvNotificacionesTorneo_SelectionChanged_1(object sender, EventArgs e)
        {
            mtdActualizarEstadoBotones();
        }
    }
}
