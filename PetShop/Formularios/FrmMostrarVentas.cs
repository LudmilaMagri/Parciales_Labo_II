using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Formularios
{
    public partial class FrmMostrarVentas : Form
    {

        public FrmMostrarVentas()
        {
            InitializeComponent();
        }

        private void FrmMostrarVentas_Load(object sender, EventArgs e)
        {
            CargarDatos.CargarVentas();
            lblPrecioFinal.Text = "$" + Shop.Costofinal().ToString();
            dgvMostrar.DataSource = Shop.listaTotalCompras;
            lblCantidadVentas.Text = Shop.listaTotalCompras.Count().ToString();
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
