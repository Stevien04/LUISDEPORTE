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
    public partial class frmInvitarUsuarioEquipo : Form
    {
        private clsUsuario_CN ObjUsuario = new clsUsuario_CN();
        private clsGestionEquipos_CN ObjGestionEquipos = new clsGestionEquipos_CN();

        private readonly int _idUsuarioActual = clsSesionUsuario_CN.idUsuario;

        //VARIABLE GLOBAL PARA USARLA EN TODO EL FORMULARIO
        private int IDEquipo_;
        private int IDUsuarioInvitado;

        //INICIAMOS EL FORMULARIO PASANDO EL VALOR DEL IDEQUIPO
        public frmInvitarUsuarioEquipo(string IDEquipo)
        {
            InitializeComponent();
            IDEquipo_ = int.Parse(IDEquipo);
            txtEquipo.Text = IDEquipo_.ToString();
        }

        private void dgvUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvUsuario.Rows.Count)
                return;

            DataGridViewRow row = dgvUsuario.Rows[e.RowIndex];

            if (row.Cells["IDUsuario"]?.Value != null)
            {
                IDUsuarioInvitado = Convert.ToInt32(row.Cells["IDUsuario"].Value);
            }
        }

        private void btnInvita_Click(object sender, EventArgs e)
        {
            if (IDUsuarioInvitado == 0)
            {
                MessageBox.Show("Seleccione un usuario de la lista antes de enviar la invitación.",
                    "Usuario requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ObjGestionEquipos.mtdInvitarUsuarioEquipo_CN(IDEquipo_, IDUsuarioInvitado, _idUsuarioActual);

            MessageBox.Show("Invitación enviada correctamente.", "Invitación", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            string NombreUsuario = txtNomUsuario.Text;
            clsUsuario_CN ObjUsuario = new clsUsuario_CN();
            dgvUsuario.DataSource = ObjUsuario.mtdBuscarUsuariosActivosCN(NombreUsuario, _idUsuarioActual);
            dgvUsuario.Columns["IDUsuario"].Visible = false;
        }
    }
}
