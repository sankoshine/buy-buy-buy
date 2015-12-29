namespace Buy_buy_buy
{
    partial class Order
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.iteminfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buybuybuyDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buy_buy_buyDataSet = new Buy_buy_buy.buy_buy_buyDataSet();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.consumerinfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.consumer_infoTableAdapter = new Buy_buy_buy.buy_buy_buyDataSetTableAdapters.consumer_infoTableAdapter();
            this.selected = new System.Windows.Forms.DataGridView();
            this.orderdetailBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.orderdetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.order_detailTableAdapter = new Buy_buy_buy.buy_buy_buyDataSetTableAdapters.order_detailTableAdapter();
            this.orderdetailBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.item_infoTableAdapter = new Buy_buy_buy.buy_buy_buyDataSetTableAdapters.item_infoTableAdapter();
            this.consumerinfoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.payinfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buy_buy_buyDataSet1 = new Buy_buy_buy.buy_buy_buyDataSet1();
            this.buybuybuyDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pay_infoTableAdapter = new Buy_buy_buy.buy_buy_buyDataSet1TableAdapters.pay_infoTableAdapter();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iteminfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buybuybuyDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buy_buy_buyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consumerinfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selected)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderdetailBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderdetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderdetailBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consumerinfoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payinfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buy_buy_buyDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buybuybuyDataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.iteminfoBindingSource;
            this.comboBox1.DisplayMember = "item_name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(86, 114);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 20);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "item_id";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // iteminfoBindingSource
            // 
            this.iteminfoBindingSource.DataMember = "item_info";
            this.iteminfoBindingSource.DataSource = this.buybuybuyDataSetBindingSource;
            // 
            // buybuybuyDataSetBindingSource
            // 
            this.buybuybuyDataSetBindingSource.DataSource = this.buy_buy_buyDataSet;
            this.buybuybuyDataSetBindingSource.Position = 0;
            // 
            // buy_buy_buyDataSet
            // 
            this.buy_buy_buyDataSet.DataSetName = "buy_buy_buyDataSet";
            this.buy_buy_buyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(86, 151);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(67, 21);
            this.textBox1.TabIndex = 1;
            // 
            // consumerinfoBindingSource
            // 
            this.consumerinfoBindingSource.DataMember = "consumer_info";
            this.consumerinfoBindingSource.DataSource = this.buybuybuyDataSetBindingSource;
            // 
            // consumer_infoTableAdapter
            // 
            this.consumer_infoTableAdapter.ClearBeforeFill = true;
            // 
            // selected
            // 
            this.selected.AllowUserToAddRows = false;
            this.selected.AllowUserToDeleteRows = false;
            this.selected.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.selected.Location = new System.Drawing.Point(250, 73);
            this.selected.Name = "selected";
            this.selected.ReadOnly = true;
            this.selected.RowTemplate.Height = 23;
            this.selected.Size = new System.Drawing.Size(257, 150);
            this.selected.TabIndex = 2;
            // 
            // orderdetailBindingSource2
            // 
            this.orderdetailBindingSource2.DataMember = "order_detail";
            this.orderdetailBindingSource2.DataSource = this.buybuybuyDataSetBindingSource;
            // 
            // orderdetailBindingSource
            // 
            this.orderdetailBindingSource.DataMember = "order_detail";
            this.orderdetailBindingSource.DataSource = this.buybuybuyDataSetBindingSource;
            // 
            // order_detailTableAdapter
            // 
            this.order_detailTableAdapter.ClearBeforeFill = true;
            // 
            // orderdetailBindingSource1
            // 
            this.orderdetailBindingSource1.DataMember = "order_detail";
            this.orderdetailBindingSource1.DataSource = this.buybuybuyDataSetBindingSource;
            // 
            // item_infoTableAdapter
            // 
            this.item_infoTableAdapter.ClearBeforeFill = true;
            // 
            // consumerinfoBindingSource1
            // 
            this.consumerinfoBindingSource1.DataMember = "consumer_info";
            this.consumerinfoBindingSource1.DataSource = this.buybuybuyDataSetBindingSource;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 27);
            this.button1.TabIndex = 3;
            this.button1.Text = "加";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "订单号";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(86, 13);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "服务员";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(86, 40);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 21);
            this.textBox3.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "商品";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "消费者";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "数量";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.consumerinfoBindingSource1;
            this.comboBox2.DisplayMember = "consumer_name";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(86, 73);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(100, 20);
            this.comboBox2.TabIndex = 11;
            this.comboBox2.ValueMember = "consumer_id";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(380, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "保存信息";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(211, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 13;
            this.label6.Text = "支付方式";
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.payinfoBindingSource;
            this.comboBox3.DisplayMember = "pay_name";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(213, 40);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 20);
            this.comboBox3.TabIndex = 14;
            this.comboBox3.ValueMember = "pay_id";
            // 
            // payinfoBindingSource
            // 
            this.payinfoBindingSource.DataMember = "pay_info";
            this.payinfoBindingSource.DataSource = this.buy_buy_buyDataSet1;
            // 
            // buy_buy_buyDataSet1
            // 
            this.buy_buy_buyDataSet1.DataSetName = "buy_buy_buyDataSet1";
            this.buy_buy_buyDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buybuybuyDataSetBindingSource1
            // 
            this.buybuybuyDataSetBindingSource1.DataSource = this.buy_buy_buyDataSet;
            this.buybuybuyDataSetBindingSource1.Position = 0;
            // 
            // pay_infoTableAdapter
            // 
            this.pay_infoTableAdapter.ClearBeforeFill = true;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(519, 320);
            this.shapeContainer1.TabIndex = 15;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 25;
            this.lineShape1.X2 = 239;
            this.lineShape1.Y1 = 100;
            this.lineShape1.Y2 = 100;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(160, 254);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(174, 54);
            this.button3.TabIndex = 16;
            this.button3.Text = "确认订单";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(101, 195);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(52, 28);
            this.button4.TabIndex = 17;
            this.button4.Text = "改";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(171, 195);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(49, 28);
            this.button5.TabIndex = 18;
            this.button5.Text = "删";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(192, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 19;
            this.label7.Text = "库存";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(169, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 12);
            this.label8.TabIndex = 20;
            this.label8.Text = "剩";
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 320);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.selected);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "Order";
            this.Text = "din";
            this.Load += new System.EventHandler(this.Order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iteminfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buybuybuyDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buy_buy_buyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consumerinfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selected)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderdetailBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderdetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderdetailBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consumerinfoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payinfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buy_buy_buyDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buybuybuyDataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource buybuybuyDataSetBindingSource;
        private buy_buy_buyDataSet buy_buy_buyDataSet;
        private System.Windows.Forms.BindingSource consumerinfoBindingSource;
        private buy_buy_buyDataSetTableAdapters.consumer_infoTableAdapter consumer_infoTableAdapter;
        private System.Windows.Forms.DataGridView selected;
        private System.Windows.Forms.BindingSource orderdetailBindingSource;
        private buy_buy_buyDataSetTableAdapters.order_detailTableAdapter order_detailTableAdapter;
        private System.Windows.Forms.BindingSource orderdetailBindingSource1;
        private System.Windows.Forms.BindingSource iteminfoBindingSource;
        private buy_buy_buyDataSetTableAdapters.item_infoTableAdapter item_infoTableAdapter;
        private System.Windows.Forms.BindingSource orderdetailBindingSource2;
        private System.Windows.Forms.BindingSource consumerinfoBindingSource1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.BindingSource buybuybuyDataSetBindingSource1;
        private buy_buy_buyDataSet1 buy_buy_buyDataSet1;
        private System.Windows.Forms.BindingSource payinfoBindingSource;
        private buy_buy_buyDataSet1TableAdapters.pay_infoTableAdapter pay_infoTableAdapter;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;



    }
}