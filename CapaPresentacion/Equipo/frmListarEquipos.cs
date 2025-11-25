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
    public partial class frmListarEquipos : Form
    {
        private clsGestionEquipos_CN ObjGestionEquipos = new clsGestionEquipos_CN();

        int IDUsuarioActual = clsSesionUsuario_CN.idUsuario;


        public frmListarEquipos()
        {
            InitializeComponent();
        }

        private string PedirTexto(string titulo, string mensaje, string valorPredeterminado)
        {
            using (Form prompt = new Form())
            {
                prompt.Width = 420;
                prompt.Height = 170;
                prompt.FormBorderStyle = FormBorderStyle.FixedDialog;
                prompt.Text = titulo;
                prompt.StartPosition = FormStartPosition.CenterParent;
                prompt.MaximizeBox = false;
                prompt.MinimizeBox = false;
                prompt.ShowInTaskbar = false;

                Label lblMensaje = new Label()
                {
                    Left = 15,
                    Top = 15,
                    Width = 370,
                    Text = mensaje
                };

                TextBox txtEntrada = new TextBox()
                {
                    Left = 15,
                    Top = 45,
                    Width = 370,
                    Text = valorPredeterminado
                };

                Button btnAceptar = new Button()
                {
                    Text = "Aceptar",
                    DialogResult = DialogResult.OK,
                    Left = 200,
                    Width = 85,
                    Top = 85
                };

                Button btnCancelar = new Button()
                {
                    Text = "Cancelar",
                    DialogResult = DialogResult.Cancel,
                    Left = 295,
                    Width = 85,
                    Top = 85
                };

                prompt.Controls.Add(lblMensaje);
                prompt.Controls.Add(txtEntrada);
                prompt.Controls.Add(btnAceptar);
                prompt.Controls.Add(btnCancelar);
                prompt.AcceptButton = btnAceptar;
                prompt.CancelButton = btnCancelar;

                return prompt.ShowDialog(this) == DialogResult.OK
                    ? txtEntrada.Text
                    : null;
            }
        }

        private void mtdCargarEquipos()
        {
            flpListaEquipos.Controls.Clear();

            DataTable tabla = ObjGestionEquipos.mtdListarEquiposPorUsuarioCD(IDUsuarioActual);

            foreach (DataRow fila in tabla.Rows)
            {
                usEquipoItem item = new usEquipoItem();

                item.NombreEquipo = fila["NombreEquipo"].ToString();
                item.Descripcion = fila["Descripcion"].ToString();
                item.IDEquipo = Convert.ToInt32(fila["IDEquipo"]);

                // FECHA DE CREACIÓN
                item.FechaCreacion = Convert.ToDateTime(fila["FechaRegistro"])
                                       .ToString("dd/MM/yyyy HH:mm");

                // FECHA DE MODIFICACIÓN (puede ser null)
                if (fila["FechaModificacion"] != DBNull.Value)
                    item.FechaModificacion = Convert.ToDateTime(fila["FechaModificacion"])
                                              .ToString("dd/MM/yyyy HH:mm");
                else
                    item.FechaModificacion = "—";

                item.OnModificarClick += Item_OnModificarClick;
                item.OnEliminarClick += Item_OnEliminarClick;
                item.OnInvitarClick += Item_OnInvitarClick;
                item.OnIntegrantesClick += Item_OnIntegrantesClick;

                flpListaEquipos.Controls.Add(item);
            }
        }


        private void frmListarEquipos_Load(object sender, EventArgs e)
        {
            mtdCargarEquipos();
        }

        private void Item_OnModificarClick(object sender, EventArgs e)
        {
            usEquipoItem item = sender as usEquipoItem;

            if (item == null)
                return;

            string nuevoNombre = PedirTexto(
                "Modificar equipo",
                "Ingrese el nuevo nombre del equipo:",
                item.NombreEquipo);

            if (string.IsNullOrWhiteSpace(nuevoNombre))
                return;

            string nuevaDescripcion = PedirTexto(
                "Modificar equipo",
                "Ingrese la nueva descripción del equipo:",
                item.Descripcion);

            if (nuevaDescripcion == null)
                return;

            if (string.IsNullOrWhiteSpace(nuevaDescripcion))
                nuevaDescripcion = item.Descripcion;

            bool actualizado = ObjGestionEquipos.mtdModificarEquipoCN(
                item.IDEquipo,
                IDUsuarioActual,
                nuevoNombre,
                nuevaDescripcion,
                true);

            if (actualizado)
            {
                MessageBox.Show("El equipo se modificó correctamente.", "Equipo actualizado",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                mtdCargarEquipos();
            }
            else
            {
                MessageBox.Show("No se pudo modificar el equipo.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Item_OnEliminarClick(object sender, EventArgs e)
        {
            usEquipoItem item = sender as usEquipoItem;

            if (item == null)
                return;

            DialogResult respuesta = MessageBox.Show(
                $"¿Desea eliminar el equipo \"{item.NombreEquipo}\"?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (respuesta != DialogResult.Yes)
                return;

            bool eliminado = ObjGestionEquipos.mtdEliminarEquipoCN(item.IDEquipo);

            if (eliminado)
            {
                MessageBox.Show("El equipo se eliminó correctamente.", "Equipo eliminado",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                mtdCargarEquipos();
            }
            else
            {
                MessageBox.Show("No se pudo eliminar el equipo.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void Item_OnInvitarClick(object sender, EventArgs e)
        {
            if (sender is usEquipoItem item)
            {
                using (frmInvitarUsuarioEquipo frmInvitacion = new frmInvitarUsuarioEquipo(item.IDEquipo.ToString()))
                {
                    frmInvitacion.StartPosition = FormStartPosition.CenterParent;
                    frmInvitacion.ShowIcon = false;
                    frmInvitacion.ShowInTaskbar = false;
                    frmInvitacion.ShowDialog(this);
                }
            }
        }

        private void Item_OnIntegrantesClick(object sender, EventArgs e)
        {
            if (sender is usEquipoItem item)
            {
                using (frmListarIntegrantesEquipo frmIntegrantes = new frmListarIntegrantesEquipo(item.IDEquipo))
                {
                    frmIntegrantes.StartPosition = FormStartPosition.CenterParent;
                    frmIntegrantes.ShowIcon = false;
                    frmIntegrantes.ShowInTaskbar = false;
                    frmIntegrantes.ShowDialog(this);
                }
            }
        }
    }
}
