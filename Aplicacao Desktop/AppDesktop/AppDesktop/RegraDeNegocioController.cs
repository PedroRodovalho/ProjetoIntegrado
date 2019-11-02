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
        Venda venda,venda_aplicada;
        List<Item_Caixa> itens;
        
        public RegraDeNegocioController(Venda venda, List<Item_Caixa> itens){

            this.venda = venda;
            this.itens = itens;

        }


        //public Venda AplicaRegras()
        //{

        //}

        public Venda AplicaRegras()
        {
            int id = regrasDAO.buscaRegraAtiva();
            MessageBox.Show(id.ToString() + "venda: " + venda.Valor_total);
            List<Regra> regrasExistentes = regrasDAO.buscaRegrasExistentes(id);
            MessageBox.Show(regrasExistentes.Count.ToString());
            venda_aplicada = venda;
            
            for (int i = 0; i < regrasExistentes.Count; i++)
            {
                
                Regra regra = regrasExistentes[i];
                if(regrasExistentes[i].Atribuicao.Equals("VALOR TOTAL")){

                    venda_aplicada  = AplicaValorTotal(regra);
                    if (venda_aplicada == null || venda_aplicada.Equals(null) || venda_aplicada.Equals("null"))
                    {
                        regrasExistentes.RemoveAt(i);
                    }
                    else { 

                        return venda_aplicada;
                    }
                    
                }

               

            }
            for (int i = 0; i < regrasExistentes.Count; i++){
                MessageBox.Show("Entrou 2 fori");
               Regra regra = regrasExistentes[i];
                if(regrasExistentes[i].Atribuicao.Equals("VALOR DO PRODUTO")){

                    venda_aplicada  = AplicaRegraQuantidade(regra);
                   // AplicaRegraQuantidade(regra);
                    if (venda_aplicada == null || venda_aplicada.Equals(null) || venda_aplicada.Equals("null"))
                    {
                        regrasExistentes.RemoveAt(i);
                    }
                    else { 

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
            return null;
        }

        private Venda AplicaValorTotal(Regra regra)
        {
            string condicao = regra.Condicao;
            MessageBox.Show("condicao: " + condicao);
            if (condicao.Equals("MAIOR OU IGUAL")){
                MessageBox.Show("Maior ou igual");
                if (venda.Valor_total >= regra.Parametro)
                {
                    MessageBox.Show("Maior ou igual");

                    venda_aplicada.Valor_final = venda.Valor_total - (venda.Valor_total * (regra.Desconto / 100));
                    MessageBox.Show("VENDA APLICADA " + venda_aplicada.Valor_final.ToString()+"\n Desconto: "+ regra.Desconto);
                    venda_aplicada.Desconto = regra.Desconto;
                    venda_aplicada.Regra_aplicada = regra.Id;
                    return venda_aplicada;
                }
                
            }
            else if (condicao.Equals("MENOR OU IGUAL")) {

                MessageBox.Show("Maior ou igual");

                if (venda.Valor_total <= regra.Parametro)
                {

                    MessageBox.Show("Maior ou igual");
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
            else if (condicao.Equals("Menor ou Igual"))
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
            
            return venda_aplicada;

        }

        private Venda AplicaRegraValorDoProduto(Regra regra)
        {
            System.Console.Write("APLICANDO REGRA DE QUANTIDADE");
            return venda_aplicada;
        }

    }
}
