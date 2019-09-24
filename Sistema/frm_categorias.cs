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
    public partial class frm_categorias : Form
    {
        public frm_categorias()
        {
            InitializeComponent();
        }

        private void Frm_categorias_Load(object sender, EventArgs e)
        {
            this.categoriaBindingSource.DataSource = DataContextFactory.DataContext.categoria;
        }

        private void Btn_novo_Click(object sender, EventArgs e)
        {
            this.categoriaBindingSource.AddNew();
        }

        private void Btn_cadastrar_Click(object sender, EventArgs e)
        {
            if (this.Valida())
            {
                this.categoriaBindingSource.EndEdit();
                DataContextFactory.DataContext.SubmitChanges();
                MessageBox.Show("Categoria inserida com sucesso!");
            }


        }

        private bool Valida()
        {
            if (txt_categoria.Text.Trim() == string.Empty)
            {
                MessageBox.Show("O campo categoria eh obrigatorio");
                txt_categoria.Focus();
                return false;
            }
            return true;
        }

        private void Btn_excluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza", "Confirmacao", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (this.CategoriaPossuiProduto(this.categoriaAtual))
                {
                    MessageBox.Show("Voce nao pode excluir categoria, pq existe produtos nela");
                }
                else
                {
                    this.categoriaBindingSource.RemoveCurrent();
                    DataContextFactory.DataContext.SubmitChanges();
                    MessageBox.Show("Categoria excluida com sucesso!");
                }
            }
            else
            {
                this.categoriaBindingSource.CancelEdit();
            }

        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            this.categoriaBindingSource.CancelEdit();

        }


        public categoria categoriaAtual
        {
            get
            {
                return (categoria)this.categoriaBindingSource.Current;
            }
        }

        private bool CategoriaPossuiProduto(categoria Categoria)
        {
            var produtos = DataContextFactory.DataContext.produto.Where(x => x.id_categoria == Categoria.id_categoria);
            if (produtos.Count() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
