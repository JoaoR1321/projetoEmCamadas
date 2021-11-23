using System.Data;


using Projeto3Camadas.Code.DTO; 
using Projeto3Camadas.Code.DAL; 


namespace Projeto3Camadas.Code.BLL
{
    class MedicamentoBLL
    {

        
        AcessoBancoDados conexao = new AcessoBancoDados();
        string tabela = "tbl_medicamento";


        
        public void Inserir (MedicamentoDTO medDto)
        {
            
            string inserir = $"insert into {tabela} values(null,'{medDto.Medicamento}','{medDto.Composicao}')";
            conexao.ExecutarComando(inserir);
        }

        public DataTable Listar()     
        {
            string sql = $"select * from {tabela} order by id;";
            return conexao.ExecutarConsulta(sql);
        }

        public void Editar(MedicamentoDTO medDto)
        {
            string alterar = $"update {tabela} set medicamento = '{medDto.Medicamento}', composicao = '{medDto.Composicao}' where id = '{medDto.Id}';";
            conexao.ExecutarComando(alterar);
        }


        public void Excluir(MedicamentoDTO medDto)
        {
            string excluir = $"delete from {tabela} where id = '{medDto.Id}';";
            conexao.ExecutarComando(excluir);
        }
    }
}
