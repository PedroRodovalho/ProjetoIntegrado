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
    public partial class FormFinanceiro : Form
    {
        public FormFinanceiro()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        FormFinanceiro_pagamentos formPagamentos = null;
        FormFinanceiro_recebidos formRecebidos = null;
        FormFinanceiro_lancamentos formLancamentos = null;
        private void btn_contas_pagar_Click(object sender, EventArgs e)
        {
            formPagamentos = new FormFinanceiro_pagamentos();
            formPagamentos.TopLevel = false;
            panel1.Controls.Add(formPagamentos);
            formPagamentos.Visible = true;
        }

        private void btn_contas_receber_Click(object sender, EventArgs e)
        {
            formRecebidos = new FormFinanceiro_recebidos();
            formRecebidos.TopLevel = false;
            panel1.Controls.Add(formRecebidos);
            formRecebidos.Visible = true;
        }

        private void btn_lancamentos_Click(object sender, EventArgs e)
        {
            formLancamentos = new FormFinanceiro_lancamentos();
            formLancamentos.TopLevel = false;
            panel1.Controls.Add(formLancamentos);
            formLancamentos.Visible = true;
        }
    }
}
