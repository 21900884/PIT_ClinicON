
namespace ClinicOnControle
{
	partial class FrmAdmins
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
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btn_listar = new System.Windows.Forms.Button();
			this.btn_testarConexao = new System.Windows.Forms.Button();
			this.dtg_admins = new System.Windows.Forms.DataGridView();
			this.btn_alterar = new System.Windows.Forms.Button();
			this.btn_cadastrar = new System.Windows.Forms.Button();
			this.btn_excluir = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txt_senha = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txt_email = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txt_nome = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txt_userId = new System.Windows.Forms.TextBox();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtg_admins)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btn_listar);
			this.groupBox2.Controls.Add(this.btn_testarConexao);
			this.groupBox2.Controls.Add(this.dtg_admins);
			this.groupBox2.Controls.Add(this.btn_alterar);
			this.groupBox2.Controls.Add(this.btn_cadastrar);
			this.groupBox2.Controls.Add(this.btn_excluir);
			this.groupBox2.Location = new System.Drawing.Point(12, 94);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(1041, 445);
			this.groupBox2.TabIndex = 17;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Output";
			// 
			// btn_listar
			// 
			this.btn_listar.Location = new System.Drawing.Point(9, 22);
			this.btn_listar.Name = "btn_listar";
			this.btn_listar.Size = new System.Drawing.Size(150, 35);
			this.btn_listar.TabIndex = 8;
			this.btn_listar.Text = "Listar";
			this.btn_listar.UseVisualStyleBackColor = true;
			this.btn_listar.Click += new System.EventHandler(this.btn_listar_Click);
			// 
			// btn_testarConexao
			// 
			this.btn_testarConexao.Location = new System.Drawing.Point(638, 22);
			this.btn_testarConexao.Name = "btn_testarConexao";
			this.btn_testarConexao.Size = new System.Drawing.Size(150, 35);
			this.btn_testarConexao.TabIndex = 14;
			this.btn_testarConexao.Text = "Testar Conexao";
			this.btn_testarConexao.UseVisualStyleBackColor = true;
			this.btn_testarConexao.Click += new System.EventHandler(this.btn_testarConexao_Click);
			// 
			// dtg_admins
			// 
			this.dtg_admins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtg_admins.Location = new System.Drawing.Point(9, 63);
			this.dtg_admins.Name = "dtg_admins";
			this.dtg_admins.RowTemplate.Height = 25;
			this.dtg_admins.Size = new System.Drawing.Size(1026, 367);
			this.dtg_admins.TabIndex = 10;
			this.dtg_admins.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_admins_CellClick);
			// 
			// btn_alterar
			// 
			this.btn_alterar.Location = new System.Drawing.Point(321, 22);
			this.btn_alterar.Name = "btn_alterar";
			this.btn_alterar.Size = new System.Drawing.Size(150, 35);
			this.btn_alterar.TabIndex = 13;
			this.btn_alterar.Text = "Alterar";
			this.btn_alterar.UseVisualStyleBackColor = true;
			this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
			// 
			// btn_cadastrar
			// 
			this.btn_cadastrar.Location = new System.Drawing.Point(165, 22);
			this.btn_cadastrar.Name = "btn_cadastrar";
			this.btn_cadastrar.Size = new System.Drawing.Size(150, 35);
			this.btn_cadastrar.TabIndex = 11;
			this.btn_cadastrar.Text = "Cadastrar";
			this.btn_cadastrar.UseVisualStyleBackColor = true;
			this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
			// 
			// btn_excluir
			// 
			this.btn_excluir.Location = new System.Drawing.Point(477, 22);
			this.btn_excluir.Name = "btn_excluir";
			this.btn_excluir.Size = new System.Drawing.Size(150, 35);
			this.btn_excluir.TabIndex = 12;
			this.btn_excluir.Text = "Excluir";
			this.btn_excluir.UseVisualStyleBackColor = true;
			this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
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
			this.groupBox1.TabIndex = 18;
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
			// FrmAdmins
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1070, 554);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupBox2);
			this.Name = "FrmAdmins";
			this.Text = "FrmAdmin";
			this.Load += new System.EventHandler(this.FrmAdmins_Load);
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dtg_admins)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button btn_listar;
		private System.Windows.Forms.Button btn_testarConexao;
		private System.Windows.Forms.DataGridView dtg_admins;
		private System.Windows.Forms.Button btn_alterar;
		private System.Windows.Forms.Button btn_cadastrar;
		private System.Windows.Forms.Button btn_excluir;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txt_senha;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txt_email;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txt_nome;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txt_userId;
	}
}