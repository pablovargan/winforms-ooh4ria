namespace LimpiezasPalmeralForms.Pedidos
{
    partial class ConsultarPedido
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
            this.proveedorGB = new System.Windows.Forms.GroupBox();
            this.pagoBox = new System.Windows.Forms.TextBox();
            this.pagoLabel = new System.Windows.Forms.Label();
            this.datosLabel = new System.Windows.Forms.Label();
            this.estadoCB = new System.Windows.Forms.ComboBox();
            this.fechaBox = new System.Windows.Forms.TextBox();
            this.fechaLabel = new System.Windows.Forms.Label();
            this.estadoLabel = new System.Windows.Forms.Label();
            this.accionesGB = new System.Windows.Forms.GroupBox();
            this.aceptarButton = new System.Windows.Forms.Button();
            this.actualizarButton = new System.Windows.Forms.Button();
            this.pedidoBox = new System.Windows.Forms.GroupBox();
            this.lineasPedidoGV = new System.Windows.Forms.DataGridView();
            this.eliminarButton = new System.Windows.Forms.Button();
            this.proveedorGB.SuspendLayout();
            this.accionesGB.SuspendLayout();
            this.pedidoBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lineasPedidoGV)).BeginInit();
            this.SuspendLayout();
            // 
            // proveedorGB
            // 
            this.proveedorGB.Controls.Add(this.pagoBox);
            this.proveedorGB.Controls.Add(this.pagoLabel);
            this.proveedorGB.Controls.Add(this.datosLabel);
            this.proveedorGB.Controls.Add(this.estadoCB);
            this.proveedorGB.Controls.Add(this.fechaBox);
            this.proveedorGB.Controls.Add(this.fechaLabel);
            this.proveedorGB.Controls.Add(this.estadoLabel);
            this.proveedorGB.Location = new System.Drawing.Point(13, 13);
            this.proveedorGB.Margin = new System.Windows.Forms.Padding(4);
            this.proveedorGB.Name = "proveedorGB";
            this.proveedorGB.Padding = new System.Windows.Forms.Padding(4);
            this.proveedorGB.Size = new System.Drawing.Size(599, 141);
            this.proveedorGB.TabIndex = 4;
            this.proveedorGB.TabStop = false;
            this.proveedorGB.Text = "Proveedor";
            // 
            // pagoBox
            // 
            this.pagoBox.Location = new System.Drawing.Point(428, 66);
            this.pagoBox.Margin = new System.Windows.Forms.Padding(4);
            this.pagoBox.Name = "pagoBox";
            this.pagoBox.ReadOnly = true;
            this.pagoBox.Size = new System.Drawing.Size(130, 22);
            this.pagoBox.TabIndex = 21;
            // 
            // pagoLabel
            // 
            this.pagoLabel.AutoSize = true;
            this.pagoLabel.Location = new System.Drawing.Point(299, 69);
            this.pagoLabel.Name = "pagoLabel";
            this.pagoLabel.Size = new System.Drawing.Size(92, 17);
            this.pagoLabel.TabIndex = 20;
            this.pagoLabel.Text = "Tipo de pago";
            // 
            // datosLabel
            // 
            this.datosLabel.AutoSize = true;
            this.datosLabel.Location = new System.Drawing.Point(27, 32);
            this.datosLabel.Margin = new System.Windows.Forms.Padding(4);
            this.datosLabel.Name = "datosLabel";
            this.datosLabel.Size = new System.Drawing.Size(79, 17);
            this.datosLabel.TabIndex = 19;
            this.datosLabel.Text = "datos_prov";
            // 
            // estadoCB
            // 
            this.estadoCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.estadoCB.Enabled = false;
            this.estadoCB.FormattingEnabled = true;
            this.estadoCB.Items.AddRange(new object[] {
            "Pendiente",
            "Enviado",
            "Recibido",
            "Cancelado"});
            this.estadoCB.Location = new System.Drawing.Point(428, 100);
            this.estadoCB.Margin = new System.Windows.Forms.Padding(4);
            this.estadoCB.Name = "estadoCB";
            this.estadoCB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.estadoCB.Size = new System.Drawing.Size(130, 24);
            this.estadoCB.TabIndex = 6;
            // 
            // fechaBox
            // 
            this.fechaBox.Location = new System.Drawing.Point(428, 31);
            this.fechaBox.Margin = new System.Windows.Forms.Padding(4);
            this.fechaBox.Name = "fechaBox";
            this.fechaBox.ReadOnly = true;
            this.fechaBox.Size = new System.Drawing.Size(130, 22);
            this.fechaBox.TabIndex = 14;
            // 
            // fechaLabel
            // 
            this.fechaLabel.AutoSize = true;
            this.fechaLabel.Location = new System.Drawing.Point(299, 32);
            this.fechaLabel.Name = "fechaLabel";
            this.fechaLabel.Size = new System.Drawing.Size(47, 17);
            this.fechaLabel.TabIndex = 18;
            this.fechaLabel.Text = "Fecha";
            // 
            // estadoLabel
            // 
            this.estadoLabel.AutoSize = true;
            this.estadoLabel.Location = new System.Drawing.Point(299, 103);
            this.estadoLabel.Name = "estadoLabel";
            this.estadoLabel.Size = new System.Drawing.Size(122, 17);
            this.estadoLabel.TabIndex = 0;
            this.estadoLabel.Text = "Estado del pedido";
            // 
            // accionesGB
            // 
            this.accionesGB.Controls.Add(this.eliminarButton);
            this.accionesGB.Controls.Add(this.aceptarButton);
            this.accionesGB.Controls.Add(this.actualizarButton);
            this.accionesGB.Location = new System.Drawing.Point(13, 515);
            this.accionesGB.Margin = new System.Windows.Forms.Padding(4);
            this.accionesGB.Name = "accionesGB";
            this.accionesGB.Padding = new System.Windows.Forms.Padding(4);
            this.accionesGB.Size = new System.Drawing.Size(599, 91);
            this.accionesGB.TabIndex = 5;
            this.accionesGB.TabStop = false;
            this.accionesGB.Text = "Acciones";
            // 
            // aceptarButton
            // 
            this.aceptarButton.Location = new System.Drawing.Point(8, 23);
            this.aceptarButton.Margin = new System.Windows.Forms.Padding(4);
            this.aceptarButton.Name = "aceptarButton";
            this.aceptarButton.Size = new System.Drawing.Size(187, 54);
            this.aceptarButton.TabIndex = 0;
            this.aceptarButton.Text = "Aceptar";
            this.aceptarButton.UseVisualStyleBackColor = true;
            this.aceptarButton.Click += new System.EventHandler(this.Aceptar_Click);
            // 
            // actualizarButton
            // 
            this.actualizarButton.Location = new System.Drawing.Point(206, 23);
            this.actualizarButton.Margin = new System.Windows.Forms.Padding(4);
            this.actualizarButton.Name = "actualizarButton";
            this.actualizarButton.Size = new System.Drawing.Size(187, 54);
            this.actualizarButton.TabIndex = 1;
            this.actualizarButton.Text = "Actualizar Estado";
            this.actualizarButton.UseVisualStyleBackColor = true;
            this.actualizarButton.Click += new System.EventHandler(this.Actualizar_Click);
            // 
            // pedidoBox
            // 
            this.pedidoBox.Controls.Add(this.lineasPedidoGV);
            this.pedidoBox.Location = new System.Drawing.Point(13, 161);
            this.pedidoBox.Name = "pedidoBox";
            this.pedidoBox.Size = new System.Drawing.Size(599, 347);
            this.pedidoBox.TabIndex = 22;
            this.pedidoBox.TabStop = false;
            this.pedidoBox.Text = "Pedido";
            // 
            // lineasPedidoGV
            // 
            this.lineasPedidoGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lineasPedidoGV.Location = new System.Drawing.Point(6, 21);
            this.lineasPedidoGV.Name = "lineasPedidoGV";
            this.lineasPedidoGV.RowTemplate.Height = 24;
            this.lineasPedidoGV.Size = new System.Drawing.Size(587, 320);
            this.lineasPedidoGV.TabIndex = 0;
            // 
            // eliminarButton
            // 
            this.eliminarButton.Location = new System.Drawing.Point(405, 23);
            this.eliminarButton.Margin = new System.Windows.Forms.Padding(4);
            this.eliminarButton.Name = "eliminarButton";
            this.eliminarButton.Size = new System.Drawing.Size(187, 54);
            this.eliminarButton.TabIndex = 2;
            this.eliminarButton.Text = "Eliminar";
            this.eliminarButton.UseVisualStyleBackColor = true;
            this.eliminarButton.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // ConsultarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 619);
            this.ControlBox = false;
            this.Controls.Add(this.pedidoBox);
            this.Controls.Add(this.accionesGB);
            this.Controls.Add(this.proveedorGB);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConsultarPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Pedido";
            this.proveedorGB.ResumeLayout(false);
            this.proveedorGB.PerformLayout();
            this.accionesGB.ResumeLayout(false);
            this.pedidoBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lineasPedidoGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox proveedorGB;
        private System.Windows.Forms.Label datosLabel;
        private System.Windows.Forms.ComboBox estadoCB;
        private System.Windows.Forms.TextBox fechaBox;
        private System.Windows.Forms.Label fechaLabel;
        private System.Windows.Forms.Label estadoLabel;
        private System.Windows.Forms.GroupBox accionesGB;
        private System.Windows.Forms.Button aceptarButton;
        private System.Windows.Forms.Button actualizarButton;
        private System.Windows.Forms.TextBox pagoBox;
        private System.Windows.Forms.Label pagoLabel;
        private System.Windows.Forms.GroupBox pedidoBox;
        private System.Windows.Forms.DataGridView lineasPedidoGV;
        private System.Windows.Forms.Button eliminarButton;

    }
}