namespace LimpiezasPalmeralForms
{
    partial class ConsultarInstalacion
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
            this.accionesGB = new System.Windows.Forms.GroupBox();
            this.aceptarButton = new System.Windows.Forms.Button();
            this.proveedorGB = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.clienteBox = new System.Windows.Forms.TextBox();
            this.m2Box = new System.Windows.Forms.TextBox();
            this.descripcionBox = new System.Windows.Forms.TextBox();
            this.descripcionLabel = new System.Windows.Forms.Label();
            this.paisBox = new System.Windows.Forms.TextBox();
            this.paisLabel = new System.Windows.Forms.Label();
            this.codigoPostalBox = new System.Windows.Forms.TextBox();
            this.codigoPostalLabel = new System.Windows.Forms.Label();
            this.telefonoBox = new System.Windows.Forms.TextBox();
            this.telefonoLabel = new System.Windows.Forms.Label();
            this.provinciaBox = new System.Windows.Forms.TextBox();
            this.provinciaLabel = new System.Windows.Forms.Label();
            this.localidadBox = new System.Windows.Forms.TextBox();
            this.localidadLabel = new System.Windows.Forms.Label();
            this.direccionBox = new System.Windows.Forms.TextBox();
            this.direccionLabel = new System.Windows.Forms.Label();
            this.nombreBox = new System.Windows.Forms.TextBox();
            this.nombreLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.idBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gridTrabajadores = new System.Windows.Forms.DataGridView();
            this.accionesGB.SuspendLayout();
            this.proveedorGB.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTrabajadores)).BeginInit();
            this.SuspendLayout();
            // 
            // accionesGB
            // 
            this.accionesGB.Controls.Add(this.aceptarButton);
            this.accionesGB.Location = new System.Drawing.Point(12, 457);
            this.accionesGB.Name = "accionesGB";
            this.accionesGB.Size = new System.Drawing.Size(449, 74);
            this.accionesGB.TabIndex = 4;
            this.accionesGB.TabStop = false;
            this.accionesGB.Text = "Acciones";
            // 
            // aceptarButton
            // 
            this.aceptarButton.Location = new System.Drawing.Point(6, 19);
            this.aceptarButton.Name = "aceptarButton";
            this.aceptarButton.Size = new System.Drawing.Size(437, 44);
            this.aceptarButton.TabIndex = 1;
            this.aceptarButton.Text = "Salir";
            this.aceptarButton.UseVisualStyleBackColor = true;
            this.aceptarButton.Click += new System.EventHandler(this.aceptarButton_Click);
            // 
            // proveedorGB
            // 
            this.proveedorGB.Controls.Add(this.label2);
            this.proveedorGB.Controls.Add(this.label1);
            this.proveedorGB.Controls.Add(this.clienteBox);
            this.proveedorGB.Controls.Add(this.m2Box);
            this.proveedorGB.Controls.Add(this.descripcionBox);
            this.proveedorGB.Controls.Add(this.descripcionLabel);
            this.proveedorGB.Controls.Add(this.paisBox);
            this.proveedorGB.Controls.Add(this.paisLabel);
            this.proveedorGB.Controls.Add(this.codigoPostalBox);
            this.proveedorGB.Controls.Add(this.codigoPostalLabel);
            this.proveedorGB.Controls.Add(this.telefonoBox);
            this.proveedorGB.Controls.Add(this.telefonoLabel);
            this.proveedorGB.Controls.Add(this.provinciaBox);
            this.proveedorGB.Controls.Add(this.provinciaLabel);
            this.proveedorGB.Controls.Add(this.localidadBox);
            this.proveedorGB.Controls.Add(this.localidadLabel);
            this.proveedorGB.Controls.Add(this.direccionBox);
            this.proveedorGB.Controls.Add(this.direccionLabel);
            this.proveedorGB.Controls.Add(this.nombreBox);
            this.proveedorGB.Controls.Add(this.nombreLabel);
            this.proveedorGB.Controls.Add(this.idLabel);
            this.proveedorGB.Controls.Add(this.idBox);
            this.proveedorGB.Location = new System.Drawing.Point(12, 12);
            this.proveedorGB.Name = "proveedorGB";
            this.proveedorGB.Size = new System.Drawing.Size(449, 256);
            this.proveedorGB.TabIndex = 3;
            this.proveedorGB.TabStop = false;
            this.proveedorGB.Text = "Instalación";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(235, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Metros cuadrados";
            // 
            // clienteBox
            // 
            this.clienteBox.Location = new System.Drawing.Point(328, 94);
            this.clienteBox.Margin = new System.Windows.Forms.Padding(2);
            this.clienteBox.Name = "clienteBox";
            this.clienteBox.ReadOnly = true;
            this.clienteBox.Size = new System.Drawing.Size(98, 20);
            this.clienteBox.TabIndex = 22;
            // 
            // m2Box
            // 
            this.m2Box.Location = new System.Drawing.Point(328, 62);
            this.m2Box.Margin = new System.Windows.Forms.Padding(2);
            this.m2Box.Name = "m2Box";
            this.m2Box.ReadOnly = true;
            this.m2Box.Size = new System.Drawing.Size(98, 20);
            this.m2Box.TabIndex = 21;
            // 
            // descripcionBox
            // 
            this.descripcionBox.Location = new System.Drawing.Point(238, 143);
            this.descripcionBox.Margin = new System.Windows.Forms.Padding(2);
            this.descripcionBox.Multiline = true;
            this.descripcionBox.Name = "descripcionBox";
            this.descripcionBox.ReadOnly = true;
            this.descripcionBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descripcionBox.Size = new System.Drawing.Size(188, 99);
            this.descripcionBox.TabIndex = 20;
            // 
            // descripcionLabel
            // 
            this.descripcionLabel.AutoSize = true;
            this.descripcionLabel.Location = new System.Drawing.Point(235, 128);
            this.descripcionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.descripcionLabel.Name = "descripcionLabel";
            this.descripcionLabel.Size = new System.Drawing.Size(63, 13);
            this.descripcionLabel.TabIndex = 16;
            this.descripcionLabel.Text = "Descripción";
            // 
            // paisBox
            // 
            this.paisBox.Location = new System.Drawing.Point(104, 190);
            this.paisBox.Margin = new System.Windows.Forms.Padding(2);
            this.paisBox.Name = "paisBox";
            this.paisBox.ReadOnly = true;
            this.paisBox.Size = new System.Drawing.Size(98, 20);
            this.paisBox.TabIndex = 19;
            // 
            // paisLabel
            // 
            this.paisLabel.AutoSize = true;
            this.paisLabel.Location = new System.Drawing.Point(20, 193);
            this.paisLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.paisLabel.Name = "paisLabel";
            this.paisLabel.Size = new System.Drawing.Size(29, 13);
            this.paisLabel.TabIndex = 13;
            this.paisLabel.Text = "País";
            // 
            // codigoPostalBox
            // 
            this.codigoPostalBox.Location = new System.Drawing.Point(104, 222);
            this.codigoPostalBox.Margin = new System.Windows.Forms.Padding(2);
            this.codigoPostalBox.Name = "codigoPostalBox";
            this.codigoPostalBox.ReadOnly = true;
            this.codigoPostalBox.Size = new System.Drawing.Size(98, 20);
            this.codigoPostalBox.TabIndex = 15;
            // 
            // codigoPostalLabel
            // 
            this.codigoPostalLabel.AutoSize = true;
            this.codigoPostalLabel.Location = new System.Drawing.Point(20, 225);
            this.codigoPostalLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.codigoPostalLabel.Name = "codigoPostalLabel";
            this.codigoPostalLabel.Size = new System.Drawing.Size(72, 13);
            this.codigoPostalLabel.TabIndex = 12;
            this.codigoPostalLabel.Text = "Código Postal";
            // 
            // telefonoBox
            // 
            this.telefonoBox.Location = new System.Drawing.Point(328, 29);
            this.telefonoBox.Margin = new System.Windows.Forms.Padding(2);
            this.telefonoBox.Name = "telefonoBox";
            this.telefonoBox.ReadOnly = true;
            this.telefonoBox.Size = new System.Drawing.Size(98, 20);
            this.telefonoBox.TabIndex = 14;
            // 
            // telefonoLabel
            // 
            this.telefonoLabel.AutoSize = true;
            this.telefonoLabel.Location = new System.Drawing.Point(237, 30);
            this.telefonoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.telefonoLabel.Name = "telefonoLabel";
            this.telefonoLabel.Size = new System.Drawing.Size(49, 13);
            this.telefonoLabel.TabIndex = 18;
            this.telefonoLabel.Text = "Teléfono";
            // 
            // provinciaBox
            // 
            this.provinciaBox.Location = new System.Drawing.Point(104, 157);
            this.provinciaBox.Margin = new System.Windows.Forms.Padding(2);
            this.provinciaBox.Name = "provinciaBox";
            this.provinciaBox.ReadOnly = true;
            this.provinciaBox.Size = new System.Drawing.Size(98, 20);
            this.provinciaBox.TabIndex = 11;
            // 
            // provinciaLabel
            // 
            this.provinciaLabel.AutoSize = true;
            this.provinciaLabel.Location = new System.Drawing.Point(20, 160);
            this.provinciaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.provinciaLabel.Name = "provinciaLabel";
            this.provinciaLabel.Size = new System.Drawing.Size(51, 13);
            this.provinciaLabel.TabIndex = 5;
            this.provinciaLabel.Text = "Provincia";
            // 
            // localidadBox
            // 
            this.localidadBox.Location = new System.Drawing.Point(104, 125);
            this.localidadBox.Margin = new System.Windows.Forms.Padding(2);
            this.localidadBox.Name = "localidadBox";
            this.localidadBox.ReadOnly = true;
            this.localidadBox.Size = new System.Drawing.Size(98, 20);
            this.localidadBox.TabIndex = 10;
            // 
            // localidadLabel
            // 
            this.localidadLabel.AutoSize = true;
            this.localidadLabel.Location = new System.Drawing.Point(20, 128);
            this.localidadLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.localidadLabel.Name = "localidadLabel";
            this.localidadLabel.Size = new System.Drawing.Size(53, 13);
            this.localidadLabel.TabIndex = 4;
            this.localidadLabel.Text = "Localidad";
            // 
            // direccionBox
            // 
            this.direccionBox.Location = new System.Drawing.Point(104, 94);
            this.direccionBox.Margin = new System.Windows.Forms.Padding(2);
            this.direccionBox.Name = "direccionBox";
            this.direccionBox.ReadOnly = true;
            this.direccionBox.Size = new System.Drawing.Size(98, 20);
            this.direccionBox.TabIndex = 9;
            // 
            // direccionLabel
            // 
            this.direccionLabel.AutoSize = true;
            this.direccionLabel.Location = new System.Drawing.Point(20, 97);
            this.direccionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.direccionLabel.Name = "direccionLabel";
            this.direccionLabel.Size = new System.Drawing.Size(52, 13);
            this.direccionLabel.TabIndex = 3;
            this.direccionLabel.Text = "Dirección";
            // 
            // nombreBox
            // 
            this.nombreBox.Location = new System.Drawing.Point(104, 62);
            this.nombreBox.Margin = new System.Windows.Forms.Padding(2);
            this.nombreBox.Name = "nombreBox";
            this.nombreBox.ReadOnly = true;
            this.nombreBox.Size = new System.Drawing.Size(98, 20);
            this.nombreBox.TabIndex = 7;
            // 
            // nombreLabel
            // 
            this.nombreLabel.AutoSize = true;
            this.nombreLabel.Location = new System.Drawing.Point(20, 63);
            this.nombreLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nombreLabel.Name = "nombreLabel";
            this.nombreLabel.Size = new System.Drawing.Size(44, 13);
            this.nombreLabel.TabIndex = 1;
            this.nombreLabel.Text = "Nombre";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(20, 30);
            this.idLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(18, 13);
            this.idLabel.TabIndex = 0;
            this.idLabel.Text = "ID";
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(104, 29);
            this.idBox.Margin = new System.Windows.Forms.Padding(2);
            this.idBox.Name = "idBox";
            this.idBox.ReadOnly = true;
            this.idBox.Size = new System.Drawing.Size(98, 20);
            this.idBox.TabIndex = 6;
            this.idBox.TextChanged += new System.EventHandler(this.nifBox_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gridTrabajadores);
            this.groupBox1.Location = new System.Drawing.Point(12, 274);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(449, 177);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Trabajadores";
            // 
            // gridTrabajadores
            // 
            this.gridTrabajadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTrabajadores.Location = new System.Drawing.Point(6, 19);
            this.gridTrabajadores.Name = "gridTrabajadores";
            this.gridTrabajadores.Size = new System.Drawing.Size(437, 144);
            this.gridTrabajadores.TabIndex = 0;
            // 
            // ConsultarInstalacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 539);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.accionesGB);
            this.Controls.Add(this.proveedorGB);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConsultarInstalacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar instalación";
            this.Load += new System.EventHandler(this.ConsultarInstalacion_Load);
            this.accionesGB.ResumeLayout(false);
            this.proveedorGB.ResumeLayout(false);
            this.proveedorGB.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridTrabajadores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox accionesGB;
        private System.Windows.Forms.Button aceptarButton;
        private System.Windows.Forms.GroupBox proveedorGB;
        private System.Windows.Forms.TextBox descripcionBox;
        private System.Windows.Forms.Label descripcionLabel;
        private System.Windows.Forms.TextBox paisBox;
        private System.Windows.Forms.Label paisLabel;
        private System.Windows.Forms.TextBox codigoPostalBox;
        private System.Windows.Forms.Label codigoPostalLabel;
        private System.Windows.Forms.TextBox telefonoBox;
        private System.Windows.Forms.Label telefonoLabel;
        private System.Windows.Forms.TextBox provinciaBox;
        private System.Windows.Forms.Label provinciaLabel;
        private System.Windows.Forms.TextBox localidadBox;
        private System.Windows.Forms.Label localidadLabel;
        private System.Windows.Forms.TextBox direccionBox;
        private System.Windows.Forms.Label direccionLabel;
        private System.Windows.Forms.TextBox nombreBox;
        private System.Windows.Forms.Label nombreLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox clienteBox;
        private System.Windows.Forms.TextBox m2Box;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView gridTrabajadores;
    }
}