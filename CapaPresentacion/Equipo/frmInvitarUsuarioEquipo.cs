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

        int IDUsuarioActual = clsSesionUsuario_CN.idUsuario;
        
        //VARIABLE GLOBAL PARA USARLA EN TODO EL FORMULARIO
        private int IDEquipo_;
        private int IDUsuarioInvitado;
        private int IdUsuarioActual = clsSesionUsuario_CN.idUsuario;

        //INICIAMOS EL FORMULARIO PASANDO EL VALOR DEL IDEQUIPO
        public frmInvitarUsuarioEquipo(string IDEquipo)
        {
            InitializeComponent();
            IDEquipo_ = int.Parse(IDEquipo);
            txtEquipo.Text = IDEquipo_.ToString();
        }

        private void frmInvitarUsuarioEquipo_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string NombreUsuario = txtNomUsuario.Text;
            clsUsuario_CN ObjUsuario = new clsUsuario_CN();
            dgvUsuario.DataSource = ObjUsuario.mtdBuscarUsuariosActivosCN(NombreUsuario, IDUsuarioActual);
            dgvUsuario.Columns["IDUsuario"].Visible = false;
        }

        private void dgvUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dgvUsuario.Rows)
            {
                if (row.Index == e.RowIndex)
                {
                    txtUsuarioInvitado.Text = row.Cells["IDUsuario"].Value.ToString();
                    IDUsuarioInvitado = Convert.ToInt32(row.Cells["IDUsuario"].Value.ToString());
                }
            }
        }

        private void btnInvitar_Click(object sender, EventArgs e)
        {
            ObjGestionEquipos.mtdInvitarUsuarioEquipo_CN(IDEquipo_, IDUsuarioInvitado, IdUsuarioActual);
        }
    }
}
