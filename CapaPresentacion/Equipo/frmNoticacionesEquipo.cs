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
    public partial class frmNoticacionesEquipo : Form
    {
        private readonly clsGestionEquipos_CN _gestionEquipos = new clsGestionEquipos_CN();
        private readonly int _idUsuarioActual = clsSesionUsuario_CN.idUsuario;

        public frmNoticacionesEquipo()
        {
            InitializeComponent();
            mtdActualizarEstadoBotones();
        }

        private void frmNoticaciones_Load(object sender, EventArgs e)
        {
            mtdCargarInvitaciones();
            mtdActualizarEstadoBotones();
        }

        private void mtdCargarInvitaciones()
        {
            DataTable invitaciones = _gestionEquipos.mtdListarInvitacionesPorUsuarioCN(_idUsuarioActual);

            if (invitaciones == null || invitaciones.Rows.Count == 0)
            {
                dataGridView1.DataSource = null;
                return;
            }

            dataGridView1.DataSource = invitaciones;

            if (dataGridView1.Columns.Contains("IdInvitacion"))
            {
                dataGridView1.Columns["IdInvitacion"].Visible = false;
            }

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ClearSelection();
            mtdActualizarEstadoBotones();
        }

        private int? mtdObtenerIdInvitacionSeleccionada()
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.Cells["IdInvitacion"] == null)
            {
                return null;
            }

            if (int.TryParse(dataGridView1.CurrentRow.Cells["IdInvitacion"].Value.ToString(), out int idInvitacion))
            {
                return idInvitacion;
            }

            return null;
        }

        private void mtdActualizarEstadoBotones()
        {
            bool haySeleccion = dataGridView1.CurrentRow != null && dataGridView1.CurrentRow.Index >= 0;
            btnAceptar.Enabled = haySeleccion;
            btnRechazar.Enabled = haySeleccion;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            mtdActualizarEstadoBotones();
        }

        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            int? idInvitacion = mtdObtenerIdInvitacionSeleccionada();

            if (!idInvitacion.HasValue)
            {
                MessageBox.Show("Seleccione una invitación para continuar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                bool resultado = _gestionEquipos.mtdResponderInvitacionCN(idInvitacion.Value, "Aceptada");

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

        private void btnRechazar_Click_1(object sender, EventArgs e)
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
                bool resultado = _gestionEquipos.mtdResponderInvitacionCN(idInvitacion.Value, "Rechazada");

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
    }
}
