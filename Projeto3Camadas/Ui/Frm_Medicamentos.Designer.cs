
namespace Projeto3Camadas.Ui
{
    partial class Frm_Medicamentos
    {
        
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtId = new System.Windows.Forms.TextBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_medicamento = new System.Windows.Forms.Label();
            this.txtComposicao = new System.Windows.Forms.TextBox();
            this.lblComposicao = new System.Windows.Forms.Label();
            this.txtMedicamento = new System.Windows.Forms.TextBox();
            this.btn_Cadastrar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.dgvMedicamentos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(53, 93);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(104, 26);
            this.txtId.TabIndex = 5;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(49, 70);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(26, 20);
            this.lbl_id.TabIndex = 4;
            this.lbl_id.Text = "ID";
            // 
            // lbl_medicamento
            // 
            this.lbl_medicamento.AutoSize = true;
            this.lbl_medicamento.Location = new System.Drawing.Point(193, 70);
            this.lbl_medicamento.Name = "lbl_medicamento";
            this.lbl_medicamento.Size = new System.Drawing.Size(128, 20);
            this.lbl_medicamento.TabIndex = 6;
            this.lbl_medicamento.Text = "MEDICAMENTO";
            // 
            // txtComposicao
            // 
            this.txtComposicao.Location = new System.Drawing.Point(564, 93);
            this.txtComposicao.Name = "txtComposicao";
            this.txtComposicao.Size = new System.Drawing.Size(318, 26);
            this.txtComposicao.TabIndex = 9;
            // 
            // lblComposicao
            // 
            this.lblComposicao.AutoSize = true;
            this.lblComposicao.Location = new System.Drawing.Point(560, 70);
            this.lblComposicao.Name = "lblComposicao";
            this.lblComposicao.Size = new System.Drawing.Size(117, 20);
            this.lblComposicao.TabIndex = 8;
            this.lblComposicao.Text = "COMPOSIÇÃO";
            // 
            // txtMedicamento
            // 
            this.txtMedicamento.Location = new System.Drawing.Point(197, 93);
            this.txtMedicamento.Name = "txtMedicamento";
            this.txtMedicamento.Size = new System.Drawing.Size(318, 26);
            this.txtMedicamento.TabIndex = 11;
            // 
            // btn_Cadastrar
            // 
            this.btn_Cadastrar.Location = new System.Drawing.Point(53, 173);
            this.btn_Cadastrar.Name = "btn_Cadastrar";
            this.btn_Cadastrar.Size = new System.Drawing.Size(245, 40);
            this.btn_Cadastrar.TabIndex = 12;
            this.btn_Cadastrar.Text = "CADASTRAR";
            this.btn_Cadastrar.UseVisualStyleBackColor = true;
            this.btn_Cadastrar.Click += new System.EventHandler(this.btn_Cadastrar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(344, 173);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(245, 40);
            this.btnEditar.TabIndex = 13;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(637, 173);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(245, 40);
            this.btnExcluir.TabIndex = 14;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // dgvMedicamentos
            // 
            this.dgvMedicamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicamentos.Location = new System.Drawing.Point(53, 244);
            this.dgvMedicamentos.Name = "dgvMedicamentos";
            this.dgvMedicamentos.RowHeadersWidth = 62;
            this.dgvMedicamentos.RowTemplate.Height = 28;
            this.dgvMedicamentos.Size = new System.Drawing.Size(829, 232);
            this.dgvMedicamentos.TabIndex = 15;
            this.dgvMedicamentos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMedicamentos_CellClick_1);
            // 
            // Frm_Medicamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 508);
            this.Controls.Add(this.dgvMedicamentos);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btn_Cadastrar);
            this.Controls.Add(this.txtMedicamento);
            this.Controls.Add(this.txtComposicao);
            this.Controls.Add(this.lblComposicao);
            this.Controls.Add(this.lbl_medicamento);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lbl_id);
            this.Name = "Frm_Medicamentos";
            this.Text = "Cadastro de Medicamento";
            this.Load += new System.EventHandler(this.Frm_Medicamentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicamentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_medicamento;
        private System.Windows.Forms.TextBox txtComposicao;
        private System.Windows.Forms.Label lblComposicao;
        private System.Windows.Forms.TextBox txtMedicamento;
        private System.Windows.Forms.Button btn_Cadastrar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.DataGridView dgvMedicamentos;
    }
}