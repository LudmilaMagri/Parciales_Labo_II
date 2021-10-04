
namespace Formularios
{
    partial class FrmMostrarCompra
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvMostrar = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCarrito = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnAceptarCompra = new System.Windows.Forms.Button();
            this.lblPrecioFinal = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblResumen = new System.Windows.Forms.Label();
            this.lblDatos = new System.Windows.Forms.Label();
            this.btnTxt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMostrar
            // 
            this.dgvMostrar.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvMostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrar.Location = new System.Drawing.Point(51, 112);
            this.dgvMostrar.Name = "dgvMostrar";
            this.dgvMostrar.ReadOnly = true;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(223)))), ((int)(((byte)(205)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvMostrar.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMostrar.RowTemplate.Height = 25;
            this.dgvMostrar.Size = new System.Drawing.Size(391, 220);
            this.dgvMostrar.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(154)))), ((int)(((byte)(188)))));
            this.panel1.Controls.Add(this.lblCarrito);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(777, 48);
            this.panel1.TabIndex = 1;
            // 
            // lblCarrito
            // 
            this.lblCarrito.AutoSize = true;
            this.lblCarrito.Font = new System.Drawing.Font("Lucida Handwriting", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCarrito.Location = new System.Drawing.Point(136, 7);
            this.lblCarrito.Name = "lblCarrito";
            this.lblCarrito.Size = new System.Drawing.Size(443, 41);
            this.lblCarrito.TabIndex = 0;
            this.lblCarrito.Text = "¡Gracias por su compra!";
            this.lblCarrito.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(154)))), ((int)(((byte)(188)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(16, 488);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(154)))), ((int)(((byte)(188)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(760, 48);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(17, 488);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(154)))), ((int)(((byte)(188)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(16, 521);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(744, 15);
            this.panel4.TabIndex = 3;
            // 
            // btnAceptarCompra
            // 
            this.btnAceptarCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(171)))), ((int)(((byte)(218)))));
            this.btnAceptarCompra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Plum;
            this.btnAceptarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptarCompra.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAceptarCompra.Location = new System.Drawing.Point(77, 447);
            this.btnAceptarCompra.Name = "btnAceptarCompra";
            this.btnAceptarCompra.Size = new System.Drawing.Size(134, 30);
            this.btnAceptarCompra.TabIndex = 4;
            this.btnAceptarCompra.Text = "Aceptar";
            this.btnAceptarCompra.UseVisualStyleBackColor = false;
            this.btnAceptarCompra.Click += new System.EventHandler(this.btnAceptarCompra_Click);
            // 
            // lblPrecioFinal
            // 
            this.lblPrecioFinal.AutoSize = true;
            this.lblPrecioFinal.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPrecioFinal.Location = new System.Drawing.Point(71, 369);
            this.lblPrecioFinal.Name = "lblPrecioFinal";
            this.lblPrecioFinal.Size = new System.Drawing.Size(140, 25);
            this.lblPrecioFinal.TabIndex = 5;
            this.lblPrecioFinal.Text = "Precio final: ";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPrecio.Location = new System.Drawing.Point(217, 369);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(25, 25);
            this.lblPrecio.TabIndex = 6;
            this.lblPrecio.Text = "$";
            // 
            // lblResumen
            // 
            this.lblResumen.AutoSize = true;
            this.lblResumen.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblResumen.Location = new System.Drawing.Point(51, 84);
            this.lblResumen.Name = "lblResumen";
            this.lblResumen.Size = new System.Drawing.Size(105, 25);
            this.lblResumen.TabIndex = 8;
            this.lblResumen.Text = "Resumen";
            // 
            // lblDatos
            // 
            this.lblDatos.AutoSize = true;
            this.lblDatos.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDatos.Location = new System.Drawing.Point(503, 112);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(0, 18);
            this.lblDatos.TabIndex = 10;
            // 
            // btnTxt
            // 
            this.btnTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(171)))), ((int)(((byte)(218)))));
            this.btnTxt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Plum;
            this.btnTxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTxt.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTxt.Location = new System.Drawing.Point(274, 447);
            this.btnTxt.Name = "btnTxt";
            this.btnTxt.Size = new System.Drawing.Size(134, 30);
            this.btnTxt.TabIndex = 11;
            this.btnTxt.Text = "Descargar Factura";
            this.btnTxt.UseVisualStyleBackColor = false;
            this.btnTxt.Click += new System.EventHandler(this.btnTxt_Click);
            // 
            // FrmMostrarCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 536);
            this.Controls.Add(this.btnTxt);
            this.Controls.Add(this.lblDatos);
            this.Controls.Add(this.lblResumen);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblPrecioFinal);
            this.Controls.Add(this.btnAceptarCompra);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvMostrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMostrarCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "s";
            this.Load += new System.EventHandler(this.FrmMostrarCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnAceptarCompra;
        private System.Windows.Forms.Label lblPrecioFinal;
        public System.Windows.Forms.DataGridView dgvMostrar;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblCarrito;
        private System.Windows.Forms.Label lblResumen;
        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.Button btnTxt;
    }
}