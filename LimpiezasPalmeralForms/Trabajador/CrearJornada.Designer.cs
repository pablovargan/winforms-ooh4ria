namespace LimpiezasPalmeralForms.Trabajador
{
    partial class CrearJornada
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
            this.Jornadas = new System.Windows.Forms.GroupBox();
            this.Instalaciones = new System.Windows.Forms.DataGridView();
            this.Trabajadores = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Crear = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            this.FechaBox = new System.Windows.Forms.DateTimePicker();
            this.Jornada = new System.Windows.Forms.DataGridView();
            this.Jornadas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Instalaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Trabajadores)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Jornada)).BeginInit();
            this.SuspendLayout();
            // 
            // Jornadas
            // 
            this.Jornadas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Jornadas.Controls.Add(this.Jornada);
            this.Jornadas.Controls.Add(this.FechaBox);
            this.Jornadas.Controls.Add(this.Instalaciones);
            this.Jornadas.Controls.Add(this.Trabajadores);
            this.Jornadas.Location = new System.Drawing.Point(12, 13);
            this.Jornadas.Name = "Jornadas";
            this.Jornadas.Size = new System.Drawing.Size(870, 298);
            this.Jornadas.TabIndex = 0;
            this.Jornadas.TabStop = false;
            this.Jornadas.Text = "Jornadas";
            // 
            // Instalaciones
            // 
            this.Instalaciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Instalaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Instalaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Instalaciones.Location = new System.Drawing.Point(295, 19);
            this.Instalaciones.MultiSelect = false;
            this.Instalaciones.Name = "Instalaciones";
            this.Instalaciones.ReadOnly = true;
            this.Instalaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Instalaciones.Size = new System.Drawing.Size(278, 273);
            this.Instalaciones.TabIndex = 1;
            // 
            // Trabajadores
            // 
            this.Trabajadores.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Trabajadores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Trabajadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Trabajadores.Location = new System.Drawing.Point(6, 19);
            this.Trabajadores.MultiSelect = false;
            this.Trabajadores.Name = "Trabajadores";
            this.Trabajadores.ReadOnly = true;
            this.Trabajadores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Trabajadores.Size = new System.Drawing.Size(278, 273);
            this.Trabajadores.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.Crear);
            this.groupBox2.Controls.Add(this.Cancelar);
            this.groupBox2.Location = new System.Drawing.Point(12, 317);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(870, 74);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Acciones";
            // 
            // Crear
            // 
            this.Crear.Location = new System.Drawing.Point(279, 19);
            this.Crear.Name = "Crear";
            this.Crear.Size = new System.Drawing.Size(140, 44);
            this.Crear.TabIndex = 11;
            this.Crear.Text = "Crear";
            this.Crear.UseVisualStyleBackColor = true;
            this.Crear.Click += new System.EventHandler(this.Crear_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.Location = new System.Drawing.Point(425, 19);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(140, 44);
            this.Cancelar.TabIndex = 12;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // FechaBox
            // 
            this.FechaBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FechaBox.Location = new System.Drawing.Point(585, 19);
            this.FechaBox.Name = "FechaBox";
            this.FechaBox.Size = new System.Drawing.Size(279, 20);
            this.FechaBox.TabIndex = 2;
            // 
            // Jornada
            // 
            this.Jornada.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Jornada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Jornada.Location = new System.Drawing.Point(585, 45);
            this.Jornada.MultiSelect = false;
            this.Jornada.Name = "Jornada";
            this.Jornada.ReadOnly = true;
            this.Jornada.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Jornada.Size = new System.Drawing.Size(279, 247);
            this.Jornada.TabIndex = 3;
            // 
            // CrearJornada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 403);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Jornadas);
            this.Name = "CrearJornada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear Jornada";
            this.Jornadas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Instalaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Trabajadores)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Jornada)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Jornadas;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Crear;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.DataGridView Instalaciones;
        private System.Windows.Forms.DataGridView Trabajadores;
        private System.Windows.Forms.DateTimePicker FechaBox;
        private System.Windows.Forms.DataGridView Jornada;
    }
}