using System;
using System.Windows.Forms;

namespace AppDesktop
{
    internal class HotKeys_Financeiro
    {
        FormFinanceiro contexto;


        bool down = true;
        string key1 = "";
        string key2 = "";


        public HotKeys_Financeiro(FormFinanceiro contexto)
        {
            this.contexto = contexto;
        }

        public void Upped()
        {
            key1 = "";
            key2 = "";

        }

        public void RecebeHotKey(object sender, KeyEventArgs e)
        {
            if (!e.Control)
            {
                MessageBox.Show("Entrou aqui");
                
            }

        }

        internal void RecebeKey(object sender, string key)
        {
            MessageBox.Show("teste " + key);
            if (key1.Equals(""))
            {
                MapeiaKey1(key);
            }
            else if (key2.Equals(""))
            {
                MapeiaKey2(key);
                ExecutaAtalho();
            }
        }

        private void MapeiaKey1(string key)
        {
            key1 = key.ToString();
        }
        private void MapeiaKey2(string key)
        {
            key2 = key.ToString();
        }
        private void ExecutaAtalho()
        {
            MessageBox.Show("CTRL + " + key1 + "+" + key2 + " APERTADO! executando funcao");
            Upped();
        }

       
    }
}