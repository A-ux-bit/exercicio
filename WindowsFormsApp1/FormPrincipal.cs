using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formusuario formusuario = new Formusuario();
            formusuario.Show();
        }

        private void testeDeBancoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                String str = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Programas\\SisLanchonete2\\DbLanchonete.mdf;Integrated Security=True";
                String query = "SELECT * FROM Usuario";
                SqlConnection con = new SqlConnection(str);
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                DataSet ds = new DataSet();
                MessageBox.Show("Conectado ao Banco de Dados!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Erro de Acesso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
