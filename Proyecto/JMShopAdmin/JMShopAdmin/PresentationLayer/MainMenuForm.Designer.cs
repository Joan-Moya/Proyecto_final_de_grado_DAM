namespace JMShopAdmin.PresentationLayer
{
    partial class MainMenuForm
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
            this.buttonGestPedidos = new System.Windows.Forms.Button();
            this.buttonArticulos = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonGestPedidos
            // 
            this.buttonGestPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGestPedidos.Location = new System.Drawing.Point(3, 126);
            this.buttonGestPedidos.Name = "buttonGestPedidos";
            this.buttonGestPedidos.Size = new System.Drawing.Size(361, 51);
            this.buttonGestPedidos.TabIndex = 0;
            this.buttonGestPedidos.Text = "Gestionar pedidos";
            this.buttonGestPedidos.UseVisualStyleBackColor = true;
            this.buttonGestPedidos.Click += new System.EventHandler(this.buttonGestPedidos_Click);
            // 
            // buttonArticulos
            // 
            this.buttonArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonArticulos.Location = new System.Drawing.Point(3, 55);
            this.buttonArticulos.Name = "buttonArticulos";
            this.buttonArticulos.Size = new System.Drawing.Size(361, 51);
            this.buttonArticulos.TabIndex = 1;
            this.buttonArticulos.Text = "Articulos";
            this.buttonArticulos.UseVisualStyleBackColor = true;
            this.buttonArticulos.Click += new System.EventHandler(this.buttonArticulos_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(3, 197);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(361, 50);
            this.button3.TabIndex = 2;
            this.button3.Text = "Reportes";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonSalir
            // 
            this.buttonSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalir.Location = new System.Drawing.Point(3, 324);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(361, 50);
            this.buttonSalir.TabIndex = 3;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 450);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonArticulos);
            this.Controls.Add(this.buttonGestPedidos);
            this.Name = "MainMenuForm";
            this.Text = "Menú Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenuForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonGestPedidos;
        private System.Windows.Forms.Button buttonArticulos;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonSalir;
    }
}