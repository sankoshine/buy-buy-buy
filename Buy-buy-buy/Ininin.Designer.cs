namespace Buy_buy_buy
{
    partial class Ininin
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.iteminfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buy_buy_buyDataSet3 = new Buy_buy_buy.buy_buy_buyDataSet3();
            this.buy_buy_buyDataSet2 = new Buy_buy_buy.buy_buy_buyDataSet2();
            this.consumerinfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.consumer_infoTableAdapter = new Buy_buy_buy.buy_buy_buyDataSet2TableAdapters.consumer_infoTableAdapter();
            this.item_infoTableAdapter = new Buy_buy_buy.buy_buy_buyDataSet3TableAdapters.item_infoTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iteminfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buy_buy_buyDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buy_buy_buyDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consumerinfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(224, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "库存";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.iteminfoBindingSource;
            this.comboBox2.DisplayMember = "item_name";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(86, 102);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(100, 20);
            this.comboBox2.TabIndex = 6;
            this.comboBox2.ValueMember = "item_id";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // iteminfoBindingSource
            // 
            this.iteminfoBindingSource.DataMember = "item_info";
            this.iteminfoBindingSource.DataSource = this.buy_buy_buyDataSet3;
            // 
            // buy_buy_buyDataSet3
            // 
            this.buy_buy_buyDataSet3.DataSetName = "buy_buy_buyDataSet3";
            this.buy_buy_buyDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buy_buy_buyDataSet2
            // 
            this.buy_buy_buyDataSet2.DataSetName = "buy_buy_buyDataSet2";
            this.buy_buy_buyDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // consumerinfoBindingSource
            // 
            this.consumerinfoBindingSource.DataMember = "consumer_info";
            this.consumerinfoBindingSource.DataSource = this.buy_buy_buyDataSet2;
            // 
            // consumer_infoTableAdapter
            // 
            this.consumer_infoTableAdapter.ClearBeforeFill = true;
            // 
            // item_infoTableAdapter
            // 
            this.item_infoTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(86, 149);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(211, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "改库存";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(211, 57);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "新货上架";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(211, 22);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 13;
            this.button5.Text = "新的顾客";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(86, 57);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 12;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(86, 22);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 21);
            this.textBox3.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 15;
            this.label2.Text = "顾客姓名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 16;
            this.label3.Text = "商品名称";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 17;
            this.label4.Text = "选择商品";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 18;
            this.label5.Text = "库存数量";
            // 
            // Ininin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 188);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label1);
            this.Name = "Ininin";
            this.Text = "Ininin";
            this.Load += new System.EventHandler(this.Ininin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iteminfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buy_buy_buyDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buy_buy_buyDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consumerinfoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private buy_buy_buyDataSet2 buy_buy_buyDataSet2;
        private System.Windows.Forms.BindingSource consumerinfoBindingSource;
        private buy_buy_buyDataSet2TableAdapters.consumer_infoTableAdapter consumer_infoTableAdapter;
        private buy_buy_buyDataSet3 buy_buy_buyDataSet3;
        private System.Windows.Forms.BindingSource iteminfoBindingSource;
        private buy_buy_buyDataSet3TableAdapters.item_infoTableAdapter item_infoTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}