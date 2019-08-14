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
    public partial class FormLogin : Form
    {
        Boolean conectado = false;
      
        public FormLogin()
        {
            InitializeComponent();
            
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            Config config_banco = new Config();
            string con = config_banco.getConexao();
            
            conectado = config_banco.verificaConexao();

            if (conectado)
            {
                toolStripStatusLabel1.Text = "CONECTADO";
                toolStripStatusLabel1.ForeColor = Color.Green;
            }
            else
            {
                toolStripStatusLabel1.Text = "DESCONECTADO";
                toolStripStatusLabel1.ForeColor = Color.Red;
            }
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            if (conectado)
            {
                Usuario user = new Usuario();

                user.Login = txt_usuario.Text;
                user.Senha = txt_senha.Text;

                UsuarioDAO userDAO = new UsuarioDAO();
                user = userDAO.validaLogin(user);
                try
                {
                    if(user == null || user.Equals(null) || user.Equals("null")){
                        MessageBox.Show("Usuario ou senha incorreto!");
                    }
                    else
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
                catch (Exception ex) {
                }

            }
            else
            {
                MessageBox.Show("Falha de conexão");
            }


           
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
