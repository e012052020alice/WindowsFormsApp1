namespace WindowsFormsApp1
{
    partial class ShoppingCart
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl庫存 = new System.Windows.Forms.Label();
            this.btn加入購物車 = new System.Windows.Forms.Button();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.pictureBox書籍資訊 = new System.Windows.Forms.PictureBox();
            this.lblBookPrice = new System.Windows.Forms.Label();
            this.lblBookId = new System.Windows.Forms.Label();
            this.txt本數 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnminus1 = new System.Windows.Forms.Button();
            this.btnadd1 = new System.Windows.Forms.Button();
            this.btn關閉 = new System.Windows.Forms.Button();
            this.edtDate = new Sunny.UI.UIDatePicker();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.cbDepartment = new Sunny.UI.UIComboBox();
            this.rbFemale = new Sunny.UI.UIRadioButton();
            this.rbMale = new Sunny.UI.UIRadioButton();
            this.uiLabel3 = new Sunny.UI.UILabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox書籍資訊)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl庫存
            // 
            this.lbl庫存.AutoSize = true;
            this.lbl庫存.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl庫存.Location = new System.Drawing.Point(32, 336);
            this.lbl庫存.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl庫存.Name = "lbl庫存";
            this.lbl庫存.Size = new System.Drawing.Size(69, 34);
            this.lbl庫存.TabIndex = 14;
            this.lbl庫存.Text = "庫存";
            // 
            // btn加入購物車
            // 
            this.btn加入購物車.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn加入購物車.Location = new System.Drawing.Point(503, 358);
            this.btn加入購物車.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn加入購物車.Name = "btn加入購物車";
            this.btn加入購物車.Size = new System.Drawing.Size(148, 42);
            this.btn加入購物車.TabIndex = 13;
            this.btn加入購物車.Text = "加入購物車";
            this.btn加入購物車.UseVisualStyleBackColor = true;
            this.btn加入購物車.Click += new System.EventHandler(this.btn加入購物車_Click);
            // 
            // txtBookName
            // 
            this.txtBookName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtBookName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBookName.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtBookName.Location = new System.Drawing.Point(23, 84);
            this.txtBookName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBookName.Multiline = true;
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(237, 136);
            this.txtBookName.TabIndex = 12;
            this.txtBookName.TextChanged += new System.EventHandler(this.txtBookName_TextChanged);
            // 
            // pictureBox書籍資訊
            // 
            this.pictureBox書籍資訊.BackColor = System.Drawing.Color.White;
            this.pictureBox書籍資訊.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox書籍資訊.Location = new System.Drawing.Point(527, 25);
            this.pictureBox書籍資訊.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox書籍資訊.Name = "pictureBox書籍資訊";
            this.pictureBox書籍資訊.Size = new System.Drawing.Size(163, 180);
            this.pictureBox書籍資訊.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox書籍資訊.TabIndex = 11;
            this.pictureBox書籍資訊.TabStop = false;
            // 
            // lblBookPrice
            // 
            this.lblBookPrice.AutoSize = true;
            this.lblBookPrice.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblBookPrice.Location = new System.Drawing.Point(32, 260);
            this.lblBookPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookPrice.Name = "lblBookPrice";
            this.lblBookPrice.Size = new System.Drawing.Size(141, 34);
            this.lblBookPrice.TabIndex = 10;
            this.lblBookPrice.Text = "BookPrice";
            // 
            // lblBookId
            // 
            this.lblBookId.AutoSize = true;
            this.lblBookId.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblBookId.Location = new System.Drawing.Point(32, 25);
            this.lblBookId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookId.Name = "lblBookId";
            this.lblBookId.Size = new System.Drawing.Size(40, 34);
            this.lblBookId.TabIndex = 9;
            this.lblBookId.Text = "Id";
            // 
            // txt本數
            // 
            this.txt本數.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt本數.Location = new System.Drawing.Point(503, 289);
            this.txt本數.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt本數.Name = "txt本數";
            this.txt本數.ReadOnly = true;
            this.txt本數.Size = new System.Drawing.Size(129, 47);
            this.txt本數.TabIndex = 17;
            this.txt本數.Text = "1";
            this.txt本數.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(680, 296);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 34);
            this.label7.TabIndex = 16;
            this.label7.Text = "本";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(535, 244);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 34);
            this.label4.TabIndex = 15;
            this.label4.Text = "數量";
            // 
            // btnminus1
            // 
            this.btnminus1.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnminus1.Location = new System.Drawing.Point(463, 289);
            this.btnminus1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnminus1.Name = "btnminus1";
            this.btnminus1.Size = new System.Drawing.Size(31, 41);
            this.btnminus1.TabIndex = 18;
            this.btnminus1.Text = "-";
            this.btnminus1.UseVisualStyleBackColor = true;
            this.btnminus1.Click += new System.EventHandler(this.btnminus1_Click);
            // 
            // btnadd1
            // 
            this.btnadd1.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnadd1.Location = new System.Drawing.Point(641, 289);
            this.btnadd1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnadd1.Name = "btnadd1";
            this.btnadd1.Size = new System.Drawing.Size(31, 41);
            this.btnadd1.TabIndex = 19;
            this.btnadd1.Text = "+";
            this.btnadd1.UseVisualStyleBackColor = true;
            this.btnadd1.Click += new System.EventHandler(this.btnadd1_Click);
            // 
            // btn關閉
            // 
            this.btn關閉.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn關閉.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn關閉.ForeColor = System.Drawing.Color.Blue;
            this.btn關閉.Location = new System.Drawing.Point(767, 25);
            this.btn關閉.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn關閉.Name = "btn關閉";
            this.btn關閉.Size = new System.Drawing.Size(32, 34);
            this.btn關閉.TabIndex = 20;
            this.btn關閉.Text = "關閉";
            this.btn關閉.UseVisualStyleBackColor = false;
            this.btn關閉.Click += new System.EventHandler(this.btn關閉_Click);
            // 
            // edtDate
            // 
            this.edtDate.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.edtDate.FillColor = System.Drawing.Color.White;
            this.edtDate.Font = new System.Drawing.Font("宋体", 12F);
            this.edtDate.Location = new System.Drawing.Point(825, 516);
            this.edtDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.edtDate.MaxLength = 10;
            this.edtDate.MinimumSize = new System.Drawing.Size(63, 0);
            this.edtDate.Name = "edtDate";
            this.edtDate.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.edtDate.Size = new System.Drawing.Size(170, 29);
            this.edtDate.SymbolDropDown = 61555;
            this.edtDate.SymbolNormal = 61555;
            this.edtDate.TabIndex = 24;
            this.edtDate.Text = "2020-05-08";
            this.edtDate.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.edtDate.Value = new System.DateTime(2020, 5, 8, 0, 0, 0, 0);
            this.edtDate.Visible = false;
            this.edtDate.Watermark = "";
            // 
            // uiLabel6
            // 
            this.uiLabel6.AutoSize = true;
            this.uiLabel6.Font = new System.Drawing.Font("宋体", 12F);
            this.uiLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel6.Location = new System.Drawing.Point(731, 520);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(49, 20);
            this.uiLabel6.TabIndex = 27;
            this.uiLabel6.Text = "生日";
            this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel6.Visible = false;
            // 
            // uiLabel5
            // 
            this.uiLabel5.AutoSize = true;
            this.uiLabel5.Font = new System.Drawing.Font("宋体", 12F);
            this.uiLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel5.Location = new System.Drawing.Point(731, 480);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(49, 20);
            this.uiLabel5.TabIndex = 26;
            this.uiLabel5.Text = "部门";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel5.Visible = false;
            // 
            // cbDepartment
            // 
            this.cbDepartment.DataSource = null;
            this.cbDepartment.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cbDepartment.FillColor = System.Drawing.Color.White;
            this.cbDepartment.Font = new System.Drawing.Font("宋体", 12F);
            this.cbDepartment.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cbDepartment.Items.AddRange(new object[] {
            "研发部",
            "采购部",
            "生产部",
            "销售部",
            "人事部",
            "财务部",
            "行政部",
            "其他"});
            this.cbDepartment.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cbDepartment.Location = new System.Drawing.Point(825, 476);
            this.cbDepartment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbDepartment.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbDepartment.Name = "cbDepartment";
            this.cbDepartment.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbDepartment.Size = new System.Drawing.Size(170, 29);
            this.cbDepartment.TabIndex = 23;
            this.cbDepartment.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbDepartment.Visible = false;
            this.cbDepartment.Watermark = "";
            // 
            // rbFemale
            // 
            this.rbFemale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbFemale.Font = new System.Drawing.Font("宋体", 12F);
            this.rbFemale.Location = new System.Drawing.Point(913, 396);
            this.rbFemale.MinimumSize = new System.Drawing.Size(1, 1);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.rbFemale.Size = new System.Drawing.Size(82, 29);
            this.rbFemale.TabIndex = 22;
            this.rbFemale.Text = "女";
            this.rbFemale.Visible = false;
            // 
            // rbMale
            // 
            this.rbMale.Checked = true;
            this.rbMale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbMale.Font = new System.Drawing.Font("宋体", 12F);
            this.rbMale.Location = new System.Drawing.Point(825, 396);
            this.rbMale.MinimumSize = new System.Drawing.Size(1, 1);
            this.rbMale.Name = "rbMale";
            this.rbMale.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.rbMale.Size = new System.Drawing.Size(82, 29);
            this.rbMale.TabIndex = 21;
            this.rbMale.Text = "男";
            this.rbMale.Visible = false;
            // 
            // uiLabel3
            // 
            this.uiLabel3.AutoSize = true;
            this.uiLabel3.Font = new System.Drawing.Font("宋体", 12F);
            this.uiLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel3.Location = new System.Drawing.Point(731, 400);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(49, 20);
            this.uiLabel3.TabIndex = 25;
            this.uiLabel3.Text = "性别";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel3.Visible = false;
            // 
            // ShoppingCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.edtDate);
            this.Controls.Add(this.uiLabel6);
            this.Controls.Add(this.uiLabel5);
            this.Controls.Add(this.cbDepartment);
            this.Controls.Add(this.rbFemale);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.btn關閉);
            this.Controls.Add(this.btnadd1);
            this.Controls.Add(this.btnminus1);
            this.Controls.Add(this.txt本數);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl庫存);
            this.Controls.Add(this.btn加入購物車);
            this.Controls.Add(this.txtBookName);
            this.Controls.Add(this.pictureBox書籍資訊);
            this.Controls.Add(this.lblBookPrice);
            this.Controls.Add(this.lblBookId);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ShoppingCart";
            this.Size = new System.Drawing.Size(1095, 669);
            this.Load += new System.EventHandler(this.ShoppingCart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox書籍資訊)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl庫存;
        private System.Windows.Forms.Button btn加入購物車;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.Label lblBookPrice;
        private System.Windows.Forms.Label lblBookId;
        public System.Windows.Forms.PictureBox pictureBox書籍資訊;
        private System.Windows.Forms.TextBox txt本數;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnminus1;
        private System.Windows.Forms.Button btnadd1;
        public System.Windows.Forms.Button btn關閉;
        private Sunny.UI.UIDatePicker edtDate;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UIComboBox cbDepartment;
        private Sunny.UI.UIRadioButton rbFemale;
        private Sunny.UI.UIRadioButton rbMale;
        private Sunny.UI.UILabel uiLabel3;
    }
}
