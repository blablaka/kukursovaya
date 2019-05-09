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
    public partial class Registration : Form
    {
        SqlConnection sqlConnection;
        public Registration()
        {
            InitializeComponent();
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            string c = e.KeyChar.ToString();
            if ((!Regex.Match(c, @"\p{IsCyrillic}|\p{IsCyrillicSupplement}").Success) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            string c = e.KeyChar.ToString();
            if ((!Regex.Match(c, @"\p{IsCyrillic}|\p{IsCyrillicSupplement}").Success) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void TextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            string c = e.KeyChar.ToString();
            if ((!Regex.Match(c, @"[a-zA-Z]|,|\.|@||_|[0-9]").Success) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void TextBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            string c = e.KeyChar.ToString();
            if ((!Regex.Match(c, "[a-zA-Z]|[0-9]").Success) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void TextBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            string c = e.KeyChar.ToString();
            if ((!Regex.Match(c, "[a-zA-Z]|[0-9]").Success) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Сашка\Kursovaya\kukursovaya\kursach\Kursach\Kursach\kursach.mdf;Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "" && textBox4.Text == "" && textBox5.Text == "" && textBox6.Text == "") ||
               (textBox2.Text == "" && textBox3.Text == "" && textBox4.Text == "" && textBox5.Text == "" && textBox6.Text == "") ||
               (textBox2.Text == "" && textBox3.Text == "" && textBox4.Text == "" && textBox5.Text == "" && textBox6.Text == "") ||
               (textBox2.Text == "" && textBox3.Text == "" && textBox4.Text == "" && textBox5.Text == "" && textBox6.Text == "") ||
               (textBox2.Text == "" && textBox3.Text == "" && textBox4.Text == "" && textBox5.Text == "" && textBox6.Text == "") ||
               (textBox2.Text == "" && textBox3.Text == "" && textBox4.Text == "" && textBox5.Text == "" && textBox6.Text == "") ||
               (textBox2.Text == "" && textBox3.Text == "" && textBox4.Text == "" && textBox5.Text == "" && textBox6.Text == "") ||
               (textBox3.Text == "" && textBox4.Text == "" && textBox5.Text == "" && textBox6.Text == "") ||
               (textBox2.Text == "" && textBox4.Text == "" && textBox5.Text == "" && textBox6.Text == "") ||
               (textBox3.Text == "" && textBox2.Text == "" && textBox5.Text == "" && textBox6.Text == "") ||
               (textBox3.Text == "" && textBox4.Text == "" && textBox2.Text == "" && textBox6.Text == "") ||
               (textBox3.Text == "" && textBox4.Text == "" && textBox5.Text == "" && textBox2.Text == "") ||
               (textBox1.Text == "" && textBox4.Text == "" && textBox5.Text == "" && textBox6.Text == "") ||
               (textBox3.Text == "" && textBox1.Text == "" && textBox5.Text == "" && textBox6.Text == "") ||
               (textBox3.Text == "" && textBox4.Text == "" && textBox1.Text == "" && textBox6.Text == "") ||
               (textBox3.Text == "" && textBox4.Text == "" && textBox5.Text == "" && textBox1.Text == "") ||
               (textBox1.Text == "" && textBox2.Text == "" && textBox5.Text == "" && textBox6.Text == "") ||
               (textBox1.Text == "" && textBox4.Text == "" && textBox2.Text == "" && textBox6.Text == "") ||
               (textBox1.Text == "" && textBox4.Text == "" && textBox5.Text == "" && textBox2.Text == "") ||
               (textBox3.Text == "" && textBox1.Text == "" && textBox2.Text == "" && textBox6.Text == "") ||
               (textBox3.Text == "" && textBox1.Text == "" && textBox5.Text == "" && textBox2.Text == "") ||
               (textBox3.Text == "" && textBox4.Text == "" && textBox1.Text == "" && textBox2.Text == "") ||
               (textBox6.Text == "" && textBox4.Text == "" && textBox5.Text == "") ||
               (textBox3.Text == "" && textBox5.Text == "" && textBox6.Text == "") ||
               (textBox3.Text == "" && textBox4.Text == "" && textBox6.Text == "") ||
               (textBox3.Text == "" && textBox6.Text == "" && textBox5.Text == "") ||
               (textBox5.Text == "" && textBox6.Text == "" && textBox1.Text == "") ||
               (textBox6.Text == "" && textBox4.Text == "" && textBox1.Text == "") ||
               (textBox5.Text == "" && textBox4.Text == "" && textBox1.Text == "") ||
               (textBox2.Text == "" && textBox6.Text == "" && textBox1.Text == "") ||
               (textBox2.Text == "" && textBox5.Text == "" && textBox1.Text == "") ||
               (textBox3.Text == "" && textBox2.Text == "" && textBox1.Text == "") ||
               (textBox5.Text == "" && textBox6.Text == "") ||
               (textBox4.Text == "" && textBox6.Text == "") ||
               (textBox4.Text == "" && textBox5.Text == "") ||
               (textBox1.Text == "" && textBox6.Text == "") ||
               (textBox1.Text == "" && textBox5.Text == "") ||
               (textBox1.Text == "" && textBox2.Text == "") ||
               (textBox6.Text == "") ||
               (textBox5.Text == "") ||
               (textBox1.Text == ""))
            {
                MessageBox.Show("Вы не заполнили все поля!");
            }
            if ((textBox6.Text != textBox5.Text))
            {
                MessageBox.Show("Неправильный пароль");
            }
            else if ((textBox6.Text == textBox5.Text) && (textBox6.Text != "" && textBox5.Text != "")) //занесение данных в БД
            {
                try
                {
                    SqlCommand command = new SqlCommand("INSERT INTO Registration(Имя, Фамилия, Email, Логин, Пароль) VALUES(@Имя, @Фамилия, @Email, @Логин, @Пароль)", sqlConnection);
                    command.Parameters.AddWithValue("Имя", textBox1.Text);
                    command.Parameters.AddWithValue("Фамилия", textBox2.Text);
                    command.Parameters.AddWithValue("Email", textBox3.Text);
                    command.Parameters.AddWithValue("Логин", textBox4.Text);
                    command.Parameters.AddWithValue("Пароль", textBox5.Text);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Данные добавлены!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Registration_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
                sqlConnection.Close();
        }
    }
}
