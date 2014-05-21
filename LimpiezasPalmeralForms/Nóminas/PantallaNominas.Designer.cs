namespace LimpiezasPalmeralForms.Trabajador.Nóminas
{
    partial class PantallaNominas
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
            this.Premisa = new System.Windows.Forms.ComboBox();
            this.Mostrar = new System.Windows.Forms.DataGridView();
            this.Buscador = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Editar = new System.Windows.Forms.Button();
            this.Consultar = new System.Windows.Forms.Button();
            this.Crear = new System.Windows.Forms.Button();
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
            this.groupBox1.Controls.Add(this.Premisa);
            this.groupBox1.Controls.Add(this.Mostrar);
            this.groupBox1.Controls.Add(this.Buscador);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(563, 354);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nominas";
            // 
            // Premisa
            // 
            this.Premisa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Premisa.FormattingEnabled = true;
            this.Premisa.Items.AddRange(new object[] {
            "Trabajador",
            "Fecha",
            "Parte Fija"});
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
            this.Mostrar.Size = new System.Drawing.Size(551, 303);
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
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.Editar);
            this.groupBox2.Controls.Add(this.Consultar);
            this.groupBox2.Controls.Add(this.Crear);
            this.groupBox2.Location = new System.Drawing.Point(581, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(133, 354);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Acciones";
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
            // Crear
            // 
            this.Crear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Crear.Location = new System.Drawing.Point(6, 17);
            this.Crear.Name = "Crear";
            this.Crear.Size = new System.Drawing.Size(121, 44);
            this.Crear.TabIndex = 0;
            this.Crear.Text = "Crear Nomina";
            this.Crear.UseVisualStyleBackColor = true;
            this.Crear.Click += new System.EventHandler(this.Crear_Click);
            // 
            // PantallaNominas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 378);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "PantallaNominas";
            this.Text = "PantallaNominas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Mostrar)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox Premisa;
        private System.Windows.Forms.DataGridView Mostrar;
        private System.Windows.Forms.TextBox Buscador;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Editar;
        private System.Windows.Forms.Button Consultar;
        private System.Windows.Forms.Button Crear;

    }
}