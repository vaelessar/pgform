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
        string constring = "Host=localhost;Username=postgres;Password=123;Database=tehzad";
        string query;
        public void Form1_Load(object sender, EventArgs e)
        {
        }
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var connection = new NpgsqlConnection(constring);
            var command = new NpgsqlCommand(query, connection);
            connection.Open();
            command.CommandText = $"INSERT INTO public.zakaz(nomer, quest, client) VALUES ({Convert.ToInt32(tBID.Text)}, '{tBQuest.Text}', '{tBCust.Text}');";
            var writer = command.ExecuteNonQuery();
            command.CommandText = $"INSERT INTO public.simpledata(nomer, one, two, drei, four, five, six, seven, art, nine, ten) VALUES ({tBID.Text}, '{tB1.Text}', '{tB2.Text}', '{tB3.Text}', '{tB4.Text}', '{tB5.Text}', '{tB6.Text}', '{tB7.Text}', '{richTextBox1.Text}', '{richTextBox2.Text}', '{richTextBox3.Text}');";
            writer = command.ExecuteNonQuery();
            connection.Close();
        }
    }
}