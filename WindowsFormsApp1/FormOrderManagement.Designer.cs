namespace WindowsFormsApp1
{
    partial class FormOrderManagement
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
            this.btn計算營業額 = new System.Windows.Forms.Button();
            this.listView訂單詳情 = new System.Windows.Forms.ListView();
            this.btn搜尋 = new System.Windows.Forms.Button();
            this.cbox欄位名稱 = new System.Windows.Forms.ComboBox();
            this.txt搜尋關鍵字 = new System.Windows.Forms.TextBox();
            this.dtp搜尋開始時間 = new System.Windows.Forms.DateTimePicker();
            this.dtp搜尋結束時間 = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txt營業額 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp營業額結束時間 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp營業額開始時間 = new System.Windows.Forms.DateTimePicker();
            this.btn回到全部 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn計算營業額
            // 
            this.btn計算營業額.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn計算營業額.Location = new System.Drawing.Point(997, 52);
            this.btn計算營業額.Name = "btn計算營業額";
            this.btn計算營業額.Size = new System.Drawing.Size(147, 43);
            this.btn計算營業額.TabIndex = 5;
            this.btn計算營業額.Text = "計算營業額";
            this.btn計算營業額.UseVisualStyleBackColor = true;
            this.btn計算營業額.Click += new System.EventHandler(this.btn計算營業額_Click);
            // 
            // listView訂單詳情
            // 
            this.listView訂單詳情.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView訂單詳情.HideSelection = false;
            this.listView訂單詳情.Location = new System.Drawing.Point(31, 165);
            this.listView訂單詳情.Margin = new System.Windows.Forms.Padding(4);
            this.listView訂單詳情.MultiSelect = false;
            this.listView訂單詳情.Name = "listView訂單詳情";
            this.listView訂單詳情.Size = new System.Drawing.Size(1154, 536);
            this.listView訂單詳情.TabIndex = 6;
            this.listView訂單詳情.UseCompatibleStateImageBehavior = false;
            this.listView訂單詳情.ItemActivate += new System.EventHandler(this.listView訂單詳情_ItemActivate);
            // 
            // btn搜尋
            // 
            this.btn搜尋.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn搜尋.Location = new System.Drawing.Point(282, 57);
            this.btn搜尋.Margin = new System.Windows.Forms.Padding(4);
            this.btn搜尋.Name = "btn搜尋";
            this.btn搜尋.Size = new System.Drawing.Size(114, 36);
            this.btn搜尋.TabIndex = 12;
            this.btn搜尋.Text = "搜尋";
            this.btn搜尋.UseVisualStyleBackColor = true;
            this.btn搜尋.Click += new System.EventHandler(this.btn搜尋_Click);
            // 
            // cbox欄位名稱
            // 
            this.cbox欄位名稱.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox欄位名稱.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbox欄位名稱.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbox欄位名稱.FormattingEnabled = true;
            this.cbox欄位名稱.Location = new System.Drawing.Point(271, 110);
            this.cbox欄位名稱.Margin = new System.Windows.Forms.Padding(4);
            this.cbox欄位名稱.Name = "cbox欄位名稱";
            this.cbox欄位名稱.Size = new System.Drawing.Size(141, 33);
            this.cbox欄位名稱.TabIndex = 11;
            this.cbox欄位名稱.SelectedIndexChanged += new System.EventHandler(this.cbox欄位名稱_SelectedIndexChanged);
            // 
            // txt搜尋關鍵字
            // 
            this.txt搜尋關鍵字.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt搜尋關鍵字.Location = new System.Drawing.Point(57, 110);
            this.txt搜尋關鍵字.Margin = new System.Windows.Forms.Padding(4);
            this.txt搜尋關鍵字.Name = "txt搜尋關鍵字";
            this.txt搜尋關鍵字.Size = new System.Drawing.Size(192, 34);
            this.txt搜尋關鍵字.TabIndex = 10;
            // 
            // dtp搜尋開始時間
            // 
            this.dtp搜尋開始時間.CalendarFont = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtp搜尋開始時間.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtp搜尋開始時間.Location = new System.Drawing.Point(60, 12);
            this.dtp搜尋開始時間.Name = "dtp搜尋開始時間";
            this.dtp搜尋開始時間.Size = new System.Drawing.Size(200, 34);
            this.dtp搜尋開始時間.TabIndex = 13;
            this.dtp搜尋開始時間.Value = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            // 
            // dtp搜尋結束時間
            // 
            this.dtp搜尋結束時間.CalendarFont = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtp搜尋結束時間.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtp搜尋結束時間.Location = new System.Drawing.Point(60, 59);
            this.dtp搜尋結束時間.Margin = new System.Windows.Forms.Padding(4);
            this.dtp搜尋結束時間.Name = "dtp搜尋結束時間";
            this.dtp搜尋結束時間.Size = new System.Drawing.Size(200, 34);
            this.dtp搜尋結束時間.TabIndex = 16;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label14.ForeColor = System.Drawing.Color.Blue;
            this.label14.Location = new System.Drawing.Point(17, 64);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(32, 25);
            this.label14.TabIndex = 15;
            this.label14.Text = "到";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label13.ForeColor = System.Drawing.Color.Blue;
            this.label13.Location = new System.Drawing.Point(17, 12);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 25);
            this.label13.TabIndex = 14;
            this.label13.Text = "從";
            // 
            // txt營業額
            // 
            this.txt營業額.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt營業額.Location = new System.Drawing.Point(811, 112);
            this.txt營業額.Margin = new System.Windows.Forms.Padding(4);
            this.txt營業額.Name = "txt營業額";
            this.txt營業額.Size = new System.Drawing.Size(152, 34);
            this.txt營業額.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(991, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 35);
            this.label3.TabIndex = 22;
            this.label3.Text = "元";
            // 
            // dtp營業額結束時間
            // 
            this.dtp營業額結束時間.CalendarFont = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtp營業額結束時間.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtp營業額結束時間.Location = new System.Drawing.Point(774, 65);
            this.dtp營業額結束時間.Margin = new System.Windows.Forms.Padding(4);
            this.dtp營業額結束時間.Name = "dtp營業額結束時間";
            this.dtp營業額結束時間.Size = new System.Drawing.Size(200, 34);
            this.dtp營業額結束時間.TabIndex = 107;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(731, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 25);
            this.label1.TabIndex = 106;
            this.label1.Text = "到";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(731, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 25);
            this.label2.TabIndex = 105;
            this.label2.Text = "從";
            // 
            // dtp營業額開始時間
            // 
            this.dtp營業額開始時間.CalendarFont = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtp營業額開始時間.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtp營業額開始時間.Location = new System.Drawing.Point(774, 12);
            this.dtp營業額開始時間.Name = "dtp營業額開始時間";
            this.dtp營業額開始時間.Size = new System.Drawing.Size(200, 34);
            this.dtp營業額開始時間.TabIndex = 104;
            this.dtp營業額開始時間.Value = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            // 
            // btn回到全部
            // 
            this.btn回到全部.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn回到全部.Location = new System.Drawing.Point(431, 57);
            this.btn回到全部.Margin = new System.Windows.Forms.Padding(4);
            this.btn回到全部.Name = "btn回到全部";
            this.btn回到全部.Size = new System.Drawing.Size(114, 36);
            this.btn回到全部.TabIndex = 108;
            this.btn回到全部.Text = "回到全部";
            this.btn回到全部.UseVisualStyleBackColor = true;
            this.btn回到全部.Click += new System.EventHandler(this.btn回到全部_Click);
            // 
            // FormOrderManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 744);
            this.Controls.Add(this.btn回到全部);
            this.Controls.Add(this.dtp營業額結束時間);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtp營業額開始時間);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt營業額);
            this.Controls.Add(this.dtp搜尋結束時間);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dtp搜尋開始時間);
            this.Controls.Add(this.btn搜尋);
            this.Controls.Add(this.cbox欄位名稱);
            this.Controls.Add(this.txt搜尋關鍵字);
            this.Controls.Add(this.listView訂單詳情);
            this.Controls.Add(this.btn計算營業額);
            this.Name = "FormOrderManagement";
            this.Text = "訂單管理";
            this.Load += new System.EventHandler(this.FormOrderManagement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn計算營業額;
        private System.Windows.Forms.ListView listView訂單詳情;
        private System.Windows.Forms.Button btn搜尋;
        private System.Windows.Forms.ComboBox cbox欄位名稱;
        private System.Windows.Forms.TextBox txt搜尋關鍵字;
        private System.Windows.Forms.DateTimePicker dtp搜尋開始時間;
        private System.Windows.Forms.DateTimePicker dtp搜尋結束時間;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt營業額;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp營業額結束時間;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp營業額開始時間;
        private System.Windows.Forms.Button btn回到全部;
    }
}