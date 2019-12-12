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
    public partial class FormCriaUsuario : Form
    {   
        private UsuarioDAO usuarioDAO = new UsuarioDAO();
        public FormCriaUsuario()
        {
            InitializeComponent();
        }

        private void btn_criar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.Login = txt_login.Text;
            usuario.Senha = txt_senha.Text;
            usuario.Ativo = 1;
            usuario.Nome = txt_nome.Text;
            usuario.Email = txt_email.Text;
            usuario.Cargo = txt_cargo.Text;

            usuarioDAO.CriaLogin(usuario);
               
        }
    }
}
