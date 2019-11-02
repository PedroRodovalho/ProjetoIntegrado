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
    public partial class FormBusca_produto : Form
    {

        EstoqueDAO estoqueDAO = new EstoqueDAO();
        public FormBusca_produto()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        Conversor conversor = new Conversor();
        private void txt_codigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Estoque estoque = estoqueDAO.buscaProdutoByCod(conversor.ToInt32(txt_codigo.Text));
                apresentaDados(estoque);
            }
        }

        public void apresentaDados(Estoque estoque)
        {
            try
            {
                txt_codigo.Text = estoque.Cod.ToString();
                txt_produto.Text = estoque.Produto;
                lbl_quantidade.Text = estoque.Quantidade.ToString();
                lbl_custo.Text = estoque.Custo.ToString("0.00");
                lbl_preco.Text = estoque.Preco.ToString("0.00");
                lbl_peso.Text = estoque.Peso.ToString("0.0");
                lbl_fornecedor.Text = estoque.Fornecedor.ToString();
                lbl_categoria.Text = estoque.Categoria;
                lbl_marca.Text = estoque.Marca;
                lbl_data.Text = estoque.Data;
                txt_descricao.Text = estoque.Descricao;
            }
            catch
            {

            }
        }
    }
}
