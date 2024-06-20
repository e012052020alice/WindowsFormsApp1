namespace WindowsFormsApp1
{
    partial class FormMemberInformationManagement
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
            this.listView會員資訊 = new System.Windows.Forms.ListView();
            this.btn搜尋 = new System.Windows.Forms.Button();
            this.cbox欄位名稱 = new System.Windows.Forms.ComboBox();
            this.txt搜尋關鍵字 = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.radio婚姻已婚 = new System.Windows.Forms.RadioButton();
            this.radio婚姻單身 = new System.Windows.Forms.RadioButton();
            this.radio婚姻全部 = new System.Windows.Forms.RadioButton();
            this.dtp結束時間 = new System.Windows.Forms.DateTimePicker();
            this.dtp開始時間 = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btn回到全部 = new System.Windows.Forms.Button();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView會員資訊
            // 
            this.listView會員資訊.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView會員資訊.HideSelection = false;
            this.listView會員資訊.Location = new System.Drawing.Point(20, 130);
            this.listView會員資訊.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listView會員資訊.Name = "listView會員資訊";
            this.listView會員資訊.Size = new System.Drawing.Size(853, 438);
            this.listView會員資訊.TabIndex = 0;
            this.listView會員資訊.UseCompatibleStateImageBehavior = false;
            this.listView會員資訊.ItemActivate += new System.EventHandler(this.listView會員資訊_ItemActivate);
            // 
            // btn搜尋
            // 
            this.btn搜尋.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn搜尋.Location = new System.Drawing.Point(760, 71);
            this.btn搜尋.Name = "btn搜尋";
            this.btn搜尋.Size = new System.Drawing.Size(86, 29);
            this.btn搜尋.TabIndex = 15;
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
            this.cbox欄位名稱.Location = new System.Drawing.Point(740, 27);
            this.cbox欄位名稱.Name = "cbox欄位名稱";
            this.cbox欄位名稱.Size = new System.Drawing.Size(107, 28);
            this.cbox欄位名稱.TabIndex = 14;
            // 
            // txt搜尋關鍵字
            // 
            this.txt搜尋關鍵字.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt搜尋關鍵字.Location = new System.Drawing.Point(589, 28);
            this.txt搜尋關鍵字.Name = "txt搜尋關鍵字";
            this.txt搜尋關鍵字.Size = new System.Drawing.Size(145, 29);
            this.txt搜尋關鍵字.TabIndex = 13;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox5.Controls.Add(this.radio婚姻已婚);
            this.groupBox5.Controls.Add(this.radio婚姻單身);
            this.groupBox5.Controls.Add(this.radio婚姻全部);
            this.groupBox5.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox5.Location = new System.Drawing.Point(310, 31);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(215, 78);
            this.groupBox5.TabIndex = 22;
            this.groupBox5.TabStop = false;
            // 
            // radio婚姻已婚
            // 
            this.radio婚姻已婚.AutoSize = true;
            this.radio婚姻已婚.Location = new System.Drawing.Point(135, 26);
            this.radio婚姻已婚.Name = "radio婚姻已婚";
            this.radio婚姻已婚.Size = new System.Drawing.Size(57, 20);
            this.radio婚姻已婚.TabIndex = 2;
            this.radio婚姻已婚.TabStop = true;
            this.radio婚姻已婚.Text = "已婚";
            this.radio婚姻已婚.UseVisualStyleBackColor = true;
            this.radio婚姻已婚.CheckedChanged += new System.EventHandler(this.radio婚姻已婚_CheckedChanged);
            // 
            // radio婚姻單身
            // 
            this.radio婚姻單身.AutoSize = true;
            this.radio婚姻單身.Location = new System.Drawing.Point(68, 26);
            this.radio婚姻單身.Name = "radio婚姻單身";
            this.radio婚姻單身.Size = new System.Drawing.Size(57, 20);
            this.radio婚姻單身.TabIndex = 1;
            this.radio婚姻單身.TabStop = true;
            this.radio婚姻單身.Text = "單身";
            this.radio婚姻單身.UseVisualStyleBackColor = true;
            this.radio婚姻單身.CheckedChanged += new System.EventHandler(this.radio婚姻單身_CheckedChanged);
            // 
            // radio婚姻全部
            // 
            this.radio婚姻全部.AutoSize = true;
            this.radio婚姻全部.Location = new System.Drawing.Point(6, 26);
            this.radio婚姻全部.Name = "radio婚姻全部";
            this.radio婚姻全部.Size = new System.Drawing.Size(57, 20);
            this.radio婚姻全部.TabIndex = 0;
            this.radio婚姻全部.TabStop = true;
            this.radio婚姻全部.Text = "全部";
            this.radio婚姻全部.UseVisualStyleBackColor = true;
            this.radio婚姻全部.CheckedChanged += new System.EventHandler(this.radio婚姻全部_CheckedChanged);
            // 
            // dtp結束時間
            // 
            this.dtp結束時間.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtp結束時間.Location = new System.Drawing.Point(56, 74);
            this.dtp結束時間.Name = "dtp結束時間";
            this.dtp結束時間.Size = new System.Drawing.Size(150, 27);
            this.dtp結束時間.TabIndex = 21;
            // 
            // dtp開始時間
            // 
            this.dtp開始時間.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtp開始時間.Location = new System.Drawing.Point(56, 33);
            this.dtp開始時間.Name = "dtp開始時間";
            this.dtp開始時間.Size = new System.Drawing.Size(150, 27);
            this.dtp開始時間.TabIndex = 20;
            this.dtp開始時間.Value = new System.DateTime(1960, 1, 1, 0, 0, 0, 0);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label14.ForeColor = System.Drawing.Color.Blue;
            this.label14.Location = new System.Drawing.Point(26, 74);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(26, 21);
            this.label14.TabIndex = 19;
            this.label14.Text = "到";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label13.ForeColor = System.Drawing.Color.Blue;
            this.label13.Location = new System.Drawing.Point(26, 34);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(26, 21);
            this.label13.TabIndex = 18;
            this.label13.Text = "從";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.ForeColor = System.Drawing.Color.Blue;
            this.label11.Location = new System.Drawing.Point(306, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 21);
            this.label11.TabIndex = 17;
            this.label11.Text = "婚姻狀態選擇";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Location = new System.Drawing.Point(23, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 21);
            this.label10.TabIndex = 16;
            this.label10.Text = "生日區間指定";
            // 
            // btn回到全部
            // 
            this.btn回到全部.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn回到全部.Location = new System.Drawing.Point(647, 70);
            this.btn回到全部.Name = "btn回到全部";
            this.btn回到全部.Size = new System.Drawing.Size(86, 29);
            this.btn回到全部.TabIndex = 23;
            this.btn回到全部.Text = "回到全部";
            this.btn回到全部.UseVisualStyleBackColor = true;
            this.btn回到全部.Click += new System.EventHandler(this.btn回到全部_Click);
            // 
            // FormMemberInformationManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 592);
            this.Controls.Add(this.btn回到全部);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.dtp結束時間);
            this.Controls.Add(this.dtp開始時間);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btn搜尋);
            this.Controls.Add(this.cbox欄位名稱);
            this.Controls.Add(this.txt搜尋關鍵字);
            this.Controls.Add(this.listView會員資訊);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormMemberInformationManagement";
            this.Text = "會員資料管理";
            this.Load += new System.EventHandler(this.FormMemberInformationManagement_Load);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView會員資訊;
        private System.Windows.Forms.Button btn搜尋;
        private System.Windows.Forms.ComboBox cbox欄位名稱;
        private System.Windows.Forms.TextBox txt搜尋關鍵字;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton radio婚姻已婚;
        private System.Windows.Forms.RadioButton radio婚姻單身;
        private System.Windows.Forms.RadioButton radio婚姻全部;
        private System.Windows.Forms.DateTimePicker dtp結束時間;
        private System.Windows.Forms.DateTimePicker dtp開始時間;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn回到全部;
    }
}