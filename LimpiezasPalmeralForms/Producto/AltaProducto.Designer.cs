namespace LimpiezasPalmeralForms.Producto
{
    partial class AltaProducto
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
            this.buttonEscogerImagen = new System.Windows.Forms.Button();
            this.labelImagen = new System.Windows.Forms.Label();
            this.pictureBoxImagen = new System.Windows.Forms.PictureBox();
            this.numericStock = new System.Windows.Forms.NumericUpDown();
            this.labelStock = new System.Windows.Forms.Label();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericStock)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonEscogerImagen);
            this.groupBox1.Controls.Add(this.labelImagen);
            this.groupBox1.Controls.Add(this.pictureBoxImagen);
            this.groupBox1.Controls.Add(this.numericStock);
            this.groupBox1.Controls.Add(this.labelStock);
            this.groupBox1.Controls.Add(this.textBoxDescripcion);
            this.groupBox1.Controls.Add(this.textBoxNombre);
            this.groupBox1.Controls.Add(this.textBoxId);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.labelNombre);
            this.groupBox1.Controls.Add(this.labelId);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(449, 223);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Producto";
            // 
            // buttonEscogerImagen
            // 
            this.buttonEscogerImagen.Location = new System.Drawing.Point(279, 21);
            this.buttonEscogerImagen.Name = "buttonEscogerImagen";
            this.buttonEscogerImagen.Size = new System.Drawing.Size(164, 23);
            this.buttonEscogerImagen.TabIndex = 14;
            this.buttonEscogerImagen.Text = "Escoger imagen";
            this.buttonEscogerImagen.UseVisualStyleBackColor = true;
            this.buttonEscogerImagen.Click += new System.EventHandler(this.buttonEscogerImagen_Click);
            // 
            // labelImagen
            // 
            this.labelImagen.AutoSize = true;
            this.labelImagen.Location = new System.Drawing.Point(227, 26);
            this.labelImagen.Name = "labelImagen";
            this.labelImagen.Size = new System.Drawing.Size(42, 13);
            this.labelImagen.TabIndex = 13;
            this.labelImagen.Text = "Imagen";
            // 
            // pictureBoxImagen
            // 
            this.pictureBoxImagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxImagen.Location = new System.Drawing.Point(230, 49);
            this.pictureBoxImagen.Name = "pictureBoxImagen";
            this.pictureBoxImagen.Size = new System.Drawing.Size(213, 158);
            this.pictureBoxImagen.TabIndex = 12;
            this.pictureBoxImagen.TabStop = false;
            // 
            // numericStock
            // 
            this.numericStock.Location = new System.Drawing.Point(101, 82);
            this.numericStock.Name = "numericStock";
            this.numericStock.Size = new System.Drawing.Size(100, 20);
            this.numericStock.TabIndex = 11;
            // 
            // labelStock
            // 
            this.labelStock.AutoSize = true;
            this.labelStock.Location = new System.Drawing.Point(15, 84);
            this.labelStock.Name = "labelStock";
            this.labelStock.Size = new System.Drawing.Size(35, 13);
            this.labelStock.TabIndex = 9;
            this.labelStock.Text = "Stock";
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Location = new System.Drawing.Point(18, 125);
            this.textBoxDescripcion.Multiline = true;
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDescripcion.Size = new System.Drawing.Size(183, 82);
            this.textBoxDescripcion.TabIndex = 7;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(101, 49);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(100, 20);
            this.textBoxNombre.TabIndex = 6;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(101, 21);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(100, 20);
            this.textBoxId.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descripción";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(15, 52);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(44, 13);
            this.labelNombre.TabIndex = 1;
            this.labelNombre.Text = "Nombre";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(15, 24);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(16, 13);
            this.labelId.TabIndex = 0;
            this.labelId.Text = "Id";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonCancelar);
            this.groupBox2.Controls.Add(this.buttonAceptar);
            this.groupBox2.Location = new System.Drawing.Point(12, 256);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(449, 74);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Acciones";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(230, 19);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(140, 44);
            this.buttonCancelar.TabIndex = 5;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(84, 19);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(140, 44);
            this.buttonAceptar.TabIndex = 1;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // AltaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 342);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AltaProducto";
            this.Text = "AltaProducto";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericStock)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Label labelStock;
        private System.Windows.Forms.NumericUpDown numericStock;
        private System.Windows.Forms.PictureBox pictureBoxImagen;
        private System.Windows.Forms.Label labelImagen;
        private System.Windows.Forms.Button buttonEscogerImagen;
    }
}