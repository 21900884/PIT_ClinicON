
namespace ClinicOnControle
{
	partial class FrmUsers
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btn_testarConexao = new System.Windows.Forms.Button();
			this.btn_alterar = new System.Windows.Forms.Button();
			this.btn_excluir = new System.Windows.Forms.Button();
			this.btn_cadastrar = new System.Windows.Forms.Button();
			this.dtg_users = new System.Windows.Forms.DataGridView();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label9 = new System.Windows.Forms.Label();
			this.txt_logradouro = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.txt_estado = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.txt_pais = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.txt_sexo = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.txt_cidade = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.txt_dataDeNascimento = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.txt_cpf = new System.Windows.Forms.TextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.txt_nomeSocial = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txt_status = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txt_senha = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txt_email = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txt_sobrenome = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txt_imagem = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txt_nome = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txt_uniqueId = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txt_userId = new System.Windows.Forms.TextBox();
			this.btn_listar = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			((System.ComponentModel.ISupportInitialize)(this.dtg_users)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// btn_testarConexao
			// 
			this.btn_testarConexao.Location = new System.Drawing.Point(635, 22);
			this.btn_testarConexao.Name = "btn_testarConexao";
			this.btn_testarConexao.Size = new System.Drawing.Size(150, 35);
			this.btn_testarConexao.TabIndex = 14;
			this.btn_testarConexao.Text = "Testar Conexao";
			this.btn_testarConexao.UseVisualStyleBackColor = true;
			this.btn_testarConexao.Click += new System.EventHandler(this.btn_testarConexao_Click);
			// 
			// btn_alterar
			// 
			this.btn_alterar.Location = new System.Drawing.Point(318, 22);
			this.btn_alterar.Name = "btn_alterar";
			this.btn_alterar.Size = new System.Drawing.Size(150, 35);
			this.btn_alterar.TabIndex = 13;
			this.btn_alterar.Text = "Alterar";
			this.btn_alterar.UseVisualStyleBackColor = true;
			this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
			// 
			// btn_excluir
			// 
			this.btn_excluir.Location = new System.Drawing.Point(474, 22);
			this.btn_excluir.Name = "btn_excluir";
			this.btn_excluir.Size = new System.Drawing.Size(150, 35);
			this.btn_excluir.TabIndex = 12;
			this.btn_excluir.Text = "Excluir";
			this.btn_excluir.UseVisualStyleBackColor = true;
			this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
			// 
			// btn_cadastrar
			// 
			this.btn_cadastrar.Location = new System.Drawing.Point(162, 22);
			this.btn_cadastrar.Name = "btn_cadastrar";
			this.btn_cadastrar.Size = new System.Drawing.Size(150, 35);
			this.btn_cadastrar.TabIndex = 11;
			this.btn_cadastrar.Text = "Cadastrar";
			this.btn_cadastrar.UseVisualStyleBackColor = true;
			this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
			// 
			// dtg_users
			// 
			this.dtg_users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtg_users.Location = new System.Drawing.Point(6, 63);
			this.dtg_users.Name = "dtg_users";
			this.dtg_users.RowTemplate.Height = 25;
			this.dtg_users.Size = new System.Drawing.Size(1026, 304);
			this.dtg_users.TabIndex = 10;
			this.dtg_users.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_users_CellClick);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.txt_logradouro);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.txt_estado);
			this.groupBox1.Controls.Add(this.label11);
			this.groupBox1.Controls.Add(this.txt_pais);
			this.groupBox1.Controls.Add(this.label12);
			this.groupBox1.Controls.Add(this.txt_sexo);
			this.groupBox1.Controls.Add(this.label13);
			this.groupBox1.Controls.Add(this.txt_cidade);
			this.groupBox1.Controls.Add(this.label14);
			this.groupBox1.Controls.Add(this.txt_dataDeNascimento);
			this.groupBox1.Controls.Add(this.label15);
			this.groupBox1.Controls.Add(this.txt_cpf);
			this.groupBox1.Controls.Add(this.label16);
			this.groupBox1.Controls.Add(this.txt_nomeSocial);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.txt_status);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.txt_senha);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.txt_email);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.txt_sobrenome);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.txt_imagem);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txt_nome);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txt_uniqueId);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.txt_userId);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1041, 236);
			this.groupBox1.TabIndex = 9;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Input";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(775, 179);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(69, 15);
			this.label9.TabIndex = 33;
			this.label9.Text = "Logradouro";
			// 
			// txt_logradouro
			// 
			this.txt_logradouro.Location = new System.Drawing.Point(775, 198);
			this.txt_logradouro.Name = "txt_logradouro";
			this.txt_logradouro.Size = new System.Drawing.Size(250, 23);
			this.txt_logradouro.TabIndex = 32;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(262, 180);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(42, 15);
			this.label10.TabIndex = 31;
			this.label10.Text = "Estado";
			// 
			// txt_estado
			// 
			this.txt_estado.Location = new System.Drawing.Point(261, 197);
			this.txt_estado.Name = "txt_estado";
			this.txt_estado.Size = new System.Drawing.Size(250, 23);
			this.txt_estado.TabIndex = 30;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(6, 181);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(28, 15);
			this.label11.TabIndex = 29;
			this.label11.Text = "País";
			// 
			// txt_pais
			// 
			this.txt_pais.Location = new System.Drawing.Point(5, 198);
			this.txt_pais.Name = "txt_pais";
			this.txt_pais.Size = new System.Drawing.Size(250, 23);
			this.txt_pais.TabIndex = 28;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(773, 125);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(32, 15);
			this.label12.TabIndex = 27;
			this.label12.Text = "Sexo";
			// 
			// txt_sexo
			// 
			this.txt_sexo.Location = new System.Drawing.Point(772, 142);
			this.txt_sexo.Name = "txt_sexo";
			this.txt_sexo.Size = new System.Drawing.Size(250, 23);
			this.txt_sexo.TabIndex = 26;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(518, 180);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(44, 15);
			this.label13.TabIndex = 25;
			this.label13.Text = "Cidade";
			// 
			// txt_cidade
			// 
			this.txt_cidade.Location = new System.Drawing.Point(518, 198);
			this.txt_cidade.Name = "txt_cidade";
			this.txt_cidade.Size = new System.Drawing.Size(250, 23);
			this.txt_cidade.TabIndex = 24;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(516, 125);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(112, 15);
			this.label14.TabIndex = 23;
			this.label14.Text = "Data de nascimento";
			// 
			// txt_dataDeNascimento
			// 
			this.txt_dataDeNascimento.Location = new System.Drawing.Point(516, 143);
			this.txt_dataDeNascimento.Name = "txt_dataDeNascimento";
			this.txt_dataDeNascimento.Size = new System.Drawing.Size(250, 23);
			this.txt_dataDeNascimento.TabIndex = 22;
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(260, 125);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(28, 15);
			this.label15.TabIndex = 21;
			this.label15.Text = "CPF";
			// 
			// txt_cpf
			// 
			this.txt_cpf.Location = new System.Drawing.Point(260, 143);
			this.txt_cpf.Name = "txt_cpf";
			this.txt_cpf.Size = new System.Drawing.Size(250, 23);
			this.txt_cpf.TabIndex = 20;
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(4, 125);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(74, 15);
			this.label16.TabIndex = 19;
			this.label16.Text = "Nome Social";
			// 
			// txt_nomeSocial
			// 
			this.txt_nomeSocial.Location = new System.Drawing.Point(4, 143);
			this.txt_nomeSocial.Name = "txt_nomeSocial";
			this.txt_nomeSocial.Size = new System.Drawing.Size(250, 23);
			this.txt_nomeSocial.TabIndex = 18;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(775, 71);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(39, 15);
			this.label8.TabIndex = 17;
			this.label8.Text = "Status";
			// 
			// txt_status
			// 
			this.txt_status.Location = new System.Drawing.Point(775, 89);
			this.txt_status.Name = "txt_status";
			this.txt_status.Size = new System.Drawing.Size(250, 23);
			this.txt_status.TabIndex = 16;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(262, 71);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(39, 15);
			this.label5.TabIndex = 15;
			this.label5.Text = "Senha";
			// 
			// txt_senha
			// 
			this.txt_senha.Location = new System.Drawing.Point(261, 88);
			this.txt_senha.Name = "txt_senha";
			this.txt_senha.Size = new System.Drawing.Size(250, 23);
			this.txt_senha.TabIndex = 14;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(6, 72);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(41, 15);
			this.label6.TabIndex = 13;
			this.label6.Text = "E-mail";
			// 
			// txt_email
			// 
			this.txt_email.Location = new System.Drawing.Point(5, 89);
			this.txt_email.Name = "txt_email";
			this.txt_email.Size = new System.Drawing.Size(250, 23);
			this.txt_email.TabIndex = 12;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(775, 20);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(68, 15);
			this.label7.TabIndex = 11;
			this.label7.Text = "Sobrenome";
			// 
			// txt_sobrenome
			// 
			this.txt_sobrenome.Location = new System.Drawing.Point(774, 37);
			this.txt_sobrenome.Name = "txt_sobrenome";
			this.txt_sobrenome.Size = new System.Drawing.Size(250, 23);
			this.txt_sobrenome.TabIndex = 10;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(518, 71);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(51, 15);
			this.label4.TabIndex = 9;
			this.label4.Text = "Imagem";
			// 
			// txt_imagem
			// 
			this.txt_imagem.Location = new System.Drawing.Point(518, 89);
			this.txt_imagem.Name = "txt_imagem";
			this.txt_imagem.Size = new System.Drawing.Size(250, 23);
			this.txt_imagem.TabIndex = 8;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(518, 19);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(40, 15);
			this.label3.TabIndex = 7;
			this.label3.Text = "Nome";
			// 
			// txt_nome
			// 
			this.txt_nome.Location = new System.Drawing.Point(518, 37);
			this.txt_nome.Name = "txt_nome";
			this.txt_nome.Size = new System.Drawing.Size(250, 23);
			this.txt_nome.TabIndex = 6;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(262, 19);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 15);
			this.label2.TabIndex = 5;
			this.label2.Text = "Unique Id";
			// 
			// txt_uniqueId
			// 
			this.txt_uniqueId.Location = new System.Drawing.Point(262, 37);
			this.txt_uniqueId.Name = "txt_uniqueId";
			this.txt_uniqueId.Size = new System.Drawing.Size(250, 23);
			this.txt_uniqueId.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(43, 15);
			this.label1.TabIndex = 3;
			this.label1.Text = "User Id";
			// 
			// txt_userId
			// 
			this.txt_userId.Enabled = false;
			this.txt_userId.Location = new System.Drawing.Point(6, 37);
			this.txt_userId.Name = "txt_userId";
			this.txt_userId.Size = new System.Drawing.Size(250, 23);
			this.txt_userId.TabIndex = 1;
			// 
			// btn_listar
			// 
			this.btn_listar.Location = new System.Drawing.Point(6, 22);
			this.btn_listar.Name = "btn_listar";
			this.btn_listar.Size = new System.Drawing.Size(150, 35);
			this.btn_listar.TabIndex = 8;
			this.btn_listar.Text = "Listar";
			this.btn_listar.UseVisualStyleBackColor = true;
			this.btn_listar.Click += new System.EventHandler(this.btn_listar_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btn_listar);
			this.groupBox2.Controls.Add(this.btn_testarConexao);
			this.groupBox2.Controls.Add(this.dtg_users);
			this.groupBox2.Controls.Add(this.btn_alterar);
			this.groupBox2.Controls.Add(this.btn_cadastrar);
			this.groupBox2.Controls.Add(this.btn_excluir);
			this.groupBox2.Location = new System.Drawing.Point(12, 254);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(1041, 376);
			this.groupBox2.TabIndex = 15;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Output";
			// 
			// FrmUsers
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1067, 633);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "FrmUsers";
			this.Text = "Form3";
			this.Load += new System.EventHandler(this.FrmUsers_Load);
			((System.ComponentModel.ISupportInitialize)(this.dtg_users)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btn_testarConexao;
		private System.Windows.Forms.Button btn_alterar;
		private System.Windows.Forms.Button btn_excluir;
		private System.Windows.Forms.Button btn_cadastrar;
		private System.Windows.Forms.DataGridView dtg_users;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txt_imagem;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txt_nome;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txt_uniqueId;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txt_userId;
		private System.Windows.Forms.Button btn_listar;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txt_status;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txt_senha;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txt_email;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txt_sobrenome;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txt_logradouro;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txt_estado;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox txt_pais;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox txt_sexo;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox txt_cidade;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox txt_dataDeNascimento;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.TextBox txt_cpf;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.TextBox txt_nomeSocial;
	}
}