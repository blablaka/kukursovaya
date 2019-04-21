using Kursovaya;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursovaya
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            textBox1.MaxLength = 3;
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 46) // цифры, клавиша BackSpace и запятая
            {
                e.Handled = true;
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Result frm = new Result();
            frm.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Registration frm = new Registration();
            frm.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (label10.Visible)
                label10.Visible = false;
            if (!string.IsNullOrEmpty(textBox3.Text) && !string.IsNullOrEmpty(textBox3.Text) &&
                !string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrEmpty(textBox2.Text))
            {
                PersonalArea frm = new PersonalArea
                {
                    asd = textBox2.Text
                };
                frm.Show();
                this.Hide();
            }
            else if (!string.IsNullOrEmpty(textBox3.Text) && !string.IsNullOrEmpty(textBox3.Text))
            {
                label10.Visible = true;

                label10.Text = "Поле 'Логин' должно быть заполнен!";
            }
            else if (!string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrEmpty(textBox2.Text))
            {
                label10.Visible = true;

                label10.Text = "Введите пароль!";
            }
            else
            {
                label10.Visible = true;

                label10.Text = "Поля 'Пароль' и 'Логин' должны быть заполнены";
            }
            

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }
        private void textBox2_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            string c = e.KeyChar.ToString();
            if ((!Regex.Match(c, "[a-zA-Z]|[0-9]").Success) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            string c = e.KeyChar.ToString();
            if ((!Regex.Match(c, "[a-zA-Z]|[0-9]").Success) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
            
        }
        private void textBox2_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
    
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void tabPage4_Click_1(object sender, EventArgs e)
        {

        }
    }
}
