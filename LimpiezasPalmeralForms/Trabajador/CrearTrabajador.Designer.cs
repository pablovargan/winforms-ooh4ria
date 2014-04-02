namespace LimpiezasPalmeralForms
{
    partial class CrearTrabajador
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
            this.components = new System.ComponentModel.Container();
            this.Crear = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Tipo1 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Telefono = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Pais = new System.Windows.Forms.TextBox();
            this.Provincia = new System.Windows.Forms.TextBox();
            this.Localidad = new System.Windows.Forms.TextBox();
            this.CP = new System.Windows.Forms.TextBox();
            this.Direccion = new System.Windows.Forms.TextBox();
            this.Apellidos = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.NIF = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.proveedorCENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorCENBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Crear
            // 
            this.Crear.Location = new System.Drawing.Point(334, 342);
            this.Crear.Name = "Crear";
            this.Crear.Size = new System.Drawing.Size(125, 23);
            this.Crear.TabIndex = 18;
            this.Crear.Text = "Crear";
            this.Crear.UseVisualStyleBackColor = true;
            this.Crear.Click += new System.EventHandler(this.Crear_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.Location = new System.Drawing.Point(475, 342);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Cancelar.TabIndex = 22;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Tipo1);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.Telefono);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Pais);
            this.groupBox1.Controls.Add(this.Provincia);
            this.groupBox1.Controls.Add(this.Localidad);
            this.groupBox1.Controls.Add(this.CP);
            this.groupBox1.Controls.Add(this.Direccion);
            this.groupBox1.Controls.Add(this.Apellidos);
            this.groupBox1.Controls.Add(this.Nombre);
            this.groupBox1.Controls.Add(this.NIF);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(581, 319);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Trabajador";
            // 
            // Tipo1
            // 
            this.Tipo1.FormattingEnabled = true;
            this.Tipo1.Items.AddRange(new object[] {
            "Cooperativista",
            "Empleado"});
            this.Tipo1.Location = new System.Drawing.Point(94, 255);
            this.Tipo1.Name = "Tipo1";
            this.Tipo1.Size = new System.Drawing.Size(121, 21);
            this.Tipo1.TabIndex = 41;
            this.Tipo1.Text = "Selecciona uno...";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(39, 258);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 13);
            this.label11.TabIndex = 40;
            this.label11.Text = "Tipo";
            // 
            // Telefono
            // 
            this.Telefono.Location = new System.Drawing.Point(412, 206);
            this.Telefono.Name = "Telefono";
            this.Telefono.Size = new System.Drawing.Size(133, 20);
            this.Telefono.TabIndex = 38;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(343, 213);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 37;
            this.label10.Text = "Teléfono";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 213);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 36;
            this.label9.Text = "País";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(343, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "Provincia";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Localidad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(343, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "C.P,";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Dirección";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(343, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Apellidos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Nombre";
            // 
            // Pais
            // 
            this.Pais.Location = new System.Drawing.Point(94, 207);
            this.Pais.Name = "Pais";
            this.Pais.Size = new System.Drawing.Size(133, 20);
            this.Pais.TabIndex = 29;
            // 
            // Provincia
            // 
            this.Provincia.Location = new System.Drawing.Point(412, 156);
            this.Provincia.Name = "Provincia";
            this.Provincia.Size = new System.Drawing.Size(133, 20);
            this.Provincia.TabIndex = 28;
            // 
            // Localidad
            // 
            this.Localidad.Location = new System.Drawing.Point(94, 157);
            this.Localidad.Name = "Localidad";
            this.Localidad.Size = new System.Drawing.Size(133, 20);
            this.Localidad.TabIndex = 27;
            // 
            // CP
            // 
            this.CP.Location = new System.Drawing.Point(412, 110);
            this.CP.Name = "CP";
            this.CP.Size = new System.Drawing.Size(133, 20);
            this.CP.TabIndex = 26;
            // 
            // Direccion
            // 
            this.Direccion.Location = new System.Drawing.Point(94, 111);
            this.Direccion.Name = "Direccion";
            this.Direccion.Size = new System.Drawing.Size(133, 20);
            this.Direccion.TabIndex = 25;
            // 
            // Apellidos
            // 
            this.Apellidos.Location = new System.Drawing.Point(412, 65);
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.Size = new System.Drawing.Size(133, 20);
            this.Apellidos.TabIndex = 24;
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(94, 65);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(133, 20);
            this.Nombre.TabIndex = 23;
            // 
            // NIF
            // 
            this.NIF.Location = new System.Drawing.Point(94, 18);
            this.NIF.Name = "NIF";
            this.NIF.Size = new System.Drawing.Size(133, 20);
            this.NIF.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "NIF";
            // 
            // proveedorCENBindingSource
            // 
            this.proveedorCENBindingSource.DataSource = typeof(PalmeralGenNHibernate.CEN.Default_.ProveedorCEN);
            // 
            // CrearTrabajador
            // 
            this.ClientSize = new System.Drawing.Size(605, 386);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.Crear);
            this.Name = "CrearTrabajador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorCENBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Crear;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Telefono;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Pais;
        private System.Windows.Forms.TextBox Provincia;
        private System.Windows.Forms.TextBox Localidad;
        private System.Windows.Forms.TextBox CP;
        private System.Windows.Forms.TextBox Direccion;
        private System.Windows.Forms.TextBox Apellidos;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.TextBox NIF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Tipo1;
        private System.Windows.Forms.BindingSource proveedorCENBindingSource;
    }
}