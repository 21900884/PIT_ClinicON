using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicOnControle
{
	class Main
	{

		public int msgId_msg, incomingMsgId_msg, outgoingMsgId_msg, userId_user, uniqueId_user, id_admin;
        public string msg_msg, fname_user, lname_user, email_user, password_user, 
            img_user, status_user, nomeSocial_user, cpf_user, dataDeNascimento_user, sexo_user, 
            pais_user, estado_user,cidade_user, logradouro_user,
            nome_admin, email_admin, senha_admin;

		Conexao objConexao = new Conexao();

		string tbl_messages = "messages";
		string tbl_users = "users";
        string tbl_admins = "admins";

        string hash = "0E91B78FE9CD35FA7C243BA8328E1570";


        //=================================================// Metodos - Outros //=================================================//

        public void TestarConexao()
		{
            objConexao.Conectar();
            MessageBox.Show("Eba, conectou ao banco!");
        }

        public DataTable Login()
        {
            string login = $@"select email, senha from {tbl_admins} where email = '{email_admin}' and senha = '{senha_admin}';";
            return objConexao.ExecutarConsulta(login);
        }

        public string Criptografar(string texto)
		{
            byte[] data = UTF8Encoding.UTF8.GetBytes(texto);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
			{
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripleDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
				{
                    ICryptoTransform transform = tripleDes.CreateEncryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    return Convert.ToBase64String(results, 0, results.Length);
                }
			}
		}

        public string Descriptografar(string texto)
        {
            byte[] data = Convert.FromBase64String(texto);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripleDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripleDes.CreateDecryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    return UTF8Encoding.UTF8.GetString(results);
                }
            }
        }


        //=================================================// Metodos - MENSAGENS (messages) //=================================================//

        public DataTable ListarMensagem()
        {
            string query = $"SELECT * FROM {tbl_messages} ORDER BY msg_id;";
            return objConexao.ExecutarConsulta(query);
        }

        public void InserirMensagem()
        {
            string inserir = $"INSERT INTO {tbl_messages} VALUES (null, '{incomingMsgId_msg}', '{outgoingMsgId_msg}', '{msg_msg}');";
            objConexao.ExecutarComando(inserir);
        }

        public void AlterarMensagem()
        {
            string alterar = $@"UPDATE {tbl_messages} SET incoming_msg_id = '{incomingMsgId_msg}', 
                                                            outgoing_msg_id = '{outgoingMsgId_msg}', 
                                                            msg = '{msg_msg}' 
                                                      WHERE msg_id = '{msgId_msg}';";
            objConexao.ExecutarComando(alterar);
        }

        public void ExcluirMensagem()
        {
            string excluir = $"DELETE FROM {tbl_messages} WHERE msg_id = '{msgId_msg}';";
            objConexao.ExecutarComando(excluir);
        }


        //=================================================// Metodos - Usuarios (users) //=================================================//

        public DataTable ListarUsuario()
        {
            string query = $@"SELECT * FROM {tbl_users} ORDER BY user_id;";
            return objConexao.ExecutarConsulta(query);
        }

        public void InserirUsuario()
        {
            string inserir = $@"INSERT INTO {tbl_users} VALUES (null, '{uniqueId_user}', '{fname_user}', '{lname_user}', 
                            '{nomeSocial_user}', '{email_user}', '{password_user}', '{cpf_user}', 
                            '{dataDeNascimento_user}', '{sexo_user}', '{pais_user}', '{estado_user}', 
                            '{cidade_user}', '{logradouro_user}', '{img_user}', '{status_user}');";

            objConexao.ExecutarComando(inserir);
        }

        public void AlterarUsuario()
        {
            string alterar = $@"UPDATE {tbl_users} SET unique_id = '{uniqueId_user}', 
                                                            fname = '{fname_user}', 
                                                            lname = '{lname_user}',
                                                            email = '{email_user}',
                                                            nome_social = '{nomeSocial_user}',
                                                            password = '{password_user}',
                                                            cpf = '{cpf_user}',
                                                            data_de_nascimento = '{dataDeNascimento_user}',
                                                            sexo = '{sexo_user}',
                                                            pais = '{pais_user}',
                                                            estado = '{estado_user}',
                                                            cidade = '{cidade_user}',
                                                            logradouro = '{logradouro_user}',
                                                            img = '{img_user}',
                                                            status = '{status_user}'
                                                      WHERE user_id = '{userId_user}';";

            objConexao.ExecutarComando(alterar);
        }

        public void ExcluirUsuario()
        {
            string excluir = $@"DELETE FROM {tbl_users} WHERE user_id = '{userId_user}';";
            objConexao.ExecutarComando(excluir);
        }



        //=================================================// Metodos - Administradores (admins) //=================================================//

        public DataTable ListarAdmins()
        {
            string query = $"SELECT * FROM {tbl_admins} ORDER BY id;";
            return objConexao.ExecutarConsulta(query);
        }

        public void InserirAdmin()
        {
            string inserir = $"INSERT INTO {tbl_admins} VALUES (null, '{nome_admin}', '{email_admin}', '{senha_admin}');";
            objConexao.ExecutarComando(inserir);
        }

        public void AlterarAdmin()
        {
            string alterar = $@"UPDATE {tbl_admins} SET nome = '{nome_admin}', 
                                                            email = '{email_admin}',
                                                            senha = '{senha_admin}'
                                                      WHERE id = '{id_admin}';";
            objConexao.ExecutarComando(alterar);
        }

        public void ExcluirAdmin()
        {
            string excluir = $"DELETE FROM {tbl_admins} WHERE id = '{id_admin}';";
            objConexao.ExecutarComando(excluir);
        }









    }
}
