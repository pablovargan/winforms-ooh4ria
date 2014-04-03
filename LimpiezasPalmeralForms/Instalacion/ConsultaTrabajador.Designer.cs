namespace LimpiezasPalmeralForms
{
    partial class ConsultaTrabajador
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
            this.GridConsulta = new System.Windows.Forms.DataGridView();
            this.comboBox_instalaciones = new System.Windows.Forms.ComboBox();
            this.comboBox_provincia = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridConsulta)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.GridConsulta);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(622, 337);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consultar trabajadores";
            // 
            // GridConsulta
            // 
            this.GridConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridConsulta.Location = new System.Drawing.Point(7, 73);
            this.GridConsulta.Name = "GridConsulta";
            this.GridConsulta.Size = new System.Drawing.Size(609, 258);
            this.GridConsulta.TabIndex = 1;
            this.GridConsulta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridConsulta_CellContentClick);
            // 
            // comboBox_instalaciones
            // 
            this.comboBox_instalaciones.FormattingEnabled = true;
            this.comboBox_instalaciones.Location = new System.Drawing.Point(6, 19);
            this.comboBox_instalaciones.Name = "comboBox_instalaciones";
            this.comboBox_instalaciones.Size = new System.Drawing.Size(121, 21);
            this.comboBox_instalaciones.TabIndex = 0;
            this.comboBox_instalaciones.SelectedIndexChanged += new System.EventHandler(this.comboBox_instalaciones_SelectedIndexChanged);
            // 
            // comboBox_provincia
            // 
            this.comboBox_provincia.FormattingEnabled = true;
            this.comboBox_provincia.Location = new System.Drawing.Point(6, 19);
            this.comboBox_provincia.Name = "comboBox_provincia";
            this.comboBox_provincia.Size = new System.Drawing.Size(121, 21);
            this.comboBox_provincia.TabIndex = 2;
            this.comboBox_provincia.SelectedIndexChanged += new System.EventHandler(this.comboBox_provincia_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox_provincia);
            this.groupBox2.Location = new System.Drawing.Point(7, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(133, 48);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Seleccione provincia";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBox_instalaciones);
            this.groupBox3.Location = new System.Drawing.Point(155, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(135, 48);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Seleccione instalación";
            // 
            // ConsultaTrabajador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 361);
            this.Controls.Add(this.groupBox1);
            this.Name = "ConsultaTrabajador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultaTrabajador";
            this.Load += new System.EventHandler(this.ConsultaTrabajador_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridConsulta)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView GridConsulta;
        private System.Windows.Forms.ComboBox comboBox_instalaciones;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox_provincia;
    }
}