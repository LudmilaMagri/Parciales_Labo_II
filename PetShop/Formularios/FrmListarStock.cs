using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using Entidades;

namespace Formularios
{
    public partial class FrmListarStock : Form
    {
        public FrmListarStock()
        {
            InitializeComponent();
        }
       
        private void FrmListarStock_Load(object sender, EventArgs e)
        {
            Limpiar();
            cbCategoria.DataSource = Enum.GetValues(typeof(Producto.ECategoria));
            dgvListarStock.DataSource = Shop.listaProductos;
        }

        #region Custom

        /// <summary>
        /// Actualiza el dataGridView cargando nuevamente la lista
        /// </summary>
        public void ActualizarDgv()
        {
            dgvListarStock.DataSource = null;
            dgvListarStock.DataSource = Shop.listaProductos;
        }
        /// <summary>
        /// Cambia el color de la celda segun el stock que posea
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvListarStock_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dgvListarStock.Columns[e.ColumnIndex].Name == "Stock")
            {
                if (Convert.ToInt32(e.Value) <= 20)
                {
                    e.CellStyle.ForeColor = Color.Black;
                    e.CellStyle.BackColor = Color.Orange;
                }
                if (Convert.ToInt32(e.Value) <= 10)
                {
                    e.CellStyle.ForeColor = Color.Black;
                    e.CellStyle.BackColor = Color.OrangeRed;
                }
                if (Convert.ToInt32(e.Value) == 0)
                {
                    e.CellStyle.ForeColor = Color.Black;
                    e.CellStyle.BackColor = Color.Red;
                }
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Limpia los campos que contiene el formulario
        /// </summary>
        private void Limpiar()
        {
            txtNombre.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
            txtCodigo.Clear();
            lblRespuesta.Text = " ";
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        #endregion

        /// <summary>
        /// Agrega un prodcuto a la lista de productos segun la categoria.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            SoundPlayer sonido = new SoundPlayer("./Add1.wav");
            float.TryParse(txtPrecio.Text, out float precio);
            int.TryParse(txtStock.Text, out int stock);
            if (Validaciones.EsNumericaInt(txtPrecio.Text) && Validaciones.EsNumerica(txtStock.Text) &&
                Validaciones.SoloLetras(txtNombre.Text))
            {
                switch (cbCategoria.SelectedItem)
                {
                    case Producto.ECategoria.Alimentos:
                        Producto.AgregarProducto(new Producto(Producto.ECategoria.Alimentos, txtNombre.Text, precio, stock));
                        break;
                    case Producto.ECategoria.Juguetes:
                        Producto.AgregarProducto(new Producto(Producto.ECategoria.Juguetes, txtNombre.Text, precio, stock));
                        break;
                    case Producto.ECategoria.Camas:
                        Producto.AgregarProducto(new Producto(Producto.ECategoria.Camas, txtNombre.Text, precio, stock));
                        break;
                    case Producto.ECategoria.Limpieza:
                        Producto.AgregarProducto(new Producto(Producto.ECategoria.Limpieza, txtNombre.Text, precio, stock));
                        break;
                    case Producto.ECategoria.Farmacia:
                        Producto.AgregarProducto(new Producto(Producto.ECategoria.Farmacia, txtNombre.Text, precio, stock));
                        break;
                    default:
                        break;
                }
                sonido.Play();
                lblRespuesta.Text = "Producto agregado";
                ActualizarDgv();
            }
            else
            {
                MessageBox.Show("Error al ingresar los datos");
            }
        }
        /// <summary>
        /// Los datos seleccionados de la fila elegida los agrega a los textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvListarStock.SelectedRows.Count > 0 )
            {
                txtCodigo.Text = dgvListarStock.CurrentRow.Cells[1].Value.ToString();
                txtNombre.Text = dgvListarStock.CurrentRow.Cells[2].Value.ToString();
                txtPrecio.Text = dgvListarStock.CurrentRow.Cells[3].Value.ToString();
                txtStock.Text = dgvListarStock.CurrentRow.Cells[4].Value.ToString();
                ActualizarDgv();
            }
            else
            {
                MessageBox.Show("Seleccione la fila que desea editar");
            }
        }
        /// <summary>
        /// Modifica los campos del producto elegido
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardarEdit_Click(object sender, EventArgs e)
        {
            int.TryParse(txtCodigo.Text, out int codigoParse);
            int.TryParse(txtStock.Text, out int stockParse);
            float.TryParse(txtPrecio.Text, out float precioParse);
            if(!(txtCodigo.Text == ""))
            {
                foreach (Producto item in Shop.listaProductos)
                {
                    if (item.Codigo == codigoParse)
                    {
                        item.Nombre = txtNombre.Text;
                        item.Stock = stockParse;
                        item.Precio = precioParse;
                        lblRespuesta.Text = "Modificacion exitosa";
                        break;
                    }
                }
            }
            else
                MessageBox.Show("Ingrese los datos");

        }
        /// <summary>
        /// Elimina el producto seleccionado de la lista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(dgvListarStock.SelectedRows.Count>0)
            {
                if(MessageBox.Show("Esta seguro de eliminarlo?", "!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int.TryParse(txtCodigo.Text, out int codigoAux);
                    Producto.BajaProducto(codigoAux);
                    lblRespuesta.Text = "Producto eliminado exitosamente";
                }
            }
            else
            {
                MessageBox.Show("Seleccione la fila que desea eliminar");
            }
            ActualizarDgv();
        }

    }
}
