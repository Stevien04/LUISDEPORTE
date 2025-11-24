using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmCrearCuenta : Form
    {
        private clsCrearCuenta_CN ObjCrearCuenta = new clsCrearCuenta_CN();

        string patronCorreo = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
        string patronSoloLetras = @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ ]+$";


        public frmCrearCuenta()
        {
            InitializeComponent();
        }

        private void frmCrearCuen_Load(object sender, EventArgs e)
        {
            lblErrorCorreo.Visible = false;
            lblErrorNombre.Visible = false;
            lblErrorApePaterno.Visible = false;
            lblErrorApeMaterno.Visible = false;
            lblErrorDocumento.Visible = false;
            lblErrorFechaNacimiento.Visible = false;
            lblErrorTelefono.Visible = false;
            lblErrorGenero.Visible = false;
            lblErrorNomUsuario.Visible = false;
            lblErrorContraseña.Visible = false;
            lblErrorDocCombox.Visible = false;

            cmbTipoDocumento.DataSource = ObjCrearCuenta.mtdListarTipoDocumentoActivosCD();
            cmbTipoDocumento.DisplayMember = "TipoDocumento";
            cmbTipoDocumento.ValueMember = "IDTipoDocumento";

            cmbTipoDocumento.SelectedIndex = -1;
        }

        private void mtdMnejaeError(string mensaje, Label lblLabel)
        {
            lblLabel.Text = "        " + mensaje;
            lblLabel.Visible = true;
        }

        private void mtdValidarDocumento(ComboBox cboTipoDocumento, TextBox txtDocumento)
        {
            string tipo = cboTipoDocumento.Text;
            string documento = txtDocumento.Text;

            // --- REGLAS MÍNIMAS PARA COMENZAR A VALIDAR ---
            if (tipo == "DNI" && documento.Length < 8) { lblErrorDocumento.Visible = false; return; }
            if (tipo == "Carnet de Extranjería" && documento.Length < 9) { lblErrorDocumento.Visible = false; return; }
            if (tipo == "Pasaporte" && documento.Length < 6) { lblErrorDocumento.Visible = false; return; }

            // --- VALIDACIÓN SEGÚN TIPO ---
            switch (tipo)
            {
                case "DNI":
                    if (!Regex.IsMatch(documento, @"^[0-9]{8}$"))
                        mtdMnejaeError("El DNI debe tener 8 dígitos numéricos", lblErrorDocumento);
                    else
                        lblErrorDocumento.Visible = false;
                    break;

                case "Carnet de Extranjería":
                    if (!Regex.IsMatch(documento, @"^[A-Za-z0-9]{9,12}$"))
                        mtdMnejaeError("El Carnet debe tener entre 9 y 12 caracteres alfanuméricos", lblErrorDocumento);
                    else
                        lblErrorDocumento.Visible = false;
                    break;

                case "Pasaporte":
                    if (!Regex.IsMatch(documento, @"^[A-Za-z0-9]{6,12}$"))
                        mtdMnejaeError("El pasaporte debe tener entre 6 y 12 caracteres alfanuméricos", lblErrorDocumento);
                    else
                        lblErrorDocumento.Visible = false;
                    break;
            }
        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            //INFORMACION DE LA CUENTA
            string NombreUsuario = txtNomUsuario.Text;
            string Clave = txtContraseña.Text;


            //INFORMACION PERSONAL
            string Nombres = txtNombre.Text.ToUpper();
            string ApellidoPaterno = txtApellidoPaterno.Text.ToUpper();
            string ApellidoMaterno = txtApellidoMaterno.Text.ToUpper();
            string Documento = txtDocumento.Text;
            string Genero = cmbGenero.Text;

            int IDTipoDocumento = Convert.ToInt32(cmbTipoDocumento.SelectedValue);

            DateTime FechaNacimiento = dtpFechaNacimiento.Value;
            string Telefono = txtTelefono.Text;
            string Correo = txtCorreo.Text;

            int edad = DateTime.Today.Year - FechaNacimiento.Year;

            if (FechaNacimiento.Date > DateTime.Today.AddYears(-edad))
            {
                edad--;
            }

            // CORREO
            if (txtCorreo.Text == "CORREO")
            {
                mtdMnejaeError("Ingrese un correo electrónico", lblErrorCorreo);
                return;
            }
            else if (!Regex.IsMatch(txtCorreo.Text, patronCorreo))
            {
                mtdMnejaeError("Ingrese un correo válido (formato incorrecto)", lblErrorCorreo);
                return;
            }
            else { lblErrorCorreo.Visible = false; }

            // NOMBRE
            if (txtNombre.Text == "NOMBRE")
            {
                mtdMnejaeError("Ingrese su nombre", lblErrorNombre);
                return;
            }
            else if (!Regex.IsMatch(txtNombre.Text, patronSoloLetras))
            {
                mtdMnejaeError("El nombre solo debe contener letras", lblErrorNombre);
                return;
            }
            else { lblErrorNombre.Visible = false; }

            // APELLIDO PATERNO
            if (txtApellidoPaterno.Text == "APELLIDO PATERNO")
            {
                mtdMnejaeError("Ingrese su apellido paterno", lblErrorApePaterno);
                return;
            }
            else if (!Regex.IsMatch(txtApellidoPaterno.Text, patronSoloLetras))
            {
                mtdMnejaeError("El apellido paterno solo debe contener letras", lblErrorApePaterno);
                return;
            }
            else { lblErrorApePaterno.Visible = false; }

            // APELLIDO MATERNO
            if (txtApellidoMaterno.Text == "APELLIDO MATERNO")
            {
                mtdMnejaeError("Ingrese su apellido materno", lblErrorApeMaterno);
                return;
            }
            else if (!Regex.IsMatch(txtApellidoMaterno.Text, patronSoloLetras))
            {
                mtdMnejaeError("El apellido materno solo debe contener letras", lblErrorApeMaterno);
                return;
            }
            else { lblErrorApeMaterno.Visible = false; }

            // TIPO DOCUMENTO
            if (cmbTipoDocumento.SelectedIndex == -1)
            {
                mtdMnejaeError("Seleccione un tipo de documento", lblErrorDocCombox);
                return;
            }
            else { lblErrorDocCombox.Visible = false; }

            // DOCUMENTO
            if (txtDocumento.Text == "DOCUMENTO")
            {
                mtdMnejaeError("Ingrese su documento", lblErrorDocumento);
                return;
            }
            else { lblErrorDocumento.Visible = false; }

            // TELÉFONO

            Regex regexTelefono = new Regex(@"^\d{9}$");

            if (txtTelefono.Text == "TELÉFONO")
            {
                mtdMnejaeError("Ingrese su número de teléfono", lblErrorTelefono);
                return;
            }
            else if (!regexTelefono.IsMatch(txtTelefono.Text))
            {
                mtdMnejaeError("El número de teléfono debe tener exactamente 9 dígitos", lblErrorTelefono);
                return;
            }
            else { lblErrorTelefono.Visible = false; }

            // GÉNERO
            if (cmbGenero.SelectedIndex == -1)
            {
                mtdMnejaeError("Seleccione un género", lblErrorGenero);
                return;
            }
            else { lblErrorGenero.Visible = false; }

            // NOMBRE DE USUARIO
            if (txtNomUsuario.Text == "NOMBRE DE USUARIO")
            {
                mtdMnejaeError("Ingrese un nombre de usuario", lblErrorNomUsuario);
                return;
            }
            else { lblErrorNomUsuario.Visible = false; }

            // CONTRASEÑA
            if (txtContraseña.Text == "CONTRASEÑA")
            {
                mtdMnejaeError("Ingrese una contraseña", lblErrorContraseña);
                return;
            }
            else { lblErrorContraseña.Visible = false; }

            // FECHA DE NACIMIENTO
            if (edad < 18)
            {
                mtdMnejaeError("Debe ser mayor de 18 años", lblErrorFechaNacimiento);
                return;
            }
            else { lblErrorFechaNacimiento.Visible = false; }


            try
            {
                string bdGenero = "";

                if (cmbGenero.Text == "HOMBRE")
                {
                    bdGenero = "M";
                }
                else if (cmbGenero.Text == "MUJER")
                {
                    bdGenero = "F";
                }


                ObjCrearCuenta.mtdCrearCuentaCN(Nombres,
                                                ApellidoPaterno,
                                                ApellidoMaterno,
                                                IDTipoDocumento,
                                                Documento,
                                                FechaNacimiento,
                                                Telefono,
                                                Correo,
                                                bdGenero,
                                                NombreUsuario,
                                                Clave);

                this.Hide();
                frmInicioSesion InicioSecion = new frmInicioSesion();
                InicioSecion.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }

        }

        private void mtdEnterTextBox(string Texto, TextBox text)
        {
            if (text.Text == Texto)
            {
                text.Text = "";
                text.ForeColor = Color.Black;
            }
        }

        private void mtdLeaveTextBox(string Texto, TextBox text)
        {
            if (text.Text == "")
            {
                text.Text = Texto;
                text.ForeColor = Color.Black;
            }
        }

        private void txtCorreo_Enter(object sender, EventArgs e)
        {
            mtdEnterTextBox("CORREO", txtCorreo);
        }

        private void txtCorreo_Leave(object sender, EventArgs e)
        {
            mtdLeaveTextBox("CORREO", txtCorreo);
        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            mtdEnterTextBox("NOMBRE", txtNombre);
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            mtdLeaveTextBox("NOMBRE", txtNombre);
        }

        private void txtApellidoPaterno_Enter(object sender, EventArgs e)
        {
            mtdEnterTextBox("APELLIDO PATERNO", txtApellidoPaterno);
        }

        private void txtApellidoPaterno_Leave(object sender, EventArgs e)
        {
            mtdLeaveTextBox("APELLIDO PATERNO", txtApellidoPaterno);
        }

        private void txtApellidoMaterno_Enter(object sender, EventArgs e)
        {
            mtdEnterTextBox("APELLIDO MATERNO", txtApellidoMaterno);
        }

        private void txtApellidoMaterno_Leave(object sender, EventArgs e)
        {
            mtdLeaveTextBox("APELLIDO MATERNO", txtApellidoMaterno);
        }

        private void txtDocumento_Enter(object sender, EventArgs e)
        {
            mtdEnterTextBox("DOCUMENTO", txtDocumento);
        }

        private void txtDocumento_Leave(object sender, EventArgs e)
        {
            mtdLeaveTextBox("DOCUMENTO", txtDocumento);
        }

        private void txtTelefono_Enter(object sender, EventArgs e)
        {
            mtdEnterTextBox("TELEFONO", txtTelefono);
        }

        private void txtTelefono_Leave(object sender, EventArgs e)
        {
            mtdLeaveTextBox("TELEFONO", txtTelefono);
        }

        private void txtNomUsuario_Enter(object sender, EventArgs e)
        {
            mtdEnterTextBox("NOMBRE DE USUARIO", txtNomUsuario);
        }

        private void txtNomUsuario_Leave(object sender, EventArgs e)
        {
            mtdLeaveTextBox("NOMBRE DE USUARIO", txtNomUsuario);
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            mtdEnterTextBox("CONTRASEÑA", txtContraseña);
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            mtdLeaveTextBox("CONTRASEÑA", txtContraseña);
        }

        private void cmbTipoDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtDocumento.Text != "DOCUMENTO") {  txtDocumento.Clear(); }
        }

        private void txtDocumento_TextChanged(object sender, EventArgs e)
        {
            mtdValidarDocumento(cmbTipoDocumento, txtDocumento);
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmInicioSesion inicioSesion = new frmInicioSesion();
            inicioSesion.ShowDialog();
        }
    }
}
