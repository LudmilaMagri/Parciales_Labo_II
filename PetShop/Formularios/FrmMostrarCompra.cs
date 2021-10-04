using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Entidades;

namespace Formularios
{
    public partial class FrmMostrarCompra : Form
    {
        public Compra compra;
        Cliente cliente;


        public FrmMostrarCompra()
        {
            InitializeComponent();
        } 
        private void FrmMostrarCompra_Load(object sender, EventArgs e)
        {
            compra = FrmCompra.sCompras;
            cliente = FrmCompra.cliente;
            dgvMostrar.DataSource = compra.ListaProductos;
            lblPrecio.Text = compra.CostoFinal.ToString();
            lblDatos.Text = cliente.ToString();
        }

        private void btnAceptarCompra_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnTxt_Click(object sender, EventArgs e)
        {
            StreamWriter archivoTxt = new StreamWriter(@"C:\Users\ludmi\Documents\factura.txt"); 
            int celdas = dgvMostrar.RowCount-1;
            archivoTxt.WriteLine(lblDatos.Text);
            
            for (int i = 0; i <dgvMostrar.RowCount; i++)
            {
                archivoTxt.WriteLine("Categoria: " + dgvMostrar.Rows[i].Cells[0].Value.ToString());
                archivoTxt.WriteLine("Codigo: " + dgvMostrar.Rows[i].Cells[1].Value.ToString());
                archivoTxt.WriteLine("Nombre: " + dgvMostrar.Rows[i].Cells[2].Value.ToString());
                archivoTxt.WriteLine("Precio: " + dgvMostrar.Rows[i].Cells[3].Value.ToString());
                archivoTxt.WriteLine("---------------------------------");
            }
            archivoTxt.WriteLine("Costo final: $" + compra.CostoFinal.ToString());
            archivoTxt.Close();
            MessageBox.Show("Archivo generado");
        }
    }
}
