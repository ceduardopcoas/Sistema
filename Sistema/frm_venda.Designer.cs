namespace Sistema
{
    partial class frm_venda
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
            System.Windows.Forms.Label id_pessoaLabel;
            System.Windows.Forms.Label id_vendaLabel;
            System.Windows.Forms.Label quantidadeLabel;
            System.Windows.Forms.Label valorLabel;
            System.Windows.Forms.Label id_produtoLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.Label descontoLabel;
            System.Windows.Forms.Label valor_pagoLabel;
            System.Windows.Forms.Label valorLabel1;
            this.tb_vendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CB_Cliente = new System.Windows.Forms.ComboBox();
            this.tb_pessoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_novaVenda = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_novoItem = new System.Windows.Forms.Button();
            this.CB_produto = new System.Windows.Forms.ComboBox();
            this.tb_itens_vendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.DG_itensVenda = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorTextBox = new System.Windows.Forms.TextBox();
            this.quantidadeTextBox = new System.Windows.Forms.TextBox();
            this.id_vendaTextBox = new System.Windows.Forms.TextBox();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txt_desconto = new System.Windows.Forms.TextBox();
            this.txt_valorTotal = new System.Windows.Forms.TextBox();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.btn_finalizarPedido = new System.Windows.Forms.Button();
            this.btn_finalizarVenda = new System.Windows.Forms.Button();
            this.btn_imprimir = new System.Windows.Forms.Button();
            id_pessoaLabel = new System.Windows.Forms.Label();
            id_vendaLabel = new System.Windows.Forms.Label();
            quantidadeLabel = new System.Windows.Forms.Label();
            valorLabel = new System.Windows.Forms.Label();
            id_produtoLabel = new System.Windows.Forms.Label();
            descontoLabel = new System.Windows.Forms.Label();
            valor_pagoLabel = new System.Windows.Forms.Label();
            valorLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tb_vendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_pessoaBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_itens_vendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_itensVenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // id_pessoaLabel
            // 
            id_pessoaLabel.AutoSize = true;
            id_pessoaLabel.Location = new System.Drawing.Point(23, 36);
            id_pessoaLabel.Name = "id_pessoaLabel";
            id_pessoaLabel.Size = new System.Drawing.Size(55, 17);
            id_pessoaLabel.TabIndex = 1;
            id_pessoaLabel.Text = "Cliente:";
            // 
            // id_vendaLabel
            // 
            id_vendaLabel.AutoSize = true;
            id_vendaLabel.Location = new System.Drawing.Point(-2, 38);
            id_vendaLabel.Name = "id_vendaLabel";
            id_vendaLabel.Size = new System.Drawing.Size(82, 17);
            id_vendaLabel.TabIndex = 0;
            id_vendaLabel.Text = "Cod Venda:";
            // 
            // quantidadeLabel
            // 
            quantidadeLabel.AutoSize = true;
            quantidadeLabel.Location = new System.Drawing.Point(21, 94);
            quantidadeLabel.Name = "quantidadeLabel";
            quantidadeLabel.Size = new System.Drawing.Size(59, 17);
            quantidadeLabel.TabIndex = 4;
            quantidadeLabel.Text = "Qtdade:";
            // 
            // valorLabel
            // 
            valorLabel.AutoSize = true;
            valorLabel.Location = new System.Drawing.Point(37, 120);
            valorLabel.Name = "valorLabel";
            valorLabel.Size = new System.Drawing.Size(45, 17);
            valorLabel.TabIndex = 6;
            valorLabel.Text = "Valor:";
            // 
            // id_produtoLabel
            // 
            id_produtoLabel.AutoSize = true;
            id_produtoLabel.Location = new System.Drawing.Point(18, 67);
            id_produtoLabel.Name = "id_produtoLabel";
            id_produtoLabel.Size = new System.Drawing.Size(62, 17);
            id_produtoLabel.TabIndex = 8;
            id_produtoLabel.Text = "Produto:";
            // 
            // tb_vendaBindingSource
            // 
            this.tb_vendaBindingSource.DataSource = typeof(Sistema.DAL.tb_venda);
            // 
            // CB_Cliente
            // 
            this.CB_Cliente.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tb_vendaBindingSource, "id_pessoa", true));
            this.CB_Cliente.DataSource = this.tb_pessoaBindingSource;
            this.CB_Cliente.DisplayMember = "nome";
            this.CB_Cliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Cliente.FormattingEnabled = true;
            this.CB_Cliente.Location = new System.Drawing.Point(84, 33);
            this.CB_Cliente.Name = "CB_Cliente";
            this.CB_Cliente.Size = new System.Drawing.Size(261, 24);
            this.CB_Cliente.TabIndex = 2;
            this.CB_Cliente.ValueMember = "id_pessoa";
            // 
            // tb_pessoaBindingSource
            // 
            this.tb_pessoaBindingSource.DataSource = typeof(Sistema.DAL.tb_pessoa);
            // 
            // btn_novaVenda
            // 
            this.btn_novaVenda.Location = new System.Drawing.Point(466, 28);
            this.btn_novaVenda.Name = "btn_novaVenda";
            this.btn_novaVenda.Size = new System.Drawing.Size(106, 29);
            this.btn_novaVenda.TabIndex = 3;
            this.btn_novaVenda.Text = "Nova Venda";
            this.btn_novaVenda.UseVisualStyleBackColor = true;
            this.btn_novaVenda.Click += new System.EventHandler(this.Btn_novaVenda_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_imprimir);
            this.groupBox1.Controls.Add(this.btn_finalizarVenda);
            this.groupBox1.Controls.Add(this.btn_finalizarPedido);
            this.groupBox1.Controls.Add(valorLabel1);
            this.groupBox1.Controls.Add(this.txt_valor);
            this.groupBox1.Controls.Add(valor_pagoLabel);
            this.groupBox1.Controls.Add(this.txt_valorTotal);
            this.groupBox1.Controls.Add(descontoLabel);
            this.groupBox1.Controls.Add(this.txt_desconto);
            this.groupBox1.Controls.Add(this.btn_novoItem);
            this.groupBox1.Controls.Add(id_produtoLabel);
            this.groupBox1.Controls.Add(this.CB_produto);
            this.groupBox1.Controls.Add(this.DG_itensVenda);
            this.groupBox1.Controls.Add(valorLabel);
            this.groupBox1.Controls.Add(this.valorTextBox);
            this.groupBox1.Controls.Add(quantidadeLabel);
            this.groupBox1.Controls.Add(this.quantidadeTextBox);
            this.groupBox1.Controls.Add(id_vendaLabel);
            this.groupBox1.Controls.Add(this.id_vendaTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(568, 388);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nova Venda";
            this.groupBox1.Visible = false;
            // 
            // btn_novoItem
            // 
            this.btn_novoItem.Location = new System.Drawing.Point(454, 111);
            this.btn_novoItem.Name = "btn_novoItem";
            this.btn_novoItem.Size = new System.Drawing.Size(106, 26);
            this.btn_novoItem.TabIndex = 5;
            this.btn_novoItem.Text = "Novo Item";
            this.btn_novoItem.UseVisualStyleBackColor = true;
            this.btn_novoItem.Click += new System.EventHandler(this.Btn_novoItem_Click);
            // 
            // CB_produto
            // 
            this.CB_produto.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tb_itens_vendaBindingSource, "id_produto", true));
            this.CB_produto.DataSource = this.produtoBindingSource1;
            this.CB_produto.DisplayMember = "desc_produto";
            this.CB_produto.FormattingEnabled = true;
            this.CB_produto.Location = new System.Drawing.Point(86, 60);
            this.CB_produto.Name = "CB_produto";
            this.CB_produto.Size = new System.Drawing.Size(247, 24);
            this.CB_produto.TabIndex = 9;
            this.CB_produto.ValueMember = "id_produto";
            this.CB_produto.SelectedIndexChanged += new System.EventHandler(this.CB_produto_SelectedIndexChanged);
            // 
            // tb_itens_vendaBindingSource
            // 
            this.tb_itens_vendaBindingSource.DataSource = typeof(Sistema.DAL.tb_itens_venda);
            // 
            // produtoBindingSource1
            // 
            this.produtoBindingSource1.DataSource = typeof(Sistema.DAL.produto);
            // 
            // DG_itensVenda
            // 
            this.DG_itensVenda.AllowUserToAddRows = false;
            this.DG_itensVenda.AllowUserToDeleteRows = false;
            this.DG_itensVenda.AutoGenerateColumns = false;
            this.DG_itensVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_itensVenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn4,
            this.ValorTotal});
            this.DG_itensVenda.DataSource = this.tb_itens_vendaBindingSource;
            this.DG_itensVenda.Location = new System.Drawing.Point(14, 149);
            this.DG_itensVenda.Name = "DG_itensVenda";
            this.DG_itensVenda.ReadOnly = true;
            this.DG_itensVenda.RowHeadersWidth = 51;
            this.DG_itensVenda.RowTemplate.Height = 24;
            this.DG_itensVenda.Size = new System.Drawing.Size(546, 150);
            this.DG_itensVenda.TabIndex = 8;
            this.DG_itensVenda.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DG_itensVenda_CellFormatting);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "id_produto";
            this.dataGridViewTextBoxColumn2.HeaderText = "Cod";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 50;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "produto";
            this.dataGridViewTextBoxColumn6.HeaderText = "Produto";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "quantidade";
            this.dataGridViewTextBoxColumn1.HeaderText = "Qtdade";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 70;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "valor";
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn4.HeaderText = "Valor";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 70;
            // 
            // ValorTotal
            // 
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.ValorTotal.DefaultCellStyle = dataGridViewCellStyle4;
            this.ValorTotal.HeaderText = "Valor Total";
            this.ValorTotal.MinimumWidth = 6;
            this.ValorTotal.Name = "ValorTotal";
            this.ValorTotal.ReadOnly = true;
            this.ValorTotal.Width = 110;
            // 
            // valorTextBox
            // 
            this.valorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_itens_vendaBindingSource, "valor", true));
            this.valorTextBox.Location = new System.Drawing.Point(86, 117);
            this.valorTextBox.Name = "valorTextBox";
            this.valorTextBox.ReadOnly = true;
            this.valorTextBox.Size = new System.Drawing.Size(247, 22);
            this.valorTextBox.TabIndex = 7;
            // 
            // quantidadeTextBox
            // 
            this.quantidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_itens_vendaBindingSource, "quantidade", true));
            this.quantidadeTextBox.Location = new System.Drawing.Point(86, 89);
            this.quantidadeTextBox.Name = "quantidadeTextBox";
            this.quantidadeTextBox.Size = new System.Drawing.Size(247, 22);
            this.quantidadeTextBox.TabIndex = 5;
            // 
            // id_vendaTextBox
            // 
            this.id_vendaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_vendaBindingSource, "id_venda", true));
            this.id_vendaTextBox.Location = new System.Drawing.Point(86, 33);
            this.id_vendaTextBox.Name = "id_vendaTextBox";
            this.id_vendaTextBox.ReadOnly = true;
            this.id_vendaTextBox.Size = new System.Drawing.Size(247, 22);
            this.id_vendaTextBox.TabIndex = 1;
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataSource = typeof(Sistema.DAL.produto);
            // 
            // descontoLabel
            // 
            descontoLabel.AutoSize = true;
            descontoLabel.Location = new System.Drawing.Point(375, 338);
            descontoLabel.Name = "descontoLabel";
            descontoLabel.Size = new System.Drawing.Size(76, 17);
            descontoLabel.TabIndex = 10;
            descontoLabel.Text = "Desconto :";
            // 
            // txt_desconto
            // 
            this.txt_desconto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_vendaBindingSource, "desconto", true));
            this.txt_desconto.Location = new System.Drawing.Point(460, 333);
            this.txt_desconto.Name = "txt_desconto";
            this.txt_desconto.Size = new System.Drawing.Size(100, 22);
            this.txt_desconto.TabIndex = 11;
            // 
            // valor_pagoLabel
            // 
            valor_pagoLabel.AutoSize = true;
            valor_pagoLabel.Location = new System.Drawing.Point(365, 366);
            valor_pagoLabel.Name = "valor_pagoLabel";
            valor_pagoLabel.Size = new System.Drawing.Size(85, 17);
            valor_pagoLabel.TabIndex = 12;
            valor_pagoLabel.Text = "Valor Total :";
            // 
            // txt_valorTotal
            // 
            this.txt_valorTotal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_vendaBindingSource, "valor_pago", true));
            this.txt_valorTotal.Location = new System.Drawing.Point(460, 361);
            this.txt_valorTotal.Name = "txt_valorTotal";
            this.txt_valorTotal.ReadOnly = true;
            this.txt_valorTotal.Size = new System.Drawing.Size(100, 22);
            this.txt_valorTotal.TabIndex = 13;
            // 
            // valorLabel1
            // 
            valorLabel1.AutoSize = true;
            valorLabel1.Location = new System.Drawing.Point(399, 310);
            valorLabel1.Name = "valorLabel1";
            valorLabel1.Size = new System.Drawing.Size(49, 17);
            valorLabel1.TabIndex = 14;
            valorLabel1.Text = "Valor :";
            // 
            // txt_valor
            // 
            this.txt_valor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_vendaBindingSource, "valor", true));
            this.txt_valor.Location = new System.Drawing.Point(460, 305);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.ReadOnly = true;
            this.txt_valor.Size = new System.Drawing.Size(100, 22);
            this.txt_valor.TabIndex = 15;
            // 
            // btn_finalizarPedido
            // 
            this.btn_finalizarPedido.Location = new System.Drawing.Point(14, 305);
            this.btn_finalizarPedido.Name = "btn_finalizarPedido";
            this.btn_finalizarPedido.Size = new System.Drawing.Size(121, 23);
            this.btn_finalizarPedido.TabIndex = 16;
            this.btn_finalizarPedido.Text = "Finalizar Pedido";
            this.btn_finalizarPedido.UseVisualStyleBackColor = true;
            // 
            // btn_finalizarVenda
            // 
            this.btn_finalizarVenda.Location = new System.Drawing.Point(141, 304);
            this.btn_finalizarVenda.Name = "btn_finalizarVenda";
            this.btn_finalizarVenda.Size = new System.Drawing.Size(121, 23);
            this.btn_finalizarVenda.TabIndex = 17;
            this.btn_finalizarVenda.Text = "Finalizar Venda";
            this.btn_finalizarVenda.UseVisualStyleBackColor = true;
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.Location = new System.Drawing.Point(266, 304);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(121, 23);
            this.btn_imprimir.TabIndex = 18;
            this.btn_imprimir.Text = "Imprirmir";
            this.btn_imprimir.UseVisualStyleBackColor = true;
            // 
            // frm_venda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 484);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_novaVenda);
            this.Controls.Add(id_pessoaLabel);
            this.Controls.Add(this.CB_Cliente);
            this.Name = "frm_venda";
            this.Text = "Vendas";
            this.Load += new System.EventHandler(this.Frm_venda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tb_vendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_pessoaBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_itens_vendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_itensVenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource tb_vendaBindingSource;
        private System.Windows.Forms.ComboBox CB_Cliente;
        private System.Windows.Forms.BindingSource tb_pessoaBindingSource;
        private System.Windows.Forms.Button btn_novaVenda;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox valorTextBox;
        private System.Windows.Forms.BindingSource tb_itens_vendaBindingSource;
        private System.Windows.Forms.TextBox quantidadeTextBox;
        private System.Windows.Forms.TextBox id_vendaTextBox;
        private System.Windows.Forms.DataGridView DG_itensVenda;
        private System.Windows.Forms.ComboBox CB_produto;
        private System.Windows.Forms.BindingSource produtoBindingSource1;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private System.Windows.Forms.Button btn_novoItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorTotal;
        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.TextBox txt_valorTotal;
        private System.Windows.Forms.TextBox txt_desconto;
        private System.Windows.Forms.Button btn_imprimir;
        private System.Windows.Forms.Button btn_finalizarVenda;
        private System.Windows.Forms.Button btn_finalizarPedido;
    }
}