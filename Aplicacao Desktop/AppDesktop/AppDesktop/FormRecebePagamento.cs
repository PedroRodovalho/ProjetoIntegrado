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
    public partial class FormRecebePagamento : Form
    {
        Conversor conversor = new Conversor();
        Venda venda;
        Venda venda_aux;
        FormCaixa contexto;
        Pagamento pagamento = new Pagamento();
        VendaDAO vendaDAO = new VendaDAO();
        public FormRecebePagamento(Venda venda, FormCaixa contexto)
        {
            this.venda = venda;
            venda_aux = venda;
            this.contexto = contexto;
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FormRecebePagamento_Load(object sender, EventArgs e)
        {
            //DADOS INICIAIS;


            //570; 313 size 1 pagamento;
            //570; 443 size 2 pagamento

            //431; 199 localizao botao 1 pagamento;
            //431; 355 localizacao botao 2 pagamento;

            lbl_valor_total.Text = venda.Valor_total.ToString();
        }
        Boolean pristine = false;
        private void btn_adiciona_pagamento_Click(object sender, EventArgs e)
        {
            if (!pristine)
            {
                this.Size = new Size(570, 443);
                btn_concluir.Location = new Point(450, 366); //NOVA LOCALIZACAO DO BOTAO DE CONCLUIR
                btn_cancelar.Location = new Point(358, 366); //NOVA LOCALIZACAO DO BOTAO DE CANCELAR
                dataGrid_pagamentos.Visible = true;
                if (venda.Regra_aplicada == 0)
                {
                    venda_aux.Valor_total = pagamento.Valor;
                }

            }
            Adiciona();
            pristine = true;

        }


        List<Pagamento> pagamentos = new List<Pagamento>();
        private void Adiciona()
        {
            dataGrid_pagamentos.DataSource = "";
            dataGrid_pagamentos.DataSource = pagamentos;


        }


        private void FormataGrid()
        {

        }
        double valor_pago = 0;
        private void txt_valor_pago_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {

                valor_pago = (double)valor_pago + conversor.toDouble(txt_valor_pago.Text);
                lbl_valor_pago.Text = valor_pago.ToString("0.00");

                
                btn_adiciona_pagamento.Enabled = true;


                pagamento.Id_venda = venda.Id;
                pagamento.Forma_pagamento = groupBox_formaPagamento.Controls.OfType<RadioButton>().SingleOrDefault(rad => rad.Checked == true).Text;
                pagamento.Quantidade_parcelas = conversor.ToInt32(combo_parcelas.Text);
                pagamento.Valor = valor_pago;
                pagamentos.Add(pagamento);

                RegraDeNegocioController controller = new RegraDeNegocioController(venda_aux, CarregaGridNaLista(), pagamento);
                Venda venda_aplicada = controller.AplicaRegras();
                if (venda_aplicada != null)
                {

                    lbl_tipo_desconto.Text = venda_aplicada.Regra_aplicada.ToString();
                    venda.Regra_aplicada = venda_aplicada.Regra_aplicada;

                    lbl_valor_final.Text = venda_aplicada.Valor_final.ToString();


                    lbl_desconto.Text = (venda_aplicada.Valor_total * venda_aplicada.Desconto / 100).ToString("0.00");
                    MessageBox.Show("REGRA APLICADA: " + venda_aplicada.Regra_aplicada.ToString());


                }
                else
                {

                    lbl_valor_final.Text = venda.Valor_total.ToString("0.00");
                }

            }
           
        }



        private void radioDinheiro_CheckedChanged(object sender, EventArgs e)
        {

            if (radioCredito.Checked) combo_parcelas.Enabled = true;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btn_concluir_Click(object sender, EventArgs e)
        {
            if (pristine) vendaDAO.InserePagamento(pagamentos);
            else vendaDAO.InserePagamento(pagamento);
            AtualizaVendaCaixa();
            this.DialogResult = DialogResult.OK;

        }

        private void AtualizaVendaCaixa()
        {
            venda.Valor_final = conversor.toDouble(lbl_valor_final.Text);
            contexto.AtualizaVenda(venda);
        }

        private List<ItemVenda> CarregaGridNaLista()
        {
            List<ItemVenda> itens = new List<ItemVenda>();
            ItemVenda ic;
            for (int i = 0; i < contexto.dataGrid_itens.RowCount - 1; i++)
            {
                ic = new ItemVenda();
                ic.Id = conversor.ToInt32(contexto.dataGrid_itens.Rows[i].Cells[0].Value.ToString());
                ic.Item = contexto.dataGrid_itens.Rows[i].Cells[1].Value.ToString();
                ic.Preco = conversor.toDouble(contexto.dataGrid_itens.Rows[i].Cells[2].Value.ToString());
                ic.Quantidade = conversor.ToInt32(contexto.dataGrid_itens.Rows[i].Cells[3].Value.ToString());
                itens.Add(ic);


                //         private int id;
                //        private int id_venda;
                //        private int id_produto;
                //         private string item;
                //private double preco;
                //private int quantidade;
                //private int id_promocao;
            }
            return itens;
        }
    }
}
