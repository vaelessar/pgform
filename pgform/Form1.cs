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
        string constring = "Host=localhost;Username=postgres;Password=123;Database=postgres";
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
            command.CommandText = $"SELECT id, quest, client FROM public.cust WHERE quest='{textBox10.Text}'";
            var reader = command.ExecuteReader();
            if (reader.Read()) query = (
                          $"UPDATE public.first SET one='{textBox1.Text}', two='{textBox2.Text}', drei='{textBox3.Text}', four='{textBox4.Text}', five='{textBox5.Text}', six='{textBox6.Text}', seven='{textBox7.Text}' WHERE quest='{textBox10.Text}';" +
                          $"UPDATE public.second SET text_one='{richTextBox1.Text}', text_two='{richTextBox2.Text}', text_three='{richTextBox3.Text}' WHERE quest='{textBox10.Text}';");
            else query = ($"INSERT INTO public.first(id_client, quest, one, two, drei, four, five, six, seven) VALUES ({textBox8.Text}, {textBox10.Text}, {textBox1.Text}, {textBox2.Text}, {textBox3.Text}, {textBox4.Text}, {textBox5.Text}, {textBox6.Text}, {textBox7.Text});\n" +
                          $"INSERT INTO public.second(quest, text_one, text_two, text_three) VALUES({textBox10.Text}, {richTextBox1.Text}, {richTextBox2.Text}, {richTextBox3.Text});");
            var write = command.ExecuteNonQuery();
            connection.Close();
        }
    }
}