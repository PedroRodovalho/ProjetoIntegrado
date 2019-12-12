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
    public partial class FormFinanceiro_CadastraBanco : Form
    {
        BancoDAO bancoDAO = new BancoDAO();
        Conversor conversor = new Conversor();
        public FormFinanceiro_CadastraBanco()
        {
            InitializeComponent();
        }

        private void FormFinanceiro_CadastraBanco_Load(object sender, EventArgs e)
        {

        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            Banco banco = new Banco();
            banco.Nome = txt_banco.Text;
            banco.Cod = conversor.ToInt32(txt_cod.Text);
            bancoDAO.NovoBanco(banco);
        }
    }
}
