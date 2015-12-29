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
    public partial class detail : Form
    {
        public detail()
        {
            InitializeComponent();
        }

        private void detail_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“buy_buy_buyDataSet.order_info”中。您可以根据需要移动或删除它。
            this.order_infoTableAdapter.Fill(this.buy_buy_buyDataSet.order_info);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = "Data Source=.;Initial Catalog=buy_buy_buy;Integrated Security=True";
            SqlConnection conn = new SqlConnection(str);
            conn.Open();
            string oid = comboBox1.SelectedValue.ToString();
            string sql = "select * from order_info where order_id = " + oid;
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            string staff = dr["staff"].ToString();
            sql = "select * from consumer_info where consumer_id = " + dr["consumer_id"].ToString();
            string sql2 = "select * from pay_info where pay_id = " + dr["pay_id"].ToString();
            conn.Close();
            conn.Open();
            cmd = new SqlCommand(sql, conn);
            dr = cmd.ExecuteReader();
            dr.Read();
            string consumer_name = dr["consumer_name"].ToString();
            conn.Close();
            conn.Open();
            cmd = new SqlCommand(sql2, conn);
            dr = cmd.ExecuteReader();
            dr.Read();
            string pay = dr["pay_name"].ToString();
            conn.Close();
            str = "";
            str += "订单号：";
            str += oid;
            str += "\n服务员：";
            str += staff;
            str += "\n消费者：";
            str += consumer_name;
            str += "\n支付方式：";
            str += pay;
            label1.Text = str;


            conn.Open();
            sql = "select item_name as '商品名', item_quantity as '数量' from item_info, order_detail where item_info.item_id = order_detail.item_id and order_detail.order_id = " + oid;
            cmd = new SqlCommand(sql, conn);
            SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            conn.Close();
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
    }
}
