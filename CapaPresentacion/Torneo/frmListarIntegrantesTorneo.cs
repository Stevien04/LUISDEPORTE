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
    public partial class frmListarIntegrantesTorneo : Form
    {
        private readonly clsGestionTorneos_CN _gestionTorneos = new clsGestionTorneos_CN();
        private readonly int _idTorneo;

        public frmListarIntegrantesTorneo()
        {
            InitializeComponent();
        }

        public frmListarIntegrantesTorneo(int idTorneo) : this()
        {
            _idTorneo = idTorneo;
            this.Load += frmListarIntegrantesTorneo_Load;
        }

        private void frmListarIntegrantesTorneo_Load(object sender, EventArgs e)
        {
            mtdCargarEquipos();
            mtdCargarEnfrentamientos();
        }

        private void mtdCargarEquipos()
        {
            DataTable equipos = _gestionTorneos.mtdListarEquiposPorTorneoCN(_idTorneo);

            dgvIntegrantesTorneo.DataSource = equipos;

            if (dgvIntegrantesTorneo.Columns.Contains("IDEquipo"))
            {
                dgvIntegrantesTorneo.Columns["IDEquipo"].Visible = false;
            }

            dgvIntegrantesTorneo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void mtdCargarEnfrentamientos()
        {
            DataTable enfrentamientos = _gestionTorneos.mtdListarEnfrentamientosPorTorneoCN(_idTorneo);

            dgvEnfrentamientos.DataSource = enfrentamientos;

            if (dgvEnfrentamientos.Columns.Contains("IdEquipo1"))
            {
                dgvEnfrentamientos.Columns["IdEquipo1"].Visible = false;
            }

            if (dgvEnfrentamientos.Columns.Contains("IdEquipo2"))
            {
                dgvEnfrentamientos.Columns["IdEquipo2"].Visible = false;
            }

            if (dgvEnfrentamientos.Columns.Contains("IdEnfrentamiento"))
            {
                dgvEnfrentamientos.Columns["IdEnfrentamiento"].Visible = false;
            }

            dgvEnfrentamientos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnGenerarEnfrentamientos_Click(object sender, EventArgs e)
        {
            DataTable equipos = dgvIntegrantesTorneo.DataSource as DataTable;
            int cantidadEquipos = equipos?.Rows.Count ?? 0;

            if (cantidadEquipos < 2)
            {
                MessageBox.Show("Se necesitan al menos dos equipos para generar enfrentamientos.", "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int creados = _gestionTorneos.mtdGenerarEnfrentamientosCN(_idTorneo);

            if (creados > 0)
            {
                MessageBox.Show($"Se generaron {creados} enfrentamientos nuevos.", "Enfrentamientos creados",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ya existen todos los enfrentamientos para los equipos del torneo.", "Sin cambios",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            mtdCargarEnfrentamientos();
        }
    }
}
