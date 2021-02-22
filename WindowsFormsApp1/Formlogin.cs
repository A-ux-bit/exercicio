using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApp1
{
    public partial class Formlogin : Form
    {
        public Formlogin()
        {
            InitializeComponent();
            FormSplashScreen formSplashScreen = new FormSplashScreen();
            formSplashScreen.Show();
            Thread.Sleep(3000);
            formSplashScreen.Close();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            String login = txblogin.Text;
            String senha = txtbsenha.Text;
            if (login == "teste" && senha == "teste")
            {
                FormPrincipal formPrincipal = new FormPrincipal();
                formPrincipal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login ou senha incorreta! Tente novamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txblogin.Text = "";
                txtbsenha.Text = "";
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
