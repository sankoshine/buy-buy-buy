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
    public partial class Order : Form
    {
        private static string order_id = null;

        public Order()
        {
            InitializeComponent();
        }

        private void Order_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“buy_buy_buyDataSet1.pay_info”中。您可以根据需要移动或删除它。
            this.pay_infoTableAdapter.Fill(this.buy_buy_buyDataSet1.pay_info);
            // TODO: 这行代码将数据加载到表“buy_buy_buyDataSet.item_info”中。您可以根据需要移动或删除它。
            this.item_infoTableAdapter.Fill(this.buy_buy_buyDataSet.item_info);
            // TODO: 这行代码将数据加载到表“buy_buy_buyDataSet.order_detail”中。您可以根据需要移动或删除它。
            this.order_detailTableAdapter.Fill(this.buy_buy_buyDataSet.order_detail);
            // TODO: 这行代码将数据加载到表“buy_buy_buyDataSet.consumer_info”中。您可以根据需要移动或删除它。
            this.consumer_infoTableAdapter.Fill(this.buy_buy_buyDataSet.consumer_info);

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                MessageBox.Show("先保存基本信息");
                return;
            }
            string str = "Data Source=.;Initial Catalog=buy_buy_buy;Integrated Security=True";
            SqlConnection conn = new SqlConnection(str);
            conn.Open();
            string sql = "select item_stock from item_info where item_id = " + comboBox1.SelectedValue.ToString();
            SqlCommand cmd = new SqlCommand(sql, conn);
            string stock = cmd.ExecuteScalar().ToString();
            if (int.Parse(stock) >= int.Parse(textBox1.Text))
            {
                sql = "insert into order_detail(order_id,item_id,item_quantity) values (" + Order.order_id + "," + comboBox1.SelectedValue.ToString() + "," + textBox1.Text + ")";
                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                int curr = int.Parse(stock) - int.Parse(textBox1.Text);
                sql = "update item_info set item_stock = " + curr + " where item_id = " + comboBox1.SelectedValue.ToString();
                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                label7.Text = curr.ToString();
            }
            else
            {
                new choice().Show();
            }
            sql = "select item_name as '商品名', item_quantity as '数量' from item_info, order_detail where item_info.item_id = order_detail.item_id and order_detail.order_id = "+ Order.order_id;
            cmd = new SqlCommand(sql, conn);
            SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            conn.Close();
            selected.DataSource = ds.Tables[0].DefaultView;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string str = "Data Source=.;Initial Catalog=buy_buy_buy;Integrated Security=True";
            SqlConnection conn = new SqlConnection(str);
            string cid = comboBox2.SelectedValue.ToString();
            string staff = textBox3.Text;
            DateTime now = DateTime.Now;
            string time = "'" + now.ToString("yyyy-MM-dd HH:mm:ss") + ".000'";
            string pay_id = comboBox3.SelectedValue.ToString();
            string sql = "insert into order_info (consumer_id,staff,order_time,pay_id) values (" + cid + ",'" + staff + "'," + time + "," + pay_id + ")";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            sql = "select MAX(order_id) from order_info";
            cmd = new SqlCommand(sql, conn);
            order_id = cmd.ExecuteScalar().ToString();
            conn.Close();
            textBox2.Text = order_id;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("正在支付……");
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                MessageBox.Show("先保存基本信息");
                return;
            }
            string str = "Data Source=.;Initial Catalog=buy_buy_buy;Integrated Security=True";
            SqlConnection conn = new SqlConnection(str);
            conn.Open();
            string sql = "select item_stock from item_info where item_id = " + comboBox1.SelectedValue.ToString();
            SqlCommand cmd = new SqlCommand(sql, conn);
            string stock = cmd.ExecuteScalar().ToString();
            sql = "select item_quantity from order_detail where order_id = " + Order.order_id + " and item_id = " + comboBox1.SelectedValue.ToString();
            cmd = new SqlCommand(sql, conn);
            string before = cmd.ExecuteScalar().ToString();
            if (int.Parse(stock) >= int.Parse(textBox1.Text) - int.Parse(before))
            {
                sql = "update order_detail set item_quantity = "+textBox1.Text+" where order_id = "+Order.order_id+" and item_id = "+comboBox1.SelectedValue.ToString();
                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                int curr = int.Parse(stock) - int.Parse(textBox1.Text) + int.Parse(before);
                sql = "update item_info set item_stock = " + curr + " where item_id = " + comboBox1.SelectedValue.ToString();
                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                label7.Text = curr.ToString();
            }
            else
            {
                new choice().Show();
            }
            sql = "select item_name as '商品名', item_quantity as '数量' from item_info, order_detail where item_info.item_id = order_detail.item_id and order_detail.order_id = " + Order.order_id;
            cmd = new SqlCommand(sql, conn);
            SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            conn.Close();
            selected.DataSource = ds.Tables[0].DefaultView;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                MessageBox.Show("先保存基本信息");
                return;
            }
            string str = "Data Source=.;Initial Catalog=buy_buy_buy;Integrated Security=True";
            SqlConnection conn = new SqlConnection(str);
            conn.Open();
            string sql = "select item_quantity from order_detail where order_id = " + Order.order_id + " and item_id = " + comboBox1.SelectedValue.ToString();
            SqlCommand cmd = new SqlCommand(sql, conn);
            string before = cmd.ExecuteScalar().ToString();
            sql = "delete from order_detail where order_id = " + Order.order_id + " and item_id = " + comboBox1.SelectedValue.ToString();
            cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            int curr = int.Parse(before) + int.Parse(label7.Text);
            sql = "update item_info set item_stock = " + curr + " where item_id = " + comboBox1.SelectedValue.ToString();
            cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            label7.Text =  curr.ToString();
            sql = "select item_name as '商品名', item_quantity as '数量' from item_info, order_detail where item_info.item_id = order_detail.item_id and order_detail.order_id = " + Order.order_id;
            cmd = new SqlCommand(sql, conn);
            SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            conn.Close();
            selected.DataSource = ds.Tables[0].DefaultView;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = "Data Source=.;Initial Catalog=buy_buy_buy;Integrated Security=True";
            SqlConnection conn = new SqlConnection(str);
            conn.Open();
            try
            {
                string sql = "select item_stock from item_info where item_id = " + comboBox1.SelectedValue.ToString();
                SqlCommand cmd = new SqlCommand(sql, conn);
                string stock = cmd.ExecuteScalar().ToString();
                label7.Text =  stock;
            }
            catch { }
            conn.Close();
        }
    }
}
