using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema.DAL;

namespace Sistema
{
    public partial class frm_venda : Form
    {
        public frm_venda()
        {
            InitializeComponent();
        }

        private void Frm_venda_Load(object sender, EventArgs e)
        {
            this.tb_pessoaBindingSource.DataSource = DataContextFactory.DataContext.tb_pessoa;
            this.tb_vendaBindingSource.DataSource = DataContextFactory.DataContext.tb_venda;
            this.produtoBindingSource1.DataSource = DataContextFactory.DataContext.produto;
            this.produtoBindingSource.DataSource = DataContextFactory.DataContext.produto;
            //this.tb_itens_vendaBindingSource.DataSource = DataContextFactory.DataContext.tb_itens_venda;
            

            this.tb_vendaBindingSource.AddNew();

        }

        public tb_venda vendaCorrente
        {
            get
            {
                return (tb_venda)this.tb_vendaBindingSource.Current;
            }
        }
        public tb_itens_venda itemCorrente
        {
            get
            {
                return (tb_itens_venda)this.tb_itens_vendaBindingSource.Current;
            }
        }

        private void Btn_novaVenda_Click(object sender, EventArgs e)
        {
            this.tb_vendaBindingSource.EndEdit();
            DataContextFactory.DataContext.SubmitChanges();
            groupBox1.Visible = true;
            btn_novaVenda.Enabled = false;

            this.tb_itens_vendaBindingSource.DataSource = DataContextFactory.DataContext.tb_itens_venda.Where(x => x.id_produto == this.vendaCorrente.id_venda);
            NovoItem();
        }

        private void NovoItem()
        {
            this.tb_itens_vendaBindingSource.AddNew();
            this.itemCorrente.id_venda = this.vendaCorrente.id_venda;
            this.itemCorrente.quantidade = 1;

        }

        private void Btn_novoItem_Click(object sender, EventArgs e)
        {
            this.tb_itens_vendaBindingSource.EndEdit();
            DG_itensVenda.Refresh();
            DataContextFactory.DataContext.SubmitChanges();
            MostraSomaValores();
            NovoItem();
        }

        private void DG_itensVenda_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null && e.ColumnIndex == 1)
                e.Value = ((produto)e.Value).desc_produto;
        }

        private void CB_produto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_produto.SelectedItem != null)
            {
                var pro = (produto)CB_produto.SelectedItem;
                this.itemCorrente.id_produto = (int)pro.id_produto;
                this.itemCorrente.valor = (decimal)pro.valor;
            }
        }

        private void MostraSomaValores()
        {
            decimal total = 0;
            foreach (DataGridViewRow dg in DG_itensVenda.Rows)
            {
                decimal v1 = Convert.ToDecimal(dg.Cells[2].Value);
                decimal v2 = Convert.ToDecimal(dg.Cells[3].Value);
                decimal subtotal = v1 * v2;
                dg.Cells[4].Value = subtotal;
                total = total + subtotal;
            }

            this.vendaCorrente.valor = total;


        }

    }
}
