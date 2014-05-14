namespace LimpiezasPalmeralForms.Pedidos
{
    partial class CrearPedido
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
            this.cancelarButton = new System.Windows.Forms.Button();
            this.accionesGB = new System.Windows.Forms.GroupBox();
            this.eliminarButton = new System.Windows.Forms.Button();
            this.crearButton = new System.Windows.Forms.Button();
            this.fechaBox = new System.Windows.Forms.TextBox();
            this.fechaLabel = new System.Windows.Forms.Label();
            this.proveedorLabel = new System.Windows.Forms.Label();
            this.proveedorGB = new System.Windows.Forms.GroupBox();
            this.datosLabel = new System.Windows.Forms.Label();
            this.proveedorCB = new System.Windows.Forms.ComboBox();
            this.busquedaBox = new System.Windows.Forms.GroupBox();
            this.agregarButton = new System.Windows.Forms.Button();
            this.buscarTextBox = new System.Windows.Forms.TextBox();
            this.filtroCB = new System.Windows.Forms.ComboBox();
            this.productosGrid = new System.Windows.Forms.DataGridView();
            this.pedidoGB = new System.Windows.Forms.GroupBox();
            this.pedidoGrid = new System.Windows.Forms.DataGridView();
            this.tipoPagoLabel = new System.Windows.Forms.Label();
            this.contadoRB = new System.Windows.Forms.RadioButton();
            this.pagareRB = new System.Windows.Forms.RadioButton();
            this.transferenciaRB = new System.Windows.Forms.RadioButton();
            this.accionesGB.SuspendLayout();
            this.proveedorGB.SuspendLayout();
            this.busquedaBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productosGrid)).BeginInit();
            this.pedidoGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelarButton
            // 
            this.cancelarButton.Location = new System.Drawing.Point(206, 23);
            this.cancelarButton.Margin = new System.Windows.Forms.Padding(4);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(187, 54);
            this.cancelarButton.TabIndex = 1;
            this.cancelarButton.Text = "Cancelar";
            this.cancelarButton.UseVisualStyleBackColor = true;
            this.cancelarButton.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // accionesGB
            // 
            this.accionesGB.Controls.Add(this.eliminarButton);
            this.accionesGB.Controls.Add(this.crearButton);
            this.accionesGB.Controls.Add(this.cancelarButton);
            this.accionesGB.Location = new System.Drawing.Point(626, 553);
            this.accionesGB.Margin = new System.Windows.Forms.Padding(4);
            this.accionesGB.Name = "accionesGB";
            this.accionesGB.Padding = new System.Windows.Forms.Padding(4);
            this.accionesGB.Size = new System.Drawing.Size(599, 91);
            this.accionesGB.TabIndex = 4;
            this.accionesGB.TabStop = false;
            this.accionesGB.Text = "Acciones";
            // 
            // eliminarButton
            // 
            this.eliminarButton.Location = new System.Drawing.Point(404, 23);
            this.eliminarButton.Margin = new System.Windows.Forms.Padding(4);
            this.eliminarButton.Name = "eliminarButton";
            this.eliminarButton.Size = new System.Drawing.Size(187, 54);
            this.eliminarButton.TabIndex = 2;
            this.eliminarButton.Text = "Eliminar Línea";
            this.eliminarButton.UseVisualStyleBackColor = true;
            this.eliminarButton.Click += new System.EventHandler(this.EliminarLinea_Click);
            // 
            // crearButton
            // 
            this.crearButton.Location = new System.Drawing.Point(8, 23);
            this.crearButton.Margin = new System.Windows.Forms.Padding(4);
            this.crearButton.Name = "crearButton";
            this.crearButton.Size = new System.Drawing.Size(187, 54);
            this.crearButton.TabIndex = 0;
            this.crearButton.Text = "Aceptar";
            this.crearButton.UseVisualStyleBackColor = true;
            this.crearButton.Click += new System.EventHandler(this.Crear_Click);
            // 
            // fechaBox
            // 
            this.fechaBox.Location = new System.Drawing.Point(139, 76);
            this.fechaBox.Margin = new System.Windows.Forms.Padding(4);
            this.fechaBox.Name = "fechaBox";
            this.fechaBox.ReadOnly = true;
            this.fechaBox.Size = new System.Drawing.Size(130, 22);
            this.fechaBox.TabIndex = 14;
            // 
            // fechaLabel
            // 
            this.fechaLabel.AutoSize = true;
            this.fechaLabel.Location = new System.Drawing.Point(27, 77);
            this.fechaLabel.Name = "fechaLabel";
            this.fechaLabel.Size = new System.Drawing.Size(47, 17);
            this.fechaLabel.TabIndex = 18;
            this.fechaLabel.Text = "Fecha";
            // 
            // proveedorLabel
            // 
            this.proveedorLabel.AutoSize = true;
            this.proveedorLabel.Location = new System.Drawing.Point(27, 37);
            this.proveedorLabel.Name = "proveedorLabel";
            this.proveedorLabel.Size = new System.Drawing.Size(74, 17);
            this.proveedorLabel.TabIndex = 0;
            this.proveedorLabel.Text = "Proveedor";
            // 
            // proveedorGB
            // 
            this.proveedorGB.Controls.Add(this.datosLabel);
            this.proveedorGB.Controls.Add(this.proveedorCB);
            this.proveedorGB.Controls.Add(this.fechaBox);
            this.proveedorGB.Controls.Add(this.fechaLabel);
            this.proveedorGB.Controls.Add(this.proveedorLabel);
            this.proveedorGB.Location = new System.Drawing.Point(16, 11);
            this.proveedorGB.Margin = new System.Windows.Forms.Padding(4);
            this.proveedorGB.Name = "proveedorGB";
            this.proveedorGB.Padding = new System.Windows.Forms.Padding(4);
            this.proveedorGB.Size = new System.Drawing.Size(599, 119);
            this.proveedorGB.TabIndex = 3;
            this.proveedorGB.TabStop = false;
            this.proveedorGB.Text = "Proveedor";
            // 
            // datosLabel
            // 
            this.datosLabel.AutoSize = true;
            this.datosLabel.Location = new System.Drawing.Point(316, 31);
            this.datosLabel.Margin = new System.Windows.Forms.Padding(4);
            this.datosLabel.Name = "datosLabel";
            this.datosLabel.Size = new System.Drawing.Size(79, 17);
            this.datosLabel.TabIndex = 19;
            this.datosLabel.Text = "datos_prov";
            // 
            // proveedorCB
            // 
            this.proveedorCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.proveedorCB.FormattingEnabled = true;
            this.proveedorCB.Location = new System.Drawing.Point(139, 36);
            this.proveedorCB.Margin = new System.Windows.Forms.Padding(4);
            this.proveedorCB.Name = "proveedorCB";
            this.proveedorCB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.proveedorCB.Size = new System.Drawing.Size(130, 24);
            this.proveedorCB.TabIndex = 6;
            this.proveedorCB.SelectedIndexChanged += new System.EventHandler(this.Proveedor_Selected);
            // 
            // busquedaBox
            // 
            this.busquedaBox.Controls.Add(this.agregarButton);
            this.busquedaBox.Controls.Add(this.buscarTextBox);
            this.busquedaBox.Controls.Add(this.filtroCB);
            this.busquedaBox.Controls.Add(this.productosGrid);
            this.busquedaBox.Enabled = false;
            this.busquedaBox.Location = new System.Drawing.Point(16, 137);
            this.busquedaBox.Name = "busquedaBox";
            this.busquedaBox.Size = new System.Drawing.Size(599, 508);
            this.busquedaBox.TabIndex = 5;
            this.busquedaBox.TabStop = false;
            this.busquedaBox.Text = "Buscar";
            // 
            // agregarButton
            // 
            this.agregarButton.Location = new System.Drawing.Point(7, 439);
            this.agregarButton.Name = "agregarButton";
            this.agregarButton.Size = new System.Drawing.Size(187, 54);
            this.agregarButton.TabIndex = 6;
            this.agregarButton.Text = "Agregar Producto";
            this.agregarButton.UseVisualStyleBackColor = true;
            this.agregarButton.Click += new System.EventHandler(this.AgregarProducto_Click);
            // 
            // buscarTextBox
            // 
            this.buscarTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buscarTextBox.Location = new System.Drawing.Point(175, 30);
            this.buscarTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.buscarTextBox.Name = "buscarTextBox";
            this.buscarTextBox.Size = new System.Drawing.Size(417, 22);
            this.buscarTextBox.TabIndex = 5;
            this.buscarTextBox.Text = "Introduzca el producto que desea buscar.";
            this.buscarTextBox.Click += new System.EventHandler(this.Buscador_Click);
            // 
            // filtroCB
            // 
            this.filtroCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filtroCB.FormattingEnabled = true;
            this.filtroCB.Items.AddRange(new object[] {
            "Id",
            "Nombre",
            "Stock"});
            this.filtroCB.Location = new System.Drawing.Point(7, 30);
            this.filtroCB.Margin = new System.Windows.Forms.Padding(4);
            this.filtroCB.Name = "filtroCB";
            this.filtroCB.Size = new System.Drawing.Size(160, 24);
            this.filtroCB.TabIndex = 4;
            // 
            // productosGrid
            // 
            this.productosGrid.AllowUserToAddRows = false;
            this.productosGrid.AllowUserToDeleteRows = false;
            this.productosGrid.AllowUserToResizeColumns = false;
            this.productosGrid.AllowUserToResizeRows = false;
            this.productosGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productosGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productosGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productosGrid.Location = new System.Drawing.Point(6, 69);
            this.productosGrid.Margin = new System.Windows.Forms.Padding(4);
            this.productosGrid.Name = "productosGrid";
            this.productosGrid.ReadOnly = true;
            this.productosGrid.RowTemplate.Height = 24;
            this.productosGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productosGrid.Size = new System.Drawing.Size(587, 354);
            this.productosGrid.TabIndex = 0;
            // 
            // pedidoGB
            // 
            this.pedidoGB.Controls.Add(this.transferenciaRB);
            this.pedidoGB.Controls.Add(this.pagareRB);
            this.pedidoGB.Controls.Add(this.contadoRB);
            this.pedidoGB.Controls.Add(this.tipoPagoLabel);
            this.pedidoGB.Controls.Add(this.pedidoGrid);
            this.pedidoGB.Enabled = false;
            this.pedidoGB.Location = new System.Drawing.Point(626, 11);
            this.pedidoGB.Margin = new System.Windows.Forms.Padding(4);
            this.pedidoGB.Name = "pedidoGB";
            this.pedidoGB.Size = new System.Drawing.Size(599, 534);
            this.pedidoGB.TabIndex = 7;
            this.pedidoGB.TabStop = false;
            this.pedidoGB.Text = "Pedido";
            // 
            // pedidoGrid
            // 
            this.pedidoGrid.AllowUserToResizeColumns = false;
            this.pedidoGrid.AllowUserToResizeRows = false;
            this.pedidoGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pedidoGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.pedidoGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pedidoGrid.Location = new System.Drawing.Point(8, 21);
            this.pedidoGrid.Margin = new System.Windows.Forms.Padding(4);
            this.pedidoGrid.Name = "pedidoGrid";
            this.pedidoGrid.RowTemplate.Height = 24;
            this.pedidoGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.pedidoGrid.Size = new System.Drawing.Size(583, 466);
            this.pedidoGrid.TabIndex = 7;
            // 
            // tipoPagoLabel
            // 
            this.tipoPagoLabel.AutoSize = true;
            this.tipoPagoLabel.Location = new System.Drawing.Point(6, 503);
            this.tipoPagoLabel.Name = "tipoPagoLabel";
            this.tipoPagoLabel.Size = new System.Drawing.Size(96, 17);
            this.tipoPagoLabel.TabIndex = 8;
            this.tipoPagoLabel.Text = "Tipo de pago:";
            // 
            // contadoRB
            // 
            this.contadoRB.AutoSize = true;
            this.contadoRB.Checked = true;
            this.contadoRB.Location = new System.Drawing.Point(120, 503);
            this.contadoRB.Name = "contadoRB";
            this.contadoRB.Size = new System.Drawing.Size(82, 21);
            this.contadoRB.TabIndex = 9;
            this.contadoRB.TabStop = true;
            this.contadoRB.Text = "Contado";
            this.contadoRB.UseVisualStyleBackColor = true;
            // 
            // pagareRB
            // 
            this.pagareRB.AutoSize = true;
            this.pagareRB.Location = new System.Drawing.Point(283, 503);
            this.pagareRB.Name = "pagareRB";
            this.pagareRB.Size = new System.Drawing.Size(75, 21);
            this.pagareRB.TabIndex = 10;
            this.pagareRB.TabStop = true;
            this.pagareRB.Text = "Pagaré";
            this.pagareRB.UseVisualStyleBackColor = true;
            // 
            // transferenciaRB
            // 
            this.transferenciaRB.AutoSize = true;
            this.transferenciaRB.Location = new System.Drawing.Point(445, 503);
            this.transferenciaRB.Name = "transferenciaRB";
            this.transferenciaRB.Size = new System.Drawing.Size(117, 21);
            this.transferenciaRB.TabIndex = 11;
            this.transferenciaRB.TabStop = true;
            this.transferenciaRB.Text = "Transferencia";
            this.transferenciaRB.UseVisualStyleBackColor = true;
            // 
            // CrearPedido
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1238, 657);
            this.ControlBox = false;
            this.Controls.Add(this.pedidoGB);
            this.Controls.Add(this.busquedaBox);
            this.Controls.Add(this.accionesGB);
            this.Controls.Add(this.proveedorGB);
            this.Name = "CrearPedido";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear Pedido";
            this.accionesGB.ResumeLayout(false);
            this.proveedorGB.ResumeLayout(false);
            this.proveedorGB.PerformLayout();
            this.busquedaBox.ResumeLayout(false);
            this.busquedaBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productosGrid)).EndInit();
            this.pedidoGB.ResumeLayout(false);
            this.pedidoGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cancelarButton;
        private System.Windows.Forms.GroupBox accionesGB;
        private System.Windows.Forms.Button crearButton;
        private System.Windows.Forms.TextBox fechaBox;
        private System.Windows.Forms.Label fechaLabel;
        private System.Windows.Forms.Label proveedorLabel;
        private System.Windows.Forms.GroupBox proveedorGB;
        private System.Windows.Forms.ComboBox proveedorCB;
        private System.Windows.Forms.Label datosLabel;
        private System.Windows.Forms.GroupBox busquedaBox;
        private System.Windows.Forms.DataGridView productosGrid;
        private System.Windows.Forms.ComboBox filtroCB;
        private System.Windows.Forms.TextBox buscarTextBox;
        private System.Windows.Forms.Button eliminarButton;
        private System.Windows.Forms.Button agregarButton;
        private System.Windows.Forms.GroupBox pedidoGB;
        private System.Windows.Forms.DataGridView pedidoGrid;
        private System.Windows.Forms.RadioButton contadoRB;
        private System.Windows.Forms.Label tipoPagoLabel;
        private System.Windows.Forms.RadioButton transferenciaRB;
        private System.Windows.Forms.RadioButton pagareRB;
    }
}