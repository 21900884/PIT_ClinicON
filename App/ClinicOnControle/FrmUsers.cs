using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ClinicOnControle
{
	public partial class FrmUsers : Form
	{
		public FrmUsers()
		{
			InitializeComponent();
		}

		Main objMain = new Main();

		private void Limpar()
		{
			txt_userId.Clear();
			txt_uniqueId.Clear();
			txt_nome.Clear();
			txt_sobrenome.Clear();
			txt_nomeSocial.Clear();
			txt_email.Clear();
			txt_senha.Clear();
			txt_cpf.Clear();
			txt_dataDeNascimento.Clear();
			txt_sexo.Clear();
			txt_pais.Clear();
			txt_estado.Clear();
			txt_cidade.Clear();
			txt_logradouro.Clear();
			txt_imagem.Clear();
			txt_status.Clear();
		}

		private void ExibirDados()
		{
			dtg_users.DataSource = objMain.ListarUsuario();
		}



		private void FrmUsers_Load(object sender, EventArgs e)
		{
			ExibirDados();
		}

		private void btn_testarConexao_Click(object sender, EventArgs e)
		{
			objMain.TestarConexao();
		}

		private void btn_listar_Click(object sender, EventArgs e)
		{
			ExibirDados();
		}

		private void btn_cadastrar_Click(object sender, EventArgs e)
		{
			if (txt_uniqueId.Text != "" && txt_nome.Text != "" && txt_sobrenome.Text != "" && txt_email.Text != "" && 
				txt_senha.Text != "" && txt_cpf.Text != "" && txt_dataDeNascimento.Text != "" && txt_sexo.Text != "" && txt_pais.Text != "" && 
				txt_estado.Text != "" && txt_cidade.Text != "" && txt_logradouro.Text != "" && txt_imagem.Text != "" && txt_status.Text != "")
			{
				int.TryParse(txt_uniqueId.Text, out objMain.uniqueId_user);
				objMain.fname_user = txt_nome.Text;
				objMain.lname_user = txt_sobrenome.Text;
				objMain.nomeSocial_user = txt_nomeSocial.Text;
				objMain.email_user = txt_email.Text;
				objMain.password_user = txt_senha.Text;
				objMain.cpf_user = txt_cpf.Text;
				objMain.dataDeNascimento_user = txt_dataDeNascimento.Text;
				objMain.sexo_user = txt_sexo.Text;
				objMain.pais_user = txt_pais.Text;
				objMain.estado_user = txt_estado.Text;
				objMain.cidade_user = txt_cidade.Text;
				objMain.logradouro_user = txt_logradouro.Text;
				objMain.img_user = txt_imagem.Text;
				objMain.status_user = txt_status.Text;

				objMain.InserirUsuario();

				MessageBox.Show("Dados cadastrados com sucesso.");

				Limpar();
				ExibirDados();

			}
			else
			{
				MessageBox.Show("Por Favor preencha todos os dados!");
			}
		}

		private void btn_alterar_Click(object sender, EventArgs e)
		{
			if (txt_userId.Text != "" && txt_uniqueId.Text != "" && txt_nome.Text != "" && txt_sobrenome.Text != "" && 
				txt_email.Text != "" && txt_senha.Text != "" && txt_cpf.Text != "" && txt_dataDeNascimento.Text != "" && txt_sexo.Text != "" && 
				txt_pais.Text != "" && txt_estado.Text != "" && txt_cidade.Text != "" && txt_logradouro.Text != "" && txt_imagem.Text != "" && 
				txt_status.Text != "")
			{
				int.TryParse(txt_userId.Text, out objMain.userId_user);
				int.TryParse(txt_uniqueId.Text, out objMain.uniqueId_user);
				objMain.fname_user = txt_nome.Text;
				objMain.lname_user = txt_sobrenome.Text;
				objMain.nomeSocial_user = txt_nomeSocial.Text;
				objMain.email_user = txt_email.Text;
				objMain.password_user = txt_senha.Text;
				objMain.cpf_user = txt_cpf.Text;
				objMain.dataDeNascimento_user = txt_dataDeNascimento.Text;
				objMain.sexo_user = txt_sexo.Text;
				objMain.pais_user = txt_pais.Text;
				objMain.estado_user = txt_estado.Text;
				objMain.cidade_user = txt_cidade.Text;
				objMain.logradouro_user = txt_logradouro.Text;
				objMain.img_user = txt_imagem.Text;
				objMain.status_user = txt_status.Text;



				objMain.AlterarUsuario();
				MessageBox.Show("Dados alterados com sucesso.");

				Limpar();
				ExibirDados();
			}
			else
			{
				MessageBox.Show("Por Favor preencha todos os dados!");
			}
		}

		private void btn_excluir_Click(object sender, EventArgs e)
		{
			if (txt_userId.Text != "")
			{
				int.TryParse(txt_userId.Text, out objMain.userId_user);

				objMain.ExcluirUsuario();

				MessageBox.Show("Dados excluídos com sucesso.");

				Limpar();
				ExibirDados();
			}
			else
			{
				MessageBox.Show("Por Favor preencha todos os dados!");
			}
		}

		private void dtg_users_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			txt_userId.Text = dtg_users.Rows[e.RowIndex].Cells[0].Value.ToString();
			txt_uniqueId.Text = dtg_users.Rows[e.RowIndex].Cells[1].Value.ToString();
			txt_nome.Text = dtg_users.Rows[e.RowIndex].Cells[2].Value.ToString();
			txt_sobrenome.Text = dtg_users.Rows[e.RowIndex].Cells[3].Value.ToString();
			txt_nomeSocial.Text = dtg_users.Rows[e.RowIndex].Cells[4].Value.ToString();
			txt_email.Text = dtg_users.Rows[e.RowIndex].Cells[5].Value.ToString();
			txt_senha.Text = dtg_users.Rows[e.RowIndex].Cells[6].Value.ToString();
			txt_cpf.Text = dtg_users.Rows[e.RowIndex].Cells[7].Value.ToString();
			txt_dataDeNascimento.Text = dtg_users.Rows[e.RowIndex].Cells[8].Value.ToString();
			txt_sexo.Text = dtg_users.Rows[e.RowIndex].Cells[9].Value.ToString();
			txt_pais.Text = dtg_users.Rows[e.RowIndex].Cells[10].Value.ToString();
			txt_estado.Text = dtg_users.Rows[e.RowIndex].Cells[11].Value.ToString();
			txt_cidade.Text = dtg_users.Rows[e.RowIndex].Cells[12].Value.ToString();
			txt_logradouro.Text = dtg_users.Rows[e.RowIndex].Cells[13].Value.ToString();
			txt_imagem.Text = dtg_users.Rows[e.RowIndex].Cells[14].Value.ToString();
			txt_status.Text = dtg_users.Rows[e.RowIndex].Cells[15].Value.ToString();
		}
	}
}
