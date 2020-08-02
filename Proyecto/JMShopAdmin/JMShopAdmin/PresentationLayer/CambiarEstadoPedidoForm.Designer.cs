namespace JMShopAdmin.PresentationLayer
{
    partial class CambiarEstadoPedidoForm
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
            this.radioButtonPendientePago = new System.Windows.Forms.RadioButton();
            this.radioButtonPreparandoPedido = new System.Windows.Forms.RadioButton();
            this.radioButtonEnviado = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.radioButtonEntregado = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButtonPendientePago
            // 
            this.radioButtonPendientePago.AutoSize = true;
            this.radioButtonPendientePago.Location = new System.Drawing.Point(16, 33);
            this.radioButtonPendientePago.Name = "radioButtonPendientePago";
            this.radioButtonPendientePago.Size = new System.Drawing.Size(115, 17);
            this.radioButtonPendientePago.TabIndex = 0;
            this.radioButtonPendientePago.TabStop = true;
            this.radioButtonPendientePago.Text = "Pendiente de pago";
            this.radioButtonPendientePago.UseVisualStyleBackColor = true;
            // 
            // radioButtonPreparandoPedido
            // 
            this.radioButtonPreparandoPedido.AutoSize = true;
            this.radioButtonPreparandoPedido.Location = new System.Drawing.Point(16, 66);
            this.radioButtonPreparandoPedido.Name = "radioButtonPreparandoPedido";
            this.radioButtonPreparandoPedido.Size = new System.Drawing.Size(115, 17);
            this.radioButtonPreparandoPedido.TabIndex = 1;
            this.radioButtonPreparandoPedido.TabStop = true;
            this.radioButtonPreparandoPedido.Text = "Preparando pedido";
            this.radioButtonPreparandoPedido.UseVisualStyleBackColor = true;
            // 
            // radioButtonEnviado
            // 
            this.radioButtonEnviado.AutoSize = true;
            this.radioButtonEnviado.Location = new System.Drawing.Point(16, 98);
            this.radioButtonEnviado.Name = "radioButtonEnviado";
            this.radioButtonEnviado.Size = new System.Drawing.Size(64, 17);
            this.radioButtonEnviado.TabIndex = 2;
            this.radioButtonEnviado.TabStop = true;
            this.radioButtonEnviado.Text = "Enviado";
            this.radioButtonEnviado.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonEntregado);
            this.groupBox1.Controls.Add(this.radioButtonPendientePago);
            this.groupBox1.Controls.Add(this.radioButtonPreparandoPedido);
            this.groupBox1.Controls.Add(this.radioButtonEnviado);
            this.groupBox1.Location = new System.Drawing.Point(41, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 164);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione estado de pedido";
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(46, 242);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(75, 23);
            this.buttonAceptar.TabIndex = 6;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(212, 242);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 7;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // radioButtonEntregado
            // 
            this.radioButtonEntregado.AutoSize = true;
            this.radioButtonEntregado.Location = new System.Drawing.Point(16, 130);
            this.radioButtonEntregado.Name = "radioButtonEntregado";
            this.radioButtonEntregado.Size = new System.Drawing.Size(74, 17);
            this.radioButtonEntregado.TabIndex = 3;
            this.radioButtonEntregado.TabStop = true;
            this.radioButtonEntregado.Text = "Entregado";
            this.radioButtonEntregado.UseVisualStyleBackColor = true;
            // 
            // CambiarEstadoPedidoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 290);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.groupBox1);
            this.Name = "CambiarEstadoPedidoForm";
            this.Text = "Cambiar estado de pedido";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonPendientePago;
        private System.Windows.Forms.RadioButton radioButtonPreparandoPedido;
        private System.Windows.Forms.RadioButton radioButtonEnviado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.RadioButton radioButtonEntregado;
    }
}