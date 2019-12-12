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
    public partial class FormMensagemAguarde : Form
    {
        string mensagem;
        public FormMensagemAguarde(string mensagem)
        {
            this.mensagem = mensagem;
            
            InitializeComponent();
        }

        private void FormMensagemAguarde_Load(object sender, EventArgs e)
        {
            label1.Text = mensagem;
        }

        private void FormMensagemAguarde_Paint(object sender, PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle,
                                                              Color.DarkCyan,
                                                              Color.Cyan,
                                                              90F))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }

        public void AtualizaMensagemTopo(string msg) 
        {
            label1.Text = msg;
        }

        public void AtualizaMensagemBot(string msg)
        {
            label2.Text = msg;
        }
    }
}
