using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grishin
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection();
            conn.ConnectionString = "Data Source = . ; Initial Catalog = var1sql ; Integrated Security = true";
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("alex", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@street", SqlDbType.VarChar).Value = textBox1.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            selectlistBox.DataSource = dt;
            selectlistBox.DisplayMember = dt.Columns[0].ColumnName;
        }

        private void SelectlistBox_DoubleClick(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("chto-to", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            DataRowView dr = (DataRowView)selectlistBox.SelectedItem;
            cmd.Parameters.Add("@depname", SqlDbType.VarChar).Value = dr.Row.ItemArray[0].ToString();
            label4.Text = "Street:" + dr.Row.ItemArray[0].ToString();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
