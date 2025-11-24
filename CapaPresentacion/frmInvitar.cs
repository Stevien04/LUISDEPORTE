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
    public partial class frmInvitar : Form
    {
        private readonly int _idTorneo;
        private readonly string _nombreTorneo;
        private readonly clsGestionTorneos_CN ObjGestionTorneos = new clsGestionTorneos_CN();

        public bool SoloLectura { get; set; }


        public frmInvitar(int idTorneo, string nombreTorneo)
        {
            InitializeComponent();
            _idTorneo = idTorneo;
            _nombreTorneo = nombreTorneo;
        }

        private void frmInvitar_Load(object sender, EventArgs e)
        {
            lblTorneo.Text = $"Torneo: {_nombreTorneo}";
            CargarEquiposDisponibles();
            CargarEquiposEnTorneo();
            AplicarSoloLectura();
        }

        private void AplicarSoloLectura()
        {
            if (SoloLectura)
            {
                txtBuscar.Enabled = false;
                btnBuscar.Enabled = false;
                btnInvitar.Enabled = false;
            }
        }

        private void CargarEquiposDisponibles()
        {
            DataTable tabla = ObjGestionTorneos.mtdBuscarEquiposCN(txtNomEquipo.Text);
            dgvEquipo.DataSource = tabla;

            if (dgvEquipo.Columns.Contains("IDEquipo"))
            {
                dgvEquipo.Columns["IDEquipo"].Visible = false;
            }
        }

        private void CargarEquiposEnTorneo()
        {
            DataTable tabla = ObjGestionTorneos.mtdListarEquiposPorTorneoCN(_idTorneo);
            dgvEquiposTorneo.DataSource = tabla;

            if (dgvEquiposTorneo.Columns.Contains("IDEquipo"))
            {
                dgvEquiposTorneo.Columns["IDEquipo"].Visible = false;
            }
        }
    }
}
