using bliblioteca.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bliblioteca.view {
    public partial class Funcionario : Form {


        SqlConnection conectar;
        SqlCommand comando;
        private string query;
        private string Nomes { get; set; }
        private int IDFuncionario { get; set; }
        decimal codLivro = 0m;
        public Funcionario() {
            InitializeComponent();
        }
        public Funcionario(string nome,int funcionario) {
            InitializeComponent();
            this.Nomes = nome;
            this.IDFuncionario = funcionario;
               
        }

        private void labelVoltar_Click(object sender, EventArgs e) {
            Close();
            Thread thread = new Thread(() => Application.Run(new Form1()));
            thread.Start();
        }

        private void Funcionario_Load(object sender, EventArgs e) {
      
            labelNome.Text = Nomes;
            Random numeros = new Random();
            
            for (int i = 0; i < 20; i++) {
               codLivro  +=(decimal) numeros.Next(000000000, 999999999);
            }

            MessageBox.Show(codLivro.ToString());

        }

        private void btnCadastrarLivro_Click(object sender, EventArgs e) {
    


            query = "INSERT INTO LIVROS (EDITORA,NUMERO_PAGINAS,GENERO,AUTOR,QUANTIDADE_LIVROS,FK_FUNCIONARIOS,NOME)" +
                "VALUES (@EDITORA,@N_PAGINAS,@GENERO,@AUTOR,@Q_LIVROS,@FK_FUNCIONARIO,@NOME)";
            conectar = BDConection.Connect();
            comando = new SqlCommand(query,conectar);
            
            try {
                conectar.Open();
                if(!string.IsNullOrEmpty(txtNomeLivro.Text) && !string.IsNullOrEmpty(txtAutor.Text) && !string.IsNullOrEmpty(txtQuaLivros.Text) && !string.IsNullOrEmpty(txtQuaPaginas.Text)
                    && !string.IsNullOrEmpty(txtEditora.Text)) {
                    string valor = comboGenero.SelectedItem.ToString();
                    comando.Parameters.AddWithValue("@NOME",txtNomeLivro.Text);
                    comando.Parameters.AddWithValue("@EDITORA",txtEditora.Text);
                    comando.Parameters.AddWithValue("@N_PAGINAS",txtQuaPaginas.Text);
                    comando.Parameters.AddWithValue("@GENERO",valor);
                    comando.Parameters.AddWithValue("@AUTOR",txtAutor.Text);
                    comando.Parameters.AddWithValue("@Q_LIVROS",txtQuaLivros.Text);
                    comando.Parameters.AddWithValue("@FK_FUNCIONARIO",IDFuncionario);
                    comando.ExecuteNonQuery();
                    comando.Dispose();
                    MessageBox.Show("Livro Inserido", "Livro");
                }
                else {
                    MessageBox.Show("Preencha o campo vazio");
                }



            }catch(Exception ex) {
                MessageBox.Show(ex.Message, "Cadastrar Livro");
            } finally {
                conectar.Close();
            }

        }
    }
}
