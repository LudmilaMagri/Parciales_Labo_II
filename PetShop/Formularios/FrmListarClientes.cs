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
    public partial class FrmListarClientes : Form
    {
        Cliente cliente;
        public FrmListarClientes()
        {
            InitializeComponent();
            dgvListarClientes.DataSource = Shop.listaClientes;
        }
        private void FrmListarClientes_Load(object sender, EventArgs e)
        {
            Limpiar();
            cliente = new Cliente();
        }

        /// <summary>
        /// Agrega un cliente a la lista de clientes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAlta_Click(object sender, EventArgs e)
        {
            SoundPlayer sonido = new SoundPlayer("./Add1.wav");
            int.TryParse(txtDni.Text, out int dniParse);
            float.TryParse(txtSaldo.Text, out float saldoParse);

            if (Validaciones.EsNumericaInt(txtDni.Text) && Validaciones.SoloLetras(txtNombre.Text) && Validaciones.SoloLetras(txtApellido.Text))
            {
                sonido.Play();
                Cliente.AltaCliente(new Cliente(txtApellido.Text, txtNombre.Text, dniParse, txtDireccion.Text, saldoParse));
                lblRespuesta.Text = "Cliente agregado";
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
            if (dgvListarClientes.SelectedRows.Count > 0)
            {
                txtId.Text = dgvListarClientes.CurrentRow.Cells[0].Value.ToString();
                txtDireccion.Text = dgvListarClientes.CurrentRow.Cells[1].Value.ToString();
                txtSaldo.Text = dgvListarClientes.CurrentRow.Cells[2].Value.ToString();
                txtApellido.Text = dgvListarClientes.CurrentRow.Cells[3].Value.ToString();
                txtNombre.Text = dgvListarClientes.CurrentRow.Cells[4].Value.ToString();
                txtDni.Text = dgvListarClientes.CurrentRow.Cells[5].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione la fila que desea editar");
            }
        }
        /// <summary>
        /// Modifica los campos del cliente elegido
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardarEdit_Click(object sender, EventArgs e)
        {
            if (!(txtId.Text == ""))
            {
                foreach (Cliente item in Shop.listaClientes)
                {
                    if (item.Id == int.Parse(txtId.Text))
                    {
                        item.Apellido = txtApellido.Text;
                        item.Nombre = txtNombre.Text;
                        item.Dni = int.Parse(txtDni.Text);
                        item.Direccion = txtDireccion.Text;
                        item.Saldo = float.Parse(txtSaldo.Text);
                        lblRespuesta.Text = "Modificacion exitosa";
                        break;
                    }
                }
                ActualizarDgv();
            }
            else
                MessageBox.Show("Ingrese los datos");
            
        }
       
        /// <summary>
        /// Elimina el cliente seleccionado de la lista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvListarClientes.SelectedRows.Count > 0)
            {
                txtId.Text = dgvListarClientes.CurrentRow.Cells[0].Value.ToString();
                txtDireccion.Text = dgvListarClientes.CurrentRow.Cells[1].Value.ToString();
                txtSaldo.Text = dgvListarClientes.CurrentRow.Cells[2].Value.ToString();
                txtApellido.Text = dgvListarClientes.CurrentRow.Cells[3].Value.ToString();
                txtNombre.Text = dgvListarClientes.CurrentRow.Cells[4].Value.ToString();
                txtDni.Text = dgvListarClientes.CurrentRow.Cells[5].Value.ToString();
                if (MessageBox.Show("Esta seguro de eliminarlo?", "!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int.TryParse(txtId.Text, out int idAux);
                    cliente.Eliminar(idAux);
                    lblRespuesta.Text = "Cliente eliminado exitosamente";
                }
            }
            else
            {
                MessageBox.Show("Seleccione la fila que desea eliminar");
            }
            ActualizarDgv();
        }

        #region Custom
        /// <summary>
        /// Actualiza el dataGridView cargando nuevamente la lista
        /// </summary>
        public void ActualizarDgv()
        {
            dgvListarClientes.DataSource = null;
            dgvListarClientes.DataSource = Shop.listaClientes;
        }
        /// <summary>
        /// Limpia los campos que contiene el formulario
        /// </summary>
        private void Limpiar()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtDni.Clear();
            txtDireccion.Clear();
            txtId.Clear();
            txtSaldo.Clear();
            lblRespuesta.Text = " ";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void pbHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        #endregion

    }
}
