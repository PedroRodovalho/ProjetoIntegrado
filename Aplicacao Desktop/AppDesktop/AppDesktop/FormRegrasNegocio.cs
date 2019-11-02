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
    public partial class FormRegrasNegocio : Form
    {
        RegrasNegocioDAO regrasDAO = new RegrasNegocioDAO();
        Conversor conversor = new Conversor();
        public FormRegrasNegocio()
        {
            InitializeComponent();
        }

        private void radio_acrescimo_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_acrescimo.Checked)
            {
                group_acrescimo.Visible = true;
                group_desconto.Visible = false;
            }



        }

        private void radio_desconto_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_desconto.Checked)
            {
                group_desconto.Visible = true;
                group_acrescimo.Visible = false;
            }
        }

        private void btn_criar_regra_Click(object sender, EventArgs e)
        {



            RegrasNegocio regraNegocio = new RegrasNegocio();
            regraNegocio.Nome = txt_descricao.Text;

            regraNegocio.Tipo_venda = combo_tipo_venda.Text;
            regraNegocio.Parcela_min = conversor.ToInt32(combo_iparcelas.Text);
            regraNegocio.Parcela_max = conversor.ToInt32(combo_fparcelas.Text);
            int id_regra;
            if (radio_acrescimo.Checked)
            {
                regraNegocio.Tipo = "ACRÉSCIMO";
                id_regra = regrasDAO.CriaRegraNegocio(regraNegocio);
                regra_acrescimo(id_regra);
            }
            else
            {
                regraNegocio.Tipo = "DESCONTO";
                id_regra = regrasDAO.CriaRegraNegocio(regraNegocio);
                regra_desconto();
            }
        }

        public void regra_acrescimo(int id)
        {
            if (id == 0)
            {
                MessageBox.Show("Não foi possivel concluir a criação da regra");
            }
            else
            {
                RegrasNegocio_acrescimo regrasNegocio_Acrescimo = new RegrasNegocio_acrescimo();
                regrasNegocio_Acrescimo.Id_regra = id;
                regrasNegocio_Acrescimo.Acrescimo_parcela = conversor.toDouble(txt_acrescimo.Text);
                regrasNegocio_Acrescimo.Por_parcela = false;
                if (check_por_parcela.Checked) regrasNegocio_Acrescimo.Por_parcela = true;

                regrasDAO.insere_regra_acrescimo(regrasNegocio_Acrescimo);
            }

        }

        public void regra_desconto()
        {
            if (desconto_produto.Checked)
            {

                Regra regra = new Regra();
                regra.Condicao = combo_valor.Text;
                regra.Desconto = conversor.toDouble(txt_desconto_produto.Text);
                regra.Parametro = conversor.toDouble(txt_valor.Text);
                regra.Atribuicao = "AplicaRegraValorProduto";
                

                regrasDAO.InsereRegra(regra);

            }
            if (desconto_venda.Checked)
            {
                Regra regra = new Regra();

                
                regra.Condicao = combo_total_venda.Text;
                regra.Parametro = conversor.toDouble(txt_total_venda.Text);
                regra.Desconto = conversor.toDouble(txt_desconto_total.Text);
                regra.Atribuicao = "AplicaRegraValorTotal";
                
                regrasDAO.InsereRegra(regra);
            }
            if (desconto_quantidade.Checked)
            {
                Regra regra = new Regra();
                
                regra.Condicao = combo_quantidade_produto.Text;
                regra.Parametro = conversor.ToInt32(txt_quantidade_produto.Text);
                regra.Desconto = conversor.toDouble(txt_desconto_quantidade.Text);
                regra.Atribuicao = "AplicaRegraQuantidade";
                
                regrasDAO.InsereRegra(regra);
            }


        }

        private void FormRegrasNegocio_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           

           // RegraDeNegocioController controller = new RegraDeNegocioController();

        }
    }

}
