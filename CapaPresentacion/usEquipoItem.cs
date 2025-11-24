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
    public partial class usEquipoItem : UserControl
    {
        public event EventHandler OnModificarClick;

        public usEquipoItem()
        {
            InitializeComponent();
        }

        public string NombreEquipo
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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (OnModificarClick != null)
                OnModificarClick(this, EventArgs.Empty);
        }

        public int IDEquipo { get; set; }
    }
}
