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
        FormHome contexto;

        // SE 0 NÃO POSSUI PERMISSAO
        // SE 1 POSSUI PERMISSAO;
        // SE 2 REQUISITAR AUTENTICACAO DE USUARIO;
        int insert = 0;
        int update = 0;
        int delete = 0;
        int id_produto_selecionado;
        Conversor conversor = new Conversor();
        public FormEstoque(FormHome contexto)
        {
            this.contexto = contexto;
            InitializeComponent();
        }

        EstoqueDAO estoqueDAO = new EstoqueDAO();
        FornecedorDAO forncedorDAO = new FornecedorDAO();
        List<Fornecedor> fornecedores;
        List<Estoque> produtos;
        FormMensagemAguarde formMensagem = null;
        private void FormEstoque_Load(object sender, EventArgs e)
        {

            if (contexto.activeSession.RequestFullPermissionEstoque())
            {
                insert = 1;
                update = 1;
                delete = 1;
            }
            else
            {
                formMensagem = new FormMensagemAguarde("CARREGANDO SOLICITAÇÃO");
                formMensagem.Show();
                backgroundWorker_RequisitaPermissao.RunWorkerAsync();
            }


            fornecedores = new List<Fornecedor>();
            produtos = estoqueDAO.lista_estoque();
            fornecedores = estoqueDAO.ListaFornecedores();
            dataGrid_estoque.DataSource = produtos;
        }


        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (insert == 2)
            {
                FormRevalidaSessao formRevalida = new FormRevalidaSessao();
            }
            FormCadastra_produto formCadastra_produto = new FormCadastra_produto(this);
            formCadastra_produto.ShowDialog();
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastra_fornecedor formCadastra_Fornecedor = new FormCadastra_fornecedor();
            DialogResult dialog = formCadastra_Fornecedor.ShowDialog();
            if (dialog == DialogResult.OK)
            {
                AtualizaDataGrid();
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

        public void AtualizaDataGrid()
        {
            dataGrid_estoque.DataSource = "";
            List<Estoque> produtos = estoqueDAO.lista_estoque();
            dataGrid_estoque.DataSource = produtos;
        }

        private void fornecedorToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (toolStripComboBox1.SelectedItem.Equals("FORNECEDOR"))
            {
                dataGrid_estoque.DataSource = "";


                dataGrid_estoque.DataSource = fornecedores;
            }
            else if (toolStripComboBox1.SelectedItem.Equals("ESTOQUE"))
            {
                dataGrid_estoque.DataSource = "";


                dataGrid_estoque.DataSource = produtos;
            }
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastra_Categoria formCadastra_Categoria = new FormCadastra_Categoria();
            formCadastra_Categoria.ShowDialog();
        }

        private void backgroundWorker_RequisitaPermissao_DoWork(object sender, DoWorkEventArgs e)
        {
            if (contexto.activeSession.RequestInsertEstoque())
            {
                insert = 1;

            }
            if (contexto.activeSession.RequestUpdateEstoque())
            {

                update = 1;
            }
            if (contexto.activeSession.RequestDeleteEstoque())
            {

                delete = 1;
            }
        }

        private void DesativaInsercoesEstoque()
        {

            fornecedorToolStripMenuItem.Visible = false;
            categoriaToolStripMenuItem.Enabled = false;
            produtoToolStripMenuItem.Enabled = false;
            criarPromoçãoToolStripMenuItem.Enabled = false;
            criarListaDePedidosToolStripMenuItem.Enabled = false;
            inserirNovoProdutoDevolvidoToolStripMenuItem.Enabled = false;

        }
        public void DesativaAtualizacoesEstoque()
        {

            ajusteDePromocaoToolStripMenuItem.Enabled = false;
            ajustePrecoToolStripMenuItem.Enabled = false;
            toolStrip_Editar.Enabled = false;
            toolStrip_Inativar.Enabled = false;

        }
        public void DesativaDeleteEstoque()
        {
            toolStrip_Deletar.Enabled = false;
        }

        private void backgroundWorker_RequisitaPermissao_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (insert == 0) DesativaInsercoesEstoque();
            if (update == 0) DesativaAtualizacoesEstoque();
            if (delete == 0) DesativaDeleteEstoque();
            formMensagem.Close();
            timerValidaPermissao.Enabled = true;
        }

        private void timerValidaPermissao_Tick(object sender, EventArgs e)
        {
            insert = 2;
            update = 2;
            delete = 2;
        }

        private void toolStrip_Deletar_Click(object sender, EventArgs e)
        {
            estoqueDAO.DeletaProduto(id_produto_selecionado);
            AtualizaDataGrid();
            contexto.toolStripStatusLabel1.Text = "Produto removido com sucesso!";
        }

        private void dataGrid_estoque_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (toolStripComboBox1.Text.Equals("ESTOQUE"))
            {
                id_produto_selecionado = conversor.ToInt32(dataGrid_estoque.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
        }
    }
}
