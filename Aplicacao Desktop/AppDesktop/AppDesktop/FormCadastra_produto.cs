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
        FormEstoque formEstoque;
        public FormCadastra_produto(FormEstoque formEstoque)
        {
            InitializeComponent();
            this.formEstoque = formEstoque;
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
                estoque.Data = conversor.toDateTimeDB(txt_data.Text);
                estoque.Categoria = combo_categoria.Text;
                estoque.Fornecedor = 1;
                estoque.Marca = txt_marca.Text;
                estoque.Descricao = txt_descricao.Text;
                estoqueDAO.insere_Estoque(estoque);

                lbl_mensagem.Text = estoque.Cod + " adicionado ao estoque.";
                lbl_mensagem.ForeColor = Color.DarkGreen;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                lbl_mensagem.Text = "Falha ao inserir estoque.";
                lbl_mensagem.ForeColor = Color.DarkRed;
            }
            limpaCampos();
        }
        public void limpaCampos()
        {
            txt_codigo.Text = "";
            txt_produto.Text = "";
            txt_quantidade.Text = "";
            txt_data.Text = "";
            txt_custo.Text = "";
            txt_preco.Text = "";
            txt_peso.Text = "";
            txt_marca.Text = "";
            combo_categoria.Text = "";
            combo_fornecedor.Text = "";
            
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            limpaCampos();
        }

        private void FormCadastra_produto_FormClosed(object sender, FormClosedEventArgs e)
        {
            formEstoque.atualizaDataGrid();
        }

        private void FormCadastra_produto_Load(object sender, EventArgs e)
        {
            
        }

        private void FormCadastra_produto_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }

    
}
