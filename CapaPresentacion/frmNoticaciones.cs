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
    public partial class frmNoticaciones : Form
    {
        private readonly clsGestionEquipos_CN _gestionEquipos = new clsGestionEquipos_CN();
        private readonly int _idUsuarioActual = clsSesionUsuario_CN.idUsuario;

        public frmNoticaciones()
        {
            InitializeComponent();
        }

        private void frmNoticaciones_Load(object sender, EventArgs e)
        {
            mtdCargarInvitaciones();
        }

        private void mtdCargarInvitaciones()
        {
            DataTable invitaciones = _gestionEquipos.mtdListarInvitacionesPorUsuarioCN(_idUsuarioActual);
            dataGridView1.DataSource = invitaciones;

            if (dataGridView1.Columns.Contains("IdInvitacion"))
            {
                dataGridView1.Columns["IdInvitacion"].Visible = false;
            }

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
