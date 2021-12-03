using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ClinicOnControle
{
	public partial class FrmMsg : Form
	{
		public FrmMsg()
		{
			InitializeComponent();
		}

		Main objMain = new Main();

		private void Limpar()
		{
			txt_incomingMsgId.Clear();
			txt_msg.Clear();
			txt_msgId.Clear();
			txt_outgoingMsgId.Clear();
		}

		private void ExibirDados()
		{
			dtg_msg.DataSource = objMain.ListarMensagem();
		}



		private void FrmMsg_Load(object sender, EventArgs e)
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
			if (txt_incomingMsgId.Text != "" && txt_outgoingMsgId.Text != "" && txt_msg.Text != "")
			{
				int.TryParse(txt_incomingMsgId.Text, out objMain.incomingMsgId_msg);
				int.TryParse(txt_outgoingMsgId.Text, out objMain.outgoingMsgId_msg);
				objMain.msg_msg = txt_msg.Text;

				objMain.InserirMensagem();

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
			if (txt_msgId.Text != "" && txt_incomingMsgId.Text != "" && txt_outgoingMsgId.Text != "" && txt_msg.Text != "")
			{
				int.TryParse(txt_msgId.Text, out objMain.msgId_msg);
				int.TryParse(txt_incomingMsgId.Text, out objMain.incomingMsgId_msg);
				int.TryParse(txt_outgoingMsgId.Text, out objMain.outgoingMsgId_msg);
				objMain.msg_msg = txt_msg.Text;

				objMain.AlterarMensagem();
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
			if (txt_msgId.Text != "")
			{
				int.TryParse(txt_msgId.Text, out objMain.msgId_msg);

				objMain.ExcluirMensagem();

				MessageBox.Show("Dados excluídos com sucesso.");

				Limpar();
				ExibirDados();
			}
			else
			{
				MessageBox.Show("Por Favor preencha todos os dados!");
			}
		}

		private void dtg_msg_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			txt_msgId.Text = dtg_msg.Rows[e.RowIndex].Cells[0].Value.ToString();
			txt_incomingMsgId.Text = dtg_msg.Rows[e.RowIndex].Cells[1].Value.ToString();
			txt_outgoingMsgId.Text = dtg_msg.Rows[e.RowIndex].Cells[2].Value.ToString();
			txt_msg.Text = dtg_msg.Rows[e.RowIndex].Cells[3].Value.ToString();
		}
	}
}
