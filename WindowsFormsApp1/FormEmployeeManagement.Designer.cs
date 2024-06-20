namespace WindowsFormsApp1
{
    partial class FormEmployeeManagement
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
            this.listView打卡紀錄 = new System.Windows.Forms.ListView();
            this.btn打卡 = new System.Windows.Forms.Button();
            this.btn建立帳號 = new System.Windows.Forms.Button();
            this.btn時間設定 = new System.Windows.Forms.Button();
            this.dtp搜尋結束時間 = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dtp搜尋開始時間 = new System.Windows.Forms.DateTimePicker();
            this.btn搜尋 = new System.Windows.Forms.Button();
            this.cbox欄位名稱 = new System.Windows.Forms.ComboBox();
            this.txt搜尋關鍵字 = new System.Windows.Forms.TextBox();
            this.btn回到全部 = new System.Windows.Forms.Button();
            this.cbox打卡欄位 = new System.Windows.Forms.ComboBox();
            this.dtp開始時間 = new System.Windows.Forms.DateTimePicker();
            this.dtp結束時間 = new System.Windows.Forms.DateTimePicker();
            this.cbox開始小時 = new System.Windows.Forms.ComboBox();
            this.cbox結束小時 = new System.Windows.Forms.ComboBox();
            this.cbox開始分 = new System.Windows.Forms.ComboBox();
            this.cbox結束分 = new System.Windows.Forms.ComboBox();
            this.txt開始時間 = new System.Windows.Forms.TextBox();
            this.txt結束時間 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listView打卡紀錄
            // 
            this.listView打卡紀錄.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listView打卡紀錄.HideSelection = false;
            this.listView打卡紀錄.Location = new System.Drawing.Point(40, 138);
            this.listView打卡紀錄.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listView打卡紀錄.MultiSelect = false;
            this.listView打卡紀錄.Name = "listView打卡紀錄";
            this.listView打卡紀錄.Size = new System.Drawing.Size(684, 327);
            this.listView打卡紀錄.TabIndex = 0;
            this.listView打卡紀錄.UseCompatibleStateImageBehavior = false;
            // 
            // btn打卡
            // 
            this.btn打卡.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn打卡.Location = new System.Drawing.Point(643, 94);
            this.btn打卡.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn打卡.Name = "btn打卡";
            this.btn打卡.Size = new System.Drawing.Size(73, 35);
            this.btn打卡.TabIndex = 1;
            this.btn打卡.Text = "打卡";
            this.btn打卡.UseVisualStyleBackColor = true;
            this.btn打卡.Click += new System.EventHandler(this.btn打卡_Click);
            // 
            // btn建立帳號
            // 
            this.btn建立帳號.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn建立帳號.Location = new System.Drawing.Point(747, 389);
            this.btn建立帳號.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn建立帳號.Name = "btn建立帳號";
            this.btn建立帳號.Size = new System.Drawing.Size(130, 35);
            this.btn建立帳號.TabIndex = 2;
            this.btn建立帳號.Text = "建立員工帳號";
            this.btn建立帳號.UseVisualStyleBackColor = true;
            this.btn建立帳號.Click += new System.EventHandler(this.btn建立帳號_Click);
            // 
            // btn時間設定
            // 
            this.btn時間設定.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn時間設定.Location = new System.Drawing.Point(629, 533);
            this.btn時間設定.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn時間設定.Name = "btn時間設定";
            this.btn時間設定.Size = new System.Drawing.Size(167, 35);
            this.btn時間設定.TabIndex = 3;
            this.btn時間設定.Text = "系統維護時間設定";
            this.btn時間設定.UseVisualStyleBackColor = true;
            this.btn時間設定.Visible = false;
            this.btn時間設定.Click += new System.EventHandler(this.btn時間設定_Click);
            // 
            // dtp搜尋結束時間
            // 
            this.dtp搜尋結束時間.CalendarFont = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtp搜尋結束時間.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtp搜尋結束時間.Location = new System.Drawing.Point(68, 53);
            this.dtp搜尋結束時間.Name = "dtp搜尋結束時間";
            this.dtp搜尋結束時間.Size = new System.Drawing.Size(151, 29);
            this.dtp搜尋結束時間.TabIndex = 23;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label14.ForeColor = System.Drawing.Color.Blue;
            this.label14.Location = new System.Drawing.Point(36, 57);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(26, 21);
            this.label14.TabIndex = 22;
            this.label14.Text = "到";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label13.ForeColor = System.Drawing.Color.Blue;
            this.label13.Location = new System.Drawing.Point(36, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(26, 21);
            this.label13.TabIndex = 21;
            this.label13.Text = "從";
            // 
            // dtp搜尋開始時間
            // 
            this.dtp搜尋開始時間.CalendarFont = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtp搜尋開始時間.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtp搜尋開始時間.Location = new System.Drawing.Point(68, 16);
            this.dtp搜尋開始時間.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtp搜尋開始時間.Name = "dtp搜尋開始時間";
            this.dtp搜尋開始時間.Size = new System.Drawing.Size(151, 29);
            this.dtp搜尋開始時間.TabIndex = 20;
            this.dtp搜尋開始時間.Value = new System.DateTime(2022, 12, 1, 0, 0, 0, 0);
            // 
            // btn搜尋
            // 
            this.btn搜尋.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn搜尋.Location = new System.Drawing.Point(235, 48);
            this.btn搜尋.Name = "btn搜尋";
            this.btn搜尋.Size = new System.Drawing.Size(86, 29);
            this.btn搜尋.TabIndex = 19;
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
            this.cbox欄位名稱.Location = new System.Drawing.Point(226, 94);
            this.cbox欄位名稱.Name = "cbox欄位名稱";
            this.cbox欄位名稱.Size = new System.Drawing.Size(107, 28);
            this.cbox欄位名稱.TabIndex = 18;
            // 
            // txt搜尋關鍵字
            // 
            this.txt搜尋關鍵字.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt搜尋關鍵字.Location = new System.Drawing.Point(66, 94);
            this.txt搜尋關鍵字.Name = "txt搜尋關鍵字";
            this.txt搜尋關鍵字.Size = new System.Drawing.Size(145, 29);
            this.txt搜尋關鍵字.TabIndex = 17;
            // 
            // btn回到全部
            // 
            this.btn回到全部.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn回到全部.Location = new System.Drawing.Point(235, 12);
            this.btn回到全部.Name = "btn回到全部";
            this.btn回到全部.Size = new System.Drawing.Size(86, 29);
            this.btn回到全部.TabIndex = 24;
            this.btn回到全部.Text = "回到全部";
            this.btn回到全部.UseVisualStyleBackColor = true;
            this.btn回到全部.Click += new System.EventHandler(this.btn回到全部_Click);
            // 
            // cbox打卡欄位
            // 
            this.cbox打卡欄位.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox打卡欄位.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbox打卡欄位.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbox打卡欄位.FormattingEnabled = true;
            this.cbox打卡欄位.Location = new System.Drawing.Point(514, 94);
            this.cbox打卡欄位.Name = "cbox打卡欄位";
            this.cbox打卡欄位.Size = new System.Drawing.Size(107, 28);
            this.cbox打卡欄位.TabIndex = 25;
            // 
            // dtp開始時間
            // 
            this.dtp開始時間.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtp開始時間.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp開始時間.Location = new System.Drawing.Point(47, 491);
            this.dtp開始時間.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtp開始時間.Name = "dtp開始時間";
            this.dtp開始時間.Size = new System.Drawing.Size(160, 29);
            this.dtp開始時間.TabIndex = 26;
            this.dtp開始時間.Visible = false;
            this.dtp開始時間.ValueChanged += new System.EventHandler(this.dateTimePicker開始時間_ValueChanged);
            // 
            // dtp結束時間
            // 
            this.dtp結束時間.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtp結束時間.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp結束時間.Location = new System.Drawing.Point(47, 539);
            this.dtp結束時間.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtp結束時間.Name = "dtp結束時間";
            this.dtp結束時間.Size = new System.Drawing.Size(160, 29);
            this.dtp結束時間.TabIndex = 27;
            this.dtp結束時間.Visible = false;
            this.dtp結束時間.ValueChanged += new System.EventHandler(this.dateTimePicker結束時間_ValueChanged);
            // 
            // cbox開始小時
            // 
            this.cbox開始小時.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox開始小時.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbox開始小時.FormattingEnabled = true;
            this.cbox開始小時.Location = new System.Drawing.Point(226, 494);
            this.cbox開始小時.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbox開始小時.Name = "cbox開始小時";
            this.cbox開始小時.Size = new System.Drawing.Size(51, 28);
            this.cbox開始小時.TabIndex = 28;
            this.cbox開始小時.Visible = false;
            this.cbox開始小時.SelectedIndexChanged += new System.EventHandler(this.cbox開始小時_SelectedIndexChanged);
            // 
            // cbox結束小時
            // 
            this.cbox結束小時.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox結束小時.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbox結束小時.FormattingEnabled = true;
            this.cbox結束小時.Location = new System.Drawing.Point(226, 540);
            this.cbox結束小時.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbox結束小時.Name = "cbox結束小時";
            this.cbox結束小時.Size = new System.Drawing.Size(51, 28);
            this.cbox結束小時.TabIndex = 29;
            this.cbox結束小時.Visible = false;
            this.cbox結束小時.SelectedIndexChanged += new System.EventHandler(this.cbox結束小時_SelectedIndexChanged);
            // 
            // cbox開始分
            // 
            this.cbox開始分.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox開始分.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbox開始分.FormattingEnabled = true;
            this.cbox開始分.Location = new System.Drawing.Point(295, 494);
            this.cbox開始分.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbox開始分.Name = "cbox開始分";
            this.cbox開始分.Size = new System.Drawing.Size(51, 28);
            this.cbox開始分.TabIndex = 30;
            this.cbox開始分.Visible = false;
            this.cbox開始分.SelectedIndexChanged += new System.EventHandler(this.cbox開始分_SelectedIndexChanged);
            // 
            // cbox結束分
            // 
            this.cbox結束分.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox結束分.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbox結束分.FormattingEnabled = true;
            this.cbox結束分.Location = new System.Drawing.Point(295, 539);
            this.cbox結束分.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbox結束分.Name = "cbox結束分";
            this.cbox結束分.Size = new System.Drawing.Size(51, 28);
            this.cbox結束分.TabIndex = 31;
            this.cbox結束分.Visible = false;
            this.cbox結束分.SelectedIndexChanged += new System.EventHandler(this.cbox結束分_SelectedIndexChanged);
            // 
            // txt開始時間
            // 
            this.txt開始時間.Enabled = false;
            this.txt開始時間.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt開始時間.Location = new System.Drawing.Point(376, 494);
            this.txt開始時間.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt開始時間.Name = "txt開始時間";
            this.txt開始時間.Size = new System.Drawing.Size(222, 29);
            this.txt開始時間.TabIndex = 32;
            this.txt開始時間.Visible = false;
            // 
            // txt結束時間
            // 
            this.txt結束時間.Enabled = false;
            this.txt結束時間.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt結束時間.Location = new System.Drawing.Point(376, 538);
            this.txt結束時間.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt結束時間.Name = "txt結束時間";
            this.txt結束時間.Size = new System.Drawing.Size(222, 29);
            this.txt結束時間.TabIndex = 33;
            this.txt結束時間.Visible = false;
            // 
            // FormEmployeeManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 592);
            this.Controls.Add(this.txt結束時間);
            this.Controls.Add(this.txt開始時間);
            this.Controls.Add(this.cbox結束分);
            this.Controls.Add(this.cbox開始分);
            this.Controls.Add(this.cbox結束小時);
            this.Controls.Add(this.cbox開始小時);
            this.Controls.Add(this.dtp結束時間);
            this.Controls.Add(this.dtp開始時間);
            this.Controls.Add(this.cbox打卡欄位);
            this.Controls.Add(this.btn回到全部);
            this.Controls.Add(this.dtp搜尋結束時間);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dtp搜尋開始時間);
            this.Controls.Add(this.btn搜尋);
            this.Controls.Add(this.cbox欄位名稱);
            this.Controls.Add(this.txt搜尋關鍵字);
            this.Controls.Add(this.btn時間設定);
            this.Controls.Add(this.btn建立帳號);
            this.Controls.Add(this.btn打卡);
            this.Controls.Add(this.listView打卡紀錄);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormEmployeeManagement";
            this.Text = "FormEmployeeManagement";
            this.Load += new System.EventHandler(this.FormEmployeeManagement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView打卡紀錄;
        private System.Windows.Forms.Button btn打卡;
        private System.Windows.Forms.Button btn建立帳號;
        private System.Windows.Forms.Button btn時間設定;
        private System.Windows.Forms.DateTimePicker dtp搜尋結束時間;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dtp搜尋開始時間;
        private System.Windows.Forms.Button btn搜尋;
        private System.Windows.Forms.ComboBox cbox欄位名稱;
        private System.Windows.Forms.TextBox txt搜尋關鍵字;
        private System.Windows.Forms.Button btn回到全部;
        private System.Windows.Forms.ComboBox cbox打卡欄位;
        private System.Windows.Forms.DateTimePicker dtp開始時間;
        private System.Windows.Forms.DateTimePicker dtp結束時間;
        private System.Windows.Forms.ComboBox cbox開始小時;
        private System.Windows.Forms.ComboBox cbox結束小時;
        private System.Windows.Forms.ComboBox cbox開始分;
        private System.Windows.Forms.ComboBox cbox結束分;
        private System.Windows.Forms.TextBox txt開始時間;
        private System.Windows.Forms.TextBox txt結束時間;
    }
}