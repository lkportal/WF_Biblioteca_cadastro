namespace bliblioteca.view {
    partial class Funcionario {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeLivro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEditora = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQuaPaginas = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboGenero = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtQuaLivros = new System.Windows.Forms.TextBox();
            this.btnCadastrarLivro = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade_livro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.btnMostraLivros = new System.Windows.Forms.Button();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelVoltar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastrar Livro";
            // 
            // txtNomeLivro
            // 
            this.txtNomeLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeLivro.Location = new System.Drawing.Point(13, 102);
            this.txtNomeLivro.Name = "txtNomeLivro";
            this.txtNomeLivro.Size = new System.Drawing.Size(290, 26);
            this.txtNomeLivro.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome Livro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Editora";
            // 
            // txtEditora
            // 
            this.txtEditora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditora.Location = new System.Drawing.Point(13, 154);
            this.txtEditora.Name = "txtEditora";
            this.txtEditora.Size = new System.Drawing.Size(290, 26);
            this.txtEditora.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Quantidades Paginas";
            // 
            // txtQuaPaginas
            // 
            this.txtQuaPaginas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuaPaginas.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtQuaPaginas.Location = new System.Drawing.Point(13, 206);
            this.txtQuaPaginas.MaxLength = 1000;
            this.txtQuaPaginas.Name = "txtQuaPaginas";
            this.txtQuaPaginas.Size = new System.Drawing.Size(290, 26);
            this.txtQuaPaginas.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Genero";
            // 
            // comboGenero
            // 
            this.comboGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboGenero.FormattingEnabled = true;
            this.comboGenero.Items.AddRange(new object[] {
            "Terro",
            "Romance",
            "Ficção Cientifica",
            "Drama",
            "Comédia",
            "Ficção",
            "Anime",
            "Auto Ajuda",
            "Aventura"});
            this.comboGenero.Location = new System.Drawing.Point(12, 258);
            this.comboGenero.Name = "comboGenero";
            this.comboGenero.Size = new System.Drawing.Size(121, 28);
            this.comboGenero.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Autor";
            // 
            // txtAutor
            // 
            this.txtAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAutor.Location = new System.Drawing.Point(13, 312);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(290, 26);
            this.txtAutor.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 350);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Quantidades Livros";
            // 
            // txtQuaLivros
            // 
            this.txtQuaLivros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuaLivros.Location = new System.Drawing.Point(13, 373);
            this.txtQuaLivros.Name = "txtQuaLivros";
            this.txtQuaLivros.Size = new System.Drawing.Size(290, 26);
            this.txtQuaLivros.TabIndex = 12;
            // 
            // btnCadastrarLivro
            // 
            this.btnCadastrarLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarLivro.Location = new System.Drawing.Point(101, 509);
            this.btnCadastrarLivro.Name = "btnCadastrarLivro";
            this.btnCadastrarLivro.Size = new System.Drawing.Size(113, 38);
            this.btnCadastrarLivro.TabIndex = 14;
            this.btnCadastrarLivro.Text = "Cadastrar";
            this.btnCadastrarLivro.UseVisualStyleBackColor = true;
            this.btnCadastrarLivro.Click += new System.EventHandler(this.btnCadastrarLivro_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.Quantidade_livro,
            this.preco,
            this.Editora});
            this.dataGridView1.Location = new System.Drawing.Point(347, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(441, 644);
            this.dataGridView1.TabIndex = 15;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // Quantidade_livro
            // 
            this.Quantidade_livro.HeaderText = "Quantidade";
            this.Quantidade_livro.Name = "Quantidade_livro";
            // 
            // preco
            // 
            this.preco.HeaderText = "Preço";
            this.preco.Name = "preco";
            // 
            // Editora
            // 
            this.Editora.HeaderText = "Editora";
            this.Editora.Name = "Editora";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 411);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Preço Unidade";
            // 
            // txtPreco
            // 
            this.txtPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco.Location = new System.Drawing.Point(13, 434);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(290, 26);
            this.txtPreco.TabIndex = 16;
            // 
            // btnMostraLivros
            // 
            this.btnMostraLivros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostraLivros.Location = new System.Drawing.Point(517, 711);
            this.btnMostraLivros.Name = "btnMostraLivros";
            this.btnMostraLivros.Size = new System.Drawing.Size(113, 38);
            this.btnMostraLivros.TabIndex = 19;
            this.btnMostraLivros.Text = "Exibir";
            this.btnMostraLivros.UseVisualStyleBackColor = true;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.Location = new System.Drawing.Point(13, 47);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(44, 16);
            this.labelNome.TabIndex = 20;
            this.labelNome.Text = "Nome\r\n";
            // 
            // labelVoltar
            // 
            this.labelVoltar.AutoSize = true;
            this.labelVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVoltar.Location = new System.Drawing.Point(720, 9);
            this.labelVoltar.Name = "labelVoltar";
            this.labelVoltar.Size = new System.Drawing.Size(57, 24);
            this.labelVoltar.TabIndex = 21;
            this.labelVoltar.Text = "Volta";
            this.labelVoltar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelVoltar.Click += new System.EventHandler(this.labelVoltar_Click);
            // 
            // Funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 761);
            this.Controls.Add(this.labelVoltar);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.btnMostraLivros);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCadastrarLivro);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtQuaLivros);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.comboGenero);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtQuaPaginas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEditora);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomeLivro);
            this.Controls.Add(this.label1);
            this.Name = "Funcionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Funcionario";
            this.Load += new System.EventHandler(this.Funcionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeLivro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEditora;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtQuaPaginas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboGenero;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtQuaLivros;
        private System.Windows.Forms.Button btnCadastrarLivro;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade_livro;
        private System.Windows.Forms.DataGridViewTextBoxColumn preco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Editora;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Button btnMostraLivros;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelVoltar;
    }
}