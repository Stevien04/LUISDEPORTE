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
    public partial class frmListarIntegrantesEquipo : Form
    {
        private readonly clsGestionEquipos_CN _gestionEquipos = new clsGestionEquipos_CN();
        private readonly int _idEquipo;

        public frmListarIntegrantesEquipo()
        {            
            InitializeComponent();
        }

        public frmListarIntegrantesEquipo(int idEquipo) : this()
        {
            _idEquipo = idEquipo;
            this.Load += frmListarIntegrantesEquipo_Load;
        }

        private void frmListarIntegrantesEquipo_Load(object sender, EventArgs e)
        {
            mtdCargarIntegrantes();
        }

        private void mtdCargarIntegrantes()
        {
            DataTable integrantes = _gestionEquipos.mtdListarIntegrantesEquipoCN(_idEquipo);

            dgvIntegrantesEquipo.DataSource = integrantes;

            if (dgvIntegrantesEquipo.Columns.Contains("IdUsuario"))
            {
                dgvIntegrantesEquipo.Columns["IdUsuario"].Visible = false;
            }

            dgvIntegrantesEquipo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
