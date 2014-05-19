namespace LimpiezasPalmeralForms.Pedidos
{
    partial class ActualizarEstadoPedido
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
            this.cancelarButton = new System.Windows.Forms.Button();
            this.actualizarButton = new System.Windows.Forms.Button();
            this.accionesGB = new System.Windows.Forms.GroupBox();
            this.proveedorGB.SuspendLayout();
            this.accionesGB.SuspendLayout();
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
            this.proveedorGB.Location = new System.Drawing.Point(12, 13);
            this.proveedorGB.Margin = new System.Windows.Forms.Padding(4);
            this.proveedorGB.Name = "proveedorGB";
            this.proveedorGB.Padding = new System.Windows.Forms.Padding(4);
            this.proveedorGB.Size = new System.Drawing.Size(599, 142);
            this.proveedorGB.TabIndex = 5;
            this.proveedorGB.TabStop = false;
            this.proveedorGB.Text = "Proveedor";
            // 
            // pagoBox
            // 
            this.pagoBox.Location = new System.Drawing.Point(428, 66);
            this.pagoBox.Margin = new System.Windows.Forms.Padding(4);
            this.pagoBox.Name = "pagoBox";
            this.pagoBox.ReadOnly = true;
            this.pagoBox.Size = new System.Drawing.Size(129, 22);
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
            this.estadoCB.Size = new System.Drawing.Size(129, 24);
            this.estadoCB.TabIndex = 6;
            // 
            // fechaBox
            // 
            this.fechaBox.Location = new System.Drawing.Point(428, 31);
            this.fechaBox.Margin = new System.Windows.Forms.Padding(4);
            this.fechaBox.Name = "fechaBox";
            this.fechaBox.ReadOnly = true;
            this.fechaBox.Size = new System.Drawing.Size(129, 22);
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
            // cancelarButton
            // 
            this.cancelarButton.Location = new System.Drawing.Point(312, 23);
            this.cancelarButton.Margin = new System.Windows.Forms.Padding(4);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(187, 54);
            this.cancelarButton.TabIndex = 3;
            this.cancelarButton.Text = "Cancelar";
            this.cancelarButton.UseVisualStyleBackColor = true;
            this.cancelarButton.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // actualizarButton
            // 
            this.actualizarButton.Location = new System.Drawing.Point(117, 23);
            this.actualizarButton.Margin = new System.Windows.Forms.Padding(4);
            this.actualizarButton.Name = "actualizarButton";
            this.actualizarButton.Size = new System.Drawing.Size(187, 54);
            this.actualizarButton.TabIndex = 0;
            this.actualizarButton.Text = "Actualizar";
            this.actualizarButton.UseVisualStyleBackColor = true;
            this.actualizarButton.Click += new System.EventHandler(this.Actualizar_Click);
            // 
            // accionesGB
            // 
            this.accionesGB.Controls.Add(this.cancelarButton);
            this.accionesGB.Controls.Add(this.actualizarButton);
            this.accionesGB.Location = new System.Drawing.Point(12, 163);
            this.accionesGB.Margin = new System.Windows.Forms.Padding(4);
            this.accionesGB.Name = "accionesGB";
            this.accionesGB.Padding = new System.Windows.Forms.Padding(4);
            this.accionesGB.Size = new System.Drawing.Size(599, 91);
            this.accionesGB.TabIndex = 6;
            this.accionesGB.TabStop = false;
            this.accionesGB.Text = "Acciones";
            // 
            // ActualizarEstadoPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 266);
            this.ControlBox = false;
            this.Controls.Add(this.accionesGB);
            this.Controls.Add(this.proveedorGB);
            this.Name = "ActualizarEstadoPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualizar Estado";
            this.proveedorGB.ResumeLayout(false);
            this.proveedorGB.PerformLayout();
            this.accionesGB.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox proveedorGB;
        private System.Windows.Forms.TextBox pagoBox;
        private System.Windows.Forms.Label pagoLabel;
        private System.Windows.Forms.Label datosLabel;
        private System.Windows.Forms.ComboBox estadoCB;
        private System.Windows.Forms.TextBox fechaBox;
        private System.Windows.Forms.Label fechaLabel;
        private System.Windows.Forms.Label estadoLabel;
        private System.Windows.Forms.Button cancelarButton;
        private System.Windows.Forms.Button actualizarButton;
        private System.Windows.Forms.GroupBox accionesGB;
    }
}