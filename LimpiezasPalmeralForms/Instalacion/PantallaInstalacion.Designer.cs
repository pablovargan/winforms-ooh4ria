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
            this.instalacionGrid = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
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
            this.Instalación.Controls.Add(this.instalacionGrid);
            this.Instalación.Controls.Add(this.button2);
            this.Instalación.Controls.Add(this.textBox1);
            this.Instalación.Location = new System.Drawing.Point(12, 12);
            this.Instalación.Name = "Instalación";
            this.Instalación.Size = new System.Drawing.Size(822, 334);
            this.Instalación.TabIndex = 0;
            this.Instalación.TabStop = false;
            this.Instalación.Text = "Instalaciones";
            // 
            // instalacionGrid
            // 
            this.instalacionGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.instalacionGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.instalacionGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.instalacionGrid.Location = new System.Drawing.Point(7, 46);
            this.instalacionGrid.Name = "instalacionGrid";
            this.instalacionGrid.Size = new System.Drawing.Size(809, 282);
            this.instalacionGrid.TabIndex = 2;
            this.instalacionGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridInstalacion_Load);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(7, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(129, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(687, 20);
            this.textBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(840, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(177, 334);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Acciones";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 57);
            this.button1.TabIndex = 0;
            this.button1.Text = "Dar de alta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AltaInstalacion_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 145);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(165, 57);
            this.button3.TabIndex = 1;
            this.button3.Text = "Dar de baja";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 82);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(165, 57);
            this.button4.TabIndex = 2;
            this.button4.Text = "Editar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(6, 208);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(165, 57);
            this.button5.TabIndex = 3;
            this.button5.Text = "Gestionar trabajadores";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(6, 271);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(165, 57);
            this.button6.TabIndex = 4;
            this.button6.Text = "Consultar trabajadores";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // PantallaInstalacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 354);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Instalación);
            this.Name = "PantallaInstalacion";
            this.Text = "PantallaInstalacion";
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView instalacionGrid;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
    }
}