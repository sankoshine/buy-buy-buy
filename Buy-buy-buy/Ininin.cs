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
    public partial class Ininin : Form
    {
        public Ininin()
        {
            InitializeComponent();
        }

        private void Ininin_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“buy_buy_buyDataSet3.item_info”中。您可以根据需要移动或删除它。
            this.item_infoTableAdapter.Fill(this.buy_buy_buyDataSet3.item_info);
            // TODO: 这行代码将数据加载到表“buy_buy_buyDataSet2.consumer_info”中。您可以根据需要移动或删除它。
            this.consumer_infoTableAdapter.Fill(this.buy_buy_buyDataSet2.consumer_info);

        }



        private void button4_Click(object sender, EventArgs e)
        {
            string str = "Data Source=.;Initial Catalog=buy_buy_buy;Integrated Security=True";
            SqlConnection conn = new SqlConnection(str);
            conn.Open();
            string sql = "delete from item_info where item_id = " + comboBox2.SelectedValue.ToString();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close(); this.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = "Data Source=.;Initial Catalog=buy_buy_buy;Integrated Security=True";
            SqlConnection conn = new SqlConnection(str);
            conn.Open();
            try
            {
                string sql = "select * from item_info where item_id = " + comboBox2.SelectedValue.ToString();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                string stock = dr["item_stock"].ToString();
                label1.Text = "还剩：" + stock;
            }
            catch { }
            conn.Close();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = "Data Source=.;Initial Catalog=buy_buy_buy;Integrated Security=True";
            SqlConnection conn = new SqlConnection(str);
            conn.Open();
            string sql = "update item_info set item_stock = " + textBox1.Text + " where item_id = " + comboBox2.SelectedValue.ToString();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            sql = "select * from item_info where item_id = " + comboBox2.SelectedValue.ToString();
            cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            string stock = dr["item_stock"].ToString();
            conn.Close();
            label1.Text = "还剩：" + stock;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string str = "Data Source=.;Initial Catalog=buy_buy_buy;Integrated Security=True";
            SqlConnection conn = new SqlConnection(str);
            conn.Open();
            string sql = "insert into consumer_info(consumer_name) values ('" + textBox3.Text + "')";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string str = "Data Source=.;Initial Catalog=buy_buy_buy;Integrated Security=True";
            SqlConnection conn = new SqlConnection(str);
            conn.Open();
            string sql = "insert into item_info(item_name,item_stock) values ('" + textBox2.Text + "',0)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            this.Close();
        }
    }
}
