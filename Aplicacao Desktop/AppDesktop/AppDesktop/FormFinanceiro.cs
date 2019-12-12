using AppDesktop.DAO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDesktop
{
    public partial class FormFinanceiro : Form
    {
        //DECLARAO DAO
        VendaDAO vendaDAO = new VendaDAO();
        FinanceiroDAO financeiroDAO = new FinanceiroDAO();
        UsuarioDAO usuarioDAO = new UsuarioDAO();
       
        ////
        
        Conversor conversor = new Conversor();
        HotKeys_Financeiro hotKeys;
        bool atalho = false;
        Usuario usuario;
        Perfil perfil;

        ////
        //DECLARAÇÃO DE FORMULARIOS;
        private FormMensagemAguarde formMensagem = null;
        private FormFinanceiro_pagamentos formPagamentos = null;
        private FormFinanceiro_recebidos formRecebidos = null;
        private FormFinanceiro_lancamentos formLancamentos = null;
        private FormFinanceiro_CadastraFavorecido formFinanceiro_CadastraFavorecido = null;
        private FormFinanceiro_lancamentos formFinanceiro_Lancamentos = null;
        private FormMensagemAguarde formMensagemAguarde = null;
        private FormFinanceiro_pagamentos formFinanceiro_Pagamentos = null;
        private FormFinanceiro_CadastraBanco formFinanceiro_CadastraBanco = null;
        //DECLARACAO DE VARIAVEIS
        double sum_venda, sum_receber, sum_pagar, sum_atrasada;
        List<Venda> vendas;
        private MySqlDataReader result_contas_pagar_hoje;
        private MySqlDataReader result_contas_receber_hoje;
        private MySqlDataReader result_contas_vencidas;
        private MySqlDataReader result_set_contas = null;
        private MySqlDataReader result_pesquisa = null;

        //private const int CS_DROPSHADOW = 0x00020000;

        public FormFinanceiro(Usuario usuario)
        {
            this.usuario = usuario;
            InitializeComponent();
        }
        private void FormFinanceiro_Load(object sender, EventArgs e)
        {
            
            hotKeys = new HotKeys_Financeiro(this);
            formMensagem = new FormMensagemAguarde("CARREGANDO SCF!");
            formMensagem.Show();
            backgroundWorker_Inicializa.RunWorkerAsync();
            FormataDataGrid();
        }

        private void FormataDataGrid()
        {
            dataGridView1.Columns.Add("id", "ID");
            dataGridView1.Columns.Add("cod", "CODIGO");
            dataGridView1.Columns.Add("forma_pagamento", "FORMA PAGAMENTO");
            dataGridView1.Columns.Add("id_favorecido", "ID FAVORECIDO");
            dataGridView1.Columns.Add("id_devedor", "ID DEVEDOR");
            dataGridView1.Columns.Add("favorecido", "FAVORECIDO");
            dataGridView1.Columns.Add("devedor", "DEVEDOR");

            dataGridView1.Columns.Add("valor", "VALOR");
            dataGridView1.Columns.Add("data_criacao", "DATA CRIAÇÃO");
            dataGridView1.Columns.Add("hora_criacao", "HORA CRIAÇÃO");
            dataGridView1.Columns.Add("data_vencimento", "VENCIMENTO");

            dataGridView1.Columns.Add("tipo", "TIPO");
            dataGridView1.Columns.Add("sub_tipo", "SUB TIPO");
            dataGridView1.Columns.Add("descricao", "DESCRIÇÃO");
            dataGridView1.Columns.Add("tipo_debito", "TIPO DEBITO");
            dataGridView1.Columns.Add("status", "STATUS");
        }
        private void AlimentaGridView(MySqlDataReader result_pesquisa)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            if (result_pesquisa != null)
            {
                
                while (result_pesquisa.Read())
                {
                    dataGridView1.Rows.Add(result_pesquisa.GetInt32("id"),
                        result_pesquisa.GetInt32("cod"),
                        result_pesquisa.GetString("forma_pagamento"),
                        result_pesquisa.GetInt32("id_favorecido"),
                        result_pesquisa.GetInt32("id_devedor"),
                        result_pesquisa.GetString("favorecido"),
                        result_pesquisa.GetString("devedor"),
                        result_pesquisa.GetDouble("valor").ToString("0.00"),
                        conversor.toDateTimeBR(result_pesquisa.GetMySqlDateTime("data_criacao")),
                        result_pesquisa.GetString("hora_criacao"),
                        conversor.toDateTimeBR(result_pesquisa.GetMySqlDateTime("data_vencimento")),
                        result_pesquisa.GetString("tipo"),
                        result_pesquisa.GetString("sub_tipo"),
                        result_pesquisa.GetString("descricao"),
                        result_pesquisa.GetString("tipo_debito"),
                        result_pesquisa.GetString("status"));
                }

               // financeiroDAO.Desconecta();
                ConfiguraExibição();
            }

            
        }

        private void ConfiguraExibição()
        {
            if (!checkBox_id.Checked)
            {
                dataGridView1.Columns["id"].Visible = false;
            }
            if (!checkBox_codigo.Checked)
            {
                dataGridView1.Columns["cod"].Visible = false;
            }
            if (!checkBox_id_fav.Checked)
            {
                dataGridView1.Columns["id_fav"].Visible = false;
            }
            if (!checkBox_id_dev.Checked)
            {
                dataGridView1.Columns["id_devedor"].Visible = false;
            }
            if (!checkBox_favorecido.Checked)
            {
                dataGridView1.Columns["favorecido"].Visible = false;
            }
            if (!checkBox_devedor.Checked)
            {
                dataGridView1.Columns["devedor"].Visible = false;
            }
            if (!checkBox_valor.Checked)
            {
                dataGridView1.Columns["valor"].Visible = false;
            }
            if (!checkBox_data_criacao.Checked)
            {
                dataGridView1.Columns["data_criacao"].Visible = false;
            }
            if (!checkBox_hora_criacao.Checked)
            {
                dataGridView1.Columns["hora_criacao"].Visible = false;
            }
            if (!checkBox_vencimento.Checked)
            {
                dataGridView1.Columns["data_vencimento"].Visible = false;
            }
            if (!checkBox_tipo.Checked)
            {
                dataGridView1.Columns["tipo"].Visible = false;
            }
            if (!checkBox_subtipo.Checked)
            {
                dataGridView1.Columns["sub_tipo"].Visible = false;
            }
            if (!checkBox_forma_pagamento.Checked)
            {
                dataGridView1.Columns["forma_pagamento"].Visible = false;
            }
            if (!checkBox_descricao.Checked)
            {
                dataGridView1.Columns["descricao"].Visible = false;
            }
            if (!checkBox_descricao.Checked)
            {
                dataGridView1.Columns["descricao"].Visible = false;
            }
            if (!checkBox_tipo_debito.Checked)
            {
                dataGridView1.Columns["tipo_debito"].Visible = false;
            }
        }


        //EVENTOS CLICKS//
        private void btn_contas_pagar_Click(object sender, EventArgs e)
        {
            formPagamentos = new FormFinanceiro_pagamentos();
            formPagamentos.Show();
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

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            panel_notificacao.Visible = false;
            panel5.Visible = false;
            panel_para_hoje.Visible = false;
            string pesquisa = txt_pesquisa.Text;
            pesquisa = pesquisa.ToLower();
            panel_data_grid.Visible = true;
            if (pesquisa.Contains("realizad") || pesquisa.Contains("pagas"))
            {
                // contas_pesquisa = financeiroDAO.ListarContasPagas();
                //AlimentaGridView(result_pesquisa);
            }
            else if (pesquisa.Contains("venci") || pesquisa.Contains("atrasada"))
            {
                // contas_pesquisa = financeiroDAO.ListarContasAtrasadas();
                //AlimentaGridView(result_pesquisa);
            }
            else if (pesquisa.Contains("recebe"))
            {
                ///contas_pesquisa = financeiroDAO.ListarContasReceber();//AlimentaGridView(result_pesquisa);
            }
            else
            {
                try
                {
                    //contas_pesquisa = financeiroDAO.ListarContasLikeCod(conversor.ToInt32(pesquisa));
                    //AlimentaGridView(result_pesquisa);
                }
                catch
                {

                }

                try
                {

                    result_pesquisa = financeiroDAO.ListarContasLikeFavorecidoDevedor(pesquisa);
                    AlimentaGridView(result_pesquisa);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btn_listar_todos_Click(object sender, EventArgs e)
        {
            lbl_resultado_pesquisa.Text = "Todas as contas";
            result_set_contas = financeiroDAO.ListarContasResultSet();
            AlimentaGridView(result_set_contas);
            // dataGridView1.DataSource = contas;
            panel_data_grid.Visible = true;
            panel_notificacao.Visible = false;
            panel5.Visible = false;
            panel_para_hoje.Visible = false;
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                if (dataGridView1.Rows[i].Cells["status"].Value.Equals("A REALIZAR"))
                {

                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Khaki;

                }
                else if (dataGridView1.Rows[i].Cells["status"].Value.Equals("PAGAMENTO EFETUADO"))
                {

                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.PaleGreen;

                }
                else if (dataGridView1.Rows[i].Cells["status"].Value.Equals("VENCIDO"))
                {

                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                }
                else if (dataGridView1.Rows[i].Cells["status"].Value.Equals("RECEBER"))
                {

                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Blue;
                }

            }
        }

     

        private void lbl_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbl_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lbl_fechar_datagrid_Click(object sender, EventArgs e)
        {
            panel_data_grid.Visible = false;

        }
        private void link_op_visualizacao_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (panel_visualizacao.Visible)
            {
                panel_visualizacao.Visible = false;
            }
            else panel_visualizacao.Visible = true;
        }

        private void picture_favorecidos_Click(object sender, EventArgs e)
        {
            if (!Application.OpenForms.OfType<FormFinanceiro_CadastraFavorecido>().Any())
            {
                formFinanceiro_CadastraFavorecido = new FormFinanceiro_CadastraFavorecido();
                formFinanceiro_CadastraFavorecido.Show();
            }

        }

        private void picture_lancamentos_Click(object sender, EventArgs e)
        {
            if (!Application.OpenForms.OfType<FormFinanceiro_lancamentos>().Any())
            {
                formFinanceiro_Lancamentos = new FormFinanceiro_lancamentos();
                formFinanceiro_Lancamentos.Show();
            }
        }

        private void picture_instituicao_Click(object sender, EventArgs e)
        {
            if (!Application.OpenForms.OfType<FormFinanceiro_CadastraBanco>().Any())
            {
                formFinanceiro_CadastraBanco = new FormFinanceiro_CadastraBanco();
                formFinanceiro_CadastraBanco.Show();
            }
        }

        private void picture_conta_Click(object sender, EventArgs e)
        {
            formMensagemAguarde = new FormMensagemAguarde("CARREGANDO SOLICITACAO");
            formMensagemAguarde.Show();
            backgroundWorker_AbreContas.RunWorkerAsync();
        }

        private void panel_vendas_hoje_Click(object sender, EventArgs e)
        {
            panel_data_grid.Visible = true;
            dataGridView1.DataSource = vendas;
            lbl_resultado_pesquisa.Text = "VENDAS DE HOJE";
            panel_notificacao.Visible = false;
            panel5.Visible = false;
            panel_para_hoje.Visible = false;
        }
        private void panel_receber_hoje_Click(object sender, EventArgs e)
        {
            panel_data_grid.Visible = true;
            AlimentaGridView(result_contas_receber_hoje);
            lbl_resultado_pesquisa.Text = "CONTAS A RECEBER DE HOJE";
            panel_notificacao.Visible = false;
            panel5.Visible = false;
            panel_para_hoje.Visible = false;
        }
        private void panel_contas_atrasadas_Click(object sender, EventArgs e)
        {
            panel_data_grid.Visible = true;
            AlimentaGridView(result_contas_receber_hoje);
            lbl_resultado_pesquisa.Text = "CONTAS ATRASADAS";
            panel_notificacao.Visible = false;
            panel5.Visible = false;
            panel_para_hoje.Visible = false;
        }
        private void panel_pagar_hoje_Click(object sender, EventArgs e)
        {
            panel_data_grid.Visible = true;
            AlimentaGridView(result_contas_pagar_hoje);

            lbl_resultado_pesquisa.Text = "CONTAS DE HOJE";
            panel_notificacao.Visible = false;
            panel5.Visible = false;
            panel_para_hoje.Visible = false;
        }
        
        
        //////////////////////////EXECUÇÕES EM SEGUNDO PLANO///////////////////////////////////////////////////////;;

        private void backgroundWorker_Inicializa_DoWork(object sender, DoWorkEventArgs e)
        {
            backgroundWorker_Inicializa.ReportProgress(1, "CONECTANDO AO BANCO - Buscando perfil");
            perfil = usuarioDAO.BuscaPerfil(usuario);

            backgroundWorker_Inicializa.ReportProgress(5, "CARREGANDO DADOS DE VENDAS");
            sum_venda = vendaDAO.SomaVendaFinalByData(DateTime.Today.ToShortDateString());

            backgroundWorker_Inicializa.ReportProgress(10, "CARREGANDO DADOS DE VENDAS");
            vendas = vendaDAO.ListarVendasByData(DateTime.Today.ToShortDateString());

            backgroundWorker_Inicializa.ReportProgress(15, "CARREGANDO DADOS DE CONTAS");
            sum_receber = financeiroDAO.SomaValorReceberByData(DateTime.Today.ToShortDateString());

            backgroundWorker_Inicializa.ReportProgress(20, "CARREGANDO DADOS DE CONTAS");
            result_contas_receber_hoje = financeiroDAO.ListarContasReceberByData_ResultSet(DateTime.Today.ToShortDateString());

            backgroundWorker_Inicializa.ReportProgress(25, "CARREGANDO DADOS DE CONTAS");
            sum_pagar = financeiroDAO.SomaValorPagarByData(DateTime.Today.ToShortDateString());

            backgroundWorker_Inicializa.ReportProgress(30, "CARREGANDO DADOS DE CONTAS");
            result_contas_pagar_hoje = financeiroDAO.ListarContasPagarByData_ResultSet(DateTime.Today.ToShortDateString());

            backgroundWorker_Inicializa.ReportProgress(35, "CARREGANDO DADOS DE CONTAS");
            sum_atrasada = 0;
            backgroundWorker_Inicializa.ReportProgress(40, "CARREGANDO NOTIFICAÇÕES");

            
        }

        private void backgroundWorker_Inicializa_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            formMensagem.progressBar1.Value = e.ProgressPercentage;
            formMensagem.AtualizaMensagemBot(e.UserState.ToString());
        }

        private void backgroundWorker_Inicializa_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lbl_vendas_hoje.Text = sum_venda.ToString("0.00");
            lbl_receber_hoje.Text = sum_receber.ToString("0.00");
            lbl_pagar_hoje.Text = sum_pagar.ToString("0.00");
            lbl_conta_atrasadas.Text = sum_atrasada.ToString("0.00");
            lbl_usuario.Text = perfil.Nome + ": Conectado";
            formMensagem.Close();


            this.Visible = true;
        }
        private void backgroundWorker_AbreContas_DoWork(object sender, DoWorkEventArgs e)
        {
            if (!Application.OpenForms.OfType<FormFinanceiro_pagamentos>().Any())
            {
                formFinanceiro_Pagamentos = new FormFinanceiro_pagamentos();

            }
        }

        private void backgroundWorker_AbreContas_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            formMensagemAguarde.Visible = false;
            formFinanceiro_Pagamentos.Show();
        }

        //checkbox;
        private void checkBox_id_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_id.Checked)
            {
                dataGridView1.Columns["id"].Visible = true;

            }
            else
            {
                dataGridView1.Columns["id"].Visible = false;
            }
            dataGridView1.Refresh();
        }
        private void checkBox_codigo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_codigo.Checked)
            {
                dataGridView1.Columns["cod"].Visible = true;
            }
            else
            {
                dataGridView1.Columns["cod"].Visible = false;
            }
        }

        private void checkBox_id_fav_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_id_fav.Checked)
            {
                dataGridView1.Columns["id_favorecido"].Visible = true;
            }
            else
            {
                dataGridView1.Columns["id_favorecido"].Visible = false;
            }

        }

        private void checkBox_id_dev_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_id_dev.Checked)
            {
                dataGridView1.Columns["id_devedor"].Visible = true;
            }
            else
            {
                dataGridView1.Columns["id_devedor"].Visible = false;
            }
        }

        private void checkBox_favorecido_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_favorecido.Checked)
            {
                dataGridView1.Columns["favorecido"].Visible = true;
            }
            else
            {
                dataGridView1.Columns["favorecido"].Visible = false;
            }
        }

        private void checkBox_devedor_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_devedor.Checked)
            {
                dataGridView1.Columns["devedor"].Visible = true;
            }
            else
            {
                dataGridView1.Columns["devedor"].Visible = false;
            }
        }

        private void checkBox_descricao_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_descricao.Checked)
            {
                dataGridView1.Columns["descricao"].Visible = true;
            }
            else
            {
                dataGridView1.Columns["descricao"].Visible = false;
            }
        }

        private void checkBox_valor_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_valor.Checked)
            {
                dataGridView1.Columns["valor"].Visible = true;
            }
            else
            {
                dataGridView1.Columns["valor"].Visible = false;
            }
        }

        private void checkBox_data_criacao_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_data_criacao.Checked)
            {
                dataGridView1.Columns["data_criacao"].Visible = true;
            }
            else
            {
                dataGridView1.Columns["data_criacao"].Visible = false;
            }
        }

        private void checkBox_hora_criacao_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_hora_criacao.Checked)
            {
                dataGridView1.Columns["hora_criacao"].Visible = true;
            }
            else
            {
                dataGridView1.Columns["hora_criacao"].Visible = false;
            }
        }

        private void checkBox_vencimento_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_vencimento.Checked)
            {
                dataGridView1.Columns["data_vencimento"].Visible = true;
            }
            else
            {
                dataGridView1.Columns["data_vencimento"].Visible = false;
            }
        }

        private void checkBox_tipo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_tipo.Checked)
            {
                dataGridView1.Columns["tipo"].Visible = true;
            }
            else
            {
                dataGridView1.Columns["tipo"].Visible = false;
            }
        }

        private void checkBox_subtipo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_subtipo.Checked)
            {
                dataGridView1.Columns["sub_tipo"].Visible = true;
            }
            else
            {
                dataGridView1.Columns["sub_tipo"].Visible = false;
            }
        }

        private void checkBox_status_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_status.Checked)
            {
                dataGridView1.Columns["status"].Visible = true;
            }
            else
            {
                dataGridView1.Columns["status"].Visible = false;
            }
        }

        private void checkBox_forma_pagamento_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_forma_pagamento.Checked)
            {
                dataGridView1.Columns["forma_pagamento"].Visible = true;
            }
            else
            {
                dataGridView1.Columns["forma_pagamento"].Visible = false;
            }
        }

        private void checkBox_tipo_debito_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_tipo_debito.Checked)
            {
                dataGridView1.Columns["tipo_debito"].Visible = true;
            }
            else
            {
                dataGridView1.Columns["tipo_debito"].Visible = false;
            }
        }

        //PAINTS
        private void panel_vendas_hoje_Paint(object sender, PaintEventArgs e)
        {

            GraphicsPath PastaGrafica = new GraphicsPath();
            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(1, 1, panel_vendas_hoje.Size.Width, panel_vendas_hoje.Size.Height));

            //Arredondar canto superior esquerdo        
            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(1, 1, 10, 10));
            PastaGrafica.AddPie(1, 1, 20, 20, 180, 90);

            //Arredondar canto superior direito
            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(panel_vendas_hoje.Width - 12, 1, 12, 13));
            PastaGrafica.AddPie(panel_vendas_hoje.Width - 24, 1, 24, 26, 270, 90);

            //Arredondar canto inferior esquerdo
            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(1, panel_vendas_hoje.Height - 10, 10, 10));
            PastaGrafica.AddPie(1, panel_vendas_hoje.Height - 20, 20, 20, 90, 90);

            //Arredondar canto inferior direito
            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(panel_vendas_hoje.Width - 12, panel_vendas_hoje.Height - 13, 13, 13));
            PastaGrafica.AddPie(panel_vendas_hoje.Width - 24, panel_vendas_hoje.Height - 26, 24, 26, 0, 90);

            PastaGrafica.SetMarkers();
            panel_vendas_hoje.Region = new Region(PastaGrafica);
        }

        private void panel_receber_hoje_Paint(object sender, PaintEventArgs e)
        {

            GraphicsPath PastaGrafica = new GraphicsPath();
            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(1, 1, panel_receber_hoje.Size.Width, panel_receber_hoje.Size.Height));

            //Arredondar canto superior esquerdo        
            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(1, 1, 10, 10));
            PastaGrafica.AddPie(1, 1, 20, 20, 180, 90);

            //Arredondar canto superior direito
            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(panel_receber_hoje.Width - 12, 1, 12, 13));
            PastaGrafica.AddPie(panel_receber_hoje.Width - 24, 1, 24, 26, 270, 90);

            //Arredondar canto inferior esquerdo
            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(1, panel_receber_hoje.Height - 10, 10, 10));
            PastaGrafica.AddPie(1, panel_receber_hoje.Height - 20, 20, 20, 90, 90);

            //Arredondar canto inferior direito
            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(panel_receber_hoje.Width - 12, panel_receber_hoje.Height - 13, 13, 13));
            PastaGrafica.AddPie(panel_receber_hoje.Width - 24, panel_receber_hoje.Height - 26, 24, 26, 0, 90);

            PastaGrafica.SetMarkers();
            panel_receber_hoje.Region = new Region(PastaGrafica);
        }

        private void panel_menu_Paint(object sender, PaintEventArgs e)
        {

            GraphicsPath PastaGrafica = new GraphicsPath();
            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(1, 1, panel_menu.Size.Width, panel_menu.Size.Height));

            //Arredondar canto superior esquerdo        
            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(1, 1, 10, 10));
            PastaGrafica.AddPie(1, 1, 20, 20, 180, 90);

            //Arredondar canto superior direito
            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(panel_menu.Width - 12, 1, 12, 13));
            PastaGrafica.AddPie(panel_menu.Width - 24, 1, 24, 26, 270, 90);

            //Arredondar canto inferior esquerdo
            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(1, panel_menu.Height - 10, 10, 10));
            PastaGrafica.AddPie(1, panel_menu.Height - 20, 20, 20, 90, 90);

            //Arredondar canto inferior direito
            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(panel_menu.Width - 12, panel_menu.Height - 13, 13, 13));
            PastaGrafica.AddPie(panel_menu.Width - 24, panel_menu.Height - 26, 24, 26, 0, 90);

            PastaGrafica.SetMarkers();
            panel_menu.Region = new Region(PastaGrafica);
        }
        bool control = false;
        private void FormFinanceiro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                hotKeys.RecebeHotKey(sender,e);
                control = true;
            }
            else
            {
                hotKeys.Upped();
                control = false;
            }
            
            
        }

        private void FormFinanceiro_KeyPress(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show(""+e.KeyChar);
            if (control) {
                hotKeys.RecebeKey(sender, e.KeyChar.ToString());
            }
            
        }

        private void panel_pagar_hoje_Paint(object sender, PaintEventArgs e)
        {


            GraphicsPath PastaGrafica = new GraphicsPath();
            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(1, 1, panel_pagar_hoje.Size.Width, panel_pagar_hoje.Size.Height));

            //Arredondar canto superior esquerdo        
            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(1, 1, 10, 10));
            PastaGrafica.AddPie(1, 1, 20, 20, 180, 90);

            //Arredondar canto superior direito
            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(panel_pagar_hoje.Width - 12, 1, 12, 13));
            PastaGrafica.AddPie(panel_pagar_hoje.Width - 24, 1, 24, 26, 270, 90);

            //Arredondar canto inferior esquerdo
            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(1, panel_pagar_hoje.Height - 10, 10, 10));
            PastaGrafica.AddPie(1, panel_pagar_hoje.Height - 20, 20, 20, 90, 90);

            //Arredondar canto inferior direito
            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(panel_pagar_hoje.Width - 12, panel_pagar_hoje.Height - 13, 13, 13));
            PastaGrafica.AddPie(panel_pagar_hoje.Width - 24, panel_pagar_hoje.Height - 26, 24, 26, 0, 90);

            PastaGrafica.SetMarkers();
            panel_pagar_hoje.Region = new Region(PastaGrafica);
        }

        private void panel_contas_atrasadas_Paint(object sender, PaintEventArgs e)
        {

            GraphicsPath PastaGrafica = new GraphicsPath();
            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(1, 1, panel_contas_atrasadas.Size.Width, panel_contas_atrasadas.Size.Height));

            //Arredondar canto superior esquerdo        
            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(1, 1, 10, 10));
            PastaGrafica.AddPie(1, 1, 20, 20, 180, 90);

            //Arredondar canto superior direito
            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(panel_contas_atrasadas.Width - 12, 1, 12, 13));
            PastaGrafica.AddPie(panel_contas_atrasadas.Width - 24, 1, 24, 26, 270, 90);

            //Arredondar canto inferior esquerdo
            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(1, panel_contas_atrasadas.Height - 10, 10, 10));
            PastaGrafica.AddPie(1, panel_contas_atrasadas.Height - 20, 20, 20, 90, 90);

            //Arredondar canto inferior direito
            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(panel_contas_atrasadas.Width - 12, panel_contas_atrasadas.Height - 13, 13, 13));
            PastaGrafica.AddPie(panel_contas_atrasadas.Width - 24, panel_contas_atrasadas.Height - 26, 24, 26, 0, 90);

            PastaGrafica.SetMarkers();
            panel_contas_atrasadas.Region = new Region(PastaGrafica);
        }
        private void panel_notificacao_Paint(object sender, PaintEventArgs e)
        {

            GraphicsPath PastaGrafica = new GraphicsPath();
            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(1, 1, panel_notificacao.Size.Width, panel_notificacao.Size.Height));

            //Arredondar canto superior esquerdo        
            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(1, 1, 10, 10));
            PastaGrafica.AddPie(1, 1, 20, 20, 180, 90);

            //Arredondar canto superior direito
            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(panel_notificacao.Width - 12, 1, 12, 13));
            PastaGrafica.AddPie(panel_notificacao.Width - 24, 1, 24, 26, 270, 90);

            //Arredondar canto inferior esquerdo
            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(1, panel_notificacao.Height - 10, 10, 10));
            PastaGrafica.AddPie(1, panel_notificacao.Height - 20, 20, 20, 90, 90);

            //Arredondar canto inferior direito
            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(panel_notificacao.Width - 12, panel_notificacao.Height - 13, 13, 13));
            PastaGrafica.AddPie(panel_notificacao.Width - 24, panel_notificacao.Height - 26, 24, 26, 0, 90);

            PastaGrafica.SetMarkers();
            panel_notificacao.Region = new Region(PastaGrafica);
        }
    }
}
