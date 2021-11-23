using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto3Camadas.Code.DTO
{
    class MedicamentoDTO
    {
        
        private int _id;
        private string _medicamento;
        private string _composicao;

        
        public int Id { get => _id; set => _id = value; }
        public string Medicamento { get => _medicamento; set => _medicamento = value; }
        public string Composicao { get => _composicao; set => _composicao = value; }
    }
}
