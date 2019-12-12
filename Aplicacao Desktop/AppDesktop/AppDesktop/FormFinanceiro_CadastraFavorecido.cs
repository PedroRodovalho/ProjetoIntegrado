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
    public partial class FormFinanceiro_CadastraFavorecido : Form
    {
        FinanceiroDAO financeiroDAO = new FinanceiroDAO();
        BancoDAO bancoDAO = new BancoDAO();
        FavorecidoDAO favorecidoDAO = new FavorecidoDAO();
        Conversor conversor = new Conversor();
        Banco banco = new Banco();
        List<Banco> bancos;


        public FormFinanceiro_CadastraFavorecido()
        {
            InitializeComponent();
        }
        private void FormFinanceiro_CadastraFavorecido_Load(object sender, EventArgs e)
        {
            bancos = bancoDAO.ListaBancos();
            for (int i = 0; i < bancos.Count; i++)
            {
                combo_banco.Items.Add(bancos[i].Nome + " - " + bancos[i].Cod);
            }
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            Favorecido favorecido = new Favorecido();
            favorecido.Nome = txt_nome.Text;
            favorecido.Cpf_cpnj = txt_cpf_cnpj.Text;
            favorecido.Id_banco = conversor.ToInt32(lbl_id_banco.Text);
            favorecido.Agencia = txt_agencia.Text;
            favorecido.Conta = txt_conta.Text;
            favorecido.Classificacao = combo_classificacao.Text;

            favorecidoDAO.NovoFavorecido(favorecido);


        }

        private void combo_banco_SelectedIndexChanged(object sender, EventArgs e)
        {
            string banco = combo_banco.Text;

            for(int i = 0; i < bancos.Count; i++)
            {
                if (banco.Contains(bancos[i].Cod.ToString()))
                {
                    lbl_id_banco.Text = bancos[i].Id.ToString();
                }
            }
        }
    }
}
