namespace JMShopAdmin.PresentationLayer
{
    partial class ArticulosForm
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
            this.buttonDetallesArtículo = new System.Windows.Forms.Button();
            this.buttonAddArticulo = new System.Windows.Forms.Button();
            this.buttonEditarArticulo = new System.Windows.Forms.Button();
            this.buttonEliminarArticulo = new System.Windows.Forms.Button();
            this.buttonVolverMenú = new System.Windows.Forms.Button();
            this.dataGridViewProductos = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxFiltrarMarca = new System.Windows.Forms.TextBox();
            this.textBoxFiltrarModelo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDetallesArtículo
            // 
            this.buttonDetallesArtículo.Location = new System.Drawing.Point(33, 40);
            this.buttonDetallesArtículo.Name = "buttonDetallesArtículo";
            this.buttonDetallesArtículo.Size = new System.Drawing.Size(111, 23);
            this.buttonDetallesArtículo.TabIndex = 0;
            this.buttonDetallesArtículo.Text = "Detalles artículo";
            this.buttonDetallesArtículo.UseVisualStyleBackColor = true;
            this.buttonDetallesArtículo.Click += new System.EventHandler(this.buttonDescripccionArtículo_Click);
            // 
            // buttonAddArticulo
            // 
            this.buttonAddArticulo.Location = new System.Drawing.Point(33, 92);
            this.buttonAddArticulo.Name = "buttonAddArticulo";
            this.buttonAddArticulo.Size = new System.Drawing.Size(111, 23);
            this.buttonAddArticulo.TabIndex = 1;
            this.buttonAddArticulo.Text = "Añadir artículo";
            this.buttonAddArticulo.UseVisualStyleBackColor = true;
            this.buttonAddArticulo.Click += new System.EventHandler(this.buttonAddArticulo_Click);
            // 
            // buttonEditarArticulo
            // 
            this.buttonEditarArticulo.Location = new System.Drawing.Point(33, 145);
            this.buttonEditarArticulo.Name = "buttonEditarArticulo";
            this.buttonEditarArticulo.Size = new System.Drawing.Size(111, 23);
            this.buttonEditarArticulo.TabIndex = 2;
            this.buttonEditarArticulo.Text = "Editar artículo";
            this.buttonEditarArticulo.UseVisualStyleBackColor = true;
            this.buttonEditarArticulo.Click += new System.EventHandler(this.buttonEditarArticulo_Click);
            // 
            // buttonEliminarArticulo
            // 
            this.buttonEliminarArticulo.Location = new System.Drawing.Point(33, 197);
            this.buttonEliminarArticulo.Name = "buttonEliminarArticulo";
            this.buttonEliminarArticulo.Size = new System.Drawing.Size(111, 23);
            this.buttonEliminarArticulo.TabIndex = 3;
            this.buttonEliminarArticulo.Text = "Eliminar Artículo";
            this.buttonEliminarArticulo.UseVisualStyleBackColor = true;
            this.buttonEliminarArticulo.Click += new System.EventHandler(this.buttonEliminarArticulo_Click);
            // 
            // buttonVolverMenú
            // 
            this.buttonVolverMenú.Location = new System.Drawing.Point(33, 265);
            this.buttonVolverMenú.Name = "buttonVolverMenú";
            this.buttonVolverMenú.Size = new System.Drawing.Size(111, 23);
            this.buttonVolverMenú.TabIndex = 5;
            this.buttonVolverMenú.Text = "Volver al menú";
            this.buttonVolverMenú.UseVisualStyleBackColor = true;
            this.buttonVolverMenú.Click += new System.EventHandler(this.buttonVolverMenú_Click);
            // 
            // dataGridViewProductos
            // 
            this.dataGridViewProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnMarca,
            this.ColumnModelo,
            this.ColumnPrecio});
            this.dataGridViewProductos.Location = new System.Drawing.Point(196, 40);
            this.dataGridViewProductos.MultiSelect = false;
            this.dataGridViewProductos.Name = "dataGridViewProductos";
            this.dataGridViewProductos.ReadOnly = true;
            this.dataGridViewProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProductos.Size = new System.Drawing.Size(668, 195);
            this.dataGridViewProductos.TabIndex = 6;
            // 
            // ColumnId
            // 
            this.ColumnId.HeaderText = "Id";
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.ReadOnly = true;
            this.ColumnId.Width = 60;
            // 
            // ColumnMarca
            // 
            this.ColumnMarca.HeaderText = "Marca";
            this.ColumnMarca.Name = "ColumnMarca";
            this.ColumnMarca.ReadOnly = true;
            this.ColumnMarca.Width = 150;
            // 
            // ColumnModelo
            // 
            this.ColumnModelo.HeaderText = "Modelo";
            this.ColumnModelo.Name = "ColumnModelo";
            this.ColumnModelo.ReadOnly = true;
            this.ColumnModelo.Width = 300;
            // 
            // ColumnPrecio
            // 
            this.ColumnPrecio.HeaderText = "Precio(€)";
            this.ColumnPrecio.Name = "ColumnPrecio";
            this.ColumnPrecio.ReadOnly = true;
            this.ColumnPrecio.Width = 115;
            // 
            // textBoxFiltrarMarca
            // 
            this.textBoxFiltrarMarca.Location = new System.Drawing.Point(284, 262);
            this.textBoxFiltrarMarca.Name = "textBoxFiltrarMarca";
            this.textBoxFiltrarMarca.Size = new System.Drawing.Size(203, 20);
            this.textBoxFiltrarMarca.TabIndex = 7;
            this.textBoxFiltrarMarca.TextChanged += new System.EventHandler(this.textBoxFiltrarMarca_TextChanged);
            // 
            // textBoxFiltrarModelo
            // 
            this.textBoxFiltrarModelo.Location = new System.Drawing.Point(661, 262);
            this.textBoxFiltrarModelo.Name = "textBoxFiltrarModelo";
            this.textBoxFiltrarModelo.Size = new System.Drawing.Size(203, 20);
            this.textBoxFiltrarModelo.TabIndex = 8;
            this.textBoxFiltrarModelo.TextChanged += new System.EventHandler(this.textBoxFiltrarModelo_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Filtrar por marca:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(556, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Filtrar por modelo:";
            // 
            // ArticulosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 326);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxFiltrarModelo);
            this.Controls.Add(this.textBoxFiltrarMarca);
            this.Controls.Add(this.dataGridViewProductos);
            this.Controls.Add(this.buttonVolverMenú);
            this.Controls.Add(this.buttonEliminarArticulo);
            this.Controls.Add(this.buttonEditarArticulo);
            this.Controls.Add(this.buttonAddArticulo);
            this.Controls.Add(this.buttonDetallesArtículo);
            this.Name = "ArticulosForm";
            this.Text = "Gestionar Artículos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDetallesArtículo;
        private System.Windows.Forms.Button buttonAddArticulo;
        private System.Windows.Forms.Button buttonEditarArticulo;
        private System.Windows.Forms.Button buttonEliminarArticulo;
        private System.Windows.Forms.Button buttonVolverMenú;
        private System.Windows.Forms.DataGridView dataGridViewProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrecio;
        private System.Windows.Forms.TextBox textBoxFiltrarMarca;
        private System.Windows.Forms.TextBox textBoxFiltrarModelo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}