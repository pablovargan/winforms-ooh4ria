namespace LimpiezasPalmeralForms.Instalacion.Facturas
{
    partial class PantallaFacturas
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Instalación = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.facturaGrid = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            this.Instalación.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facturaGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.buttonEditar);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(581, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Size = new System.Drawing.Size(133, 353);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Acciones";
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(6, 67);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(121, 44);
            this.buttonEditar.TabIndex = 1;
            this.buttonEditar.Text = "Modificar factura";
            this.buttonEditar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "Crear factura";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Instalación
            // 
            this.Instalación.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Instalación.Controls.Add(this.label2);
            this.Instalación.Controls.Add(this.label1);
            this.Instalación.Controls.Add(this.comboBox2);
            this.Instalación.Controls.Add(this.comboBox1);
            this.Instalación.Controls.Add(this.facturaGrid);
            this.Instalación.Location = new System.Drawing.Point(12, 13);
            this.Instalación.Name = "Instalación";
            this.Instalación.Padding = new System.Windows.Forms.Padding(4);
            this.Instalación.Size = new System.Drawing.Size(563, 353);
            this.Instalación.TabIndex = 2;
            this.Instalación.TabStop = false;
            this.Instalación.Text = "Facturas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Seleccionar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Filtrar";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(324, 20);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(194, 21);
            this.comboBox2.TabIndex = 4;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(45, 20);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(194, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // facturaGrid
            // 
            this.facturaGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.facturaGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.facturaGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.facturaGrid.Location = new System.Drawing.Point(8, 47);
            this.facturaGrid.Name = "facturaGrid";
            this.facturaGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.facturaGrid.Size = new System.Drawing.Size(548, 300);
            this.facturaGrid.TabIndex = 2;
            this.facturaGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.facturaGrid_CellContentClick);
            // 
            // PantallaFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 378);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Instalación);
            this.Name = "PantallaFacturas";
            this.Text = "PantallaFacturas";
            this.Load += new System.EventHandler(this.PantallaFacturas_Load);
            this.groupBox2.ResumeLayout(false);
            this.Instalación.ResumeLayout(false);
            this.Instalación.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facturaGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox Instalación;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView facturaGrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}