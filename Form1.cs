using bliblioteca.model;
using bliblioteca.view;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bliblioteca {
    public partial class Form1 : Form {
    
        public Form1() {
            InitializeComponent();
           
        }

        private void btnFuncionario_Click(object sender, EventArgs e) {
            Close();
            Thread thread = new Thread(() => Application.Run(new Funcionario()));
            thread.Start();
        }

        private void Form1_Load(object sender, EventArgs e) {
         
            
        }

        private void btnCliente_Click(object sender, EventArgs e) {
            Close();
            Thread thread = new Thread(() => Application.Run(new Cliente()));
            thread.Start();
        }

        private void button1_Click(object sender, EventArgs e) {

       
            CadastroCliente cs = new CadastroCliente();
            cs.ShowDialog();


        }

        private void btnSair_Click(object sender, EventArgs e) {
            Application.Exit();
        }
    }
}
