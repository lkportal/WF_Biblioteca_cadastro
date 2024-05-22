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


        public static void ConnectBD() {
            SqlConnection conectar = new SqlConnection(urlBD);
            try {
                conectar.Open();
                MessageBox.Show(conectar.State.ToString());
            }catch(Exception ex) {
                MessageBox.Show("Conectar: " + ex.Message);
            }
        }
        public static void DesconnectBD() {
            SqlConnection conectar = new SqlConnection(urlBD);
            try {
                conectar.Close();
                MessageBox.Show(conectar.State.ToString());
            } catch (Exception ex) {
                MessageBox.Show("Conectar: " + ex.Message);
            }
        }

        
    }
}
