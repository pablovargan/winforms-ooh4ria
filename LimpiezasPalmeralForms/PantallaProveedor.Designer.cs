namespace LimpiezasPalmeralForms
{
    partial class PantallaProveedor
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
            this.button1 = new System.Windows.Forms.Button();
            this.dniBox = new System.Windows.Forms.TextBox();
            this.nombreBox = new System.Windows.Forms.TextBox();
            this.telefonoBox = new System.Windows.Forms.TextBox();
            this.localidadBox = new System.Windows.Forms.TextBox();
            this.provinciaBox = new System.Windows.Forms.TextBox();
            this.codigoPostalBox = new System.Windows.Forms.TextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.paisBox = new System.Windows.Forms.TextBox();
            this.descripcionBox = new System.Windows.Forms.TextBox();
            this.direccionBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(374, 548);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Crear Proveedor";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.altaProveedor_click);
            // 
            // dniBox
            // 
            this.dniBox.Location = new System.Drawing.Point(92, 59);
            this.dniBox.Name = "dniBox";
            this.dniBox.Size = new System.Drawing.Size(100, 22);
            this.dniBox.TabIndex = 1;
            // 
            // nombreBox
            // 
            this.nombreBox.Location = new System.Drawing.Point(92, 87);
            this.nombreBox.Name = "nombreBox";
            this.nombreBox.Size = new System.Drawing.Size(100, 22);
            this.nombreBox.TabIndex = 2;
            // 
            // telefonoBox
            // 
            this.telefonoBox.Location = new System.Drawing.Point(92, 115);
            this.telefonoBox.Name = "telefonoBox";
            this.telefonoBox.Size = new System.Drawing.Size(100, 22);
            this.telefonoBox.TabIndex = 3;
            // 
            // localidadBox
            // 
            this.localidadBox.Location = new System.Drawing.Point(92, 172);
            this.localidadBox.Name = "localidadBox";
            this.localidadBox.Size = new System.Drawing.Size(100, 22);
            this.localidadBox.TabIndex = 4;
            // 
            // provinciaBox
            // 
            this.provinciaBox.Location = new System.Drawing.Point(92, 201);
            this.provinciaBox.Name = "provinciaBox";
            this.provinciaBox.Size = new System.Drawing.Size(100, 22);
            this.provinciaBox.TabIndex = 5;
            // 
            // codigoPostalBox
            // 
            this.codigoPostalBox.Location = new System.Drawing.Point(92, 230);
            this.codigoPostalBox.Name = "codigoPostalBox";
            this.codigoPostalBox.Size = new System.Drawing.Size(100, 22);
            this.codigoPostalBox.TabIndex = 6;
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(92, 259);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(100, 22);
            this.emailBox.TabIndex = 7;
            // 
            // paisBox
            // 
            this.paisBox.Location = new System.Drawing.Point(92, 288);
            this.paisBox.Name = "paisBox";
            this.paisBox.Size = new System.Drawing.Size(100, 22);
            this.paisBox.TabIndex = 8;
            // 
            // descripcionBox
            // 
            this.descripcionBox.Location = new System.Drawing.Point(92, 317);
            this.descripcionBox.Name = "descripcionBox";
            this.descripcionBox.Size = new System.Drawing.Size(100, 22);
            this.descripcionBox.TabIndex = 9;
            // 
            // textBox1
            // 
            this.direccionBox.Location = new System.Drawing.Point(92, 144);
            this.direccionBox.Name = "textBox1";
            this.direccionBox.Size = new System.Drawing.Size(100, 22);
            this.direccionBox.TabIndex = 10;
            // 
            // PantallaProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 628);
            this.Controls.Add(this.direccionBox);
            this.Controls.Add(this.descripcionBox);
            this.Controls.Add(this.paisBox);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.codigoPostalBox);
            this.Controls.Add(this.provinciaBox);
            this.Controls.Add(this.localidadBox);
            this.Controls.Add(this.telefonoBox);
            this.Controls.Add(this.nombreBox);
            this.Controls.Add(this.dniBox);
            this.Controls.Add(this.button1);
            this.Name = "PantallaProveedor";
            this.Text = "PantallaProveedores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox dniBox;
        private System.Windows.Forms.TextBox nombreBox;
        private System.Windows.Forms.TextBox telefonoBox;
        private System.Windows.Forms.TextBox localidadBox;
        private System.Windows.Forms.TextBox provinciaBox;
        private System.Windows.Forms.TextBox codigoPostalBox;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox paisBox;
        private System.Windows.Forms.TextBox descripcionBox;
        private System.Windows.Forms.TextBox direccionBox;
        
        
        
              
    }
}