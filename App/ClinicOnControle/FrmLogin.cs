using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicOnControle
{
	public partial class FrmLogin : Form
	{
		public FrmLogin()
		{
			InitializeComponent();
		}

		Main objMain = new Main();

		private void Limpar()
		{
			txt_email.Clear();
			txt_nome.Clear();
			txt_senha.Clear();
			txt_userId.Clear();
		}

		private void MudarDeTela()
		{
			FrmMenu frmMenu = new FrmMenu();
			frmMenu.ShowDialog();
		}

		private void btn_testarConexao_Click(object sender, EventArgs e)
		{
			objMain.TestarConexao();
		}

		private void btn_login_Click(object sender, EventArgs e)
		{
			if (txt_email.Text != "" && txt_senha.Text != "")
			{
				objMain.email_admin = txt_email.Text;
				objMain.senha_admin = objMain.Criptografar(txt_senha.Text);

				string email = "";
				string senha = "";

				foreach (DataRow row in objMain.Login().Rows)
				{
					email = row["email"].ToString();
					senha = row["senha"].ToString();
				}

				if (email == txt_email.Text && objMain.Descriptografar(senha) == txt_senha.Text)
				{
					MessageBox.Show("Logado com sucesso!");

					Limpar();

					MudarDeTela();
				}
				else
				{
					MessageBox.Show("Usuario nao encontrado");

					Limpar();
				}
			}
			else
			{
				MessageBox.Show("Por favor preencha os campos de login e senha!");

				Limpar();
			}
		}

		private void btn_cadastrar_Click(object sender, EventArgs e)
		{
			if (txt_nome.Text != "" && txt_email.Text != "" && txt_senha.Text != "")
			{
				objMain.nome_admin = txt_nome.Text;
				objMain.email_admin = txt_email.Text;
				objMain.senha_admin = objMain.Criptografar(txt_senha.Text);

				objMain.InserirAdmin();
				MessageBox.Show("Cadastrado com sucesso!");

				Limpar();

				MudarDeTela();
			}
			else
			{
				MessageBox.Show("Por favor preencha todos os campos!");
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			MessageBox.Show(objMain.Descriptografar(txt_senha.Text));
		}
	}
}
