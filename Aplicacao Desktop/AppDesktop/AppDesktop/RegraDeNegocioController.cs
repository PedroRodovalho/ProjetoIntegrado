using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDesktop
{
    class RegraDeNegocioController
    {
        RegrasNegocioDAO regrasDAO = new RegrasNegocioDAO();
        Venda venda, venda_aplicada;
        Pagamento pagamento;
        List<Item_Caixa> itens;

        public RegraDeNegocioController(Venda venda, List<Item_Caixa> itens, Pagamento pagamento)
        {

            this.venda = venda;
            this.itens = itens;
            this.pagamento = pagamento;

        }


        //public Venda AplicaRegras()
        //{

        //}

        public Venda AplicaRegras()
        {

            if (venda.Regra_aplicada != 0) return null;
            
            string forma_pagamento = pagamento.Forma_pagamento;
     
            RegrasNegocio regra_negocio = regrasDAO.buscaRegraAtiva(forma_pagamento);

            string tipo_venda = regra_negocio.Tipo_venda;
            if (regra_negocio != null && (tipo_venda.Equals(pagamento.Forma_pagamento) || tipo_venda.Equals("TODAS")))
            {
                
                if ((forma_pagamento.Equals("CREDITO") || tipo_venda.Equals("TODAS")) && !(pagamento.Quantidade_parcelas >= regra_negocio.Parcela_min && pagamento.Quantidade_parcelas <= regra_negocio.Parcela_max))
                {
                    return null;
                }
                
                List<Regra> regrasExistentes = regrasDAO.buscaRegrasExistentes(regra_negocio.Id);
              
                venda_aplicada = venda;
                
                for (int i = 0; i < regrasExistentes.Count; i++)
                {

                    Regra regra = regrasExistentes[i];
                    if (regrasExistentes[i].Atribuicao.Equals("VALOR TOTAL"))
                    {

                        venda_aplicada = AplicaValorTotal(regra);
                       
                        if (venda_aplicada == null )
                        {
                            regrasExistentes.RemoveAt(i);
                        }
                        else
                        {

                            return venda_aplicada;
                        }

                    }



                }
                for (int i = 0; i < regrasExistentes.Count; i++)
                {
                    
                    Regra regra = regrasExistentes[i];
                    if (regrasExistentes[i].Atribuicao.Equals("QUANTIDADE"))
                    {

                        venda_aplicada = AplicaRegraQuantidade(regra);
                       
                        if (venda_aplicada == null)
                        {
                            regrasExistentes.RemoveAt(i);
                        }
                        else
                        {

                            return venda_aplicada;
                        }

                    }
                }
                /**
                if (regrasExistentes[i].Atribuicao.Equals("VALOR DO PRODUTO"))
                {
                    MessageBox.Show("VALOR PRODUTO");
                    venda_aplicada = AplicaRegraValorDoProduto(regra);
                    if (venda_aplicada != null || !venda_aplicada.Equals(null) || venda_aplicada.Equals("null")) return venda_aplicada;
                }
                */
            }
            return null;
        }
        private Venda AplicaValorTotal(Regra regra)
        {
            string condicao = regra.Condicao;
           
            if (condicao.Equals("MAIOR OU IGUAL"))
            {
                
                if (venda.Valor_total >= regra.Parametro)
                {
                   

                    venda_aplicada.Valor_final = venda.Valor_total - (venda.Valor_total * (regra.Desconto / 100));
                    
                    venda_aplicada.Desconto = regra.Desconto;
                    venda_aplicada.Regra_aplicada = regra.Id;
                    return venda_aplicada;
                }

            }
            else if (condicao.Equals("MENOR OU IGUAL"))
            {

             

                if (venda.Valor_total <= regra.Parametro)
                {

                    
                    venda_aplicada.Valor_final = venda.Valor_total - (venda.Valor_total * (regra.Desconto / 100));
                    venda_aplicada.Desconto = regra.Desconto;
                    venda_aplicada.Regra_aplicada = regra.Id;

                    return venda_aplicada;
                }
            }
            return null;
        }

        private Venda AplicaRegraQuantidade(Regra regra)
        {
            venda_aplicada = new Venda();
            string condicao = regra.Condicao;
            
            if (condicao.Equals("MAIOR OU IGUAL"))
            {
                if (venda.Quantidade_itens >= regra.Parametro)
                {
                    venda_aplicada.Valor_final = venda.Valor_total - (venda.Valor_total * (regra.Desconto / 100));
                    venda_aplicada.Desconto = regra.Desconto;
                    venda_aplicada.Regra_aplicada = regra.Id;
                    return venda_aplicada;
                }
            }
            else if (condicao.Equals("MENOR OU IGUAL"))
            {
                if (venda.Valor_final <= regra.Parametro)
                {
                    venda_aplicada.Valor_final = venda.Valor_total - (venda.Valor_total * (regra.Desconto / 100));
                    venda_aplicada.Desconto = regra.Desconto;
                    venda_aplicada.Regra_aplicada = regra.Id;

                    return venda_aplicada;
                }



            }
            System.Console.Write("APLICANDO REGRA DE QUANTIDADE");

            return null;

        }

        private Venda AplicaRegraValorDoProduto(Regra regra)
        {

            for (int i = 0; i < itens.Count; i++)
            {

            }
            System.Console.Write("APLICANDO REGRA DE QUANTIDADE");
            return null;
        }



    }
}
