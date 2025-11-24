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
    public partial class frmCrearEquipo : Form
    {
        private clsGestionEquipos_CN ObjGestionEquipos = new clsGestionEquipos_CN();

        string NombreUsuario = clsSesionUsuario_CN.NombreUsuario.ToString();
        int IDCreador = clsSesionUsuario_CN.idUsuario;

        public frmCrearEquipo()
        {
            InitializeComponent();
        }

        private void btnCrearEquipo_Click(object sender, EventArgs e)
        {
            string NombreEquipo = txtNombreEquipo.Text;
            string Descripcion = txtDescripcion.Text;

            //LISTA DE PROBLEMAS A RESOLVER
            /*
             * NO PERMITIR DUPLICIDAD DE EQUIPO
             * EN VES DE SALIR CONO ESPACIO VACIO EN LA TABLA DEBE SALIR COMO NULL
             * USAR EL CORREO DE LA TABLA PERSONA PARA LOS CONTACTOS DEL USUSARIO CREADOR
             */

            try
            {
                ObjGestionEquipos.mtdCrearEquipoCN(IDCreador, NombreEquipo,Descripcion);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void frmCrearEquipo_Load(object sender, EventArgs e)
        {
            txtCreador.Text = NombreUsuario;
        }
    }
}
