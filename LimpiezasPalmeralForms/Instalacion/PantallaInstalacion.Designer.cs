﻿namespace LimpiezasPalmeralForms
{
    partial class PantallaInstalacion
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
            this.Instalación = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.instalacionGrid = new System.Windows.Forms.DataGridView();
            this.textBox_buscar = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button_consulta = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Instalación.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.instalacionGrid)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Instalación
            // 
            this.Instalación.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Instalación.Controls.Add(this.comboBox1);
            this.Instalación.Controls.Add(this.instalacionGrid);
            this.Instalación.Controls.Add(this.textBox_buscar);
            this.Instalación.Location = new System.Drawing.Point(12, 13);
            this.Instalación.Name = "Instalación";
            this.Instalación.Padding = new System.Windows.Forms.Padding(4);
            this.Instalación.Size = new System.Drawing.Size(562, 353);
            this.Instalación.TabIndex = 0;
            this.Instalación.TabStop = false;
            this.Instalación.Text = "Instalaciones";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(8, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // instalacionGrid
            // 
            this.instalacionGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.instalacionGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.instalacionGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.instalacionGrid.Location = new System.Drawing.Point(8, 47);
            this.instalacionGrid.Name = "instalacionGrid";
            this.instalacionGrid.Size = new System.Drawing.Size(549, 300);
            this.instalacionGrid.TabIndex = 2;
            this.instalacionGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridInstalacion_Load);
            // 
            // textBox_buscar
            // 
            this.textBox_buscar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_buscar.Location = new System.Drawing.Point(135, 19);
            this.textBox_buscar.Name = "textBox_buscar";
            this.textBox_buscar.Size = new System.Drawing.Size(420, 20);
            this.textBox_buscar.TabIndex = 0;
            this.textBox_buscar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button_consulta);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(581, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Size = new System.Drawing.Size(133, 353);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Acciones";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 119);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(121, 44);
            this.button4.TabIndex = 2;
            this.button4.Text = "Eliminar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 69);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 44);
            this.button3.TabIndex = 1;
            this.button3.Text = "Editar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button_consulta
            // 
            this.button_consulta.Location = new System.Drawing.Point(6, 169);
            this.button_consulta.Name = "button_consulta";
            this.button_consulta.Size = new System.Drawing.Size(121, 44);
            this.button_consulta.TabIndex = 3;
            this.button_consulta.Text = "Consultar trabajadores";
            this.button_consulta.UseVisualStyleBackColor = true;
            this.button_consulta.Click += new System.EventHandler(this.button_consulta_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "Dar de alta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AltaInstalacion_Click);
            // 
            // PantallaInstalacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 378);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Instalación);
            this.Name = "PantallaInstalacion";
            this.Text = "PantallaInstalacion";
            this.Load += new System.EventHandler(this.PantallaInstalacion_Load);
            this.Instalación.ResumeLayout(false);
            this.Instalación.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.instalacionGrid)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Instalación;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_buscar;
        private System.Windows.Forms.DataGridView instalacionGrid;
        private System.Windows.Forms.Button button_consulta;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}