namespace JMShopAdmin.PresentationLayer
{
    partial class EditarArticuloForm
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
            this.textBoxNombreArchivo = new System.Windows.Forms.TextBox();
            this.textBoxTipoCorrea = new System.Windows.Forms.TextBox();
            this.textBoxDiametro = new System.Windows.Forms.TextBox();
            this.textBoxCristal = new System.Windows.Forms.TextBox();
            this.labelImagenProducto = new System.Windows.Forms.Label();
            this.labelTipoCorrea = new System.Windows.Forms.Label();
            this.labelDiametro = new System.Windows.Forms.Label();
            this.labelCristal = new System.Windows.Forms.Label();
            this.labelModelo = new System.Windows.Forms.Label();
            this.textBoxModelo = new System.Windows.Forms.TextBox();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.textBoxMarca = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelMarca = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.errorProviderEditarArticulo = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEditarArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNombreArchivo
            // 
            this.textBoxNombreArchivo.Location = new System.Drawing.Point(484, 111);
            this.textBoxNombreArchivo.Name = "textBoxNombreArchivo";
            this.textBoxNombreArchivo.Size = new System.Drawing.Size(175, 20);
            this.textBoxNombreArchivo.TabIndex = 35;
            this.textBoxNombreArchivo.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxNombreArchivo_Validating);
            // 
            // textBoxTipoCorrea
            // 
            this.textBoxTipoCorrea.Location = new System.Drawing.Point(397, 70);
            this.textBoxTipoCorrea.Name = "textBoxTipoCorrea";
            this.textBoxTipoCorrea.Size = new System.Drawing.Size(262, 20);
            this.textBoxTipoCorrea.TabIndex = 34;
            this.textBoxTipoCorrea.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxTipoCorrea_Validating);
            // 
            // textBoxDiametro
            // 
            this.textBoxDiametro.Location = new System.Drawing.Point(99, 106);
            this.textBoxDiametro.Name = "textBoxDiametro";
            this.textBoxDiametro.Size = new System.Drawing.Size(155, 20);
            this.textBoxDiametro.TabIndex = 33;
            this.textBoxDiametro.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxDiametro_Validating);
            // 
            // textBoxCristal
            // 
            this.textBoxCristal.Location = new System.Drawing.Point(99, 65);
            this.textBoxCristal.Name = "textBoxCristal";
            this.textBoxCristal.Size = new System.Drawing.Size(155, 20);
            this.textBoxCristal.TabIndex = 32;
            this.textBoxCristal.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxCristal_Validating);
            // 
            // labelImagenProducto
            // 
            this.labelImagenProducto.AutoSize = true;
            this.labelImagenProducto.Location = new System.Drawing.Point(304, 114);
            this.labelImagenProducto.Name = "labelImagenProducto";
            this.labelImagenProducto.Size = new System.Drawing.Size(164, 13);
            this.labelImagenProducto.TabIndex = 31;
            this.labelImagenProducto.Text = "Nombre archivo imagen producto";
            // 
            // labelTipoCorrea
            // 
            this.labelTipoCorrea.AutoSize = true;
            this.labelTipoCorrea.Location = new System.Drawing.Point(304, 73);
            this.labelTipoCorrea.Name = "labelTipoCorrea";
            this.labelTipoCorrea.Size = new System.Drawing.Size(76, 13);
            this.labelTipoCorrea.TabIndex = 30;
            this.labelTipoCorrea.Text = "Tipo de correa";
            // 
            // labelDiametro
            // 
            this.labelDiametro.AutoSize = true;
            this.labelDiametro.Location = new System.Drawing.Point(31, 113);
            this.labelDiametro.Name = "labelDiametro";
            this.labelDiametro.Size = new System.Drawing.Size(49, 13);
            this.labelDiametro.TabIndex = 29;
            this.labelDiametro.Text = "Diametro";
            // 
            // labelCristal
            // 
            this.labelCristal.AutoSize = true;
            this.labelCristal.Location = new System.Drawing.Point(43, 73);
            this.labelCristal.Name = "labelCristal";
            this.labelCristal.Size = new System.Drawing.Size(35, 13);
            this.labelCristal.TabIndex = 28;
            this.labelCristal.Text = "Cristal";
            // 
            // labelModelo
            // 
            this.labelModelo.AutoSize = true;
            this.labelModelo.Location = new System.Drawing.Point(304, 29);
            this.labelModelo.Name = "labelModelo";
            this.labelModelo.Size = new System.Drawing.Size(42, 13);
            this.labelModelo.TabIndex = 27;
            this.labelModelo.Text = "Modelo";
            // 
            // textBoxModelo
            // 
            this.textBoxModelo.Location = new System.Drawing.Point(366, 26);
            this.textBoxModelo.Name = "textBoxModelo";
            this.textBoxModelo.Size = new System.Drawing.Size(293, 20);
            this.textBoxModelo.TabIndex = 26;
            this.textBoxModelo.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxModelo_Validating);
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Location = new System.Drawing.Point(99, 375);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.Size = new System.Drawing.Size(155, 20);
            this.textBoxPrecio.TabIndex = 25;
            this.textBoxPrecio.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxPrecio_Validating);
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Location = new System.Drawing.Point(99, 157);
            this.textBoxDescripcion.Multiline = true;
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDescripcion.Size = new System.Drawing.Size(560, 194);
            this.textBoxDescripcion.TabIndex = 24;
            this.textBoxDescripcion.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxDescripcion_Validating);
            // 
            // textBoxMarca
            // 
            this.textBoxMarca.Location = new System.Drawing.Point(99, 23);
            this.textBoxMarca.Name = "textBoxMarca";
            this.textBoxMarca.Size = new System.Drawing.Size(155, 20);
            this.textBoxMarca.TabIndex = 23;
            this.textBoxMarca.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxMarca_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 375);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Precio (€)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Descripcion";
            // 
            // labelMarca
            // 
            this.labelMarca.AutoSize = true;
            this.labelMarca.Location = new System.Drawing.Point(43, 26);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(37, 13);
            this.labelMarca.TabIndex = 20;
            this.labelMarca.Text = "Marca";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(445, 425);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 19;
            this.buttonCancel.Text = "Cancelar";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click_1);
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(179, 425);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(75, 23);
            this.buttonEditar.TabIndex = 18;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // errorProviderEditarArticulo
            // 
            this.errorProviderEditarArticulo.ContainerControl = this;
            // 
            // EditarArticuloForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 471);
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
            this.Controls.Add(this.buttonEditar);
            this.Name = "EditarArticuloForm";
            this.Text = "Editar artículo";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEditarArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNombreArchivo;
        private System.Windows.Forms.TextBox textBoxTipoCorrea;
        private System.Windows.Forms.TextBox textBoxDiametro;
        private System.Windows.Forms.TextBox textBoxCristal;
        private System.Windows.Forms.Label labelImagenProducto;
        private System.Windows.Forms.Label labelTipoCorrea;
        private System.Windows.Forms.Label labelDiametro;
        private System.Windows.Forms.Label labelCristal;
        private System.Windows.Forms.Label labelModelo;
        private System.Windows.Forms.TextBox textBoxModelo;
        private System.Windows.Forms.TextBox textBoxPrecio;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.TextBox textBoxMarca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelMarca;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.ErrorProvider errorProviderEditarArticulo;
    }
}