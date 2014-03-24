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
            this.components = new System.ComponentModel.Container();
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
            this.proveedoresGB = new System.Windows.Forms.GroupBox();
            this.proveedorCENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.palmeralGenNHibernateDataSet = new LimpiezasPalmeralForms.PalmeralGenNHibernateDataSet();
            this.proveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proveedorTableAdapter = new LimpiezasPalmeralForms.PalmeralGenNHibernateDataSetTableAdapters.ProveedorTableAdapter();
            this.proveedorGridView = new System.Windows.Forms.DataGridView();
            this.proveedorCENBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.proveedoresGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorCENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.palmeralGenNHibernateDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorCENBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1050, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Crear Proveedor";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.altaProveedor_click);
            // 
            // dniBox
            // 
            this.dniBox.Location = new System.Drawing.Point(1050, 327);
            this.dniBox.Name = "dniBox";
            this.dniBox.Size = new System.Drawing.Size(100, 22);
            this.dniBox.TabIndex = 1;
            // 
            // nombreBox
            // 
            this.nombreBox.Location = new System.Drawing.Point(1050, 355);
            this.nombreBox.Name = "nombreBox";
            this.nombreBox.Size = new System.Drawing.Size(100, 22);
            this.nombreBox.TabIndex = 2;
            // 
            // telefonoBox
            // 
            this.telefonoBox.Location = new System.Drawing.Point(1050, 383);
            this.telefonoBox.Name = "telefonoBox";
            this.telefonoBox.Size = new System.Drawing.Size(100, 22);
            this.telefonoBox.TabIndex = 3;
            // 
            // localidadBox
            // 
            this.localidadBox.Location = new System.Drawing.Point(1050, 440);
            this.localidadBox.Name = "localidadBox";
            this.localidadBox.Size = new System.Drawing.Size(100, 22);
            this.localidadBox.TabIndex = 4;
            // 
            // provinciaBox
            // 
            this.provinciaBox.Location = new System.Drawing.Point(1050, 469);
            this.provinciaBox.Name = "provinciaBox";
            this.provinciaBox.Size = new System.Drawing.Size(100, 22);
            this.provinciaBox.TabIndex = 5;
            // 
            // codigoPostalBox
            // 
            this.codigoPostalBox.Location = new System.Drawing.Point(1050, 498);
            this.codigoPostalBox.Name = "codigoPostalBox";
            this.codigoPostalBox.Size = new System.Drawing.Size(100, 22);
            this.codigoPostalBox.TabIndex = 6;
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(1050, 527);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(100, 22);
            this.emailBox.TabIndex = 7;
            // 
            // paisBox
            // 
            this.paisBox.Location = new System.Drawing.Point(1050, 556);
            this.paisBox.Name = "paisBox";
            this.paisBox.Size = new System.Drawing.Size(100, 22);
            this.paisBox.TabIndex = 8;
            // 
            // descripcionBox
            // 
            this.descripcionBox.Location = new System.Drawing.Point(1050, 585);
            this.descripcionBox.Name = "descripcionBox";
            this.descripcionBox.Size = new System.Drawing.Size(100, 22);
            this.descripcionBox.TabIndex = 9;
            // 
            // direccionBox
            // 
            this.direccionBox.Location = new System.Drawing.Point(1050, 412);
            this.direccionBox.Name = "direccionBox";
            this.direccionBox.Size = new System.Drawing.Size(100, 22);
            this.direccionBox.TabIndex = 10;
            // 
            // proveedoresGB
            // 
            this.proveedoresGB.Controls.Add(this.proveedorGridView);
            this.proveedoresGB.Location = new System.Drawing.Point(12, 12);
            this.proveedoresGB.Name = "proveedoresGB";
            this.proveedoresGB.Size = new System.Drawing.Size(1003, 446);
            this.proveedoresGB.TabIndex = 11;
            this.proveedoresGB.TabStop = false;
            this.proveedoresGB.Text = "Proveedores";
            // 
            // proveedorCENBindingSource
            // 
            this.proveedorCENBindingSource.DataSource = typeof(PalmeralGenNHibernate.CEN.Default_.ProveedorCEN);
            // 
            // palmeralGenNHibernateDataSet
            // 
            this.palmeralGenNHibernateDataSet.DataSetName = "PalmeralGenNHibernateDataSet";
            this.palmeralGenNHibernateDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // proveedorBindingSource
            // 
            this.proveedorBindingSource.DataMember = "Proveedor";
            this.proveedorBindingSource.DataSource = this.palmeralGenNHibernateDataSet;
            // 
            // proveedorTableAdapter
            // 
            this.proveedorTableAdapter.ClearBeforeFill = true;
            // 
            // proveedorGridView
            // 
            this.proveedorGridView.AllowUserToOrderColumns = true;
            this.proveedorGridView.AutoGenerateColumns = false;
            this.proveedorGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.proveedorGridView.DataSource = this.proveedorCENBindingSource;
            this.proveedorGridView.Location = new System.Drawing.Point(6, 21);
            this.proveedorGridView.Name = "proveedorGridView";
            this.proveedorGridView.RowTemplate.Height = 24;
            this.proveedorGridView.Size = new System.Drawing.Size(991, 419);
            this.proveedorGridView.TabIndex = 0;
            // 
            // proveedorCENBindingSource1
            // 
            this.proveedorCENBindingSource1.DataSource = typeof(PalmeralGenNHibernate.CEN.Default_.ProveedorCEN);
            // 
            // PantallaProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 628);
            this.Controls.Add(this.proveedoresGB);
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
            this.proveedoresGB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.proveedorCENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.palmeralGenNHibernateDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorCENBindingSource1)).EndInit();
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
        private System.Windows.Forms.GroupBox proveedoresGB;
        private PalmeralGenNHibernateDataSet palmeralGenNHibernateDataSet;
        private System.Windows.Forms.BindingSource proveedorBindingSource;
        private PalmeralGenNHibernateDataSetTableAdapters.ProveedorTableAdapter proveedorTableAdapter;
        private System.Windows.Forms.BindingSource proveedorCENBindingSource;
        private System.Windows.Forms.DataGridView proveedorGridView;
        private System.Windows.Forms.BindingSource proveedorCENBindingSource1;
        
        
        
              
    }
}