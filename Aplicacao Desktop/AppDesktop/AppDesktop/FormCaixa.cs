using AppDesktop.DAO;
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_cadastrar_cliente_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        int enter_count = 0;

        Estoque produto_add = new Estoque();
        private void txt_codigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (enter_count > 0)
            {
                if (produto_add.Id != 0) // Com o contador > 0 e o id do produto != 0 significa que um produto deve ser adicionado
                {

                    adicionaItem(produto_add);

                }
                else
                {
                    //abre caixa de procura
                }



            }
            else if (e.KeyCode == Keys.Enter)
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
        //List<Estoque> lista_itens = new List<Estoque>();


        int linha_produto_adicionado = -1;
        public void adicionaItem(Estoque item)
        {
            try
            {
                for (int i = 0; i < dataGrid_itens.Rows.Count - 1; i++)
                {
                    if (item.Cod.ToString().Equals(dataGrid_itens.Rows[i].Cells[0].Value.ToString()))
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
                dataGrid_itens.Rows.Add(item.Cod, item.Produto, item.Preco, 1); // Adiciona produto a lista;
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
                        txt_nome_cliente.Text = clientes[0].Nome;
                        txt_cpf.Text = clientes[0].Cpf;
                        txt_tel.Text = clientes[0].Telefone;
                        count_cliente++;

                    }
                }
                else
                {
                    enter_pressed = false;
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


            }
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
                dataGrid_itens.Rows[linha_produto_adicionado].Cells[3].Value = txt_quantidade.Text;
                double preco = conversor.toDouble(dataGrid_itens.Rows[linha_produto_adicionado].Cells[2].Value.ToString());
                itens_count = itens_count + conversor.ToInt32(txt_quantidade.Text) - 1;
                lbl_total_itens.Text = itens_count.ToString();
                valor_total = valor_total + (preco * conversor.toDouble(txt_quantidade.Text)) - preco;
                lbl_valor_total.Text = valor_total.ToString();
                panel_quantidade.Visible = false;
                txt_quantidade.Text = "1";
            }

        }

        private void radio_credito_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_credito.Checked)
            {
                combo_parcelas.Visible = true;
            }
        }

        private void btnFinalizarVenda_click(object sender, EventArgs e)
        {
            if (venda_preparada) Finalizar();
            else PreparaFinalizacao();
            
        }


        private void Finalizar()
        {
            throw new NotImplementedException();
        }

        private void PreparaFinalizacao()
        {
            List<Item_Caixa> itens_caixa = CarregaGridNaLista();
            Venda venda = new Venda();
            venda.Valor_total = conversor.toDouble(lbl_valor_total.Text);
            venda.Quantidade_itens = conversor.ToInt32(lbl_total_itens.Text);

            MessageBox.Show(itens_caixa.Count.ToString());
            RegraDeNegocioController controller = new RegraDeNegocioController(venda, itens_caixa);
            Venda venda_aplicada = controller.AplicaRegras();

            lbl_valor_final.Text = venda_aplicada.Valor_final.ToString();
            lbl_desconto.Text = " "+venda_aplicada.Desconto.ToString()+"%";
            MessageBox.Show("REGRA APLICADA: "+  venda_aplicada.Regra_aplicada.ToString());
            venda_preparada = true;

        }

        private List<Item_Caixa> CarregaGridNaLista()
        {
            Item_Caixa ic;
            List<Item_Caixa> itens = new List<Item_Caixa>();
            for (int i = 0; i < dataGrid_itens.RowCount - 1; i++)
            {
                ic = new Item_Caixa();
                ic.Id = conversor.ToInt32(dataGrid_itens.Rows[i].Cells[0].Value.ToString());
                ic.Produto = dataGrid_itens.Rows[i].Cells[1].Value.ToString();
                ic.Preco = conversor.toDouble(dataGrid_itens.Rows[i].Cells[2].Value.ToString());
                ic.Quantidade = conversor.ToInt32(dataGrid_itens.Rows[i].Cells[3].Value.ToString());
                itens.Add(ic);

            }
            return itens;
        }

        private void txt_quantidade_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
