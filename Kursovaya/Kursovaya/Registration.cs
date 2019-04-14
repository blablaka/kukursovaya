using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursovaya
{
    public partial class Registration : Form
    {
        SqlConnection sqlConnection;
        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Сашка\Kursovaya\kukursovaya\Kursovaya\Kursovaya\Database1.mdf;Integrated Security=True";

            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            string c = e.KeyChar.ToString();
            if ((!Regex.Match(c, @"\p{IsCyrillic}|\p{IsCyrillicSupplement}").Success) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            string c = e.KeyChar.ToString();
            if ((!Regex.Match(c, @"\p{IsCyrillic}|\p{IsCyrillicSupplement}").Success) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            string c = e.KeyChar.ToString();
            if ((!Regex.Match(c, @"[a-zA-Z]|,|\.|@|[0-9]").Success) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            string c = e.KeyChar.ToString();
            if ((!Regex.Match(c, "[a-zA-Z]|[0-9]").Success) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            string c = e.KeyChar.ToString();
            if ((!Regex.Match(c, "[a-zA-Z]|[0-9]").Success) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*if ((textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "" && textBox4.Text == "" && textBox5.Text == "" && textBox6.Text == "") ||
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
               (textBox2.Text == "" && textBox1.Text == "" && textBox5.Text == "" && textBox6.Text == "") ||
               (textBox3.Text == "" && textBox4.Text == "" && textBox1.Text == "" && textBox6.Text == "") ||
               (textBox3.Text == "" && textBox4.Text == "" && textBox5.Text == "" && textBox1.Text == "") ||
               (textBox3.Text == "" && textBox4.Text == "" && textBox5.Text == "" && textBox6.Text == "") ||
               (textBox3.Text == "" && textBox4.Text == "" && textBox5.Text == "" && textBox6.Text == "") ||
               (textBox3.Text == "" && textBox4.Text == "" && textBox5.Text == "" && textBox6.Text == "") ||
               (textBox3.Text == "" && textBox4.Text == "" && textBox5.Text == "" && textBox6.Text == "") ||
               (textBox3.Text == "" && textBox4.Text == "" && textBox5.Text == "" && textBox6.Text == "") ||
               (textBox3.Text == "" && textBox4.Text == "" && textBox5.Text == "" && textBox6.Text == ""))
            {
                MessageBox.Show("Вы не заполнили все поля!");
            }
            if (textBox5.Text != textBox4.Text)
            {
                MessageBox.Show("Неправильный пароль");
            }*/
            /*if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox1.Text) &&
                !string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrEmpty(textBox2.Text) &&
                !string.IsNullOrEmpty(textBox3.Text) && !string.IsNullOrEmpty(textBox3.Text) &&
                !string.IsNullOrEmpty(textBox4.Text) && !string.IsNullOrEmpty(textBox4.Text) &&
                !string.IsNullOrEmpty(textBox6.Text) && !string.IsNullOrEmpty(textBox6.Text) &&
                !string.IsNullOrEmpty(textBox5.Text) && !string.IsNullOrEmpty(textBox5.Text))*/
            {
                //sqlConnection.Open();
                
                    SqlCommand command = new SqlCommand("INSERT INTO [Registration] (Имя, Фамилия, E-mail, Логин, Пароль, Повторите пароль)VALUES(@Имя, @Фамилия, @E-mail, @Логин, @Пароль, @Повторите пароль)", sqlConnection);
                    

                    command.Parameters.AddWithValue("Имя", textBox1.Text);

                    command.Parameters.AddWithValue("Фамилия", textBox2.Text);

                    command.Parameters.AddWithValue("E-mail", textBox6.Text);

                    command.Parameters.AddWithValue("Логин", textBox3.Text);

                    command.Parameters.AddWithValue("Пароль", textBox4.Text);

                    command.Parameters.AddWithValue("Повторите пароль", textBox5.Text);

                    
               

                command.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }

        private void Registration_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
                sqlConnection.Close();
        }
    }
}
