﻿namespace LimpiezasPalmeralForms
{
    partial class PantallaTrabajador
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BusquedaTipo = new System.Windows.Forms.ComboBox();
            this.Premisa = new System.Windows.Forms.ComboBox();
            this.Mostrar = new System.Windows.Forms.DataGridView();
            this.Buscador = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.GenerarListado = new System.Windows.Forms.Button();
            this.GenerarInforme = new System.Windows.Forms.Button();
            this.Editar = new System.Windows.Forms.Button();
            this.Consultar = new System.Windows.Forms.Button();
            this.Eliminar = new System.Windows.Forms.Button();
            this.Crear = new System.Windows.Forms.Button();
            this.Asignar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Mostrar)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.BusquedaTipo);
            this.groupBox1.Controls.Add(this.Premisa);
            this.groupBox1.Controls.Add(this.Mostrar);
            this.groupBox1.Controls.Add(this.Buscador);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(563, 380);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Trabajadores";
            // 
            // BusquedaTipo
            // 
            this.BusquedaTipo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BusquedaTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BusquedaTipo.FormattingEnabled = true;
            this.BusquedaTipo.Items.AddRange(new object[] {
            "Cooperativista",
            "Empleado",
            "Todos"});
            this.BusquedaTipo.Location = new System.Drawing.Point(134, 17);
            this.BusquedaTipo.Name = "BusquedaTipo";
            this.BusquedaTipo.Size = new System.Drawing.Size(419, 21);
            this.BusquedaTipo.TabIndex = 4;
            this.BusquedaTipo.Visible = false;
            // 
            // Premisa
            // 
            this.Premisa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Premisa.FormattingEnabled = true;
            this.Premisa.Items.AddRange(new object[] {
            "Nombre",
            "Provincia",
            "Tipo",
            "Localidad"});
            this.Premisa.Location = new System.Drawing.Point(7, 17);
            this.Premisa.Name = "Premisa";
            this.Premisa.Size = new System.Drawing.Size(121, 21);
            this.Premisa.TabIndex = 3;
            // 
            // Mostrar
            // 
            this.Mostrar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Mostrar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Mostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Mostrar.Location = new System.Drawing.Point(6, 45);
            this.Mostrar.MultiSelect = false;
            this.Mostrar.Name = "Mostrar";
            this.Mostrar.ReadOnly = true;
            this.Mostrar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Mostrar.Size = new System.Drawing.Size(551, 329);
            this.Mostrar.TabIndex = 2;
            // 
            // Buscador
            // 
            this.Buscador.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Buscador.Location = new System.Drawing.Point(134, 17);
            this.Buscador.Name = "Buscador";
            this.Buscador.Size = new System.Drawing.Size(419, 20);
            this.Buscador.TabIndex = 0;
            this.Buscador.Click += new System.EventHandler(this.Buscador_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.Asignar);
            this.groupBox2.Controls.Add(this.GenerarListado);
            this.groupBox2.Controls.Add(this.GenerarInforme);
            this.groupBox2.Controls.Add(this.Editar);
            this.groupBox2.Controls.Add(this.Consultar);
            this.groupBox2.Controls.Add(this.Eliminar);
            this.groupBox2.Controls.Add(this.Crear);
            this.groupBox2.Location = new System.Drawing.Point(581, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(133, 380);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Acciones";
            // 
            // GenerarListado
            // 
            this.GenerarListado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GenerarListado.Location = new System.Drawing.Point(6, 267);
            this.GenerarListado.Name = "GenerarListado";
            this.GenerarListado.Size = new System.Drawing.Size(121, 44);
            this.GenerarListado.TabIndex = 5;
            this.GenerarListado.Text = "Generar Listado";
            this.GenerarListado.UseVisualStyleBackColor = true;
            this.GenerarListado.Click += new System.EventHandler(this.GenerarListado_Click);
            // 
            // GenerarInforme
            // 
            this.GenerarInforme.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GenerarInforme.Location = new System.Drawing.Point(6, 217);
            this.GenerarInforme.Name = "GenerarInforme";
            this.GenerarInforme.Size = new System.Drawing.Size(121, 44);
            this.GenerarInforme.TabIndex = 4;
            this.GenerarInforme.Text = "Generar Informe";
            this.GenerarInforme.UseVisualStyleBackColor = true;
            this.GenerarInforme.Click += new System.EventHandler(this.GenerarInforme_Click);
            // 
            // Editar
            // 
            this.Editar.Location = new System.Drawing.Point(6, 117);
            this.Editar.Name = "Editar";
            this.Editar.Size = new System.Drawing.Size(121, 44);
            this.Editar.TabIndex = 3;
            this.Editar.Text = "Editar";
            this.Editar.UseVisualStyleBackColor = true;
            this.Editar.Click += new System.EventHandler(this.Editar_Click);
            // 
            // Consultar
            // 
            this.Consultar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Consultar.Location = new System.Drawing.Point(6, 67);
            this.Consultar.Name = "Consultar";
            this.Consultar.Size = new System.Drawing.Size(121, 44);
            this.Consultar.TabIndex = 2;
            this.Consultar.Text = "Consultar";
            this.Consultar.UseVisualStyleBackColor = true;
            this.Consultar.Click += new System.EventHandler(this.Consultar_Click);
            // 
            // Eliminar
            // 
            this.Eliminar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Eliminar.Location = new System.Drawing.Point(6, 167);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(121, 44);
            this.Eliminar.TabIndex = 1;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseVisualStyleBackColor = true;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // Crear
            // 
            this.Crear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Crear.Location = new System.Drawing.Point(6, 17);
            this.Crear.Name = "Crear";
            this.Crear.Size = new System.Drawing.Size(121, 44);
            this.Crear.TabIndex = 0;
            this.Crear.Text = "Dar de Alta";
            this.Crear.UseVisualStyleBackColor = true;
            this.Crear.Click += new System.EventHandler(this.Crear_Click);
            // 
            // Asignar
            // 
            this.Asignar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Asignar.Location = new System.Drawing.Point(6, 317);
            this.Asignar.Name = "Asignar";
            this.Asignar.Size = new System.Drawing.Size(121, 44);
            this.Asignar.TabIndex = 6;
            this.Asignar.Text = "Crear Jornada";
            this.Asignar.UseVisualStyleBackColor = true;
            this.Asignar.Click += new System.EventHandler(this.Asignar_Click);
            // 
            // PantallaTrabajador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 404);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "PantallaTrabajador";
            this.Text = "TrabajdorPrincipal";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Mostrar)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Buscador;
        private System.Windows.Forms.DataGridView Mostrar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Crear;
        private System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.Button Consultar;
        private System.Windows.Forms.ComboBox Premisa;
        private System.Windows.Forms.Button Editar;
        private System.Windows.Forms.ComboBox BusquedaTipo;
        private System.Windows.Forms.Button GenerarInforme;
        private System.Windows.Forms.Button GenerarListado;
        private System.Windows.Forms.Button Asignar;
    }
}