
namespace ClinicOnControle
{
	partial class FrmMsg
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
			this.btn_listar = new System.Windows.Forms.Button();
			this.txt_msgId = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txt_msg = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txt_outgoingMsgId = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txt_incomingMsgId = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.dtg_msg = new System.Windows.Forms.DataGridView();
			this.btn_cadastrar = new System.Windows.Forms.Button();
			this.btn_alterar = new System.Windows.Forms.Button();
			this.btn_excluir = new System.Windows.Forms.Button();
			this.btn_testarConexao = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtg_msg)).BeginInit();
			this.SuspendLayout();
			// 
			// btn_listar
			// 
			this.btn_listar.Location = new System.Drawing.Point(12, 152);
			this.btn_listar.Name = "btn_listar";
			this.btn_listar.Size = new System.Drawing.Size(150, 35);
			this.btn_listar.TabIndex = 0;
			this.btn_listar.Text = "Listar";
			this.btn_listar.UseVisualStyleBackColor = true;
			this.btn_listar.Click += new System.EventHandler(this.btn_listar_Click);
			// 
			// txt_msgId
			// 
			this.txt_msgId.Enabled = false;
			this.txt_msgId.Location = new System.Drawing.Point(6, 37);
			this.txt_msgId.Name = "txt_msgId";
			this.txt_msgId.Size = new System.Drawing.Size(250, 23);
			this.txt_msgId.TabIndex = 1;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.txt_msg);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txt_outgoingMsgId);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txt_incomingMsgId);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.txt_msgId);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(779, 118);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Input";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 63);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(30, 15);
			this.label4.TabIndex = 9;
			this.label4.Text = "Msg";
			// 
			// txt_msg
			// 
			this.txt_msg.Location = new System.Drawing.Point(6, 81);
			this.txt_msg.Name = "txt_msg";
			this.txt_msg.Size = new System.Drawing.Size(762, 23);
			this.txt_msg.TabIndex = 8;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(518, 19);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(97, 15);
			this.label3.TabIndex = 7;
			this.label3.Text = "Outgoing Msg Id";
			// 
			// txt_outgoingMsgId
			// 
			this.txt_outgoingMsgId.Location = new System.Drawing.Point(518, 37);
			this.txt_outgoingMsgId.Name = "txt_outgoingMsgId";
			this.txt_outgoingMsgId.Size = new System.Drawing.Size(250, 23);
			this.txt_outgoingMsgId.TabIndex = 6;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(262, 19);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(97, 15);
			this.label2.TabIndex = 5;
			this.label2.Text = "Incoming Msg Id";
			// 
			// txt_incomingMsgId
			// 
			this.txt_incomingMsgId.Location = new System.Drawing.Point(262, 37);
			this.txt_incomingMsgId.Name = "txt_incomingMsgId";
			this.txt_incomingMsgId.Size = new System.Drawing.Size(250, 23);
			this.txt_incomingMsgId.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(43, 15);
			this.label1.TabIndex = 3;
			this.label1.Text = "Msg Id";
			// 
			// dtg_msg
			// 
			this.dtg_msg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtg_msg.Location = new System.Drawing.Point(12, 193);
			this.dtg_msg.Name = "dtg_msg";
			this.dtg_msg.RowTemplate.Height = 25;
			this.dtg_msg.Size = new System.Drawing.Size(779, 367);
			this.dtg_msg.TabIndex = 3;
			this.dtg_msg.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_msg_CellClick);
			// 
			// btn_cadastrar
			// 
			this.btn_cadastrar.Location = new System.Drawing.Point(168, 152);
			this.btn_cadastrar.Name = "btn_cadastrar";
			this.btn_cadastrar.Size = new System.Drawing.Size(150, 35);
			this.btn_cadastrar.TabIndex = 4;
			this.btn_cadastrar.Text = "Cadastrar";
			this.btn_cadastrar.UseVisualStyleBackColor = true;
			this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
			// 
			// btn_alterar
			// 
			this.btn_alterar.Location = new System.Drawing.Point(324, 152);
			this.btn_alterar.Name = "btn_alterar";
			this.btn_alterar.Size = new System.Drawing.Size(150, 35);
			this.btn_alterar.TabIndex = 6;
			this.btn_alterar.Text = "Alterar";
			this.btn_alterar.UseVisualStyleBackColor = true;
			this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
			// 
			// btn_excluir
			// 
			this.btn_excluir.Location = new System.Drawing.Point(480, 152);
			this.btn_excluir.Name = "btn_excluir";
			this.btn_excluir.Size = new System.Drawing.Size(150, 35);
			this.btn_excluir.TabIndex = 5;
			this.btn_excluir.Text = "Excluir";
			this.btn_excluir.UseVisualStyleBackColor = true;
			this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
			// 
			// btn_testarConexao
			// 
			this.btn_testarConexao.Location = new System.Drawing.Point(641, 152);
			this.btn_testarConexao.Name = "btn_testarConexao";
			this.btn_testarConexao.Size = new System.Drawing.Size(150, 35);
			this.btn_testarConexao.TabIndex = 7;
			this.btn_testarConexao.Text = "Testar Conexao";
			this.btn_testarConexao.UseVisualStyleBackColor = true;
			this.btn_testarConexao.Click += new System.EventHandler(this.btn_testarConexao_Click);
			// 
			// FrmMsg
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(804, 576);
			this.Controls.Add(this.btn_testarConexao);
			this.Controls.Add(this.btn_alterar);
			this.Controls.Add(this.btn_excluir);
			this.Controls.Add(this.btn_cadastrar);
			this.Controls.Add(this.dtg_msg);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btn_listar);
			this.Name = "FrmMsg";
			this.Text = "Form2";
			this.Load += new System.EventHandler(this.FrmMsg_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtg_msg)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btn_listar;
		private System.Windows.Forms.TextBox txt_msgId;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txt_msg;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txt_outgoingMsgId;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txt_incomingMsgId;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dtg_msg;
		private System.Windows.Forms.Button btn_cadastrar;
		private System.Windows.Forms.Button btn_alterar;
		private System.Windows.Forms.Button btn_excluir;
		private System.Windows.Forms.Button btn_testarConexao;
	}
}