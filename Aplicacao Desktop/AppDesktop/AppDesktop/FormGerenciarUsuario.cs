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
    public partial class FormGerenciarUsuario : Form
    {
        private UsuarioDAO usuarioDAO = new UsuarioDAO();
        private Usuario usuario;
        private List<PerfilAcesso> perfilAcessos = new List<PerfilAcesso>();
        private List<PerfilAcessoUsuario> perfilAcessosUsuario = new List<PerfilAcessoUsuario>();
        //DECLARAÇÃO DE FORMULARIOS
        FormCriaUsuario formCriaUsuario = null;
        FormEnviaNotificacao formEnviaNotificacao = null;

        public FormGerenciarUsuario()
        {
            InitializeComponent();
        }
        private void FormGerenciarUsuario_Load(object sender, EventArgs e)
        {
            perfilAcessos = usuarioDAO.ListaPerfisAcesso();
            for (int i = 0; i < perfilAcessos.Count; i++)
            {
                comboBox_perfil.Items.Add(perfilAcessos[i].NomeAcesso);
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formCriaUsuario = new FormCriaUsuario();
            formCriaUsuario.Dispose();
        }
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            string login = txt_login.Text;
            string nome = txt_nome_completo.Text;
            if (!login.Equals(""))
            {

                usuario = usuarioDAO.BuscaUsuario(login);
                perfilAcessosUsuario = usuarioDAO.BuscaPerfilAcessoUsuario(usuario.Id);
                AlimentaCamposUsuario();
            }
            else
            {
                List<Usuario> usuarios = usuarioDAO.BuscaUsuarioLikeNome(nome);
            }
        }

        private void AlimentaCamposUsuario()
        {
            try
            {
                txt_login.Text = usuario.Login;
                txt_nome_completo.Text = usuario.Nome;
                txt_cargo.Text = usuario.Cargo;
                txt_email.Text = usuario.Email;
                if (usuario.Ativo == 1)
                {
                    lbl_status_usuario.Text = "ATIVO";
                    lbl_status_usuario.ForeColor = Color.Green;
                }
                else
                {
                    lbl_status_usuario.Text = "INATIVO";
                    lbl_status_usuario.ForeColor = Color.Red;
                }
                dataGridView1.DataSource = perfilAcessosUsuario;
            }
            catch
            {
                lbl_resultado.Text = "NENHUM USUÁRIO ENCONTRADO";
                lbl_resultado.ForeColor = Color.Red;
                lbl_resultado.Visible = true;
            }

        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            string perfil = comboBox_perfil.Text;
            int posicao = comboBox_perfil.SelectedIndex;
            int id = perfilAcessos[posicao].Id;
            MessageBox.Show(id.ToString());

            string status = comboBox_status.Text;
            usuarioDAO.InserePerfilAcesso(id, usuario.Id,status);



        }

        private void notificar_btn_Click(object sender, EventArgs e)
        {
            formEnviaNotificacao = new FormEnviaNotificacao();
            formEnviaNotificacao.Show();
        }

        private void toolStripButton_deletar_Click(object sender, EventArgs e)
        {
            usuarioDAO.DeletaUsuario(usuario.Id);

        }

        private void toolStripButton_bloquear_Click(object sender, EventArgs e)
        {
            usuarioDAO.BloqueiaUsuario(usuario.Id);
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            btn_save.Enabled = true;
            btn_buscar.Enabled = false;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string nome, email, senha, login, cargo;
            login = txt_login.Text;
            senha = txt_senha.Text;
            nome = txt_nome_completo.Text;
            email = txt_email.Text;
            cargo = txt_cargo.Text;

            Usuario usuario_upd = new Usuario();
            usuario_upd.Id = usuario.Id;
            usuario_upd.Login = login;
            usuario_upd.Nome = nome;
            usuario_upd.Senha = senha;
            usuario_upd.Email = email;
            usuario_upd.Cargo = cargo;

            usuarioDAO.AtualizaUsuario(usuario_upd);

        }
    }
}
