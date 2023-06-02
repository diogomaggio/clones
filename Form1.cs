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
using Microsoft.Win32;

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConexao = new SqlConnection("Data Source = LAPTOP - J3ALPK85\\SQLEXPRESS; Initial Catalog = registro; Integrated Security = True");
            SqlCommand cmd = new SqlCommand("INSERT INTO Credenciais(login,senha,email)VALUES('" + txtUsuario.Text + "','" + txtSenha + "',)", sqlConexao);
            MessageBox.Show("INSERT INTO Credenciais(login,senha,email)VALUES('" + txtUsuario.Text + "','" + txtSenha.Text + "','" + txtEmail.Text + "')");
            try
            {
                sqlConexao.Open();
                cmd.ExecuteNonQuery();
                sqlConexao.Close();
                MessageBox.Show("Login criado com sucesso!");
            }
            catch
            {
                MessageBox.Show("Deu bosta!");

            }
        }
    }
}   
