using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDesktop
{
    class Conversor
    {
        public Conversor()
        {

        }

        public int toInt(string texto)
        {
            int inteiro_convertido = 0;

            Int32.TryParse(texto, out inteiro_convertido);

            return inteiro_convertido;
        }

        public double toDouble(string texto)
        {
            double double_convertido = 0;

            if (texto.Contains("."))
            {
                texto = texto.Replace(".", ",");
            }
            Double.TryParse(texto, out double_convertido);
            return double_convertido;
        }

        public string toDoubleDB(string d)
        {

            if (d.Contains(","))
            {
                d = d.Replace(",", ".");
            }

            return d;
        }

        public string toDateTimeDB(string data_string)
        {
            try
            {
                DateTime data = DateTime.ParseExact(data_string, "dd/MM/yyyy", CultureInfo.InvariantCulture);

                return data.ToString("yyyy/MM/dd");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel completar a operação: " + ex.Message);

            }


            return null;
        }
    }
}
