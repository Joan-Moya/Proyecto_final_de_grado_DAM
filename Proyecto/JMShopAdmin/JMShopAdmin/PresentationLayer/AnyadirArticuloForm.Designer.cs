namespace JMShopAdmin.PresentationLayer
{
    partial class AnyadirArticuloForm
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
            this.buttonAñadir = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelMarca = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxMarca = new System.Windows.Forms.TextBox();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            this.errorProviderAddProducto = new System.Windows.Forms.ErrorProvider(this.components);
            this.textBoxModelo = new System.Windows.Forms.TextBox();
            this.labelModelo = new System.Windows.Forms.Label();
            this.labelCristal = new System.Windows.Forms.Label();
            this.labelDiametro = new System.Windows.Forms.Label();
            this.labelTipoCorrea = new System.Windows.Forms.Label();
            this.labelImagenProducto = new System.Windows.Forms.Label();
            this.textBoxCristal = new System.Windows.Forms.TextBox();
            this.textBoxDiametro = new System.Windows.Forms.TextBox();
            this.textBoxTipoCorrea = new System.Windows.Forms.TextBox();
            this.textBoxNombreArchivo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAddProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAñadir
            // 
            this.buttonAñadir.Location = new System.Drawing.Point(197, 427);
            this.buttonAñadir.Name = "buttonAñadir";
            this.buttonAñadir.Size = new System.Drawing.Size(75, 23);
            this.buttonAñadir.TabIndex = 0;
            this.buttonAñadir.Text = "Añadir";
            this.buttonAñadir.UseVisualStyleBackColor = true;
            this.buttonAñadir.Click += new System.EventHandler(this.buttonAñadir_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(463, 427);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancelar";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelMarca
            // 
            this.labelMarca.AutoSize = true;
            this.labelMarca.Location = new System.Drawing.Point(61, 28);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(37, 13);
            this.labelMarca.TabIndex = 2;
            this.labelMarca.Text = "Marca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 377);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Precio (€)";
            // 
            // textBoxMarca
            // 
            this.textBoxMarca.Location = new System.Drawing.Point(117, 25);
            this.textBoxMarca.Name = "textBoxMarca";
            this.textBoxMarca.Size = new System.Drawing.Size(155, 20);
            this.textBoxMarca.TabIndex = 5;
            this.textBoxMarca.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxMarca_Validating);
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Location = new System.Drawing.Point(117, 159);
            this.textBoxDescripcion.Multiline = true;
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDescripcion.Size = new System.Drawing.Size(560, 194);
            this.textBoxDescripcion.TabIndex = 6;
            this.textBoxDescripcion.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxDescripcion_Validating);
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Location = new System.Drawing.Point(117, 377);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.Size = new System.Drawing.Size(155, 20);
            this.textBoxPrecio.TabIndex = 7;
            this.textBoxPrecio.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxPrecio_Validating);
            // 
            // errorProviderAddProducto
            // 
            this.errorProviderAddProducto.ContainerControl = this;
            // 
            // textBoxModelo
            // 
            this.textBoxModelo.Location = new System.Drawing.Point(384, 28);
            this.textBoxModelo.Name = "textBoxModelo";
            this.textBoxModelo.Size = new System.Drawing.Size(293, 20);
            this.textBoxModelo.TabIndex = 8;
            this.textBoxModelo.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxModelo_Validating);
            // 
            // labelModelo
            // 
            this.labelModelo.AutoSize = true;
            this.labelModelo.Location = new System.Drawing.Point(322, 31);
            this.labelModelo.Name = "labelModelo";
            this.labelModelo.Size = new System.Drawing.Size(42, 13);
            this.labelModelo.TabIndex = 9;
            this.labelModelo.Text = "Modelo";
            // 
            // labelCristal
            // 
            this.labelCristal.AutoSize = true;
            this.labelCristal.Location = new System.Drawing.Point(61, 75);
            this.labelCristal.Name = "labelCristal";
            this.labelCristal.Size = new System.Drawing.Size(35, 13);
            this.labelCristal.TabIndex = 10;
            this.labelCristal.Text = "Cristal";
            // 
            // labelDiametro
            // 
            this.labelDiametro.AutoSize = true;
            this.labelDiametro.Location = new System.Drawing.Point(49, 115);
            this.labelDiametro.Name = "labelDiametro";
            this.labelDiametro.Size = new System.Drawing.Size(49, 13);
            this.labelDiametro.TabIndex = 11;
            this.labelDiametro.Text = "Diametro";
            // 
            // labelTipoCorrea
            // 
            this.labelTipoCorrea.AutoSize = true;
            this.labelTipoCorrea.Location = new System.Drawing.Point(322, 75);
            this.labelTipoCorrea.Name = "labelTipoCorrea";
            this.labelTipoCorrea.Size = new System.Drawing.Size(76, 13);
            this.labelTipoCorrea.TabIndex = 12;
            this.labelTipoCorrea.Text = "Tipo de correa";
            // 
            // labelImagenProducto
            // 
            this.labelImagenProducto.AutoSize = true;
            this.labelImagenProducto.Location = new System.Drawing.Point(322, 116);
            this.labelImagenProducto.Name = "labelImagenProducto";
            this.labelImagenProducto.Size = new System.Drawing.Size(164, 13);
            this.labelImagenProducto.TabIndex = 13;
            this.labelImagenProducto.Text = "Nombre archivo imagen producto";
            // 
            // textBoxCristal
            // 
            this.textBoxCristal.Location = new System.Drawing.Point(117, 67);
            this.textBoxCristal.Name = "textBoxCristal";
            this.textBoxCristal.Size = new System.Drawing.Size(155, 20);
            this.textBoxCristal.TabIndex = 14;
            this.textBoxCristal.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxCristal_Validating);
            // 
            // textBoxDiametro
            // 
            this.textBoxDiametro.Location = new System.Drawing.Point(117, 108);
            this.textBoxDiametro.Name = "textBoxDiametro";
            this.textBoxDiametro.Size = new System.Drawing.Size(155, 20);
            this.textBoxDiametro.TabIndex = 15;
            this.textBoxDiametro.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxDiametro_Validating);
            // 
            // textBoxTipoCorrea
            // 
            this.textBoxTipoCorrea.Location = new System.Drawing.Point(415, 72);
            this.textBoxTipoCorrea.Name = "textBoxTipoCorrea";
            this.textBoxTipoCorrea.Size = new System.Drawing.Size(262, 20);
            this.textBoxTipoCorrea.TabIndex = 16;
            this.textBoxTipoCorrea.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxTipoCorrea_Validating);
            // 
            // textBoxNombreArchivo
            // 
            this.textBoxNombreArchivo.Location = new System.Drawing.Point(502, 113);
            this.textBoxNombreArchivo.Name = "textBoxNombreArchivo";
            this.textBoxNombreArchivo.Size = new System.Drawing.Size(175, 20);
            this.textBoxNombreArchivo.TabIndex = 17;
            this.textBoxNombreArchivo.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxNombreArchivo_Validating);
            // 
            // AnyadirArticuloForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 484);
            this.Controls.Add(this.textBoxNombreArchivo);
            this.Controls.Add(this.textBoxTipoCorrea);
            this.Controls.Add(this.textBoxDiametro);
            this.Controls.Add(this.textBoxCristal);
            this.Controls.Add(this.labelImagenProducto);
            this.Controls.Add(this.labelTipoCorrea);
            this.Controls.Add(this.labelDiametro);
            this.Controls.Add(this.labelCristal);
            this.Controls.Add(this.labelModelo);
            this.Controls.Add(this.textBoxModelo);
            this.Controls.Add(this.textBoxPrecio);
            this.Controls.Add(this.textBoxDescripcion);
            this.Controls.Add(this.textBoxMarca);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelMarca);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAñadir);
            this.Name = "AnyadirArticuloForm";
            this.Text = "Añadir artículo";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAddProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAñadir;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelMarca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxMarca;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.TextBox textBoxPrecio;
        private System.Windows.Forms.ErrorProvider errorProviderAddProducto;
        private System.Windows.Forms.Label labelModelo;
        private System.Windows.Forms.TextBox textBoxModelo;
        private System.Windows.Forms.Label labelImagenProducto;
        private System.Windows.Forms.Label labelTipoCorrea;
        private System.Windows.Forms.Label labelDiametro;
        private System.Windows.Forms.Label labelCristal;
        private System.Windows.Forms.TextBox textBoxNombreArchivo;
        private System.Windows.Forms.TextBox textBoxTipoCorrea;
        private System.Windows.Forms.TextBox textBoxDiametro;
        private System.Windows.Forms.TextBox textBoxCristal;
    }
}