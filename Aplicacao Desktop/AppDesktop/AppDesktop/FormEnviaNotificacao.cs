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
    
    public partial class FormEnviaNotificacao : Form
    {
        UsuarioDAO usuarioDAO = new UsuarioDAO();
        public FormEnviaNotificacao()
        {
            InitializeComponent();
        }

        private void btn_enviar_Click(object sender, EventArgs e)
        {
            Usuario destinatario = usuarioDAO.BuscaUsuario(txt_destinatario.Text);
            
            
            Notificacao notificacao = new Notificacao();
            notificacao.Id_destinatario = destinatario.Id;
            notificacao.Id_remetente = 2;
            notificacao.Assunto = txt_assunto.Text;
            notificacao.Mensagem = txt_mensagem.Text;
            notificacao.Tipo = comboBox_tipo.Text;

            usuarioDAO.EnviaNotificacao(notificacao);

        }
    }
}
