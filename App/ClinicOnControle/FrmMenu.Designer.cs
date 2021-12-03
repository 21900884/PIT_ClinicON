
namespace ClinicOnControle
{
	partial class FrmMenu
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
			this.btn_testarConexao = new System.Windows.Forms.Button();
			this.btn_telaLogin = new System.Windows.Forms.Button();
			this.btn_telaMsg = new System.Windows.Forms.Button();
			this.btn_telaUsers = new System.Windows.Forms.Button();
			this.btn_telaAdmins = new System.Windows.Forms.Button();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btn_telaAdmins);
			this.groupBox2.Controls.Add(this.btn_telaUsers);
			this.groupBox2.Controls.Add(this.btn_testarConexao);
			this.groupBox2.Controls.Add(this.btn_telaLogin);
			this.groupBox2.Controls.Add(this.btn_telaMsg);
			this.groupBox2.Location = new System.Drawing.Point(12, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(1042, 70);
			this.groupBox2.TabIndex = 18;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Menu";
			// 
			// btn_testarConexao
			// 
			this.btn_testarConexao.Location = new System.Drawing.Point(830, 22);
			this.btn_testarConexao.Name = "btn_testarConexao";
			this.btn_testarConexao.Size = new System.Drawing.Size(200, 35);
			this.btn_testarConexao.TabIndex = 14;
			this.btn_testarConexao.Text = "Testar Conexao";
			this.btn_testarConexao.UseVisualStyleBackColor = true;
			this.btn_testarConexao.Click += new System.EventHandler(this.btn_testarConexao_Click);
			// 
			// btn_telaLogin
			// 
			this.btn_telaLogin.Location = new System.Drawing.Point(6, 22);
			this.btn_telaLogin.Name = "btn_telaLogin";
			this.btn_telaLogin.Size = new System.Drawing.Size(200, 35);
			this.btn_telaLogin.TabIndex = 11;
			this.btn_telaLogin.Text = "Tela de login";
			this.btn_telaLogin.UseVisualStyleBackColor = true;
			this.btn_telaLogin.Click += new System.EventHandler(this.btn_telaLogin_Click);
			// 
			// btn_telaMsg
			// 
			this.btn_telaMsg.Location = new System.Drawing.Point(212, 22);
			this.btn_telaMsg.Name = "btn_telaMsg";
			this.btn_telaMsg.Size = new System.Drawing.Size(200, 35);
			this.btn_telaMsg.TabIndex = 12;
			this.btn_telaMsg.Text = "Gerenciar Mensagens";
			this.btn_telaMsg.UseVisualStyleBackColor = true;
			this.btn_telaMsg.Click += new System.EventHandler(this.btn_telaMsg_Click);
			// 
			// btn_telaUsers
			// 
			this.btn_telaUsers.Location = new System.Drawing.Point(418, 22);
			this.btn_telaUsers.Name = "btn_telaUsers";
			this.btn_telaUsers.Size = new System.Drawing.Size(200, 35);
			this.btn_telaUsers.TabIndex = 15;
			this.btn_telaUsers.Text = "Gerenciar Usuarios";
			this.btn_telaUsers.UseVisualStyleBackColor = true;
			this.btn_telaUsers.Click += new System.EventHandler(this.btn_telaUsers_Click);
			// 
			// btn_telaAdmins
			// 
			this.btn_telaAdmins.Location = new System.Drawing.Point(624, 22);
			this.btn_telaAdmins.Name = "btn_telaAdmins";
			this.btn_telaAdmins.Size = new System.Drawing.Size(200, 35);
			this.btn_telaAdmins.TabIndex = 16;
			this.btn_telaAdmins.Text = "Gerenciar Administradores";
			this.btn_telaAdmins.UseVisualStyleBackColor = true;
			this.btn_telaAdmins.Click += new System.EventHandler(this.btn_telaAdmins_Click);
			// 
			// FrmMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1066, 94);
			this.Controls.Add(this.groupBox2);
			this.Name = "FrmMenu";
			this.Text = "FrmMenu";
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button btn_telaAdmins;
		private System.Windows.Forms.Button btn_telaUsers;
		private System.Windows.Forms.Button btn_testarConexao;
		private System.Windows.Forms.Button btn_telaLogin;
		private System.Windows.Forms.Button btn_telaMsg;
	}
}