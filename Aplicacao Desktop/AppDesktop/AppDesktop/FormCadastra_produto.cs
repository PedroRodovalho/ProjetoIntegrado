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
                estoque.Cod = conversor.ToInt32(txt_codigo.Text);
                estoque.Produto = txt_produto.Text;
                estoque.Quantidade = conversor.ToInt32(txt_quantidade.Text);
                estoque.Custo = conversor.toDouble(txt_custo.Text);
                estoque.Preco = conversor.toDouble(txt_preco.Text);
                estoque.Peso = conversor.toDouble(txt_peso.Text);
                estoque.Data = txt_data.Text;
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
            FornecedorDAO fornecedorDAO = new FornecedorDAO();

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            limpaCampos();
        }

        private void FormCadastra_produto_FormClosed(object sender, FormClosedEventArgs e)
        {
            formEstoque.AtualizaDataGrid();
        }

        private void FormCadastra_produto_Load(object sender, EventArgs e)
        {
            List<Categoria> categorias = estoqueDAO.ListaCategorias();
            List<Fornecedor> fornecedores = fornecedorDAO.Lista_fornecedores();
            combo_categoria.Items.Add("SELECIONAR CATEGORIA");
            combo_categoria.SelectedIndex = 0;
            combo_fornecedor.Items.Add("SELECIONAR FORNECEDOR");
            combo_fornecedor.SelectedIndex = 0;


            //for(int i = 0;i<categorias.Count;i++)
            //{
            //    Categoria categoria = categorias[i];
            //    combo_categoria.Items.Add(categoria.Nome);

            //}

            foreach (Categoria categoria in categorias)
            {
                combo_categoria.Items.Add(categoria.Nome);
            }
            foreach (Fornecedor fornecedor in fornecedores)
            {
                combo_fornecedor.Items.Add(fornecedor.Nome);
            }
        }

        private void FormCadastra_produto_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void btn_calendario_Click(object sender, EventArgs e)
        {
            if (monthCalendar1.Visible)
            {
                string data = monthCalendar1.SelectionStart.ToShortDateString();
                txt_data.Text = data;
                monthCalendar1.Visible = false;
            }
            else
            {
                monthCalendar1.Visible = true;
            }
        }
    }

    
}
