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
    public partial class frmInvitarEquipoTorneo : Form
    {
        private readonly int _idTorneo;
        private readonly string _nombreTorneo;
        private readonly clsGestionTorneos_CN ObjGestionTorneos = new clsGestionTorneos_CN();
        private readonly int _idUsuarioActual = clsSesionUsuario_CN.idUsuario;

        private int _idEquipoSeleccionado;
        private string _nombreEquipoSeleccionado;

        public bool SoloLectura { get; set; }


        public frmInvitarEquipoTorneo(int idTorneo, string nombreTorneo)
        {
            InitializeComponent();
            _idTorneo = idTorneo;
            _nombreTorneo = nombreTorneo;
        }

        private void frmInvitar_Load(object sender, EventArgs e)
        {
            txtTorneo.Text = _nombreTorneo;
            CargarEquiposDisponibles();
            AplicarSoloLectura();
        }

        private void AplicarSoloLectura()
        {
            if (SoloLectura)
            {
                txtNomEquipo.Enabled = false;
                txtUsuario.Enabled = false;
                btnBusca.Enabled = false;
                btnInvita.Enabled = false;
            }
        }

        private void CargarEquiposDisponibles()
        {
            string filtroUsuario = txtUsuario.Text.Trim();
            string filtroEquipo = txtNomEquipo.Text.Trim();

            _idEquipoSeleccionado = 0;
            _nombreEquipoSeleccionado = string.Empty;
            btnInvita.Enabled = false;

            DataTable tabla = ObjGestionTorneos.mtdBuscarEquiposCN(filtroUsuario, filtroEquipo);

            dgvEquipo.DataSource = null;
            dgvEquipo.Rows.Clear();
            dgvEquipo.Columns.Clear();
            dgvEquipo.DataSource = tabla;

            if (dgvEquipo.Columns.Contains("IDEquipo"))
            {
                dgvEquipo.Columns["IDEquipo"].Visible = false;
            }
        }

        private void dgvEquipo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvEquipo.Rows.Count)
                return;

            DataGridViewRow row = dgvEquipo.Rows[e.RowIndex];

            if (row.Cells["IDEquipo"]?.Value == null)
                return;

            _idEquipoSeleccionado = Convert.ToInt32(row.Cells["IDEquipo"].Value);
            _nombreEquipoSeleccionado = row.Cells["NombreEquipo"]?.Value?.ToString() ?? string.Empty;

            btnInvita.Enabled = !SoloLectura;
        }

        private void btnInvita_Click(object sender, EventArgs e)
        {
            if (_idEquipoSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un equipo antes de enviar la invitación.", "Equipo requerido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool invitacionRegistrada = ObjGestionTorneos.mtdInvitarEquipoATorneoCN(_idTorneo, _idEquipoSeleccionado, _idUsuarioActual);

            if (invitacionRegistrada)
            {
                MessageBox.Show($"Se envió la invitación al equipo '{_nombreEquipoSeleccionado}'. Quedará pendiente hasta que el otro usuario responda.", "Invitación registrada",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarEquiposDisponibles();
            }
            else
            {
                MessageBox.Show("No se pudo registrar la invitación. Intente nuevamente.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            CargarEquiposDisponibles();
        }
    }
}
