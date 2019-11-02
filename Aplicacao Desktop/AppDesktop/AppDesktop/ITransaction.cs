using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDesktop
{
    interface ITransaction
    {
    
 
            MySqlConnection Conecta();

            MySqlTransaction CriaTransaction(MySqlConnection conn);


    }
}
