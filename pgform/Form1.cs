using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;


namespace pgform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void Form1_Load(object sender, EventArgs e)
        {
            //
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string connestring = "Host=localhost;Username=postgres;Password=123;Database=postgres";
            var connection = new NpgsqlConnection(connestring);
            connection.Open();
            string query = $"SELECT * FROM testing WHERE login='' and pwd='';";
            var command = new NpgsqlCommand(query, connection);
            NpgsqlDataReader reader = command.ExecuteReader();
        }
    }
}