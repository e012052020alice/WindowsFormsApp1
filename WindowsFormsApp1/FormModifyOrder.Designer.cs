namespace WindowsFormsApp1
{
    partial class FormModifyOrder
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
            this.label4 = new System.Windows.Forms.Label();
            this.btn修改訂單 = new System.Windows.Forms.Button();
            this.btn取消訂單 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txt訂購時間 = new System.Windows.Forms.TextBox();
            this.txtI訂單編號 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn審核確認 = new System.Windows.Forms.Button();
            this.lblBookId = new System.Windows.Forms.Label();
            this.listView商品詳請 = new System.Windows.Forms.ListView();
            this.txt訂購人 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn延遲出貨 = new System.Windows.Forms.Button();
            this.cbox處理狀態 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(5, 189);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 35);
            this.label4.TabIndex = 95;
            this.label4.Text = "商品詳情";
            // 
            // btn修改訂單
            // 
            this.btn修改訂單.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn修改訂單.Location = new System.Drawing.Point(870, 497);
            this.btn修改訂單.Margin = new System.Windows.Forms.Padding(4);
            this.btn修改訂單.Name = "btn修改訂單";
            this.btn修改訂單.Size = new System.Drawing.Size(139, 38);
            this.btn修改訂單.TabIndex = 93;
            this.btn修改訂單.Text = "修改訂單";
            this.btn修改訂單.UseVisualStyleBackColor = true;
            this.btn修改訂單.Click += new System.EventHandler(this.btn修改訂單_Click);
            // 
            // btn取消訂單
            // 
            this.btn取消訂單.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn取消訂單.Location = new System.Drawing.Point(695, 497);
            this.btn取消訂單.Margin = new System.Windows.Forms.Padding(4);
            this.btn取消訂單.Name = "btn取消訂單";
            this.btn取消訂單.Size = new System.Drawing.Size(139, 36);
            this.btn取消訂單.TabIndex = 91;
            this.btn取消訂單.Text = "取消訂單";
            this.btn取消訂單.UseVisualStyleBackColor = true;
            this.btn取消訂單.Click += new System.EventHandler(this.btn取消訂單_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(566, 22);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 34);
            this.label8.TabIndex = 89;
            this.label8.Text = "處理狀態";
            // 
            // txt訂購時間
            // 
            this.txt訂購時間.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt訂購時間.Location = new System.Drawing.Point(147, 62);
            this.txt訂購時間.Margin = new System.Windows.Forms.Padding(4);
            this.txt訂購時間.Name = "txt訂購時間";
            this.txt訂購時間.ReadOnly = true;
            this.txt訂購時間.Size = new System.Drawing.Size(372, 47);
            this.txt訂購時間.TabIndex = 84;
            // 
            // txtI訂單編號
            // 
            this.txtI訂單編號.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtI訂單編號.Location = new System.Drawing.Point(147, 7);
            this.txtI訂單編號.Margin = new System.Windows.Forms.Padding(4);
            this.txtI訂單編號.Name = "txtI訂單編號";
            this.txtI訂單編號.ReadOnly = true;
            this.txtI訂單編號.Size = new System.Drawing.Size(222, 47);
            this.txtI訂單編號.TabIndex = 82;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(11, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 35);
            this.label1.TabIndex = 80;
            this.label1.Text = "訂購時間";
            // 
            // btn審核確認
            // 
            this.btn審核確認.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn審核確認.Location = new System.Drawing.Point(683, 73);
            this.btn審核確認.Margin = new System.Windows.Forms.Padding(4);
            this.btn審核確認.Name = "btn審核確認";
            this.btn審核確認.Size = new System.Drawing.Size(139, 40);
            this.btn審核確認.TabIndex = 78;
            this.btn審核確認.Text = "審核確認";
            this.btn審核確認.UseVisualStyleBackColor = true;
            this.btn審核確認.Click += new System.EventHandler(this.btn審核確認_Click);
            // 
            // lblBookId
            // 
            this.lblBookId.AutoSize = true;
            this.lblBookId.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblBookId.Location = new System.Drawing.Point(16, 14);
            this.lblBookId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookId.Name = "lblBookId";
            this.lblBookId.Size = new System.Drawing.Size(123, 34);
            this.lblBookId.TabIndex = 75;
            this.lblBookId.Text = "訂單編號";
            // 
            // listView商品詳請
            // 
            this.listView商品詳請.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listView商品詳請.HideSelection = false;
            this.listView商品詳請.Location = new System.Drawing.Point(22, 227);
            this.listView商品詳請.Name = "listView商品詳請";
            this.listView商品詳請.Size = new System.Drawing.Size(976, 244);
            this.listView商品詳請.TabIndex = 96;
            this.listView商品詳請.UseCompatibleStateImageBehavior = false;
            // 
            // txt訂購人
            // 
            this.txt訂購人.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt訂購人.Location = new System.Drawing.Point(147, 117);
            this.txt訂購人.Margin = new System.Windows.Forms.Padding(4);
            this.txt訂購人.Name = "txt訂購人";
            this.txt訂購人.ReadOnly = true;
            this.txt訂購人.Size = new System.Drawing.Size(222, 47);
            this.txt訂購人.TabIndex = 98;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(53, 124);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 34);
            this.label2.TabIndex = 97;
            this.label2.Text = "訂購人";
            // 
            // btn延遲出貨
            // 
            this.btn延遲出貨.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn延遲出貨.Location = new System.Drawing.Point(859, 72);
            this.btn延遲出貨.Margin = new System.Windows.Forms.Padding(4);
            this.btn延遲出貨.Name = "btn延遲出貨";
            this.btn延遲出貨.Size = new System.Drawing.Size(139, 40);
            this.btn延遲出貨.TabIndex = 99;
            this.btn延遲出貨.Text = "延遲出貨";
            this.btn延遲出貨.UseVisualStyleBackColor = true;
            this.btn延遲出貨.Visible = false;
            this.btn延遲出貨.Click += new System.EventHandler(this.btn延遲出貨_Click);
            // 
            // cbox處理狀態
            // 
            this.cbox處理狀態.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox處理狀態.Enabled = false;
            this.cbox處理狀態.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbox處理狀態.FormattingEnabled = true;
            this.cbox處理狀態.Location = new System.Drawing.Point(702, 23);
            this.cbox處理狀態.Name = "cbox處理狀態";
            this.cbox處理狀態.Size = new System.Drawing.Size(271, 42);
            this.cbox處理狀態.TabIndex = 90;
            this.cbox處理狀態.SelectedIndexChanged += new System.EventHandler(this.cbox處理狀態_SelectedIndexChanged);
            // 
            // FormModifyOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 548);
            this.Controls.Add(this.btn延遲出貨);
            this.Controls.Add(this.txt訂購人);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listView商品詳請);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn修改訂單);
            this.Controls.Add(this.btn取消訂單);
            this.Controls.Add(this.cbox處理狀態);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt訂購時間);
            this.Controls.Add(this.txtI訂單編號);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn審核確認);
            this.Controls.Add(this.lblBookId);
            this.Name = "FormModifyOrder";
            this.Text = "修改訂單";
            this.Load += new System.EventHandler(this.FormModifyOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button btn修改訂單;
        public System.Windows.Forms.Button btn取消訂單;
        public System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt訂購時間;
        private System.Windows.Forms.TextBox txtI訂單編號;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btn審核確認;
        public System.Windows.Forms.Label lblBookId;
        private System.Windows.Forms.ListView listView商品詳請;
        private System.Windows.Forms.TextBox txt訂購人;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btn延遲出貨;
        private System.Windows.Forms.ComboBox cbox處理狀態;
    }
}