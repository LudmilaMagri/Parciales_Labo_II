using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using Entidades;

namespace Formularios
{
    public partial class FrmCompra : Form
    {
       // public Compra compras;
        public static Compra sCompras;
        public static Cliente cliente;
        Producto productoSelec;

        public FrmCompra()
        {
            InitializeComponent();
        }



        private void FrmCompra_Load(object sender, EventArgs e)
        {
            this.cmbClientes.DataSource = Shop.listaClientes;
            this.cmbClientes.DisplayMember = "nombre";
            dgvProductos.DataSource = Shop.listaProductos;
            sCompras = new Compra();
            txtId.Text = " ";
            dgvListaCarrito.DataSource = null;
        }


        private void btnComprar_Click(object sender, EventArgs e)
        {
            SoundPlayer sonidoAdd = new SoundPlayer("./ca-ching.wav");
            SoundPlayer sonidoError = new SoundPlayer("./Error.wav");
            if(!(txtId.Text == " "))
            {
                if (Validaciones.SaldoSuficiente(cliente))
                {
                    if (sCompras.CalcularCostoFinal() <= cliente.Saldo)
                    {
                        FrmMostrarCompra fCompra = new FrmMostrarCompra();
                        sonidoAdd.Play();
                        sCompras.IdCliente = cliente.Id;
                        sCompras.DniCliente = cliente.Dni;
                        if (fCompra.ShowDialog() == DialogResult.OK)
                        {
                            cliente.AgregarCompraLista(sCompras);
                            Shop.listaTotalCompras.Add(sCompras);
                            cliente.RestarSaldo(cliente, sCompras);
                            this.DialogResult = DialogResult.OK;
                        }
                    }
                    else
                    {
                        sCompras = new Compra();
                        lblRespuesta.ForeColor = Color.Red;
                        lblRespuesta.Text = "Saldo insuficiente";
                        sonidoError.Play();
                        
                    }
                    ActualizarDgvProducto();
                }
            }
            else
            {
                MessageBox.Show("Ingrese productos a la lista y elija un cliente", "!");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            SoundPlayer sonido = new SoundPlayer("./click.wav");
            if (this.dgvProductos.SelectedRows.Count > 0)
            {
                productoSelec = (Producto)dgvProductos.CurrentRow.DataBoundItem;
               
                if(Validaciones.HayStock(productoSelec))
                {
                    sonido.Play();
                    sCompras.AgregarProductoLista(productoSelec);
                    dgvListaCarrito.Rows.Add(productoSelec.Nombre, productoSelec.Precio);
                    Producto.RestarStock(productoSelec);
                }
                else
                {
                    MessageBox.Show("¡Lo siento, no hay mas stock de ese producto!", ":(");
                }
                ActualizarDgvProducto();
            }
            else
            {
                MessageBox.Show("Seleccione la fila del item que quiere agregar", "!");
            }
        }

        private void btnAceptarCliente_Click(object sender, EventArgs e)
        {
            cliente = new Cliente();
            cliente = (Cliente)cmbClientes.SelectedItem;
            txtId.Text = cliente.Id.ToString();
            cmbClientes.Enabled = false;
            txtId.Enabled = false;
        }

        private void ActualizarDgvProducto()
        {
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = Shop.listaProductos;
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void Limpiar()
        {
            txtId.Clear();
            cmbClientes.Enabled = true;
            dgvListaCarrito.Rows.Clear();
            lblRespuesta.Text = " ";
        }

        private void pbHome_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
