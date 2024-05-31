using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bliblioteca.model {
    static class BDConection {

        private static string urlBD = "Server=DESKTOP-7KUBS2C\\SQLEXPRESS;Database=biblioteca;Trusted_Connection=True;";


        public static SqlConnection Connect() {
            SqlConnection conectar = new SqlConnection(urlBD);
           
            return conectar;
        }
      

        
    }
}
