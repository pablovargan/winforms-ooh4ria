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
            this.busquedaBox = new System.Windows.Forms.TextBox();
            this.buscarComboBox = new System.Windows.Forms.ComboBox();
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
            this.proveedoresGB.AutoSize = true;
            this.proveedoresGB.Controls.Add(this.busquedaBox);
            this.proveedoresGB.Controls.Add(this.buscarComboBox);
            this.proveedoresGB.Controls.Add(this.proveedorGrid);
            this.proveedoresGB.Location = new System.Drawing.Point(16, 15);
            this.proveedoresGB.Margin = new System.Windows.Forms.Padding(4);
            this.proveedoresGB.Name = "proveedoresGB";
            this.proveedoresGB.Padding = new System.Windows.Forms.Padding(4);
            this.proveedoresGB.Size = new System.Drawing.Size(760, 430);
            this.proveedoresGB.TabIndex = 11;
            this.proveedoresGB.TabStop = false;
            this.proveedoresGB.Text = "Proveedores";
            // 
            // busquedaBox
            // 
            this.busquedaBox.Location = new System.Drawing.Point(154, 25);
            this.busquedaBox.Name = "busquedaBox";
            this.busquedaBox.Size = new System.Drawing.Size(599, 22);
            this.busquedaBox.TabIndex = 2;
            this.busquedaBox.Text = "Introduzca el término a buscar";
            this.busquedaBox.Click += new System.EventHandler(this.Buscador_Click);
            this.busquedaBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.busquedaBox_KeyUp);
            // 
            // buscarComboBox
            // 
            this.buscarComboBox.FormattingEnabled = true;
            this.buscarComboBox.Items.AddRange(new object[] {
            "Id",
            "Localidad",
            "Nombre",
            "Provincia"});
            this.buscarComboBox.Location = new System.Drawing.Point(8, 23);
            this.buscarComboBox.Name = "buscarComboBox";
            this.buscarComboBox.Size = new System.Drawing.Size(140, 24);
            this.buscarComboBox.TabIndex = 3;
            this.buscarComboBox.Text = "Buscar por...";
            // 
            // proveedorGrid
            // 
            this.proveedorGrid.AllowUserToOrderColumns = true;
            this.proveedorGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.proveedorGrid.Location = new System.Drawing.Point(8, 55);
            this.proveedorGrid.Margin = new System.Windows.Forms.Padding(4);
            this.proveedorGrid.Name = "proveedorGrid";
            this.proveedorGrid.RowTemplate.Height = 24;
            this.proveedorGrid.Size = new System.Drawing.Size(744, 367);
            this.proveedorGrid.TabIndex = 0;
            // 
            // accionesGB
            // 
            this.accionesGB.Controls.Add(this.altaButton);
            this.accionesGB.Location = new System.Drawing.Point(783, 15);
            this.accionesGB.Name = "accionesGB";
            this.accionesGB.Size = new System.Drawing.Size(216, 430);
            this.accionesGB.TabIndex = 12;
            this.accionesGB.TabStop = false;
            this.accionesGB.Text = "Acciones";
            // 
            // altaButton
            // 
            this.altaButton.Location = new System.Drawing.Point(7, 22);
            this.altaButton.Name = "altaButton";
            this.altaButton.Size = new System.Drawing.Size(203, 56);
            this.altaButton.TabIndex = 0;
            this.altaButton.Text = "Dar de Alta";
            this.altaButton.UseVisualStyleBackColor = true;
            this.altaButton.Click += new System.EventHandler(this.AltaProveedor_Click);
            // 
            // PantallaProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 459);
            this.ControlBox = false;
            this.Controls.Add(this.accionesGB);
            this.Controls.Add(this.proveedoresGB);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PantallaProveedor";
            this.ShowIcon = false;
            this.Text = "PantallaProveedores";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.proveedoresGB.ResumeLayout(false);
            this.proveedoresGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorGrid)).EndInit();
            this.accionesGB.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox proveedoresGB;
        private System.Windows.Forms.DataGridView proveedorGrid;
        private System.Windows.Forms.GroupBox accionesGB;
        private System.Windows.Forms.Button altaButton;
        private System.Windows.Forms.ComboBox buscarComboBox;
        private System.Windows.Forms.TextBox busquedaBox;
    }
}