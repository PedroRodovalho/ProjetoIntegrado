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
    public partial class FormCliente : Form
    {
        FormConsulta_Cliente formConsulta = null;
        List<Cliente> clientes;
        FormCadastra_cliente formCadastra_Cliente = null;
        Conversor conversor = new Conversor();
        ClienteDAO clienteDAO = new ClienteDAO();
        public FormCliente()
        {
            InitializeComponent();
        }
        private void FormCliente_Load(object sender, EventArgs e)
        {
            clientes = new List<Cliente>();
            clientes = clienteDAO.lista_cliente();
            dataGrid_cliente.DataSource = clientes;
            FormataDataGrid();
        }

        private void FormataDataGrid()
        {
            dataGrid_cliente.Columns["id"].HeaderText = "ID";
            dataGrid_cliente.Columns["nome"].HeaderText = "Nome";
            dataGrid_cliente.Columns["telefone"].HeaderText = "Telefone";
            dataGrid_cliente.Columns["tipo_cliente"].HeaderText = "Tipo Cliente";
            dataGrid_cliente.Columns["cpf"].HeaderText = "CPF/CNPJ";
            dataGrid_cliente.Columns["data_nascimento"].HeaderText = "Data Nascimento";
            dataGrid_cliente.Columns["data_cadastro"].HeaderText = "Data Cadastro";
            dataGrid_cliente.Columns["ativo"].HeaderText = "Ativo";
            dataGrid_cliente.Columns["id"].Width = 60;
            dataGrid_cliente.Columns["nome"].Width = 400;
            dataGrid_cliente.Columns["telefone"].Width = 150;
            dataGrid_cliente.Columns["tipo_cliente"].Width = 190;
            dataGrid_cliente.Columns["cpf"].Width = 120;
            dataGrid_cliente.Columns["data_nascimento"].Width = 120;
            dataGrid_cliente.Columns["data_cadastro"].Width = 120;
            dataGrid_cliente.Columns["ativo"].Width = 100;
           
        }

        private void toolStripButton_add_Click(object sender, EventArgs e)
        {
            formCadastra_Cliente = new FormCadastra_cliente();
            formCadastra_Cliente.ShowDialog();
        }

        

      

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            clientes = clienteDAO.lista_cliente();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            int linha_selecionada = linha;

            dataGrid_cliente.DataSource = clientes;
            if (clientes.Count > 0)
            {
                if (linha_selecionada >= 0)
                {
                    dataGrid_cliente.Rows[linha_selecionada].Selected = true;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy == false)
            {
                backgroundWorker1.RunWorkerAsync();
            }

        }
        int linha = 0;
        private void dataGrid_cliente_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            linha = e.RowIndex;
        }

        
        private void tollStripButton_consultar_Click(object sender, EventArgs e)
        {
            Cliente cliente = null;
            if(linha >= 0)
            {
                int id = conversor.ToInt32(dataGrid_cliente.Rows[linha].Cells["id"].Value.ToString());
               
                cliente = clienteDAO.BuscaClienteId(id);
            }
            
            if(cliente != null) { 
                formConsulta = new FormConsulta_Cliente(cliente);
                formConsulta.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        { 
           
            
        }
    }
}
