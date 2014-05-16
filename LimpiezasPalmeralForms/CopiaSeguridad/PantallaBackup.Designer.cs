namespace LimpiezasPalmeralForms.Backup
{
    partial class PantallaBackup
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
            this.dataGridViewCopiasSeguridad = new System.Windows.Forms.DataGridView();
            this.groupBoxClientesAcciones = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.restaurarButton = new System.Windows.Forms.Button();
            this.FechaCopiaSeguridad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCopiaSeguridad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCopiasSeguridad)).BeginInit();
            this.groupBoxClientesAcciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dataGridViewCopiasSeguridad);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(590, 338);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Copias de Seguridad Realizadas";
            // 
            // dataGridViewCopiasSeguridad
            // 
            this.dataGridViewCopiasSeguridad.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridViewCopiasSeguridad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCopiasSeguridad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FechaCopiaSeguridad,
            this.NombreCopiaSeguridad});
            this.dataGridViewCopiasSeguridad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCopiasSeguridad.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewCopiasSeguridad.Name = "dataGridViewCopiasSeguridad";
            this.dataGridViewCopiasSeguridad.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCopiasSeguridad.Size = new System.Drawing.Size(584, 319);
            this.dataGridViewCopiasSeguridad.TabIndex = 2;
            // 
            // groupBoxClientesAcciones
            // 
            this.groupBoxClientesAcciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxClientesAcciones.Controls.Add(this.restaurarButton);
            this.groupBoxClientesAcciones.Controls.Add(this.button1);
            this.groupBoxClientesAcciones.Location = new System.Drawing.Point(608, 12);
            this.groupBoxClientesAcciones.Name = "groupBoxClientesAcciones";
            this.groupBoxClientesAcciones.Size = new System.Drawing.Size(133, 338);
            this.groupBoxClientesAcciones.TabIndex = 2;
            this.groupBoxClientesAcciones.TabStop = false;
            this.groupBoxClientesAcciones.Text = "Acciones";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 44);
            this.button1.TabIndex = 5;
            this.button1.Text = "Crear Copia de Seguridad";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // restaurarButton
            // 
            this.restaurarButton.Location = new System.Drawing.Point(6, 69);
            this.restaurarButton.Name = "restaurarButton";
            this.restaurarButton.Size = new System.Drawing.Size(121, 44);
            this.restaurarButton.TabIndex = 6;
            this.restaurarButton.Text = "Restaurar";
            this.restaurarButton.UseVisualStyleBackColor = true;
            this.restaurarButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // FechaCopiaSeguridad
            // 
            this.FechaCopiaSeguridad.HeaderText = "Fecha";
            this.FechaCopiaSeguridad.Name = "FechaCopiaSeguridad";
            this.FechaCopiaSeguridad.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.FechaCopiaSeguridad.Width = 300;
            // 
            // NombreCopiaSeguridad
            // 
            this.NombreCopiaSeguridad.HeaderText = "Nombre";
            this.NombreCopiaSeguridad.Name = "NombreCopiaSeguridad";
            this.NombreCopiaSeguridad.Width = 300;
            // 
            // PantallaBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 362);
            this.Controls.Add(this.groupBoxClientesAcciones);
            this.Controls.Add(this.groupBox1);
            this.Name = "PantallaBackup";
            this.Text = "s";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCopiasSeguridad)).EndInit();
            this.groupBoxClientesAcciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewCopiasSeguridad;
        private System.Windows.Forms.GroupBox groupBoxClientesAcciones;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button restaurarButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaCopiaSeguridad;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCopiaSeguridad;
    }
}