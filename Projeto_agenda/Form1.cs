using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Projeto_agenda
{
    public partial class Form1 : Form
    {
        MySqlConnection conexao = new MySqlConnection("server = localhost; uid = root; pwd = ''; database = Agenda");
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlCommand comando = new MySqlCommand ("insert into pessoa(nome, email, telefone)values(" +
                "'" + textBox1.Text + "','"
                + textBox2.Text + "','"
                + textBox3.Text + "')", conexao);
            conexao.Open();
            comando.ExecuteReader();
            MessageBox.Show("Cadastrado com sucesso!");
        }
    }
}