using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursach
{
    public partial class Form1 : Form
    {
        SqlConnection sqlConnection;
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox3.MaxLength = 2;
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 46) // цифры, клавиша BackSpace и запятая
            {
                e.Handled = true;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Result frm = new Result();
            frm.Show();
            this.Hide();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Registration frm = new Registration();
            frm.Show();
            this.Hide();
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            string c = e.KeyChar.ToString();
            if ((!Regex.Match(c, "[a-zA-Z]|[0-9]").Success) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            string c = e.KeyChar.ToString();
            if ((!Regex.Match(c, "[a-zA-Z]|[0-9]").Success) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (label4.Visible)
                label4.Visible = false;


            //Проверка введенного логина и пароля


            string query = "SELECT * FROM Registration WHERE Логин = '" + textBox1.Text.Trim() + "' AND Пароль = '" + textBox2.Text.Trim() + "'";
            SqlDataAdapter sqlDA = new SqlDataAdapter(query, sqlConnection);
            DataTable dT = new DataTable();
            sqlDA.Fill(dT);
            if (dT.Rows.Count == 1)
            {
                PersonalArea frm = new PersonalArea
                {
                    asd = textBox2.Text
                };
                frm.Show();
                this.Hide();
            }
            else if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox1.Text))
            {
                label4.Visible = true;

                label4.Text = "Поле 'Логин' должно быть заполнен!";
            }
            else if (!string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrEmpty(textBox2.Text))
            {
                label4.Visible = true;

                label4.Text = "Введите пароль!";
            }
            else
            {
                label4.Visible = true;

                label4.Text = "Поля 'Пароль' и 'Логин' должны быть заполнены";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursachDataSet.Wall". При необходимости она может быть перемещена или удалена.
            this.wallTableAdapter.Fill(this.kursachDataSet.Wall);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursachDataSet.Room". При необходимости она может быть перемещена или удалена.
            this.roomTableAdapter.Fill(this.kursachDataSet.Room);
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Сашка\Kursovaya\kukursovaya\kursach\Kursach\Kursach\kursach.mdf;Integrated Security=True";

            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            dataGridView2.Visible = true;
        }
    }
}
