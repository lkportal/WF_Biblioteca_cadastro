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
using System.Data.SqlClient;

namespace bliblioteca {
    public partial class Form1 : Form {
        SqlCommand comando;
        SqlDataAdapter adapter;
        DataTable table;
        string query;
        public Form1() {
            InitializeComponent();
           
        }

        private void btnFuncionario_Click(object sender, EventArgs e) {
            query = "SELECT IDFUNCIONARIO, NOME, N_REGISTRO FROM FUNCIONARIO WHERE NOME = @NOME OR N_REGISTRO = @N_REGISTRO";
            comando = new SqlCommand(query,BDConection.Connect());
            table = new DataTable();
            
            BDConection.Connect().Open();
           

            try {
                if(!string.IsNullOrEmpty(txtNome.Text) && !string.IsNullOrEmpty(txtRegistro.Text)) {
                    comando.Parameters.AddWithValue("@NOME",txtNome.Text.ToUpper());
                    comando.Parameters.AddWithValue("@N_REGISTRO", txtRegistro.Text);
                    adapter = new SqlDataAdapter(comando);
                    adapter.Fill(table);
                    foreach(DataRow data in table.Rows) {
                        if (data["NOME"].ToString()== (txtNome.Text.ToUpper())  && data["N_REGISTRO"].ToString() ==(txtRegistro.Text)) {
                            Close();
                            Thread thread = new Thread(() => Application.Run(new Funcionario(data["NOME"].ToString(), (int)(data["IDFUNCIONARIO"]))));
                            thread.Start();
                        }
                        else {
                            MessageBox.Show("Nome ou Registro incorreto!");
                        }
                    }

                }
                else {
                    MessageBox.Show("Preencha os campos");
                }
         

            
            }catch(Exception ex) {
            
            
            } finally {
                BDConection.Connect().Close();
                comando.Dispose();
                txtNome.Text = "";
                txtRegistro.Text = "";
            }
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
