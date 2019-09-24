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
    public partial class frm_produtos : Form
    {
        public frm_produtos()
        {
            InitializeComponent();
        }

        private void Frm_produtos_Load(object sender, EventArgs e)
        {
            this.produtoBindingSource.DataSource = DataContextFactory.DataContext.produto;
            this.categoriaBindingSource.DataSource = DataContextFactory.DataContext.categoria;
        }

        private void Btn_novo_Click(object sender, EventArgs e)
        {
            this.produtoBindingSource.AddNew();
        }

        private void Btn_cadastrar_Click(object sender, EventArgs e)
        {
            if (this.Valida())
            {
                this.produtoBindingSource.EndEdit();
                DataContextFactory.DataContext.SubmitChanges();
                dataGridView1.Refresh();
                MessageBox.Show("Produto inserido com sucesso!");
            }


        }

        private bool Valida()
        {
            if (txt_descricao.Text.Trim() == string.Empty)
            {
                MessageBox.Show("O campo descricao produto eh obrigatorio");
                txt_descricao.Focus();
                return false;
            }
            return true;
        }


        private void Btn_excluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza", "Confirmacao", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                this.produtoBindingSource.RemoveCurrent();
                DataContextFactory.DataContext.SubmitChanges();
                MessageBox.Show("Categoria excluida com sucesso!");

            }
        }


        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            this.produtoBindingSource.CancelEdit();
        }

        private void DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null && e.ColumnIndex == 3)
            {
                e.Value = ((categoria)e.Value).desc_categoria;
            }
        }
    }
}
