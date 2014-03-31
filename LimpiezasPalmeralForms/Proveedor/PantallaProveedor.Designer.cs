namespace LimpiezasPalmeralForms
{
    partial class PantallaProveedor
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
            this.proveedoresGB = new System.Windows.Forms.GroupBox();
            this.Buscar = new System.Windows.Forms.Button();
            this.busquedaBox = new System.Windows.Forms.TextBox();
            this.proveedorGrid = new System.Windows.Forms.DataGridView();
            this.accionesGB = new System.Windows.Forms.GroupBox();
            this.altaButton = new System.Windows.Forms.Button();
            this.proveedoresGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorGrid)).BeginInit();
            this.accionesGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // proveedoresGB
            // 
            this.proveedoresGB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.proveedoresGB.Controls.Add(this.Buscar);
            this.proveedoresGB.Controls.Add(this.busquedaBox);
            this.proveedoresGB.Controls.Add(this.proveedorGrid);
            this.proveedoresGB.Location = new System.Drawing.Point(12, 12);
            this.proveedoresGB.Name = "proveedoresGB";
            this.proveedoresGB.Size = new System.Drawing.Size(571, 381);
            this.proveedoresGB.TabIndex = 11;
            this.proveedoresGB.TabStop = false;
            this.proveedoresGB.Text = "Proveedores";
            // 
            // Buscar
            // 
            this.Buscar.Location = new System.Drawing.Point(90, 16);
            this.Buscar.Margin = new System.Windows.Forms.Padding(2);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(82, 23);
            this.Buscar.TabIndex = 3;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // busquedaBox
            // 
            this.busquedaBox.Location = new System.Drawing.Point(6, 19);
            this.busquedaBox.Margin = new System.Windows.Forms.Padding(2);
            this.busquedaBox.Name = "busquedaBox";
            this.busquedaBox.Size = new System.Drawing.Size(80, 20);
            this.busquedaBox.TabIndex = 2;
            this.busquedaBox.Text = "NIF";
            this.busquedaBox.Click += new System.EventHandler(this.Buscador_Click);
            // 
            // proveedorGrid
            // 
            this.proveedorGrid.AllowUserToAddRows = false;
            this.proveedorGrid.AllowUserToDeleteRows = false;
            this.proveedorGrid.AllowUserToResizeColumns = false;
            this.proveedorGrid.AllowUserToResizeRows = false;
            this.proveedorGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.proveedorGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.proveedorGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.proveedorGrid.Location = new System.Drawing.Point(6, 45);
            this.proveedorGrid.Name = "proveedorGrid";
            this.proveedorGrid.ReadOnly = true;
            this.proveedorGrid.RowTemplate.Height = 24;
            this.proveedorGrid.Size = new System.Drawing.Size(558, 330);
            this.proveedorGrid.TabIndex = 0;
            // 
            // accionesGB
            // 
            this.accionesGB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.accionesGB.Controls.Add(this.altaButton);
            this.accionesGB.Location = new System.Drawing.Point(588, 12);
            this.accionesGB.Margin = new System.Windows.Forms.Padding(2);
            this.accionesGB.Name = "accionesGB";
            this.accionesGB.Padding = new System.Windows.Forms.Padding(2);
            this.accionesGB.Size = new System.Drawing.Size(161, 381);
            this.accionesGB.TabIndex = 12;
            this.accionesGB.TabStop = false;
            this.accionesGB.Text = "Acciones";
            // 
            // altaButton
            // 
            this.altaButton.Location = new System.Drawing.Point(5, 18);
            this.altaButton.Margin = new System.Windows.Forms.Padding(2);
            this.altaButton.Name = "altaButton";
            this.altaButton.Size = new System.Drawing.Size(152, 46);
            this.altaButton.TabIndex = 0;
            this.altaButton.Text = "Dar de Alta";
            this.altaButton.UseVisualStyleBackColor = true;
            this.altaButton.Click += new System.EventHandler(this.AltaProveedor_Click);
            // 
            // PantallaProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 405);
            this.ControlBox = false;
            this.Controls.Add(this.accionesGB);
            this.Controls.Add(this.proveedoresGB);
            this.Name = "PantallaProveedor";
            this.ShowIcon = false;
            this.Text = "PantallaProveedores";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.proveedoresGB.ResumeLayout(false);
            this.proveedoresGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorGrid)).EndInit();
            this.accionesGB.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox proveedoresGB;
        private System.Windows.Forms.DataGridView proveedorGrid;
        private System.Windows.Forms.GroupBox accionesGB;
        private System.Windows.Forms.Button altaButton;
        private System.Windows.Forms.TextBox busquedaBox;
        private System.Windows.Forms.Button Buscar;
    }
}