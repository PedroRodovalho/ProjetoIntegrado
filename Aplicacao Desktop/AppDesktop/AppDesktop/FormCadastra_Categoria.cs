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
    public partial class FormCadastra_Categoria : Form
    {
        public FormCadastra_Categoria()
        {
            InitializeComponent();
        }
        EstoqueDAO estoqueDAO = new EstoqueDAO();


        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            estoqueDAO.CadastraCategoria(txt_categoria.Text);
            this.Close();
        }
    }
}
