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
    public partial class frmInicioSesion : Form
    {
        private clsCredenciales_CN ObjCredenciales = new clsCredenciales_CN();

        public frmInicioSesion()
        {
            InitializeComponent();
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Black;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.Black;
            }
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "CONTRASEÑA")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.Black;
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "CONTRASEÑA";
                txtContraseña.ForeColor = Color.Black;
                txtContraseña.UseSystemPasswordChar = false;
            }
        }

        private void ptbCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ptbMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void mtdMensajeError(string mensaje, Label lblLabel)
        {
            lblLabel.Text = "        " + mensaje;
            lblLabel.Visible = true;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //VALORES
            string Usuario = txtUsuario.Text;
            string clave = txtContraseña.Text;

            //VERIFICAR QUE NO SE INGRESEN
            if (txtUsuario.Text == "USUARIO")
            {
                mtdMensajeError("Ingrese el nombre de Usuario", lblErrorUsuario);
                return;
            }
            else
            {
                lblErrorUsuario.Visible = false;
            }

            if (txtContraseña.Text == "CONTRASEÑA")
            {
                mtdMensajeError("Ingrese la contraseña", lblErrorContraseña);
                return;
            }
            else
            {
                lblErrorContraseña.Visible = false;
            }

            try
            {
                bool ValidarCredencial = ObjCredenciales.mtdCValidarCredencialesCN(Usuario, clave); //VERIFICAR SI LAS CREDENCIALES SON CORRECTAS
                var GuardarUsuario = ObjCredenciales.mtdObtenerUsuarioCN(Usuario, clave); //GUARDAR LA INFORMACION DEL USUARIO PARA EL USO DEL SISTEMA

                if (ValidarCredencial)
                {
                    //GUADAR EL USUARIO EN UNA CLASE GLOBAL STATIC
                    clsSesionUsuario_CN.idUsuario = GuardarUsuario.idUsuario;
                    clsSesionUsuario_CN.NombreUsuario = GuardarUsuario.nombreUsuario;

                    this.Hide();
                    frmPrincipal MenuPrincipal = new frmPrincipal();
                    MenuPrincipal.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Credenciales Incorrectas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            lblErrorUsuario.Visible = false;
            lblErrorContraseña.Visible = false;
        }

        private void lnkCrearCuenta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmCrearCuenta CrearCuenta = new frmCrearCuenta();
            CrearCuenta.ShowDialog();
        }
    }
}
