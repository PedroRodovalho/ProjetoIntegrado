using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.Types;

namespace AppDesktop
{
    class Conversor
    {
        public Conversor()
        {

        }

        public int ToInt32(string texto)
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

        public byte[] imageToByte(Image image)
        {
            var stream = new MemoryStream();
            image.Save(stream, ImageFormat.Jpeg);
            stream.Seek(0, SeekOrigin.Begin);
            byte[] imageArray = new byte[stream.Length];
            stream.Read(imageArray, 0, System.Convert.ToInt32(stream.Length));
            return imageArray;
        }

        internal string toDateTimeBR(MySqlDateTime mySqlDateTime)
        {
            string day = "";
            string month = "";
            if (ToInt32(mySqlDateTime.Day.ToString()) < 10)
            {
                day = "0";
            }

            if (ToInt32(mySqlDateTime.Month.ToString()) < 10)
            {
                month = "0";
            }
            day = day + mySqlDateTime.Day.ToString();
            month = month + mySqlDateTime.Month.ToString() ;
            string year = mySqlDateTime.Year.ToString();
            string data = day + "/" + month + "/" + year;
            return data;
        }
    }
}
