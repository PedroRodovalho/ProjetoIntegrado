﻿using AppDesktop.DAO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDesktop
{
    public partial class FormCaixa : Form
    {

        public FormCaixa()
        {
            InitializeComponent();
        }
        Conversor conversor = new Conversor();
        EstoqueDAO estoqueDAO = new EstoqueDAO();
        ClienteDAO clienteDAO = new ClienteDAO();
        VendaDAO vendaDAO = new VendaDAO();

        Boolean venda_preparada = false;
        int itens_count = 0;
        double valor_total = 0;

        private void FormCaixa_Load(object sender, EventArgs e)
        {
            formataDataGrid();
        }

        private void FormCaixa_SizeChanged(object sender, EventArgs e)
        {
            //dataGridView1.Size = new Size(this.Size.Width - 10, dataGridView1.Size.Height);

        }


        int enter_count = 0;

        Estoque produto_add = new Estoque();
        private void txt_codigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (enter_count > 0)
                {
                    if (produto_add.Id != 0 && produto_add.Quantidade > 1) // Com o contador > 0 e o id do produto != 0 significa que um produto deve ser adicionado
                    {
                        adicionaItem(produto_add);
                    }
                    else if (produto_add.Id != 0 && produto_add.Quantidade <= 1)
                    {
                        lbl_mensagens.Text = "PRODUTO INDISPONIVEL POR QUANTIDADE!";
                        lbl_mensagens.ForeColor = Color.Red;
                        lbl_mensagens.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
                    }
                }
                else
                {

                    produto_add = estoqueDAO.buscaProdutoByCod(conversor.ToInt32(txt_codigo.Text));

                    if (produto_add.Id != 0)
                    {

                        txt_codigo.Text = produto_add.Cod.ToString();
                        txt_produto.Text = produto_add.Produto;
                        lbl_mensagens.Text = "";


                    }
                    else
                    {
                        lbl_mensagens.Text = "PRODUTO NÃO ENCONTRADO!";
                        lbl_mensagens.ForeColor = Color.Red;
                        lbl_mensagens.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
                    }

                    enter_count++;

                }
            }
        }
        //List<Estoque> lista_itens = new List<Estoque>();

        Estoque ultimo_item_add;
        int linha_produto_adicionado = -1;
        public void adicionaItem(Estoque item)
        {


            ultimo_item_add = item;
            try
            {

                for (int i = 0; i < dataGrid_itens.Rows.Count - 1; i++)
                {

                    if (item.Cod.ToString().Equals(dataGrid_itens.Rows[i].Cells["cod"].Value.ToString()))
                    {


                        linha_produto_adicionado = i;
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (linha_produto_adicionado == -1)
            {
                dataGrid_itens.Rows.Add(item.Id, item.Cod, item.Produto, item.Preco, 1); // Adiciona produto a lista;
                itens_count = itens_count + 1;
                lbl_total_itens.Text = itens_count.ToString();
                valor_total = valor_total + item.Preco;
                lbl_valor_total.Text = valor_total.ToString();


            }
            else
            {

                panel_quantidade.Visible = true;
                this.ActiveControl = txt_quantidade;
                txt_quantidade.SelectAll();

            }
        }
        public void formataDataGrid()
        {
            dataGrid_itens.Columns.Add("id_produto", "ID_PRODUTO");
            dataGrid_itens.Columns["id_produto"].Visible = false;
            dataGrid_itens.Columns.Add("cod", "Código");
            dataGrid_itens.Columns.Add("produto", "Produto");
            dataGrid_itens.Columns.Add("preco", "Preço");
            dataGrid_itens.Columns.Add("quantidade", "Quantidade");
        }
        private void txt_codigo_TextChanged(object sender, EventArgs e)
        {
            enter_count = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_relogio.Text = DateTime.Now.ToString();
        }
        List<Cliente> clientes = null;
        Boolean enter_pressed = false;
        Boolean text_changed = false;
        int count_cliente = 0;
        private void txt_nome_cliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {


                enter_pressed = true;
                if (text_changed == true)
                {
                    enter_pressed = false;
                    clientes = null;

                }

                string nome = txt_nome_cliente.Text;
                if (clientes == null)
                {

                    clientes = clienteDAO.busca_cliente_nome(nome);
                    if (clientes.Count <= 0)
                    {
                        lbl_mensagens.Text = "NENHUM CLIENTE ENCONTRADO!";

                    }
                    else
                    {
                        count_cliente = 0;
                        enter_pressed = false;
                        FotoCliente foto = clienteDAO.BuscaFoto(clientes[0].Id);
                        txt_nome_cliente.Text = clientes[0].Nome;
                        txt_cpf.Text = clientes[0].Cpf;
                        txt_tel.Text = clientes[0].Telefone;
                        count_cliente++;
                        pictureBox1.ImageLocation = foto.Caminho_foto;
                    }
                }
                else
                {
                    try
                    {


                        enter_pressed = false;
                        FotoCliente foto =  clienteDAO.BuscaFoto(clientes[count_cliente].Id);
                        pictureBox1.ImageLocation = foto.Caminho_foto;
                        txt_nome_cliente.Text = clientes[count_cliente].Nome;
                        txt_cpf.Text = clientes[count_cliente].Cpf;
                        txt_tel.Text = clientes[count_cliente].Telefone;
                        count_cliente++;
                        enter_pressed = true;
                        if (count_cliente == clientes.Count)
                        {
                            clientes = null;
                            count_cliente = 0;
                            lbl_mensagens.Text = "NENHUN OUTRO CLIENTE ENCONTRADO!";
                        }
                    }
                    catch { }
                }
            }
        }

        internal void AtualizaVenda(Venda venda)
        {
            this.venda = venda;
        }

        private void txt_cpf_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string cpf = txt_cpf.Text;

                Cliente cliente = clienteDAO.busca_cliente_cpf(cpf);


                txt_nome_cliente.Text = cliente.Nome;

                txt_tel.Text = cliente.Telefone;
            }
        }

        private void txt_nome_cliente_TextChanged(object sender, EventArgs e)
        {
            if (enter_pressed == true)
            {
                text_changed = true;
                clientes = null;
            }
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            FormCadastra_cliente formCadastra = new FormCadastra_cliente();
            formCadastra.ShowDialog();
        }



        private void txt_quantidade_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (conversor.ToInt32(txt_quantidade.Text) > ultimo_item_add.Quantidade - 1)
                {

                    lbl_mensagens.Text = "PRODUTO COM FALTA EM ESTOQUE! DISPONIBILIDADE: " + (ultimo_item_add.Quantidade - 1);
                    lbl_mensagens.ForeColor = Color.Red;
                    lbl_mensagens.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
                }
                else
                {
                    dataGrid_itens.Rows[linha_produto_adicionado].Cells["quantidade"].Value = txt_quantidade.Text;
                    double preco = conversor.toDouble(dataGrid_itens.Rows[linha_produto_adicionado].Cells["preco"].Value.ToString());
                    itens_count = itens_count + conversor.ToInt32(txt_quantidade.Text) - 1;
                    lbl_total_itens.Text = itens_count.ToString();
                    valor_total = valor_total + (preco * conversor.toDouble(txt_quantidade.Text)) - preco;
                    lbl_valor_total.Text = valor_total.ToString();
                    panel_quantidade.Visible = false;
                    txt_quantidade.Text = "1";
                    linha_produto_adicionado = -1;
                    lbl_mensagens.Text = "PRODUTO " + ultimo_item_add.Produto + " - Quantidade atualizada.";
                    lbl_mensagens.ForeColor = Color.Blue;
                    lbl_mensagens.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
                }
            }

        }



        private void btnFinalizarVenda_click(object sender, EventArgs e)
        {
            if (itens_count == 0)
            {
                lbl_mensagens.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
                lbl_mensagens.Text = "NÃO HÁ ITENS PARA CRIAR UMA VENDA";
                lbl_mensagens.ForeColor = Color.Yellow;
            }
            else
            {


                if (venda_preparada) Finalizar();
                else PreparaFinalizacao();
            }

        }


        public void Finalizar()
        {
            // vendaDAO.InsereItensVenda(CarregaGridNaLista());

            vendaDAO.CommitTransaction(transaction);
            vendaDAO.atualizaVFVenda(venda);
            List<ItemVenda> itensVenda = AtualizaID_IV();

            vendaDAO.InsereItensVenda(itensVenda);
            if (clientes != null)
            {
                vendaDAO.InsereHistoricoCliente(venda.Id, clientes[count_cliente - 1].Id);
            }
            LimparCampos();



        }

        private List<ItemVenda> AtualizaID_IV()
        {
            List<ItemVenda> iv = CarregaGridNaLista();
            MessageBox.Show(venda.Id.ToString());
            int i = 0;
            foreach (ItemVenda item in iv)
            {
                iv[i].Id_venda = venda.Id;
                i++;

            }

            return iv;
        }

        public void LimparCampos()
        {
            count_cliente = 0;
            dataGrid_itens.Rows.Clear();
            lbl_desconto.Text = "0.00";
            lbl_valor_final.Text = "0.00";
            lbl_valor_total.Text = "0.00";
            lbl_desconto_liquido.Text = "0.00";
            txt_codigo.Text = "";
            txt_produto.Text = "";
            txt_nome_cliente.Text = "";
            txt_cpf.Text = "";
            txt_nome_cliente.Text = "";
            txt_quantidade.Text = "";
            venda_preparada = false;


        }
        MySqlTransaction transaction;
        Venda venda = new Venda();
        private void PreparaFinalizacao()
        {
            List<ItemVenda> itens_caixa = CarregaGridNaLista();
            venda.Data = conversor.toDateTimeDB(DateTime.Today.ToShortDateString());
            venda.Valor_total = conversor.toDouble(lbl_valor_total.Text);
            venda.Quantidade_itens = conversor.ToInt32(lbl_total_itens.Text);

            VendaDAO vendaDAO = new VendaDAO();
            transaction = vendaDAO.InsereVenda(venda);
            venda.Id = vendaDAO.GetLastIdVenda() + 1;

            FormRecebePagamento formPagamento;

            formPagamento = new FormRecebePagamento(venda, this);
            DialogResult dialogo = formPagamento.ShowDialog();

            if (dialogo == DialogResult.Cancel)
            {
                lbl_mensagens.Text = "PAGAMENTO RECUSADO - TENTE NOVAMENTE";
                lbl_mensagens.ForeColor = Color.Red;
            }
            else
            {

                lbl_mensagens.Text = "PAGAMENTO ACEITO - AGUARDANDO FINALIZACAÇÃO!";
                lbl_mensagens.ForeColor = Color.Green;
                lbl_valor_final.Text = venda.Valor_final.ToString("0.00");

            }
            formPagamento.Close();
            venda_preparada = true;

        }


        private List<ItemVenda> CarregaGridNaLista()
        {
            List<ItemVenda> itens = new List<ItemVenda>();
            ItemVenda ic;
            for (int i = 0; i < dataGrid_itens.RowCount - 1; i++)
            {
                ic = new ItemVenda();
                //  ic.Id = conversor.ToInt32(dataGrid_itens.Rows[i].Cells[].Value.ToString());
                ic.Id_produto = conversor.ToInt32(dataGrid_itens.Rows[i].Cells["id_produto"].Value.ToString());
                ic.Preco = conversor.toDouble(dataGrid_itens.Rows[i].Cells["preco"].Value.ToString());
                ic.Quantidade = conversor.ToInt32(dataGrid_itens.Rows[i].Cells["quantidade"].Value.ToString());
                itens.Add(ic);

            }
            return itens;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DateTime.Today.AddDays(-3).ToShortDateString());
        }

        private void btn_ok_quantidade_Click(object sender, EventArgs e)
        {

        }

        private void txt_quantidade_TextChanged(object sender, EventArgs e)
        {
            enter_count = 0;
        }
    }
}
