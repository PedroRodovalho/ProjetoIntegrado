using AppDesktop.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDesktop
{
    public partial class FormEstoque : Form
    {
        public FormEstoque()
        {
            InitializeComponent();
        }

        EstoqueDAO estoqueDAO = new EstoqueDAO();
        private void FormEstoque_Load(object sender, EventArgs e)
        {
            List<Estoque> produtos = estoqueDAO.lista_estoque();

            dataGrid_estoque.DataSource = produtos;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastra_produto formCadastra_produto = new FormCadastra_produto(this);
            formCadastra_produto.ShowDialog();
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastra_fornecedor formCadastra_Fornecedor = new FormCadastra_fornecedor();
            DialogResult dialog = formCadastra_Fornecedor.ShowDialog();
            if (dialog == DialogResult.OK)
            {
                atualizaDataGrid();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void produtoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormBusca_produto formBusca_Produto = new FormBusca_produto();
            formBusca_Produto.ShowDialog();
        }

        public void atualizaDataGrid()
        {
            dataGrid_estoque.DataSource = "";
            List<Estoque> produtos = estoqueDAO.lista_estoque();
            dataGrid_estoque.DataSource = produtos;
        }
    }
}
