namespace LimpiezasPalmeralForms
{
    partial class PantallaCliente
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
            this.groupBoxClientes = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonClienteBuscar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBoxClientesAcciones = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonClienteDarAlta = new System.Windows.Forms.Button();
            this.groupBoxClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxClientesAcciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxClientes
            // 
            this.groupBoxClientes.Controls.Add(this.textBox1);
            this.groupBoxClientes.Controls.Add(this.buttonClienteBuscar);
            this.groupBoxClientes.Controls.Add(this.dataGridView1);
            this.groupBoxClientes.Location = new System.Drawing.Point(13, 13);
            this.groupBoxClientes.Name = "groupBoxClientes";
            this.groupBoxClientes.Size = new System.Drawing.Size(562, 353);
            this.groupBoxClientes.TabIndex = 0;
            this.groupBoxClientes.TabStop = false;
            this.groupBoxClientes.Text = "Clientes";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(468, 20);
            this.textBox1.TabIndex = 2;
            // 
            // buttonClienteBuscar
            // 
            this.buttonClienteBuscar.Location = new System.Drawing.Point(481, 17);
            this.buttonClienteBuscar.Name = "buttonClienteBuscar";
            this.buttonClienteBuscar.Size = new System.Drawing.Size(75, 23);
            this.buttonClienteBuscar.TabIndex = 1;
            this.buttonClienteBuscar.Text = "Buscar";
            this.buttonClienteBuscar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(549, 302);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBoxClientesAcciones
            // 
            this.groupBoxClientesAcciones.Controls.Add(this.button2);
            this.groupBoxClientesAcciones.Controls.Add(this.button1);
            this.groupBoxClientesAcciones.Controls.Add(this.buttonClienteDarAlta);
            this.groupBoxClientesAcciones.Location = new System.Drawing.Point(581, 13);
            this.groupBoxClientesAcciones.Name = "groupBoxClientesAcciones";
            this.groupBoxClientesAcciones.Size = new System.Drawing.Size(133, 353);
            this.groupBoxClientesAcciones.TabIndex = 1;
            this.groupBoxClientesAcciones.TabStop = false;
            this.groupBoxClientesAcciones.Text = "Acciones";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 77);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Dar de Alta";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Dar de Alta";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // buttonClienteDarAlta
            // 
            this.buttonClienteDarAlta.Location = new System.Drawing.Point(6, 19);
            this.buttonClienteDarAlta.Name = "buttonClienteDarAlta";
            this.buttonClienteDarAlta.Size = new System.Drawing.Size(75, 23);
            this.buttonClienteDarAlta.TabIndex = 0;
            this.buttonClienteDarAlta.Text = "Dar de Alta";
            this.buttonClienteDarAlta.UseVisualStyleBackColor = true;
            this.buttonClienteDarAlta.Click += new System.EventHandler(this.button1_Click);
            // 
            // PantallaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 378);
            this.ControlBox = false;
            this.Controls.Add(this.groupBoxClientesAcciones);
            this.Controls.Add(this.groupBoxClientes);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PantallaCliente";
            this.Text = "PantallaCliente";
            this.groupBoxClientes.ResumeLayout(false);
            this.groupBoxClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxClientesAcciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxClientes;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonClienteBuscar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBoxClientesAcciones;
        private System.Windows.Forms.Button buttonClienteDarAlta;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;

    }
}