
namespace ClinicOnControle
{
	partial class FrmLogin
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btn_testarConexao = new System.Windows.Forms.Button();
			this.btn_cadastrar = new System.Windows.Forms.Button();
			this.btn_login = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txt_senha = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txt_email = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txt_nome = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txt_userId = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.button1);
			this.groupBox2.Controls.Add(this.btn_testarConexao);
			this.groupBox2.Controls.Add(this.btn_cadastrar);
			this.groupBox2.Controls.Add(this.btn_login);
			this.groupBox2.Location = new System.Drawing.Point(12, 136);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(1041, 70);
			this.groupBox2.TabIndex = 17;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Output";
			// 
			// btn_testarConexao
			// 
			this.btn_testarConexao.Location = new System.Drawing.Point(318, 22);
			this.btn_testarConexao.Name = "btn_testarConexao";
			this.btn_testarConexao.Size = new System.Drawing.Size(150, 35);
			this.btn_testarConexao.TabIndex = 14;
			this.btn_testarConexao.Text = "Testar Conexao";
			this.btn_testarConexao.UseVisualStyleBackColor = true;
			this.btn_testarConexao.Click += new System.EventHandler(this.btn_testarConexao_Click);
			// 
			// btn_cadastrar
			// 
			this.btn_cadastrar.Location = new System.Drawing.Point(6, 22);
			this.btn_cadastrar.Name = "btn_cadastrar";
			this.btn_cadastrar.Size = new System.Drawing.Size(150, 35);
			this.btn_cadastrar.TabIndex = 11;
			this.btn_cadastrar.Text = "Cadastrar";
			this.btn_cadastrar.UseVisualStyleBackColor = true;
			this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
			// 
			// btn_login
			// 
			this.btn_login.Location = new System.Drawing.Point(162, 22);
			this.btn_login.Name = "btn_login";
			this.btn_login.Size = new System.Drawing.Size(150, 35);
			this.btn_login.TabIndex = 12;
			this.btn_login.Text = "Login";
			this.btn_login.UseVisualStyleBackColor = true;
			this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.txt_senha);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.txt_email);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txt_nome);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.txt_userId);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1041, 76);
			this.groupBox1.TabIndex = 16;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Input";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(775, 19);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(39, 15);
			this.label5.TabIndex = 15;
			this.label5.Text = "Senha";
			// 
			// txt_senha
			// 
			this.txt_senha.Location = new System.Drawing.Point(774, 36);
			this.txt_senha.Name = "txt_senha";
			this.txt_senha.Size = new System.Drawing.Size(250, 23);
			this.txt_senha.TabIndex = 14;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(519, 20);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(41, 15);
			this.label6.TabIndex = 13;
			this.label6.Text = "E-mail";
			// 
			// txt_email
			// 
			this.txt_email.Location = new System.Drawing.Point(518, 37);
			this.txt_email.Name = "txt_email";
			this.txt_email.Size = new System.Drawing.Size(250, 23);
			this.txt_email.TabIndex = 12;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(262, 19);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(40, 15);
			this.label3.TabIndex = 7;
			this.label3.Text = "Nome";
			// 
			// txt_nome
			// 
			this.txt_nome.Location = new System.Drawing.Point(262, 37);
			this.txt_nome.Name = "txt_nome";
			this.txt_nome.Size = new System.Drawing.Size(250, 23);
			this.txt_nome.TabIndex = 6;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(17, 15);
			this.label1.TabIndex = 3;
			this.label1.Text = "Id";
			// 
			// txt_userId
			// 
			this.txt_userId.Enabled = false;
			this.txt_userId.Location = new System.Drawing.Point(6, 37);
			this.txt_userId.Name = "txt_userId";
			this.txt_userId.Size = new System.Drawing.Size(250, 23);
			this.txt_userId.TabIndex = 1;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(474, 22);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(150, 35);
			this.button1.TabIndex = 15;
			this.button1.Text = "Testar Conexao";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// FrmLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1067, 217);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "FrmLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Tela De Login";
			this.groupBox2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button btn_testarConexao;
		private System.Windows.Forms.Button btn_cadastrar;
		private System.Windows.Forms.Button btn_login;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txt_senha;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txt_email;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txt_nome;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txt_userId;
		private System.Windows.Forms.Button button1;
	}
}

