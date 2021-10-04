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
    public partial class FrmListarAdministrador : Form
    {
        Administrador admin;
        public FrmListarAdministrador()
        {
            InitializeComponent();
        }
        private void FrmListarAdministrador_Load(object sender, EventArgs e)
        {
            dgvListarAdmin.DataSource = Shop.listaAdmin;
            admin = new Administrador();
            Limpiar();
        }

        /// <summary>
        /// Agrega un administrador a la lista de admin.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAlta_Click(object sender, EventArgs e)
        {
            SoundPlayer sonido = new SoundPlayer("./Add1.wav");
            int.TryParse(txtAltaDni.Text, out int dniParse);
            if (Validaciones.EsNumericaInt(txtAltaDni.Text) && Validaciones.SoloLetras(txtAltaNombre.Text) && Validaciones.SoloLetras(txtAltaApellido.Text))
            {
                sonido.Play();
                Administrador.AltaAdmin(new Administrador(txtAltaApellido.Text, txtAltaNombre.Text, dniParse));
            }
            else
            {
                MessageBox.Show("Error al ingresar los datos");
            }
            ActualizarDgv();
        }
        /// <summary>
        /// Elimina el administrador seleccionado de la lista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvListarAdmin.SelectedRows.Count > 0)
            {
                txtId.Text = dgvListarAdmin.CurrentRow.Cells[0].Value.ToString();
                txtAltaApellido.Text = dgvListarAdmin.CurrentRow.Cells[1].Value.ToString();
                txtAltaNombre.Text = dgvListarAdmin.CurrentRow.Cells[2].Value.ToString();
                txtAltaDni.Text = dgvListarAdmin.CurrentRow.Cells[3].Value.ToString();
                if(MessageBox.Show("Esta seguro de eliminarlo?", "!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int.TryParse(txtId.Text, out int idAux);
                    admin.Eliminar(idAux);
                    lblRespuesta.Text = "Administrador eliminado exitosamente";
                }
            }
            else
            {
                MessageBox.Show("Seleccione la fila que desea editar");
            }
            ActualizarDgv();
        }

        /// <summary>
        /// Los datos seleccionados de la fila elegida los agrega a los textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvListarAdmin.SelectedRows.Count > 0)
            {
                txtId.Text = dgvListarAdmin.CurrentRow.Cells[0].Value.ToString();
                txtAltaApellido.Text = dgvListarAdmin.CurrentRow.Cells[1].Value.ToString();
                txtAltaNombre.Text = dgvListarAdmin.CurrentRow.Cells[2].Value.ToString();
                txtAltaDni.Text = dgvListarAdmin.CurrentRow.Cells[3].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione la fila que desea editar");
            }
            ActualizarDgv();
        }
        /// <summary>
        /// Modifica los campos del administrador elegido
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardarAlta_Click(object sender, EventArgs e)
        {
            if (!(txtId.Text == ""))
            {
                foreach (Administrador item in Shop.listaAdmin)
                {
                    if (item.Id == int.Parse(txtId.Text))
                    {
                        item.Apellido = txtAltaApellido.Text;
                        item.Nombre = txtAltaNombre.Text;
                        item.Dni = int.Parse(txtAltaDni.Text);
                        lblRespuesta.Text = "Modificacion exitosa";
                        break;
                    }
                }
                ActualizarDgv();
            }
            else
                MessageBox.Show("Ingrese los datos");
        }

        #region Custom
        private void pbHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        /// <summary>
        /// Limpia los campos que contiene el formulario
        /// </summary>
        private void Limpiar()
        {
            txtAltaNombre.Clear();
            txtAltaApellido.Clear();
            txtAltaDni.Clear();
            txtId.Clear();
            lblRespuesta.Text = " ";
        }
        /// <summary>
        /// Actualiza el dataGridView cargando nuevamente la lista
        /// </summary>
        public void ActualizarDgv()
        {
            dgvListarAdmin.DataSource = null;
            dgvListarAdmin.DataSource = Shop.listaAdmin;
        }
        #endregion

        
    }

}
