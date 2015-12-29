namespace Buy_buy_buy
{
    partial class detail
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
            this.orderinfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buybuybuyDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buy_buy_buyDataSet = new Buy_buy_buy.buy_buy_buyDataSet();
            this.order_infoTableAdapter = new Buy_buy_buy.buy_buy_buyDataSetTableAdapters.order_infoTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.orderinfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buybuybuyDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buy_buy_buyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.orderinfoBindingSource;
            this.comboBox1.DisplayMember = "order_time";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(26, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(135, 20);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "order_id";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // orderinfoBindingSource
            // 
            this.orderinfoBindingSource.DataMember = "order_info";
            this.orderinfoBindingSource.DataSource = this.buybuybuyDataSetBindingSource;
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
            // order_infoTableAdapter
            // 
            this.order_infoTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 108);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(244, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "订单详情";
            // 
            // detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 272);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Name = "detail";
            this.Text = "detail";
            this.Load += new System.EventHandler(this.detail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderinfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buybuybuyDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buy_buy_buyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource buybuybuyDataSetBindingSource;
        private buy_buy_buyDataSet buy_buy_buyDataSet;
        private System.Windows.Forms.BindingSource orderinfoBindingSource;
        private buy_buy_buyDataSetTableAdapters.order_infoTableAdapter order_infoTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
    }
}