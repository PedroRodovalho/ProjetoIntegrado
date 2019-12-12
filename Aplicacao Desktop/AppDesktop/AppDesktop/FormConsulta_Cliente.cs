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
    public partial class FormConsulta_Cliente : Form
    {
        ClienteDAO clienteDAO = new ClienteDAO();
        Conversor conversor = new Conversor();
        Cliente cliente;
        public FormConsulta_Cliente(Cliente cliente)
        {
            this.cliente = cliente;
            InitializeComponent();
        }

        private void FormConsulta_Cliente_Load(object sender, EventArgs e)
        {
            AlimentaCampos();
            
        }

        private void AlimentaCampos()
        {
            txt_id.Text = cliente.Id.ToString();
            txt_cliente.Text = cliente.Nome;
            txt_telefone.Text = cliente.Telefone;
            txt_cpf_cnpj.Text = cliente.Cpf;
            txt_data_cadastro.Text = cliente.Data_cadastro;
            if(cliente.Ativo == 0)
            {
                lbl_cadastro_ativo.Text = "INATIVO";
                btn_inativar.Text = "ATIVAR";
            }
            else
            {
                lbl_cadastro_ativo.Text = "ATIVO";
            }
            comboBox_tipo_cliente.Text = cliente.Tipo_cliente;
            txt_data_nascimento.Text = cliente.Data_nascimento;
            List<HistoricoCliente> historico_cliente = clienteDAO.BuscaHistoricoCliente(cliente.Id);
            if(historico_cliente == null)
            {
                lbl_compras_realizadas.Text = "Nenhuma compra realizada";
            }
            dataGridView1.DataSource = historico_cliente;

            FotoCliente foto = clienteDAO.BuscaFoto(cliente.Id);
            if(foto != null)
            {
                pictureBox_foto.ImageLocation = foto.Caminho_foto;
                
            }
            
            
        }

        private void btn_inativar_Click(object sender, EventArgs e)
        {
            if(cliente.Ativo == 0)
            {
                clienteDAO.AtivaCliente(cliente.Id);
                btn_inativar.Text = "INATIVAR";
            }
            else
            {
                clienteDAO.DesativaCliente(cliente.Id);
                btn_inativar.Text = "ATIVAR";
            }

            cliente = clienteDAO.BuscaClienteId(cliente.Id);
            AlimentaCampos();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            clienteDAO.DeletaCliente(cliente.Id);
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            groupBox_cliente.Enabled = true;
            btn_salvar.Enabled = true;
            txt_id.Enabled = false;

        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            groupBox_cliente.Enabled = false;
            Cliente cliente_upd = new Cliente();

            cliente_upd.Id = conversor.ToInt32(txt_id.Text);
            cliente_upd.Nome = txt_cliente.Text;
            cliente_upd.Telefone = txt_telefone.Text;
            cliente_upd.Cpf = txt_cpf_cnpj.Text;
            cliente_upd.Tipo_cliente = comboBox_tipo_cliente.Text;
            cliente_upd.Data_nascimento = txt_data_nascimento.Text;

            clienteDAO.AtualizaCliente(cliente_upd) ;
            btn_salvar.Enabled = false;
        }
    }
}
