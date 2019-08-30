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
    public partial class FormCadastra_cliente : Form
    {
        public FormCadastra_cliente()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        public void limparCampos()
        {
            txt_nome.Text = "";
            txt_cpf_cnpj.Text = "";
            txt_telefone.Text = "";
            txt_data_nascimento.Text = "";
            txt_rua.Text = "";
            txt_numero.Text = "";
            txt_bairro.Text = "";
            txt_cep.Text = "";
            txt_cidade.Text = "";
            combo_uf.Text = "";
        }
        ClienteDAO clienteDAO = new ClienteDAO();
        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Nome = txt_nome.Text;
            cliente.Telefone = txt_telefone.Text;
            if (radioButton1.Checked)
            {
                cliente.Tipo_cliente = "Pessoa Fisica";
            }
            else
            {
                cliente.Tipo_cliente = "Pessoa Juridica";
            }
            if (radioButton1.Checked)
            {
                cliente.Cpf = txt_cpf.Text;
            }
            else
            {
                cliente.Cpf = txt_cnpj.Text;
            }

            cliente.Data_nascimento = txt_data_nascimento.Text;

            clienteDAO.insere_cliente(cliente);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                lbl_pessoa.Text = "CPF";
                txt_cpf.Visible = true;
                txt_cnpj.Visible = false;
            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                lbl_pessoa.Text = "CNPJ";
                txt_cpf.Visible = false;
                txt_cnpj.Visible = true;
            }
        }
    }
}
