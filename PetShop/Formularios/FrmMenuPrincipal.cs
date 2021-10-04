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
    public partial class FrmMenuPrincipal : Form
    {
        Timer timer = new Timer();
        public FrmMenuPrincipal()
        {
            InitializeComponent();
            
        }
        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            CargarDatos.CargarClientes();
            CargarDatos.CargarEmpleados();
            CargarDatos.CargarAdministrador();
            CargarDatos.CargarProductos();
          // CargarTimer();
        }
        #region Custom MenuPrincipal
        
        /// <summary>
        /// Abre un form de manera generica y lo personaliza.
        /// </summary>
        /// <typeparam name="FormGenerico"></typeparam>
        private void AbrirFrm<FormGenerico>() where FormGenerico : Form, new() //instancia un nuevo form llamando al constructor
        {
            Form f;
            f = pnlFrmMenuPrincipal.Controls.OfType<FormGenerico>().FirstOrDefault();
            if (f == null)
            {
                f = new FormGenerico();
                f.TopLevel = false;
                f.Dock = DockStyle.Fill;
                f.FormBorderStyle = FormBorderStyle.None;
                pnlFrmMenuPrincipal.Controls.Add(f);
                pnlFrmMenuPrincipal.Tag = f;
                f.Show();
                f.BringToFront();
            }
            else
            {
                f.BringToFront();
            }
        }
        /// <summary>
        /// Cierra el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Miniminiza el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        /// <summary>
        /// Sale de la sesion 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        #endregion
        private void tmrMenu_Tick(object sender, EventArgs e)
        {
            lblReloj.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void btnClientes_Click_1(object sender, EventArgs e)
        {
            AbrirFrm<FrmListarClientes>();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            AbrirFrm<FrmListarEmpleado>();
        }

        private void btnAdministradores_Click(object sender, EventArgs e)
        {
            AbrirFrm<FrmListarAdministrador>();
        }

        private void btnStock_Click_1(object sender, EventArgs e)
        {
            AbrirFrm<FrmListarStock>();
        }

       
        private void btnMostrarVentas_Click(object sender, EventArgs e)
        {
            AbrirFrm<FrmMostrarVentas>();
        }

        private void pbVenta_Click(object sender, EventArgs e)
        {
            FrmCompra fCompra = new FrmCompra();
            if (fCompra.ShowDialog() == DialogResult.OK)
            {
                this.BringToFront();
            }
        }

        private void FrmMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if((MessageBox.Show("¿Está seguro de querer salir ? ","Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No))
            {
                e.Cancel = true;
            }
        }

       
    }
}
