namespace LimpiezasPalmeralForms
{
    partial class PantallaProducto
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
            this.groupBoxProductosAcciones = new System.Windows.Forms.GroupBox();
            this.buttonGenerarInforme = new System.Windows.Forms.Button();
            this.buttonIncrementarStock = new System.Windows.Forms.Button();
            this.buttonReducirStock = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonConsultar = new System.Windows.Forms.Button();
            this.buttonRegistrar = new System.Windows.Forms.Button();
            this.groupBoxProductos = new System.Windows.Forms.GroupBox();
            this.comboBoxFiltro = new System.Windows.Forms.ComboBox();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.dataGridViewProducto = new System.Windows.Forms.DataGridView();
            this.groupBoxProductosAcciones.SuspendLayout();
            this.groupBoxProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxProductosAcciones
            // 
            this.groupBoxProductosAcciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxProductosAcciones.Controls.Add(this.buttonGenerarInforme);
            this.groupBoxProductosAcciones.Controls.Add(this.buttonIncrementarStock);
            this.groupBoxProductosAcciones.Controls.Add(this.buttonReducirStock);
            this.groupBoxProductosAcciones.Controls.Add(this.buttonEliminar);
            this.groupBoxProductosAcciones.Controls.Add(this.buttonEditar);
            this.groupBoxProductosAcciones.Controls.Add(this.buttonConsultar);
            this.groupBoxProductosAcciones.Controls.Add(this.buttonRegistrar);
            this.groupBoxProductosAcciones.Location = new System.Drawing.Point(594, 12);
            this.groupBoxProductosAcciones.Name = "groupBoxProductosAcciones";
            this.groupBoxProductosAcciones.Size = new System.Drawing.Size(133, 356);
            this.groupBoxProductosAcciones.TabIndex = 3;
            this.groupBoxProductosAcciones.TabStop = false;
            this.groupBoxProductosAcciones.Text = "Acciones";
            // 
            // buttonGenerarInforme
            // 
            this.buttonGenerarInforme.Location = new System.Drawing.Point(6, 317);
            this.buttonGenerarInforme.Name = "buttonGenerarInforme";
            this.buttonGenerarInforme.Size = new System.Drawing.Size(121, 44);
            this.buttonGenerarInforme.TabIndex = 9;
            this.buttonGenerarInforme.Text = "Generar Informe";
            this.buttonGenerarInforme.UseVisualStyleBackColor = true;
            this.buttonGenerarInforme.Click += new System.EventHandler(this.buttonGenerarInforme_Click);
            // 
            // buttonIncrementarStock
            // 
            this.buttonIncrementarStock.Location = new System.Drawing.Point(6, 217);
            this.buttonIncrementarStock.Name = "buttonIncrementarStock";
            this.buttonIncrementarStock.Size = new System.Drawing.Size(121, 44);
            this.buttonIncrementarStock.TabIndex = 8;
            this.buttonIncrementarStock.Text = "Incrementar Stock";
            this.buttonIncrementarStock.UseVisualStyleBackColor = true;
            this.buttonIncrementarStock.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonReducirStock
            // 
            this.buttonReducirStock.Location = new System.Drawing.Point(6, 267);
            this.buttonReducirStock.Name = "buttonReducirStock";
            this.buttonReducirStock.Size = new System.Drawing.Size(121, 44);
            this.buttonReducirStock.TabIndex = 7;
            this.buttonReducirStock.Text = "Reducir Stock";
            this.buttonReducirStock.UseVisualStyleBackColor = true;
            this.buttonReducirStock.Click += new System.EventHandler(this.buttonReducirStock_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(6, 167);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(121, 44);
            this.buttonEliminar.TabIndex = 6;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(6, 117);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(121, 44);
            this.buttonEditar.TabIndex = 5;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonConsultar
            // 
            this.buttonConsultar.Location = new System.Drawing.Point(6, 67);
            this.buttonConsultar.Name = "buttonConsultar";
            this.buttonConsultar.Size = new System.Drawing.Size(121, 44);
            this.buttonConsultar.TabIndex = 4;
            this.buttonConsultar.Text = "Consultar";
            this.buttonConsultar.UseVisualStyleBackColor = true;
            this.buttonConsultar.Click += new System.EventHandler(this.buttonConsultar_Click);
            // 
            // buttonRegistrar
            // 
            this.buttonRegistrar.Location = new System.Drawing.Point(6, 17);
            this.buttonRegistrar.Name = "buttonRegistrar";
            this.buttonRegistrar.Size = new System.Drawing.Size(121, 44);
            this.buttonRegistrar.TabIndex = 3;
            this.buttonRegistrar.Text = "Registrar";
            this.buttonRegistrar.UseVisualStyleBackColor = true;
            this.buttonRegistrar.Click += new System.EventHandler(this.buttonRegistrar_Click);
            // 
            // groupBoxProductos
            // 
            this.groupBoxProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxProductos.Controls.Add(this.comboBoxFiltro);
            this.groupBoxProductos.Controls.Add(this.textBoxBuscar);
            this.groupBoxProductos.Controls.Add(this.dataGridViewProducto);
            this.groupBoxProductos.Location = new System.Drawing.Point(12, 12);
            this.groupBoxProductos.Name = "groupBoxProductos";
            this.groupBoxProductos.Size = new System.Drawing.Size(576, 356);
            this.groupBoxProductos.TabIndex = 2;
            this.groupBoxProductos.TabStop = false;
            this.groupBoxProductos.Text = "Productos";
            // 
            // comboBoxFiltro
            // 
            this.comboBoxFiltro.FormattingEnabled = true;
            this.comboBoxFiltro.Items.AddRange(new object[] {
            "Id",
            "Nombre",
            "Stock"});
            this.comboBoxFiltro.Location = new System.Drawing.Point(7, 17);
            this.comboBoxFiltro.Name = "comboBoxFiltro";
            this.comboBoxFiltro.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFiltro.TabIndex = 1;
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBuscar.Location = new System.Drawing.Point(134, 17);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(436, 20);
            this.textBoxBuscar.TabIndex = 2;
            this.textBoxBuscar.Text = "Introduzca el producto que desea buscar.";
            this.textBoxBuscar.Click += new System.EventHandler(this.textBoxBuscar_Click);
            this.textBoxBuscar.TextChanged += new System.EventHandler(this.textBoxBuscar_TextChanged);
            // 
            // dataGridViewProducto
            // 
            this.dataGridViewProducto.AllowUserToAddRows = false;
            this.dataGridViewProducto.AllowUserToDeleteRows = false;
            this.dataGridViewProducto.AllowUserToResizeColumns = false;
            this.dataGridViewProducto.AllowUserToResizeRows = false;
            this.dataGridViewProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducto.Location = new System.Drawing.Point(7, 47);
            this.dataGridViewProducto.Name = "dataGridViewProducto";
            this.dataGridViewProducto.ReadOnly = true;
            this.dataGridViewProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProducto.Size = new System.Drawing.Size(563, 303);
            this.dataGridViewProducto.TabIndex = 0;
            // 
            // PantallaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 380);
            this.ControlBox = false;
            this.Controls.Add(this.groupBoxProductosAcciones);
            this.Controls.Add(this.groupBoxProductos);
            this.Name = "PantallaProducto";
            this.Text = "Pantalla Producto";
            this.groupBoxProductosAcciones.ResumeLayout(false);
            this.groupBoxProductos.ResumeLayout(false);
            this.groupBoxProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxProductosAcciones;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonConsultar;
        private System.Windows.Forms.Button buttonRegistrar;
        private System.Windows.Forms.GroupBox groupBoxProductos;
        private System.Windows.Forms.ComboBox comboBoxFiltro;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.DataGridView dataGridViewProducto;
        private System.Windows.Forms.Button buttonReducirStock;
        private System.Windows.Forms.Button buttonIncrementarStock;
        private System.Windows.Forms.Button buttonGenerarInforme;

    }
}