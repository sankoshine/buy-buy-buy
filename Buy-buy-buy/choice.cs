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
    public partial class choice : Form
    {
        public choice()
        {
            InitializeComponent();
        }

        private void choice_Load(object sender, EventArgs e)
        {
            string str = "Data Source=.;Initial Catalog=buy_buy_buy;Integrated Security=True";
            SqlConnection conn = new SqlConnection(str);
            conn.Open();
            string sql = "select item_name as '商品名称', item_stock as '库存数量' from item_info where item_stock > 0";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            conn.Close();
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }
    }
}
