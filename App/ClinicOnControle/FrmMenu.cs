using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ClinicOnControle
{
	public partial class FrmMenu : Form
	{
		public FrmMenu()
		{
			InitializeComponent();
		}

		Main objMain = new Main();

		private void btn_telaLogin_Click(object sender, EventArgs e)
		{
			FrmLogin frmLogin = new FrmLogin();
			frmLogin.ShowDialog();
		}

		private void btn_telaMsg_Click(object sender, EventArgs e)
		{
			FrmMsg frmMsg = new FrmMsg();
			frmMsg.ShowDialog();
		}

		private void btn_telaUsers_Click(object sender, EventArgs e)
		{
			FrmUsers frmUsers = new FrmUsers();
			frmUsers.ShowDialog();
		}

		private void btn_telaAdmins_Click(object sender, EventArgs e)
		{
			FrmAdmins frmAdmins = new FrmAdmins();
			frmAdmins.ShowDialog();
		}

		private void btn_testarConexao_Click(object sender, EventArgs e)
		{
			objMain.TestarConexao();
		}
	}
}
