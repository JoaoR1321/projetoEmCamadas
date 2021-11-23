using System;
using System.Windows.Forms;


using Projeto3Camadas.Code.BLL; 
using Projeto3Camadas.Code.DTO; 

namespace Projeto3Camadas.Ui
{
    public partial class Frm_Medicamentos : Form
    {

        
        MedicamentoBLL medbll = new MedicamentoBLL();
        MedicamentoDTO meddto = new MedicamentoDTO();

        public Frm_Medicamentos()
        {
            InitializeComponent();
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            
            meddto.Medicamento = txtMedicamento.Text;
            meddto.Composicao = txtComposicao.Text;

            medbll.Inserir(meddto);

            
            MessageBox.Show("Cadastrado Concluído", "Medicamento", MessageBoxButtons.OK, MessageBoxIcon.Information);

            
            txtId.Clear();
            txtMedicamento.Clear();
            txtComposicao.Clear();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            
            meddto.Id = int.Parse(txtId.Text);
            meddto.Medicamento = txtMedicamento.Text;
            meddto.Composicao = txtComposicao.Text;

            
            medbll.Editar(meddto);

            
            MessageBox.Show("Alteração Concluída", "Medicamento", MessageBoxButtons.OK, MessageBoxIcon.Information);

            
            medbll.Listar();

            
            txtId.Clear();
            txtMedicamento.Clear();
            txtComposicao.Clear();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        { 
            meddto.Id = int.Parse(txtId.Text);
         
            medbll.Excluir(meddto);

            MessageBox.Show("Exclusão Concluída", "Medicamento", MessageBoxButtons.OK, MessageBoxIcon.Information);

            medbll.Listar();

            txtId.Clear();
            txtMedicamento.Clear();
            txtComposicao.Clear();
        }

        private void Frm_Medicamentos_Load(object sender, EventArgs e)
        {
            dgvMedicamentos.DataSource = medbll.Listar();
        }

        private void dgvMedicamentos_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvMedicamentos.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtMedicamento.Text = dgvMedicamentos.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtComposicao.Text = dgvMedicamentos.Rows[e.RowIndex].Cells[2].Value.ToString();
        }
    }
}
