using System.Data;

using Projeto3Camadas.Code.DTO; 
using Projeto3Camadas.Code.DAL; 


namespace Projeto3Camadas.Code.BLL
{
    class LoginBLL
    {

        AcessoBancoDados conexao = new AcessoBancoDados();
        string tabela = "tbl_login";

        public bool RealizarLogin(LoginDTO login)     
        {
            string sql = $"select * from {tabela} where email='{login.Email}' and senha='{login.Senha}'";
            DataTable dt = conexao.ExecutarConsulta(sql);

            if (dt.Rows.Count > 0)
                return true;            
            else
                return false;
        }
        public string RetornarSenha(LoginDTO login)     
        {
            string sql = $"select * from {tabela} where email='{login.Email}'";
            DataTable dt = conexao.ExecutarConsulta(sql);

            if (dt.Rows.Count > 0)
                return dt.Rows[0]["senha"].ToString();
            else
                return "false";
        }

    }
}
