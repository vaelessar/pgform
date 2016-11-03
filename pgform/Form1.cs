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

        const string constring = "Host=localhost;Username=postgres;Password=123;Database=tehzad";
        string query;

        public void Form1_Load(object sender, EventArgs e)
        {
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var connection = new NpgsqlConnection(constring);
            connection.Open();
            connection.Close();
            query = $"SELECT quest, client FROM public.zakaz WHERE nomer={tBID.Text};";
            connection.Open();
            var command = new NpgsqlCommand(query, connection);
            var reader = command.ExecuteReader();
            if (reader.Read())
            {
                tBQuest.Text = $@"{reader[0]}";
                tBCust.Text = $@"{reader[1]}";
            }
            else MessageBox.Show("Ошибка чтения данных из базы.\nПопробуйте ещё раз.");
            connection.Close();
            connection.Open();
            command.CommandText = $"SELECT one, two, drei, four, five, six, seven, art, nine, ten FROM public.simpledata WHERE nomer={tBID.Text};";
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                tB1.Text = $@"{reader[0]}";
                tB2.Text = $@"{reader[1]}";
                tB3.Text = $@"{reader[2]}";
                tB4.Text = $@"{reader[3]}";
                tB5.Text = $@"{reader[4]}";
                tB6.Text = $@"{reader[5]}";
                tB7.Text = $@"{reader[6]}";
                richTextBox1.Text = $@"{reader[7]}";
                richTextBox2.Text = $@"{reader[8]}";
                richTextBox3.Text = $@"{reader[9]}";
            }
            else MessageBox.Show("Ошибка чтения данных из базы.\nПопробуйте ещё раз.");
            connection.Close();
        }
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)//сохраняет/обновляет данные на серевере
        {
            query = $"SELECT * FROM public.zakaz WHERE nomer={tBID.Text}";
            var connection = new NpgsqlConnection(constring);
            var command = new NpgsqlCommand(query, connection);
            connection.Open();
            var reader = command.ExecuteReader();
            if (reader.Read())
            {
                command.CommandText =
                    $"UPDATE public.zakaz SET quest='{tBQuest.Text}', client='{tBCust.Text}' WHERE nomer={tBID.Text};";
                command.CommandText +=
                    $"UPDATE public.simpledata SET one='{tB1.Text}', two='{tB2.Text}', drei='{tB3.Text}', four='{tB4.Text}', five='{tB5.Text}', six='{tB6.Text}', seven='{tB7.Text}', art='{richTextBox1.Text}', nine='{richTextBox2.Text}', ten='{richTextBox3.Text}' WHERE nomer={tBID.Text};";
            }
            else
            {
                command.CommandText =
                    $"INSERT INTO public.zakaz(nomer, quest, client) VALUES ({Convert.ToInt32(tBID.Text)}, '{tBQuest.Text}', '{tBCust.Text}');";
                command.CommandText +=
                    $"INSERT INTO public.simpledata(nomer, one, two, drei, four, five, six, seven, art, nine, ten) VALUES ({tBID.Text}, \'{tB1.Text}\', \'{tB2.Text}\', \'{tB3.Text}\', \'{tB4.Text}\', \'{tB5.Text}\', \'{tB6.Text}\', \'{tB7.Text}\', \'{richTextBox1.Text}\', \'{richTextBox2.Text}\', \'{richTextBox3.Text}\');";
            }
            connection.Close();
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}