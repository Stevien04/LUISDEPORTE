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
    }
}
