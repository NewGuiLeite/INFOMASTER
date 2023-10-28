using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INFOMASTER.Forms
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Obter o nome de usuário e senha dos campos de texto
            string username = usernameBox.Text;
            string password = passwordBox.Text;

            // Verificar se o nome de usuário e a senha estão corretos
            if (username == "ADM" && password == "561")
            {
                // Login bem-sucedido
                //MessageBox.Show("Login bem-sucedido. Bem-vindo, ADM!");

                // Criar uma instância do frmMain e exibi-la
                frmMain frm = new frmMain();
                frm.Show(); // Use Show() em vez de ShowDialog()

                // Fechar o formulário de login (se desejado)
                this.Hide(); // Oculta o formulário de login em vez de fechá-lo
            }
            else
            {
                // Se as credenciais estiverem incorretas, exibir uma mensagem de erro
                MessageBox.Show("Credenciais incorretas. Tente novamente.");
                // Você pode limpar os campos de texto ou executar outras ações aqui.
            }
        }


    }
}
