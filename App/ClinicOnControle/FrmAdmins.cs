using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ClinicOnControle
{
	public partial class FrmAdmins : Form
	{
		public FrmAdmins()
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

		private void ExibirDados()
		{
			dtg_admins.DataSource = objMain.ListarAdmins();
		}



		private void FrmAdmins_Load(object sender, EventArgs e)
		{
			ExibirDados();
		}

		private void btn_listar_Click(object sender, EventArgs e)
		{
			ExibirDados();
		}

		private void btn_cadastrar_Click(object sender, EventArgs e)
		{
			if (txt_nome.Text != "" && txt_email.Text != "" && txt_senha.Text != "")
			{
				objMain.nome_admin = txt_nome.Text;
				objMain.email_admin = txt_email.Text;
				objMain.senha_admin = txt_senha.Text;

				objMain.InserirAdmin();
				MessageBox.Show("Cadastrado com sucesso!");

				Limpar();
				ExibirDados();
			}
			else
			{
				MessageBox.Show("Por favor os campos: Nome, E-mail e Senha!");
			}
		}

		private void btn_alterar_Click(object sender, EventArgs e)
		{
			if (txt_userId.Text != "" && txt_nome.Text != "" && txt_email.Text != "" && txt_senha.Text != "")
			{
				int.TryParse(txt_userId.Text, out objMain.id_admin);
				objMain.nome_admin = txt_nome.Text;
				objMain.email_admin = txt_email.Text;
				objMain.senha_admin = txt_senha.Text;

				objMain.AlterarAdmin();
				MessageBox.Show("Alterado com sucesso!");

				Limpar();
				ExibirDados();
			}
			else
			{
				MessageBox.Show("Por favor preencha todos os campos!");
			}
		}

		private void btn_excluir_Click(object sender, EventArgs e)
		{
			if (txt_userId.Text != "")
			{
				int.TryParse(txt_userId.Text, out objMain.id_admin);

				objMain.ExcluirAdmin();
				MessageBox.Show("Excluido com sucesso!");

				Limpar();
				ExibirDados();
			}
			else
			{
				MessageBox.Show("Por favor preencha o campo Id");
			}
		}

		private void btn_testarConexao_Click(object sender, EventArgs e)
		{
			objMain.TestarConexao();
		}

		private void dtg_admins_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			txt_userId.Text = dtg_admins.Rows[e.RowIndex].Cells[0].Value.ToString();
			txt_nome.Text = dtg_admins.Rows[e.RowIndex].Cells[1].Value.ToString();
			txt_email.Text = dtg_admins.Rows[e.RowIndex].Cells[2].Value.ToString();
			txt_senha.Text = dtg_admins.Rows[e.RowIndex].Cells[3].Value.ToString();
		}

		
	}
}
