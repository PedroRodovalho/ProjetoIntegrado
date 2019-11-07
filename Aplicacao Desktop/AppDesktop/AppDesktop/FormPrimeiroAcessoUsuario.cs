using AppDesktop.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDesktop
{
    public partial class FormPrimeiroAcessoUsuario : Form
    {
        Usuario usuario;
        public FormPrimeiroAcessoUsuario(Usuario usuario)
        {
            this.usuario = usuario;
            InitializeComponent();
        }
        string remetente;
        string mensagem;
        string assunto;
        string nome;
        string email;
        string chave_confirmacao = "";
        bool enviado;
        private void btn_enviar_Click(object sender, EventArgs e)
        {
            bool validado = ValidaCampos();
            if (validado)
            {
                email = txt_email.Text;
                nome = txt_nome.Text;

                chave_confirmacao = GerarChaveConfirmacao();


                remetente = "BEAT System";
                mensagem = "Olá, bem-vindo ao sistema BEAT, para confirmar sua conta informe o codigo: " + chave_confirmacao + "no sistema.";
                assunto = "Confirmação de Endereço de Email";

                backgroundWorker_EnviaEmail.RunWorkerAsync();
                lbl_mensagem.Text = "● Enviando chave de confirmação para " + email + ".";
                lbl_mensagem.ForeColor = Color.Blue;


            }
        }

        private string GerarChaveConfirmacao()
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvxyz0123456789";
            var random = new Random();
            var result = new string(
                Enumerable.Repeat(chars, 8)
                          .Select(s => s[random.Next(s.Length)])
                          .ToArray());
            return result;
        }

        public bool ValidaCampos()
        {
            bool validado = true;
            lbl_mensagem.Text = "";
            lbl_mensagem.ForeColor = Color.Red;
            lbl_mensagem.Visible = true;
            if (txt_nome.Text.Equals(""))
            {
                lbl_mensagem.Text = "● O campo nome não pode estar em branco.\n";
                validado = false;
            }
            if (txt_email.Text.Equals(""))
            {
                lbl_mensagem.Text = lbl_mensagem.Text + "● O campo e-mail não pode estar em branco.";
                validado = false;
            }

            return validado ;
        }

        private void backgroundWorker_EnviaEmail_DoWork(object sender, DoWorkEventArgs e)
        {
            EnviarEmail enviaEmail = new EnviarEmail();
            enviado = enviaEmail.Envia(remetente, email, mensagem, assunto);
            
        }

        public void ProximaPag()
        {
            groupBox_Finalizacao.Visible = true;

        }

        private void backgroundWorker_EnviaEmail_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void backgroundWorker_EnviaEmail_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (enviado)
            {
                lbl_mensagem.Text = "● E-Mail enviado com sucesso!";

                ProximaPag();
            }
        }

        private void btn_finalizar_Click(object sender, EventArgs e)
        {
            bool confirmado = ConfirmarChave();
            if (confirmado)
            {
                groupBox_mensagem.Location = new Point(15, 62);
                groupBox1.Visible = false;
                groupBox_Finalizacao.Visible = false;
                btn_cancelar.Visible = false;
                btn_enviar.Visible = false;
                label7.Visible = false;
                btn_concluir.Visible = true;
            }
        }

        public bool ConfirmarChave()
        {
            if (txt_chave.Text.Equals(chave_confirmacao))
            {
                lbl_mensagem.ForeColor = Color.Green;
                lbl_mensagem.Text = "● Chave de confirmação validada com sucesso!";
                usuario.Email = email;
                return true;
            }
            else
            {
                lbl_mensagem.Text = "● Chave de confirmação invalida.";
                lbl_mensagem.ForeColor = Color.Red;
                return false;
            }
        }

        private void FormPrimeiroAcessoUsuario_Load(object sender, EventArgs e)
        {
            GraphicsPath PastaGrafica = new GraphicsPath();
            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(1, 1, this.Size.Width, this.Size.Height));
            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(this.Width - 12, 1, 12, 13));
            PastaGrafica.AddPie(this.Width - 24, 1, 24, 26, 270, 90);
            PastaGrafica.SetMarkers();
            this.Region = new Region(PastaGrafica);
        }

        
        private void lbl_fechar_MouseEnter(object sender, EventArgs e)
        {
            lbl_fechar.ForeColor = Color.DarkRed;
        }

        private void lbl_fechar_MouseLeave(object sender, EventArgs e)
        {
            lbl_fechar.ForeColor = Color.White;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath PastaGrafica = new GraphicsPath();
            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(1, 1, panel1.Size.Width, panel1.Size.Height));
            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(panel1.Width - 12, 1, 12, 13));
            PastaGrafica.AddPie(panel1.Width - 24, 1, 24, 26, 270, 90);
            PastaGrafica.SetMarkers();
            panel1.Region = new Region(PastaGrafica);
        }

        private void lbl_fechar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btn_concluir_Click(object sender, EventArgs e)
        {
            new UsuarioDAO().AtualizaEmailUsuario(usuario);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
