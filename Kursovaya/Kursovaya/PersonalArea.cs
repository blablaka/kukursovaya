using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursovaya
{
    public partial class PersonalArea : Form
    {
        public string asd;
        public PersonalArea()
        {
            InitializeComponent();
        }
        public static Label l;

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void PersonalArea_Load(object sender, EventArgs e)
        {
            
        }

        private void PersonalArea_Activated(object sender, EventArgs e)
        {
            label2.Text = asd;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }
    }
}
