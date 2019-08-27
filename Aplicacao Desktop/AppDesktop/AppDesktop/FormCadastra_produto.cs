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
    public partial class FormCadastra_produto : Form
    {
        EstoqueDAO estoqueDAO = new EstoqueDAO();
        Conversor conversor = new Conversor();

        public FormCadastra_produto()
        {
            InitializeComponent();
        }

        private void btn_finalizar_Click(object sender, EventArgs e)
        {
            try
            {
                Estoque estoque = new Estoque();
                estoque.Cod = conversor.toInt(txt_codigo.Text);
                estoque.Produto = txt_produto.Text;
                estoque.Quantidade = conversor.toInt(txt_quantidade.Text);
                estoque.Custo = conversor.toDouble(txt_custo.Text);
                estoque.Preco = conversor.toDouble(txt_preco.Text);
                estoque.Peso = conversor.toDouble(txt_peso.Text);
                estoque.Categoria = combo_categoria.Text;
                estoque.Fornecedor = 1;
                estoque.Marca = txt_marca.Text;
                estoque.Descricao = txt_descricao.Text;
                estoqueDAO.insere_Estoque(estoque);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
