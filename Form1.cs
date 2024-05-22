using bliblioteca.model;
using bliblioteca.view;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bliblioteca {
    public partial class Form1 : Form {
    
        public Form1() {
            InitializeComponent();
           
        }

        private void btnFuncionario_Click(object sender, EventArgs e) {
            BDConection.ConnectBD();


        }

        private void Form1_Load(object sender, EventArgs e) {
         
            
        }

        private void btnCliente_Click(object sender, EventArgs e) {
            BDConection.DesconnectBD();
        }
    }
}
