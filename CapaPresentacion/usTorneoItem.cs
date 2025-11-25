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
    public partial class usTorneoItem : UserControl
    {
        public event EventHandler OnModificarClick;
        public event EventHandler OnEliminarClick;
        public event EventHandler OnInvitarClick;
        public event EventHandler OnIntegrantesClick;


        public usTorneoItem()
        {
            InitializeComponent();
        }

        public int IDTorneo { get; set; }

        public string NombreTorneo
        {
            get { return lblNombreEquipo.Text; }
            set { lblNombreEquipo.Text = value; }
        }

        public string Descripcion
        {
            get { return lblDescripcion.Text; }
            set { lblDescripcion.Text = value; }
        }

        public string FechaCreacion
        {
            get { return lblFechaCreacion.Text; }
            set { lblFechaCreacion.Text = value; }
        }

        public string FechaModificacion
        {
            get { return lblFechaModificacion.Text; }
            set { lblFechaModificacion.Text = value; }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            OnEliminarClick?.Invoke(this, EventArgs.Empty);
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            OnModificarClick?.Invoke(this, EventArgs.Empty);
        }

        private void btnInvitar_Click_1(object sender, EventArgs e)
        {
            OnInvitarClick?.Invoke(this, EventArgs.Empty);
        }

        private void btnIntegrantes_Click_1(object sender, EventArgs e)
        {
            OnIntegrantesClick?.Invoke(this, EventArgs.Empty);
        }
    }
}
