using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace ClinicOnControle
{
	class Conexao
	{
        MySqlConnection conexao;
        string connString;


        public void Conectar()
        {
            //connString = "SERVER=185.176.43.95;PORT=3306;DATABASE=3453039_clinicon;UID=3453039_clinicon;PASSWORD=mByRcIT72555";
            try
            {
                connString = "Persist Security Info = false; " + "server = localhost;port=3306; " + "database = clinicon; " + "uid = root; pwd=";
                //conexao = new MySqlConnection(conn);

                conexao = new MySqlConnection();
                conexao.ConnectionString = connString;
                conexao.Open();
            }
            catch (MySqlException ex)
            {
                throw new Exception("Não foi possível conectar ao banco de dados.\n" + ex.Message);
            }
        }

        private void Desconectar()
		{
            if (conexao != null)
			{
                conexao.Close();
                conexao = null;
			}
		}




        public DataTable ExecutarConsulta(string sql)       //sql é uma string que deve conter uma instrução Select
        {
            try
            {
                Conectar();
                MySqlDataAdapter dados = new MySqlDataAdapter(sql, conexao);
                DataTable dt = new DataTable();
                dados.Fill(dt);    //Preenchimento do objeto DataTable(dt) com os dados obtidos da execução do select

                return dt;
            }
            catch (MySqlException ex)
            {
                throw new Exception("Não foi possível executar a CONSULTA solicitada.\n" + ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        public void ExecutarComando(string sql)     //sql: instrução sql de INSERT, UPDATE ou DELETE
        {
            Conectar();

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexao);
                comando.ExecuteNonQuery();      //Método responsável por executar a instrução sql
            }
            catch (MySqlException ex)
            {
                throw new Exception("A instrução não foi realizada.\n" + ex.Message);
            }
            finally
            {
                conexao.Close();        //Importante para que o banco não fique vulnerável.
            }
        }
    }
}
