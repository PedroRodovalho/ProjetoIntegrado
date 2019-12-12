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
    public partial class FormFinanceiro_BuscaFavorecido : Form
    {

        private FavorecidoDAO favorecidoDAO = new FavorecidoDAO();
        List<Favorecido> favorecidos;
        Conversor conversor = new Conversor();
        FormFinanceiro_pagamentos contexto;
        int operacao;
        public FormFinanceiro_BuscaFavorecido(FormFinanceiro_pagamentos contexto,int operacao)
        {
            this.contexto = contexto;
            this.operacao = operacao;
            
            InitializeComponent();
        }
        private void FormFinanceiro_BuscaFavorecido_Load(object sender, EventArgs e)
        {
            if(operacao == 0)
            {
                this.Text = "BUSCAR FAVORECIDO";
            }
            else
            {
                this.Text = "BUSCAR DEVEDOR";
            }

            favorecidos = favorecidoDAO.ListaFavorecido();
            if (favorecidos == null)
            {
                txt_nome.Enabled = false;
                MessageBox.Show("Não há nenhum favorecido cadastrado");
            }
            else
            {
                dataGridView1.DataSource = favorecidos;
            }
            
        }
        private void txt_nome_TextChanged(object sender, EventArgs e)
        {
            
            List<Favorecido> favorecidos_filtrado = favorecidos.Where(f => f.Nome.ToUpper()
                .Contains(txt_nome.Text.ToUpper())).ToList<Favorecido>();
            dataGridView1.DataSource = favorecidos_filtrado;
        }

        private void btn_selecionar_Click(object sender, EventArgs e)
        {
            int id = conversor.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            string nome = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            string cpf_cnpj = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            int id_banco = conversor.ToInt32(dataGridView1.CurrentRow.Cells[3].Value.ToString());
            string agencia = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            string conta = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            string classificacao = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            if(operacao == 0)
            {
                contexto.favorecido.Id = id;
                contexto.favorecido.Nome = nome;
                contexto.favorecido.Cpf_cpnj = cpf_cnpj;
                contexto.favorecido.Id_banco = id_banco;
                contexto.favorecido.Agencia = agencia;
                contexto.favorecido.Conta = conta;
                contexto.favorecido.Classificacao = classificacao;
            }
            else
            {
                contexto.devedor.Id = id;
                contexto.devedor.Nome = nome;
                contexto.devedor.Cpf_cpnj = cpf_cnpj;
                contexto.devedor.Id_banco = id_banco;
                contexto.devedor.Agencia = agencia;
                contexto.devedor.Conta = conta;
                contexto.devedor.Classificacao = classificacao;
            }
            
            this.DialogResult = DialogResult.OK;
            
        }

    
    }
}
