using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class FrmMenuEmpleado : FrmMenuPrincipal
    {
        public FrmMenuEmpleado()
        {
            InitializeComponent();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FrmListarClientes f = new FrmListarClientes();
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            f.FormBorderStyle = FormBorderStyle.None;
            pnlFrmMenuPrincipal.Controls.Add(f);
            pnlFrmMenuPrincipal.Tag = f;
            f.Show();
            f.BringToFront();
        }

        private void pbVenta_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
