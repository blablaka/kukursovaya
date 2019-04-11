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
        Button b;
        public Form1()
        {
            InitializeComponent();
            {
                b = new Button();
                this.Controls.Add(b);
                this.b.Click += new System.EventHandler(this.bu_Click);
            }
        }
        private void bu_Click(object sender, EventArgs e)
        {
            PersonalArea.l.Text = "новый текст";
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
            PersonalArea frm = new PersonalArea();
            frm.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
