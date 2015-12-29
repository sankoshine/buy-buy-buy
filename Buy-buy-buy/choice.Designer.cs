namespace Buy_buy_buy
{
    partial class choice
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
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buy_buy_buyDataSet = new Buy_buy_buy.buy_buy_buyDataSet();
            this.iteminfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.item_infoTableAdapter = new Buy_buy_buy.buy_buy_buyDataSetTableAdapters.item_infoTableAdapter();
            this.buy_buy_buyDataSet1 = new Buy_buy_buy.buy_buy_buyDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buy_buy_buyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iteminfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buy_buy_buyDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(25, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "库存不足";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "推荐购买以下商品：";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // buy_buy_buyDataSet
            // 
            this.buy_buy_buyDataSet.DataSetName = "buy_buy_buyDataSet";
            this.buy_buy_buyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iteminfoBindingSource
            // 
            this.iteminfoBindingSource.DataMember = "item_info";
            this.iteminfoBindingSource.DataSource = this.buy_buy_buyDataSet;
            // 
            // item_infoTableAdapter
            // 
            this.item_infoTableAdapter.ClearBeforeFill = true;
            // 
            // buy_buy_buyDataSet1
            // 
            this.buy_buy_buyDataSet1.DataSetName = "buy_buy_buyDataSet";
            this.buy_buy_buyDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // choice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "choice";
            this.Text = "choice";
            this.Load += new System.EventHandler(this.choice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buy_buy_buyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iteminfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buy_buy_buyDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private buy_buy_buyDataSet buy_buy_buyDataSet;
        private System.Windows.Forms.BindingSource iteminfoBindingSource;
        private buy_buy_buyDataSetTableAdapters.item_infoTableAdapter item_infoTableAdapter;
        private buy_buy_buyDataSet buy_buy_buyDataSet1;
    }
}