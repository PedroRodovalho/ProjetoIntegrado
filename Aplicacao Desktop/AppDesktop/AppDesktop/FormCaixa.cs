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
    public partial class FormCaixa : Form
    {
        public FormCaixa()
        {
            InitializeComponent();
        }
        Conversor conversor = new Conversor();
        EstoqueDAO estoqueDAO = new EstoqueDAO();
        private void FormCaixa_Load(object sender, EventArgs e)
        {
            
        }

        private void FormCaixa_SizeChanged(object sender, EventArgs e)
        {
            //dataGridView1.Size = new Size(this.Size.Width - 10, dataGridView1.Size.Height);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_cadastrar_cliente_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        
        int count = 0;
        Estoque produto_add = new Estoque();
        private void txt_codigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (count > 0) 
            {
              if(produto_add.Id != 0)
                {
                    adicionaItem(produto_add);
                    count = 0;
                }
                else
                {
                    //abre caixa de procura
                }
               
                
                
            }
            else if (e.KeyCode == Keys.Enter)
            {
                    
                produto_add = estoqueDAO.buscaProdutoByCod(conversor.toInt(txt_codigo.Text));
                if(produto_add.Id != 0)
                {
                    txt_codigo.Text = produto_add.Cod.ToString();
                    txt_produto.Text = produto_add.Produto;
                    lbl_mensagens.Text = "";
                   

                }
                else
                {
                    lbl_mensagens.Text = "PRODUTO NÃO ENCONTRADO!";
                    lbl_mensagens.ForeColor = Color.Red;
                    lbl_mensagens.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
                }
                count++;

            }
        }
        List<Estoque> lista_itens = new List<Estoque>();
        public void adicionaItem(Estoque item)
        {
            
            dataGrid_itens.DataSource = "";
            lista_itens.Add(item);
            dataGrid_itens.DataSource = lista_itens;
        }

        private void txt_codigo_TextChanged(object sender, EventArgs e)
        {
            count = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_relogio.Text = DateTime.Now.ToString();
        }
    }
}
