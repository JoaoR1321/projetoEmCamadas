using System;
using System.Windows.Forms;
using System.Net; 
using System.Net.Mail; 


using Projeto3Camadas.Code.BLL; 
using Projeto3Camadas.Code.DTO; 



namespace Projeto3Camadas.Ui
{
    public partial class Frm_Login : Form
    {

        
        LoginBLL loginBBL = new LoginBLL();
        LoginDTO loginDTO = new LoginDTO();

        public Frm_Login()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            
            loginDTO.Email = txtEmail.Text;
            loginDTO.Senha = txtSenha.Text;


             
            if (loginBBL.RealizarLogin(loginDTO) == true)
            {

                Frm_Medicamentos frm_Medicamentos = new Frm_Medicamentos();
                frm_Medicamentos.ShowDialog();
            }
            else
            {
               
                MessageBox.Show("Verificar e-mail e senha.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lnkLabEsqueceu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var client = new SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new NetworkCredential("jrfgois@gmail.com", "lwkejdlxawtwpnjc"),
                EnableSsl = true
            };


            loginDTO.Email = txtEmail.Text;
            string senha = loginBBL.RetornarSenha(loginDTO); 


            
            client.Send("jrfgois@gmail.com", $"{txtEmail.Text}", "Redefinir Senha", $"Seu e-mail é {txtEmail.Text} com senha {senha}");
            
            
            MessageBox.Show("E-mail e senha concluídos.", "E-mail", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }
    }
}
