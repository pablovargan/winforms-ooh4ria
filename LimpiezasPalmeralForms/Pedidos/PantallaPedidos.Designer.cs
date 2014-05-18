namespace LimpiezasPalmeralForms.Proveedor.Pedidos
{
    partial class PantallaPedidos
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
            this.eliminarButton = new System.Windows.Forms.Button();
            this.editarButton = new System.Windows.Forms.Button();
            this.consultarButton = new System.Windows.Forms.Button();
            this.crearButton = new System.Windows.Forms.Button();
            this.proveedoresGB = new System.Windows.Forms.GroupBox();
            this.Buscar = new System.Windows.Forms.Button();
            this.busquedaBox = new System.Windows.Forms.TextBox();
            this.pedidoGrid = new System.Windows.Forms.DataGridView();
            this.accionesGB.SuspendLayout();
            this.proveedoresGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // accionesGB
            // 
            this.accionesGB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.accionesGB.Controls.Add(this.eliminarButton);
            this.accionesGB.Controls.Add(this.editarButton);
            this.accionesGB.Controls.Add(this.consultarButton);
            this.accionesGB.Controls.Add(this.crearButton);
            this.accionesGB.Location = new System.Drawing.Point(775, 15);
            this.accionesGB.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.accionesGB.Name = "accionesGB";
            this.accionesGB.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.accionesGB.Size = new System.Drawing.Size(177, 434);
            this.accionesGB.TabIndex = 14;
            this.accionesGB.TabStop = false;
            this.accionesGB.Text = "Acciones";
            // 
            // eliminarButton
            // 
            this.eliminarButton.Location = new System.Drawing.Point(8, 206);
            this.eliminarButton.Name = "eliminarButton";
            this.eliminarButton.Size = new System.Drawing.Size(161, 54);
            this.eliminarButton.TabIndex = 6;
            this.eliminarButton.Text = "Eliminar";
            this.eliminarButton.UseVisualStyleBackColor = true;
            // 
            // editarButton
            // 
            this.editarButton.Location = new System.Drawing.Point(8, 144);
            this.editarButton.Name = "editarButton";
            this.editarButton.Size = new System.Drawing.Size(161, 54);
            this.editarButton.TabIndex = 5;
            this.editarButton.Text = "Actualizar Estado";
            this.editarButton.UseVisualStyleBackColor = true;
            // 
            // consultarButton
            // 
            this.consultarButton.Location = new System.Drawing.Point(8, 82);
            this.consultarButton.Margin = new System.Windows.Forms.Padding(4);
            this.consultarButton.Name = "consultarButton";
            this.consultarButton.Size = new System.Drawing.Size(161, 54);
            this.consultarButton.TabIndex = 4;
            this.consultarButton.Text = "Consultar";
            this.consultarButton.UseVisualStyleBackColor = true;
            this.consultarButton.Click += new System.EventHandler(this.Consultar_Click);
            // 
            // crearButton
            // 
            this.crearButton.Location = new System.Drawing.Point(8, 21);
            this.crearButton.Margin = new System.Windows.Forms.Padding(4);
            this.crearButton.Name = "crearButton";
            this.crearButton.Size = new System.Drawing.Size(161, 54);
            this.crearButton.TabIndex = 0;
            this.crearButton.Text = "Crear ";
            this.crearButton.UseVisualStyleBackColor = true;
            this.crearButton.Click += new System.EventHandler(this.Crear_Click);
            // 
            // proveedoresGB
            // 
            this.proveedoresGB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.proveedoresGB.Controls.Add(this.Buscar);
            this.proveedoresGB.Controls.Add(this.busquedaBox);
            this.proveedoresGB.Controls.Add(this.pedidoGrid);
            this.proveedoresGB.Location = new System.Drawing.Point(17, 15);
            this.proveedoresGB.Margin = new System.Windows.Forms.Padding(5);
            this.proveedoresGB.Name = "proveedoresGB";
            this.proveedoresGB.Padding = new System.Windows.Forms.Padding(5);
            this.proveedoresGB.Size = new System.Drawing.Size(749, 434);
            this.proveedoresGB.TabIndex = 13;
            this.proveedoresGB.TabStop = false;
            this.proveedoresGB.Text = "Pedidos";
            // 
            // Buscar
            // 
            this.Buscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Buscar.Location = new System.Drawing.Point(595, 21);
            this.Buscar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(145, 29);
            this.Buscar.TabIndex = 3;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = true;
            // 
            // busquedaBox
            // 
            this.busquedaBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.busquedaBox.Location = new System.Drawing.Point(9, 25);
            this.busquedaBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.busquedaBox.Name = "busquedaBox";
            this.busquedaBox.Size = new System.Drawing.Size(578, 22);
            this.busquedaBox.TabIndex = 2;
            this.busquedaBox.Text = "NIF";
            // 
            // pedidoGrid
            // 
            this.pedidoGrid.AllowUserToAddRows = false;
            this.pedidoGrid.AllowUserToDeleteRows = false;
            this.pedidoGrid.AllowUserToResizeColumns = false;
            this.pedidoGrid.AllowUserToResizeRows = false;
            this.pedidoGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pedidoGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.pedidoGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pedidoGrid.Location = new System.Drawing.Point(9, 58);
            this.pedidoGrid.Margin = new System.Windows.Forms.Padding(5);
            this.pedidoGrid.Name = "pedidoGrid";
            this.pedidoGrid.ReadOnly = true;
            this.pedidoGrid.RowTemplate.Height = 24;
            this.pedidoGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.pedidoGrid.Size = new System.Drawing.Size(732, 369);
            this.pedidoGrid.TabIndex = 0;
            // 
            // PantallaPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 465);
            this.ControlBox = false;
            this.Controls.Add(this.accionesGB);
            this.Controls.Add(this.proveedoresGB);
            this.Name = "PantallaPedidos";
            this.ShowIcon = false;
            this.Text = "PantallaPedidos";
            this.accionesGB.ResumeLayout(false);
            this.proveedoresGB.ResumeLayout(false);
            this.proveedoresGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox accionesGB;
        private System.Windows.Forms.Button eliminarButton;
        private System.Windows.Forms.Button editarButton;
        private System.Windows.Forms.Button consultarButton;
        private System.Windows.Forms.Button crearButton;
        private System.Windows.Forms.GroupBox proveedoresGB;
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.TextBox busquedaBox;
        private System.Windows.Forms.DataGridView pedidoGrid;

    }
}