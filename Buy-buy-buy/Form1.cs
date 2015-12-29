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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“buy_buy_buyDataSet.consumer_info”中。您可以根据需要移动或删除它。
            this.consumer_infoTableAdapter.Fill(this.buy_buy_buyDataSet.consumer_info);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Order().Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            new detail().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Ininin().Show();
        }

    }
}
