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
    public partial class FormLogin_Financeiro : Form
    {
        UsuarioDAO usuarioDAO = new UsuarioDAO();
        FinanceiroDAO financeiroDAO = new FinanceiroDAO();
        public FormLogin_Financeiro()
        {
            InitializeComponent();
        }

        private void lbl_close_MouseEnter(object sender, EventArgs e)
        {
            lbl_close.ForeColor = Color.Red;
        }

        private void lbl_close_MouseLeave(object sender, EventArgs e)
        {
            lbl_close.ForeColor = Color.White;
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            AutenticacaoLogin();
        }

        private void AutenticacaoLogin()
        {
            string login, senha;
            login = txt_login.Text;
            senha = txt_senha.Text;

            Usuario usuario = new Usuario();
            usuario.Login = login;
            usuario.Senha = senha;

            Usuario user_autenticado = usuarioDAO.validaLogin(usuario);
            if(user_autenticado != null) {
                if (financeiroDAO.AutenticaPermissao(user_autenticado.Id))
                {
                    IniciaFinanceiro(user_autenticado);
                }
                else
                {
                    MessageBox.Show("Você não tem permissões suficiente para acessar o SCF");
                }
            }
            else
            {
                MessageBox.Show("Usuario/Senha inválidos!");
            }
        }

        private void IniciaFinanceiro(Usuario usuario)
        {
            FormFinanceiro formFinanceiro = new FormFinanceiro(usuario);
            formFinanceiro.Show();
            this.Close();
        }
    }
}
