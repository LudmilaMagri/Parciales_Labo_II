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
    public partial class FrmListarEmpleado : Form
    {
        Empleado empleado;
        public FrmListarEmpleado()
        {
            InitializeComponent();
            dgvListarEmpleados.DataSource = Shop.listaEmpleado;
        }
        private void FrmListarEmpleado_Load(object sender, EventArgs e)
        {
            Limpiar();
            empleado = new Empleado();
        }
        /// <summary>
        /// Agrega un empleado a la lista de empleados.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAlta_Click_1(object sender, EventArgs e)
        {
            SoundPlayer sonido = new SoundPlayer("./Add1.wav");
            int.TryParse(txtDni.Text, out int dniParse);
            double.TryParse(txtSueldo.Text, out double sueldoParse);
            if (Validaciones.EsNumericaInt(txtDni.Text) && Validaciones.SoloLetras(txtNombre.Text) && Validaciones.SoloLetras(txtApellido.Text)
                && Validaciones.EsNumerica(txtSueldo.Text))
            {
                sonido.Play();
                Empleado.AltaEmpleado(new Empleado(txtApellido.Text, txtNombre.Text, dniParse, sueldoParse));
                lblRespuesta.Text = "Empleado agregado";
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
        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            if (dgvListarEmpleados.SelectedRows.Count > 0)
            {
                txtId.Text = dgvListarEmpleados.CurrentRow.Cells[0].Value.ToString();
                txtSueldo.Text = dgvListarEmpleados.CurrentRow.Cells[1].Value.ToString();
                txtApellido.Text = dgvListarEmpleados.CurrentRow.Cells[2].Value.ToString();
                txtNombre.Text = dgvListarEmpleados.CurrentRow.Cells[3].Value.ToString();
                txtDni.Text = dgvListarEmpleados.CurrentRow.Cells[4].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione la fila que desea editar");
            }
        }
        /// <summary>
        /// Modifica los campos del empleado elegido
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardarEdit_Click(object sender, EventArgs e)
        {
            if (!(txtId.Text == ""))
            {
                foreach (Empleado item in Shop.listaEmpleado)
                {
                    if (item.Id == int.Parse(txtId.Text))
                    {
                        item.Apellido = txtApellido.Text;
                        item.Nombre = txtNombre.Text;
                        item.Dni = int.Parse(txtDni.Text);
                        item.Sueldo = float.Parse(txtSueldo.Text);
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
        /// Elimina el empleado seleccionado de la lista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (dgvListarEmpleados.SelectedRows.Count > 0)
            {
                txtSueldo.Text = dgvListarEmpleados.CurrentRow.Cells[0].Value.ToString();
                txtId.Text = dgvListarEmpleados.CurrentRow.Cells[1].Value.ToString();
                txtApellido.Text = dgvListarEmpleados.CurrentRow.Cells[2].Value.ToString();
                txtNombre.Text = dgvListarEmpleados.CurrentRow.Cells[3].Value.ToString();
                txtDni.Text = dgvListarEmpleados.CurrentRow.Cells[4].Value.ToString();
                if (MessageBox.Show("Esta seguro de eliminarlo?", "!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int.TryParse(txtId.Text, out int idAux);
                    empleado.Eliminar(idAux);
                    lblRespuesta.Text = "Cliente eliminado exitosamente";
                }
            }
            else
            {
                MessageBox.Show("Seleccione la fila que desea editar");
            }
            ActualizarDgv();
        }

        #region Custom

        /// <summary>
        /// Actualiza el dataGridView cargando nuevamente la lista
        /// </summary>
        public void ActualizarDgv()
        {
            dgvListarEmpleados.DataSource = null;
            dgvListarEmpleados.DataSource = Shop.listaEmpleado;
        }
        /// <summary>
        /// Limpia los campos que contiene el formulario
        /// </summary>
        private void Limpiar()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtDni.Clear();
            txtSueldo.Clear();
            txtId.Clear();
            lblRespuesta.Text = " ";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion


    }
}
