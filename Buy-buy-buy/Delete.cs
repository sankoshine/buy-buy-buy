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

namespace Buy_buy_buy
{
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = "Data Source=.;Initial Catalog=buy_buy_buy;Integrated Security=True";
            SqlConnection conn = new SqlConnection(str);
            conn.Open();
            string sql = "insert into consumer_info(consumer_name) values ('" + textBox1.Text + "')";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string str = "Data Source=.;Initial Catalog=buy_buy_buy;Integrated Security=True";
            SqlConnection conn = new SqlConnection(str);
            conn.Open();
            string sql = "insert into item_info(item_name,item_stock) values ('" + textBox2.Text + "',0)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            textBox2.Clear();
        }
    }
}
