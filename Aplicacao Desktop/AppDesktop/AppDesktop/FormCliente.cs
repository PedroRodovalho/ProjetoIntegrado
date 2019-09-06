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
        public FormCliente()
        {
            InitializeComponent();
        }

        private void toolStripButton_add_Click(object sender, EventArgs e)
        {
            FormCadastra_cliente formCadastra_Cliente = new FormCadastra_cliente();
            formCadastra_Cliente.ShowDialog();
        }

        ClienteDAO clienteDAO = new ClienteDAO();

        private void FormCliente_Load(object sender, EventArgs e)
        {
            List<Cliente> clientes = new List<Cliente>();
            clientes = clienteDAO.lista_cliente();
            dataGrid_cliente.DataSource = clientes;
        }
    }
}
