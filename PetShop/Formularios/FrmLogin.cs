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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            CargarDatos.CargarUsuariosAdmin();
            CargarDatos.CargarUsuariosEmpleado();
            CargarDatos.CargarContraseñasAdmin();
            CargarDatos.CargarContraseñasEmpleado();
            cmbUsuario.Items.Add("Administrador");
            cmbUsuario.Items.Add("Empleado");
        }
      
        /// <summary>
        /// Comprueba si el usuario y la contraseña coinciden para poder loguearse.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int.TryParse(txtContraseña.Text, out int contraseña);
            if (cmbUsuario.Text == "Administrador")
            {
                if (Shop.usuarioAdmin.TryGetValue(contraseña, out string usuario))
                {
                    if (usuario == this.txtUsuario.Text)
                    {
                        FrmMenuPrincipal frmPrincipal = new FrmMenuPrincipal();
                        if (frmPrincipal.ShowDialog() == DialogResult.OK)
                        {
                            this.BringToFront();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Contraseña incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            else
            {
                if (Shop.usuarioEmpleado.TryGetValue(contraseña, out string usuario))
                {
                    if (usuario == this.txtUsuario.Text)
                    {
                        FrmMenuEmpleado frmEmpleado = new FrmMenuEmpleado();
                        if (frmEmpleado.ShowDialog() == DialogResult.OK)
                        {
                            this.BringToFront();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Contraseña incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }

        /// <summary>
        /// Genera un numero random que sera el indice de una lista y asi traer el usuario 
        /// para poder loguearse automaticamente.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAutoLogin_Click(object sender, EventArgs e)
        {
            Random aleatorio = new Random();
            int numeroAleatorio;
            int retorno;
            if (cmbUsuario.Text == "Administrador")
            {
                numeroAleatorio = aleatorio.Next(0, 3);
                retorno = Shop.listaContraseñasAdmin.ElementAt(numeroAleatorio);
                txtContraseña.Text = retorno.ToString();
                foreach (KeyValuePair<int, string> item in Shop.usuarioAdmin)
                {
                    if (retorno == item.Key)
                    {
                        txtUsuario.Text = item.Value;
                    }
                }
            }
            else
            {
                numeroAleatorio = aleatorio.Next(0, 2);
                retorno = Shop.listaContraseñasEmpleado.ElementAt(numeroAleatorio);
                txtContraseña.Text = retorno.ToString();
                foreach (KeyValuePair<int, string> item in Shop.usuarioEmpleado)
                {
                    if (retorno == item.Key)
                    {
                        txtUsuario.Text = item.Value;
                    }
                }
            }
        }
      /// <summary>
      /// Cierra el login
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Miniminiza el login
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
