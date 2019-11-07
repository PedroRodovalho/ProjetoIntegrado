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
    public partial class FormAba : Form
    {
       
        string aba;
        FormHome contexto;
        Point localizacao;
        int posicao;
        public FormAba(FormHome contexto, string aba, Point localizacao, int posicao)
        {
            this.contexto = contexto;
            this.aba = aba;
            this.localizacao = localizacao;
            this.posicao = posicao;
            InitializeComponent();


        }

        private void FormAba_Load(object sender, EventArgs e)
        {
            ArredondaCantosDoForm();
            this.Location = localizacao;
            aba = aba.ToUpper();
            lbl_aba.Text = aba;

        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            contexto.FechaAba(aba);
        }

        private void FormAba_Paint(object sender, PaintEventArgs e)
        {
        }
        public void ArredondaCantosDoForm()
        {
            GraphicsPath PastaGrafica = new GraphicsPath();
            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(1, 1, this.Size.Width, this.Size.Height));

            //Arredondar canto superior esquerdo        
            // PastaGrafica.AddRectangle(new System.Drawing.Rectangle(1, 1, 10, 10));
            // PastaGrafica.AddPie(1, 1, 20, 20, 180, 90);

            //Arredondar canto superior direito
            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(this.Width - 12, 1, 12, 13));
            PastaGrafica.AddPie(this.Width - 24, 1, 24, 26, 270, 90);

            //Arredondar canto inferior esquerdo
            //  PastaGrafica.AddRectangle(new System.Drawing.Rectangle(1, this.Height - 10, 10, 10));
            // PastaGrafica.AddPie(1, this.Height - 20, 20, 20, 90, 90);

            //Arredondar canto inferior direito
            //PastaGrafica.AddRectangle(new System.Drawing.Rectangle(this.Width - 12, this.Height - 13, 13, 13));
            // PastaGrafica.AddPie(this.Width - 24, this.Height - 26, 24, 26, 0, 90);

            PastaGrafica.SetMarkers();
            this.Region = new Region(PastaGrafica);
        }
        public void SelecionaAba()
        {
            
        }
    }

}
