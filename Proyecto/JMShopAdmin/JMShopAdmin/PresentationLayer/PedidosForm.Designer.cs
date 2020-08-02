namespace JMShopAdmin.PresentationLayer
{
    partial class PedidosForm
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
            this.dataGridViewPedidos = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEmailCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonDetallesPedido = new System.Windows.Forms.Button();
            this.buttonCambiarEstadoPedido = new System.Windows.Forms.Button();
            this.buttonVolver = new System.Windows.Forms.Button();
            this.checkBoxPendientePago = new System.Windows.Forms.CheckBox();
            this.checkBoxPreparando = new System.Windows.Forms.CheckBox();
            this.checkBoxEnviado = new System.Windows.Forms.CheckBox();
            this.radioButtonPendientes = new System.Windows.Forms.RadioButton();
            this.radioButtonEntregados = new System.Windows.Forms.RadioButton();
            this.radioButtonTodos = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonFiltrar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxFiltrarCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedidos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewPedidos
            // 
            this.dataGridViewPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnEmailCliente,
            this.ColumnEstado,
            this.ColumnTotal});
            this.dataGridViewPedidos.Location = new System.Drawing.Point(234, 38);
            this.dataGridViewPedidos.Name = "dataGridViewPedidos";
            this.dataGridViewPedidos.ReadOnly = true;
            this.dataGridViewPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPedidos.Size = new System.Drawing.Size(522, 215);
            this.dataGridViewPedidos.TabIndex = 0;
            // 
            // ColumnId
            // 
            this.ColumnId.HeaderText = "Id";
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.ReadOnly = true;
            this.ColumnId.Width = 60;
            // 
            // ColumnEmailCliente
            // 
            this.ColumnEmailCliente.HeaderText = "Email Cliente";
            this.ColumnEmailCliente.Name = "ColumnEmailCliente";
            this.ColumnEmailCliente.ReadOnly = true;
            this.ColumnEmailCliente.Width = 160;
            // 
            // ColumnEstado
            // 
            this.ColumnEstado.HeaderText = "Estado";
            this.ColumnEstado.Name = "ColumnEstado";
            this.ColumnEstado.ReadOnly = true;
            this.ColumnEstado.Width = 160;
            // 
            // ColumnTotal
            // 
            this.ColumnTotal.HeaderText = "Total(€)";
            this.ColumnTotal.Name = "ColumnTotal";
            this.ColumnTotal.ReadOnly = true;
            // 
            // buttonDetallesPedido
            // 
            this.buttonDetallesPedido.Location = new System.Drawing.Point(32, 82);
            this.buttonDetallesPedido.Name = "buttonDetallesPedido";
            this.buttonDetallesPedido.Size = new System.Drawing.Size(150, 23);
            this.buttonDetallesPedido.TabIndex = 1;
            this.buttonDetallesPedido.Text = "Detalles de pedido";
            this.buttonDetallesPedido.UseVisualStyleBackColor = true;
            this.buttonDetallesPedido.Click += new System.EventHandler(this.buttonDetallesPedido_Click);
            // 
            // buttonCambiarEstadoPedido
            // 
            this.buttonCambiarEstadoPedido.Location = new System.Drawing.Point(32, 142);
            this.buttonCambiarEstadoPedido.Name = "buttonCambiarEstadoPedido";
            this.buttonCambiarEstadoPedido.Size = new System.Drawing.Size(150, 22);
            this.buttonCambiarEstadoPedido.TabIndex = 2;
            this.buttonCambiarEstadoPedido.Text = "Cambiar estado de pedido";
            this.buttonCambiarEstadoPedido.UseVisualStyleBackColor = true;
            this.buttonCambiarEstadoPedido.Click += new System.EventHandler(this.buttonCambiarEstadoPedido_Click);
            // 
            // buttonVolver
            // 
            this.buttonVolver.Location = new System.Drawing.Point(32, 432);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(150, 23);
            this.buttonVolver.TabIndex = 4;
            this.buttonVolver.Text = "Volver al menú";
            this.buttonVolver.UseVisualStyleBackColor = true;
            this.buttonVolver.Click += new System.EventHandler(this.button4_Click);
            // 
            // checkBoxPendientePago
            // 
            this.checkBoxPendientePago.AutoSize = true;
            this.checkBoxPendientePago.Location = new System.Drawing.Point(6, 28);
            this.checkBoxPendientePago.Name = "checkBoxPendientePago";
            this.checkBoxPendientePago.Size = new System.Drawing.Size(116, 17);
            this.checkBoxPendientePago.TabIndex = 5;
            this.checkBoxPendientePago.Text = "Pendiente de pago";
            this.checkBoxPendientePago.UseVisualStyleBackColor = true;
            // 
            // checkBoxPreparando
            // 
            this.checkBoxPreparando.AutoSize = true;
            this.checkBoxPreparando.Location = new System.Drawing.Point(6, 51);
            this.checkBoxPreparando.Name = "checkBoxPreparando";
            this.checkBoxPreparando.Size = new System.Drawing.Size(116, 17);
            this.checkBoxPreparando.TabIndex = 6;
            this.checkBoxPreparando.Text = "Preparando pedido";
            this.checkBoxPreparando.UseVisualStyleBackColor = true;
            // 
            // checkBoxEnviado
            // 
            this.checkBoxEnviado.AutoSize = true;
            this.checkBoxEnviado.Location = new System.Drawing.Point(6, 74);
            this.checkBoxEnviado.Name = "checkBoxEnviado";
            this.checkBoxEnviado.Size = new System.Drawing.Size(65, 17);
            this.checkBoxEnviado.TabIndex = 7;
            this.checkBoxEnviado.Text = "Enviado";
            this.checkBoxEnviado.UseVisualStyleBackColor = true;
            // 
            // radioButtonPendientes
            // 
            this.radioButtonPendientes.AutoSize = true;
            this.radioButtonPendientes.Location = new System.Drawing.Point(29, 28);
            this.radioButtonPendientes.Name = "radioButtonPendientes";
            this.radioButtonPendientes.Size = new System.Drawing.Size(78, 17);
            this.radioButtonPendientes.TabIndex = 8;
            this.radioButtonPendientes.Text = "Pendientes";
            this.radioButtonPendientes.UseVisualStyleBackColor = true;
            // 
            // radioButtonEntregados
            // 
            this.radioButtonEntregados.AutoSize = true;
            this.radioButtonEntregados.Location = new System.Drawing.Point(206, 28);
            this.radioButtonEntregados.Name = "radioButtonEntregados";
            this.radioButtonEntregados.Size = new System.Drawing.Size(79, 17);
            this.radioButtonEntregados.TabIndex = 9;
            this.radioButtonEntregados.Text = "Entregados";
            this.radioButtonEntregados.UseVisualStyleBackColor = true;
            // 
            // radioButtonTodos
            // 
            this.radioButtonTodos.AutoSize = true;
            this.radioButtonTodos.Checked = true;
            this.radioButtonTodos.Location = new System.Drawing.Point(388, 28);
            this.radioButtonTodos.Name = "radioButtonTodos";
            this.radioButtonTodos.Size = new System.Drawing.Size(55, 17);
            this.radioButtonTodos.TabIndex = 10;
            this.radioButtonTodos.TabStop = true;
            this.radioButtonTodos.Text = "Todos";
            this.radioButtonTodos.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonFiltrar);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.radioButtonTodos);
            this.groupBox1.Controls.Add(this.radioButtonPendientes);
            this.groupBox1.Controls.Add(this.radioButtonEntregados);
            this.groupBox1.Location = new System.Drawing.Point(234, 279);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(524, 216);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrar por estado de pedido";
            // 
            // buttonFiltrar
            // 
            this.buttonFiltrar.Location = new System.Drawing.Point(282, 153);
            this.buttonFiltrar.Name = "buttonFiltrar";
            this.buttonFiltrar.Size = new System.Drawing.Size(75, 23);
            this.buttonFiltrar.TabIndex = 11;
            this.buttonFiltrar.Text = "Filtrar";
            this.buttonFiltrar.UseVisualStyleBackColor = true;
            this.buttonFiltrar.Click += new System.EventHandler(this.buttonFiltrar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxPendientePago);
            this.groupBox2.Controls.Add(this.checkBoxPreparando);
            this.groupBox2.Controls.Add(this.checkBoxEnviado);
            this.groupBox2.Location = new System.Drawing.Point(20, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(137, 104);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Estado Pendientes";
            // 
            // textBoxFiltrarCliente
            // 
            this.textBoxFiltrarCliente.Location = new System.Drawing.Point(32, 304);
            this.textBoxFiltrarCliente.Name = "textBoxFiltrarCliente";
            this.textBoxFiltrarCliente.Size = new System.Drawing.Size(134, 20);
            this.textBoxFiltrarCliente.TabIndex = 12;
            this.textBoxFiltrarCliente.TextChanged += new System.EventHandler(this.textBoxFiltrarCliente_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Filtrar por Email de cliente";
            // 
            // PedidosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 504);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxFiltrarCliente);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonVolver);
            this.Controls.Add(this.buttonCambiarEstadoPedido);
            this.Controls.Add(this.buttonDetallesPedido);
            this.Controls.Add(this.dataGridViewPedidos);
            this.Name = "PedidosForm";
            this.Text = "PedidosForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedidos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPedidos;
        private System.Windows.Forms.Button buttonDetallesPedido;
        private System.Windows.Forms.Button buttonCambiarEstadoPedido;
        private System.Windows.Forms.Button buttonVolver;
        private System.Windows.Forms.CheckBox checkBoxPendientePago;
        private System.Windows.Forms.CheckBox checkBoxPreparando;
        private System.Windows.Forms.CheckBox checkBoxEnviado;
        private System.Windows.Forms.RadioButton radioButtonPendientes;
        private System.Windows.Forms.RadioButton radioButtonEntregados;
        private System.Windows.Forms.RadioButton radioButtonTodos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonFiltrar;
        private System.Windows.Forms.TextBox textBoxFiltrarCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEmailCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTotal;
    }
}