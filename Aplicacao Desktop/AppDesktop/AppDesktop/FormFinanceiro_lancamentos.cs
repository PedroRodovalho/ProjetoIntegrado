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
    public partial class FormFinanceiro_lancamentos : Form
    {
        public FormFinanceiro_lancamentos()
        {
            InitializeComponent();
        }

        private void FormFinanceiro_lancamentos_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("descrição","Descrição");
            dataGridView1.Columns.Add("valor", "Valor");
            dataGridView1.Columns.Add("tipo", "Tipo");
            dataGridView1.Columns.Add("vencimento", "Vencimento");


        }
    }
}
