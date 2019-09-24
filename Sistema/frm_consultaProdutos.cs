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
    public partial class frm_consultaProdutos : Form
    {
        public frm_consultaProdutos()
        {
            InitializeComponent();
        }

        private void Frm_consultaProdutos_Load(object sender, EventArgs e)
        {
            //this.produtoBindingSource.DataSource = DataContextFactory.DataContext.produto;
            this.categoriaBindingSource.DataSource = DataContextFactory.DataContext.categoria;
        }

        public void Pesquisar(int codigoCategoria)
        {
            this.produtoBindingSource.DataSource = DataContextFactory.DataContext.produto.Where(x => x.id_categoria == codigoCategoria);
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            this.Pesquisar((int)CB_categoria.SelectedValue);
        }
    }
}
