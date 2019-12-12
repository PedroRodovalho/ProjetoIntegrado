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
    public partial class FormVenda : Form
    {

        public string[] filtros_ultimas_vendas = {"ULTIMOS 3 DIAS",
                                                  "ULTIMOS 7 DIAS",
                                                  "ULTIMOS 15 DIAS",
                                                  "ULTIMOS 30 DIAS",};


        public string[] filtros_valor_quantidade = { "CRESCENTE", "DESCRESCENTE" };
        public string[] filtros_tipo_venda = { "DINHEIRO", "DEBITO", "CREDITO" };
        Conversor conversor = new Conversor();
        public FormVenda()
        {
            InitializeComponent();
        }
        VendaDAO vendaDAO = new VendaDAO();
        List<Venda> vendas = new List<Venda>();
        List<ItemVenda> itens_venda = new List<ItemVenda>();
        private void FormVenda_Load(object sender, EventArgs e)
        {
            vendas = vendaDAO.ListarVendas();
            itens_venda = vendaDAO.ListaItensVenda();
            dataGrid_venda.DataSource = vendas;
            if (vendas.Count > 0)
                dataGrid_venda.Rows[0].Selected = true;
            FormataDataGridVenda();
            lbl_qtd_resultados.Text = vendas.Count.ToString();


        }

        private void combo_filtro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo_filtro.SelectedItem.Equals("TODOS")) combo_filtro2.Visible = false;
            if (combo_filtro.SelectedItem.Equals("HOJE")) combo_filtro2.Visible = false;
            if (combo_filtro.SelectedItem.Equals("ULTIMAS VENDAS")) { combo_filtro2.Visible = true; combo_filtro2.DataSource = filtros_ultimas_vendas; }
            if (combo_filtro.SelectedItem.Equals("VALOR")) { combo_filtro2.Visible = true; combo_filtro2.DataSource = filtros_valor_quantidade; }
            if (combo_filtro.SelectedItem.Equals("QUANTIDADE")) { combo_filtro2.Visible = true; combo_filtro2.DataSource = filtros_valor_quantidade; }
            if (combo_filtro.SelectedItem.Equals("TIPO DE VENDA")) { combo_filtro2.Visible = true; combo_filtro2.DataSource = filtros_tipo_venda; }
        }

        private void combo_filtro2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //FILTROS DE ULTIMAS VENDAS
            if (combo_filtro2.SelectedItem.Equals(filtros_ultimas_vendas[0]))
            {
                FiltraVendasPorData(DateTime.Today.AddDays(-3).ToShortDateString(), DateTime.Today.ToShortDateString());
            }
            if (combo_filtro2.SelectedItem.Equals(filtros_ultimas_vendas[1]))
            {
                FiltraVendasPorData(DateTime.Today.AddDays(-7).ToShortDateString(), DateTime.Today.ToShortDateString());
            }
            if (combo_filtro2.SelectedItem.Equals(filtros_ultimas_vendas[2]))
            {
                FiltraVendasPorData(DateTime.Today.AddDays(-15).ToShortDateString(), DateTime.Today.ToShortDateString());
            }
            if (combo_filtro2.SelectedItem.Equals(filtros_ultimas_vendas[3]))
            {
                FiltraVendasPorData(DateTime.Today.AddDays(-30).ToShortDateString(), DateTime.Today.ToShortDateString());
            }


        }

        private void FiltraVendasPorData(string data_inicio, string data_fim)

        {
            MessageBox.Show("ENTROU AUQI");
            List<Venda> vendas_filtrada = vendaDAO.listarVendas(conversor.toDateTimeDB(data_inicio), conversor.toDateTimeDB(data_fim));
            // dataGrid_venda.DataSource = "";
            dataGrid_venda.DataSource = vendas_filtrada;

        }

        private void dataGrid_venda_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

            //dataGrid_venda.;
            ItemVenda iv2 = new ItemVenda();
            if (dataGrid_venda.Rows[e.RowIndex].Cells[0].Value != null)
            {

                int id = conversor.ToInt32(dataGrid_venda.Rows[e.RowIndex].Cells[0].Value.ToString());
                var itens = itens_venda.Where(i => i.Id_venda == id).ToList<ItemVenda>();

                dataGrid_Itens.DataSource = itens;
                FormataDataGridItens();
            }


            //from iv2 in itens_venda where iv2.Id_venda == id select id_venda;
        }

        private void FormataDataGridItens()
        {
            dataGrid_Itens.Columns["id"].Visible = false;
            dataGrid_Itens.Columns["id_venda"].HeaderText = "ID VENDA";
            dataGrid_Itens.Columns["id_produto"].HeaderText = "ID PRODUTO";
            dataGrid_Itens.Columns["item"].HeaderText = "PRODUTO";
            dataGrid_Itens.Columns["preco"].HeaderText = "PREÇO";
            dataGrid_Itens.Columns["quantidade"].HeaderText = "QUANTIDADE";
            dataGrid_Itens.Columns["id_promocao"].Visible = false;


            dataGrid_Itens.Columns["id_venda"].Width = 81;
            dataGrid_Itens.Columns["id_produto"].Width = 100;
            dataGrid_Itens.Columns["item"].Width = 448;
            dataGrid_Itens.Columns["preco"].Width = 100;
            dataGrid_Itens.Columns["quantidade"].Width = 100;
            //id_venda 81 id_produto 100 item 448 preco 100 quant 100
        }
        private void FormataDataGridVenda()
        {
            dataGrid_venda.Columns["id"].HeaderText = "ID";
            dataGrid_venda.Columns["data"].HeaderText = "DATA DA VENDA";
            dataGrid_venda.Columns["valor_total"].HeaderText = "VALOR FINAL";

            dataGrid_venda.Columns["valor_final"].HeaderText = "VALOR FINAL";
            dataGrid_venda.Columns["desconto"].HeaderText = "DESCONTO";
            dataGrid_venda.Columns["quantidade_itens"].HeaderText = "QUANTIDADE DE ITENS";
            dataGrid_venda.Columns["regra_aplicada"].HeaderText = "REGRA APLICADA";

            dataGrid_venda.Columns["id"].Width = 53;
            dataGrid_venda.Columns["data"].Width = 139;
            dataGrid_venda.Columns["valor_total"].Width = 150;

            dataGrid_venda.Columns["valor_final"].Width = 137;
            dataGrid_venda.Columns["desconto"].Width = 449;
            dataGrid_venda.Columns["quantidade_itens"].Width = 159;
            dataGrid_venda.Columns["regra_aplicada"].Width = 133;

            //id :53 data 139 valt 150 valf 137 preco 449 quant 159 regra 133

        }

        private void dataGrid_venda_RowValidated(object sender, DataGridViewCellEventArgs e)
        {

        }

 


        private void combo_filtro2_TextUpdate(object sender, EventArgs e)
        {
            if (combo_filtro.SelectedItem.Equals("ULTIMOS 3 DIAS"))
            {
                FiltraVendasPorData(DateTime.Today.AddDays(-3).ToShortDateString(), DateTime.Today.ToShortDateString());
            }
            if (combo_filtro.SelectedItem.Equals("ULTIMOS 7 DIAS"))
            {
                FiltraVendasPorData(DateTime.Today.AddDays(-7).ToShortDateString(), DateTime.Today.ToShortDateString());
            }
            if (combo_filtro.SelectedItem.Equals("ULTIMOS 15 DIAS"))
            {
                FiltraVendasPorData(DateTime.Today.AddDays(-15).ToShortDateString(), DateTime.Today.ToShortDateString());
            }
            if (combo_filtro.SelectedItem.Equals("ULTIMOS 30 DIAS"))
            {
                FiltraVendasPorData(DateTime.Today.AddDays(-30).ToShortDateString(), DateTime.Today.ToShortDateString());
            }
        }

        Microsoft.Office.Interop.Excel.Application XcelApp = new Microsoft.Office.Interop.Excel.Application();
        private void btn_exportar_Click(object sender, EventArgs e)
        {
            if (dataGrid_venda.Rows.Count > 0)
            {
                try
                {
                    XcelApp.Application.Workbooks.Add(Type.Missing);

                    for (int i = 1; i < dataGrid_venda.Columns.Count + 1; i++)
                    {
                        XcelApp.Cells[1, i] = dataGrid_venda.Columns[i - 1].HeaderText;
                    }
                    //
                    for (int i = 0; i < dataGrid_venda.Rows.Count - 1; i++)
                    {
                        for (int j = 0; j < dataGrid_venda.Columns.Count; j++)
                        {
                            XcelApp.Cells[i + 2, j + 1] = dataGrid_venda.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                    //
                    XcelApp.Columns.AutoFit();
                    //
                    XcelApp.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro : " + ex.Message);
                    XcelApp.Quit();
                }
            }
        }

        private void btn_busca_Click(object sender, EventArgs e)
        {
            string data_inicio = masked_DataInicio.Text;
            string data_fim = masked_DataFim.Text;
            FiltraVendasPorData(data_inicio, data_fim);

        }

        private void btn_view_cliente_Click(object sender, EventArgs e)
        {
            ClienteDAO clienteDAO = new ClienteDAO();
           // int id = dataGrid_venda.Rows[dataGrid_venda.].Cells[0].Value;


        }
    }
}
