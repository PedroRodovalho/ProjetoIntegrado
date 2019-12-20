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
    public partial class FormFinanceiro_pagamentos : Form
    {
        public Favorecido favorecido = new Favorecido();
        public Devedor devedor = new Devedor();
        private Lancamento lancamento = new Lancamento();
        BancoDAO bancoDAO = new BancoDAO();
        Conta conta = new Conta();
        List<Banco> bancos;
        private FinanceiroDAO financeiroDAO = new FinanceiroDAO();
        private Conversor conversor = new Conversor();
        public FormFinanceiro_pagamentos()
        {
            InitializeComponent();
        }

        private void FormFinanceiro_pagamentos_Load(object sender, EventArgs e)
        {
            bancos = bancoDAO.ListaBancos();
            for (int i = 0; i < bancos.Count; i++)
            {
                combo_banco.Items.Add(bancos[i].Nome + " - " + bancos[i].Cod);
            }
            //timer1.Start();
        }

     

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_date_time.Text = DateTime.Now.ToString();
            lbl_date_time.Refresh();
        }

        private void combo_forma_pagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo_forma_pagamento.SelectedItem.Equals("")) groupBox_Dados.Enabled = false;
            if (combo_forma_pagamento.SelectedItem.Equals("BOLETO"))
            {
                groupBox_Dados.Enabled = true;
                txt_cod_barras.Enabled = true;
                txt_agencia.Enabled = false;
                txt_conta.Enabled = false;
            }
            if (combo_forma_pagamento.SelectedItem.Equals("TRANSFÊRENCIA"))
            {
                groupBox_Dados.Enabled = true;
                txt_cod_barras.Enabled = false;
                txt_agencia.Enabled = true;
                txt_conta.Enabled = true;
            }
            if (combo_forma_pagamento.SelectedItem.Equals("DEPOSITO"))
            {
                groupBox_Dados.Enabled = true;
                txt_cod_barras.Enabled = false;
                txt_agencia.Enabled = true;
                txt_conta.Enabled = true;
            }

        }

        private void btn_busca_favorecido_Click(object sender, EventArgs e)
        {
            FormFinanceiro_BuscaFavorecido formBuscaFavorecido = new FormFinanceiro_BuscaFavorecido(this, 0);
            DialogResult dialogo = formBuscaFavorecido.ShowDialog();
            if (dialogo == DialogResult.OK)
            {
                txt_favorecido.Text = favorecido.Nome;
                lbl_cpf_cnpj.Text = favorecido.Cpf_cpnj;
                txt_conta.Text = favorecido.Conta;
                txt_agencia.Text = favorecido.Agencia;
                lbl_classificacao.Text = favorecido.Classificacao;
            }
        }

       
        
        private void btn_registrar_Click(object sender, EventArgs e)
        {
            //ValidaCampos();
            CapturaDados();
            financeiroDAO.NovaConta(conta);
            financeiroDAO.NovoLancamento(lancamento);
            
        }
        public void CapturaDados()
        {
            conta.Cod = conversor.ToInt32(txt_cod.Text);
            conta.Forma_pagamento = combo_forma_pagamento.SelectedItem.ToString();
            conta.Id_favorecido = favorecido.Id;
            conta.Id_devedor = devedor.Id;
            conta.Id_banco = favorecido.Id_banco;
            conta.Tipo = combo_tipo_pagamento.SelectedItem.ToString();
            conta.Sub_tipo = combo_subtipo.SelectedItem.ToString();
            conta.Tipo_debito = combo_tipo_debito.SelectedItem.ToString();
            conta.Data_criacao = DateTime.Today.ToShortDateString();
            conta.Hora_criacao = DateTime.Today.ToShortTimeString();
            conta.Data_vencimento = maskedTxt_Data.Text;
            conta.Valor = conversor.toDouble(txt_valor.Text);
            conta.Descricao = txt_descricao.Text;
          
            lancamento.Cod_conta = conta.Cod;
            lancamento.Data_lancamento = masked_data_pagamento.Text;

        }
        private bool ValidaCampos()
        {
            //if(text)
            throw new NotImplementedException();
        }

        private void combo_banco_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_busca_devedor_Click(object sender, EventArgs e)
        {
            FormFinanceiro_BuscaFavorecido formBuscaFavorecido = new FormFinanceiro_BuscaFavorecido(this, 1);
            DialogResult dialogo = formBuscaFavorecido.ShowDialog();
            if (dialogo == DialogResult.OK)
            {
                txt_devedor.Text = devedor.Nome;
            }
        }

        private void btn_calendario_Click(object sender, EventArgs e)
        {
            if (monthCalendar1.Visible)
            {
                string data = monthCalendar1.SelectionStart.ToShortDateString();
                maskedTxt_Data.Text = data;
                monthCalendar1.Visible = false;
            }
            else
            {
                monthCalendar1.Visible = true;
            }
        }

  

        private void combo_tipo_pagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo_tipo_pagamento.SelectedItem.Equals("AGUA/ENERGIA/TELEFONE"))
            {
                string[] sub_tipos = { "AGUA", "ENERGIA", "TELEFONE" };
                combo_subtipo.DataSource = sub_tipos;
            }
            if (combo_tipo_pagamento.SelectedItem.Equals("FORNECEDOR"))
            {
                string[] sub_tipos = { "COMPRA DE MERCADORIA", "PAGAMENTO DE MERCADORIA", "AJUSTES" };
                combo_subtipo.DataSource = sub_tipos;
            }
            if (combo_tipo_pagamento.SelectedItem.Equals("FUNCIONÁRIO"))
            {
                string[] sub_tipos = { "SALÁRIO", "COMISSÃO", "VALE-TRANSPORTE", "VALE-ALIMENTACAO", "ADIANTAMENTO" };
                combo_subtipo.DataSource = sub_tipos;
            }
        }

        private void btn_calendario2_Click(object sender, EventArgs e)
        {
            if (monthCalendar1.Visible)
            {
                string data = monthCalendar1.SelectionStart.ToShortDateString();
                masked_data_pagamento.Text = data;
                monthCalendar1.Visible = false;
            }
            else
            {
                monthCalendar1.Visible = true;

            }
        }


        private void txt_cod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int cod = conversor.ToInt32(txt_cod.Text);
                conta = financeiroDAO.BuscaContaByCod(cod);

                if(conta == null)
                {
                    lbl_status.Text = "EM CADASTRO";
                    combo_forma_pagamento.Enabled = true;
                }
                else
                {
                    CarregaConta();
                }
            }
            
        }
        Banco banco;
        private void CarregaConta()
        {

            btn_editar.Enabled = true;
            groupBox_Dados.Enabled = false;
            FavorecidoDAO favorecidoDAO = new FavorecidoDAO();
            favorecido = favorecidoDAO.BuscaFavorecidoById(conta.Id_favorecido);
            devedor = favorecidoDAO.BuscaDevedorById(conta.Id_devedor);
            
            banco = bancoDAO.BuscaBanco(favorecido.Id_banco);

            Lancamento lancamento = financeiroDAO.BuscaLancamento(conta.Cod);
            if(lancamento == null)
            {
                btn_lancar.Enabled = true;
            }
            else
            {
                masked_data_pagamento.Text = lancamento.Data_lancamento;
            }

            combo_banco.Text = banco.Nome + " - " + banco.Cod;
            combo_forma_pagamento.SelectedItem = conta.Forma_pagamento;
            txt_favorecido.Text = favorecido.Nome;
            txt_agencia.Text = favorecido.Agencia;
            txt_conta.Text = favorecido.Conta;
            lbl_cpf_cnpj.Text = favorecido.Cpf_cpnj;
            lbl_cpf_cnpj.Text = favorecido.Classificacao;
            lbl_status.Text = conta.Status;
            txt_devedor.Text = devedor.Nome;
             
            
            combo_tipo_pagamento.SelectedItem = conta.Tipo;
            combo_subtipo.SelectedItem = conta.Sub_tipo;
            combo_tipo_debito.SelectedItem = conta.Tipo_debito;
            lbl_date_time.Text = conta.Data_criacao + " " + conta.Hora_criacao;

            maskedTxt_Data.Text = conta.Data_vencimento;
            txt_valor.Text = conta.Valor.ToString("0,00");
            txt_descricao.Text = conta.Descricao;

        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            groupBox_Dados.Enabled = true;
            btn_registrar.Enabled = false;
            btn_salvar.Visible = true;

            CapturaDados();   
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            Lancamento lancamento = new Lancamento();
            financeiroDAO.AtualizaConta(conta);
            financeiroDAO.AtualizaLancamento(lancamento);
        }

        private void btn_lancar_Click(object sender, EventArgs e)
        {
            CapturaDados();
            financeiroDAO.NovoLancamento(lancamento);
        }
    }

}
