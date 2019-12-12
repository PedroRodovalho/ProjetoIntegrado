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
    public partial class FormCadastra_fornecedor : Form
    {

        Conversor conversor = new Conversor();
        BancoDAO bancoDAO = new BancoDAO();
        List<Banco> bancos;
        public FormCadastra_fornecedor()
        {
            
            InitializeComponent();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            FornecedorDAO fornecedorDAO = new FornecedorDAO();
            Fornecedor fornecedor = new Fornecedor();

            fornecedor.Nome = txt_nome.Text;
            fornecedor.Tel = txt_telefone.Text;
            fornecedor.Email = txt_email.Text;
            fornecedor.Cnpj = txt_cnpj.Text;

            fornecedorDAO.Cadastra_fornecedor(fornecedor);

            if (check_cadastra_favorecido.Checked)
            {
                FavorecidoDAO favorecidoDAO = new FavorecidoDAO();
                Favorecido favorecido = new Favorecido();
                favorecido.Nome = txt_nome.Text;
                favorecido.Cpf_cpnj = txt_cnpj.Text;
                favorecido.Id_banco = conversor.ToInt32(lbl_id_banco.Text);
                favorecido.Agencia = txt_agencia.Text;
                favorecido.Conta = txt_conta.Text;
                favorecido.Classificacao = combo_classificacao.Text;

                favorecidoDAO.NovoFavorecido(favorecido);
            }
        }

        private void check_cadastra_favorecido_CheckedChanged(object sender, EventArgs e)
        {
            if (check_cadastra_favorecido.Checked)
            {

                this.Size = new Size(761, 443);
                group_favorecido.Visible = true;
                btn_cadastrar.Location = new Point(627,326);
                CarregaBancos();
            }
            else
            {
                this.Size = new Size(761, 177);
                group_favorecido.Visible = false;
                btn_cadastrar.Location = new Point(627, 106);
            }
        }

        private void CarregaBancos()
        {
            combo_banco.Items.Clear();
            bancos = bancoDAO.ListaBancos();
            for (int i = 0; i < bancos.Count; i++)
            {
                combo_banco.Items.Add(bancos[i].Nome + " - " + bancos[i].Cod);
            }
        }

        private void combo_banco_SelectedIndexChanged(object sender, EventArgs e)
        {
            string banco = combo_banco.Text;

            for (int i = 0; i < bancos.Count; i++)
            {
                if (banco.Contains(bancos[i].Cod.ToString()))
                {
                    lbl_id_banco.Text = bancos[i].Id.ToString();
                }
            }
        }

        private void FormCadastra_fornecedor_Load(object sender, EventArgs e)
        {
            this.Size = new Size(761, 177);
        }
    }
}
