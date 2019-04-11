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
        public PersonalArea()
        {
            InitializeComponent();
            l = new Label();
            l.Text = "текст";
            this.Controls.Add(PersonalArea.l);
        }
        public static Label l;

        private void button1_Click(object sender, EventArgs e)
        {
            l.Text = "новый текст";
        }

        private void PersonalArea_Load(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
        }
    }
}
