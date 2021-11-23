using MySqlConnector;
using System;
using System.Data;

namespace Projeto3Camadas.Code.DAL
{
    class AcessoBancoDados
    {
        MySqlConnection conexao;

        public void Conectar()
        {
            try
            {
                string conn = "Persist Security Info = false; " +
                              "server = localhost; " +
                              "database = db3camadas; " +
                              "uid = root; pwd=root";

                conexao = new MySqlConnection(conn);
                conexao.Open();
            }
            catch (MySqlException ex)
            {
                throw new Exception("Não foi concluído.\n" + ex.Message);
            }
        }

        public DataTable ExecutarConsulta(string sql)       
        {
            try
            {
                Conectar();
                MySqlDataAdapter dados = new MySqlDataAdapter(sql, conexao);
                DataTable dt = new DataTable();
                dados.Fill(dt);    

                return dt;
            }
            catch (MySqlException ex)
            {
                throw new Exception("A consulta não foi concluída.\n" + ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        public void ExecutarComando(string sql)     
        {
            Conectar();

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexao);
                comando.ExecuteNonQuery();      
            }
            catch (MySqlException ex)
            {
                throw new Exception("O comando não foi feito.\n" + ex.Message);
            }
            finally
            {
                conexao.Close();        .
            }
        }
    }
}
