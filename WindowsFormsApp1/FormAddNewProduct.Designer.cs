namespace WindowsFormsApp1
{
    partial class FormAddNewProduct
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
            this.lbl庫存 = new System.Windows.Forms.Label();
            this.btn加入商品庫 = new System.Windows.Forms.Button();
            this.txt商品名稱 = new System.Windows.Forms.TextBox();
            this.pictureBox書籍圖片 = new System.Windows.Forms.PictureBox();
            this.lblBookId = new System.Windows.Forms.Label();
            this.txt商品價格 = new System.Windows.Forms.TextBox();
            this.txt庫存 = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt作者 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbox分類欄位 = new System.Windows.Forms.ComboBox();
            this.選取圖片 = new System.Windows.Forms.Button();
            this.cbox商品狀況 = new System.Windows.Forms.ComboBox();
            this.btn修改商品庫 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btn進貨 = new System.Windows.Forms.Button();
            this.txt簡介 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox書籍圖片)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl庫存
            // 
            this.lbl庫存.AutoSize = true;
            this.lbl庫存.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl庫存.Location = new System.Drawing.Point(13, 478);
            this.lbl庫存.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl庫存.Name = "lbl庫存";
            this.lbl庫存.Size = new System.Drawing.Size(69, 34);
            this.lbl庫存.TabIndex = 50;
            this.lbl庫存.Text = "庫存";
            // 
            // btn加入商品庫
            // 
            this.btn加入商品庫.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn加入商品庫.Location = new System.Drawing.Point(853, 490);
            this.btn加入商品庫.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn加入商品庫.Name = "btn加入商品庫";
            this.btn加入商品庫.Size = new System.Drawing.Size(139, 40);
            this.btn加入商品庫.TabIndex = 49;
            this.btn加入商品庫.Text = "加入商品庫";
            this.btn加入商品庫.UseVisualStyleBackColor = true;
            this.btn加入商品庫.Click += new System.EventHandler(this.btn加入商品庫_Click);
            // 
            // txt商品名稱
            // 
            this.txt商品名稱.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt商品名稱.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt商品名稱.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt商品名稱.Location = new System.Drawing.Point(160, 16);
            this.txt商品名稱.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt商品名稱.Multiline = true;
            this.txt商品名稱.Name = "txt商品名稱";
            this.txt商品名稱.Size = new System.Drawing.Size(368, 180);
            this.txt商品名稱.TabIndex = 48;
            // 
            // pictureBox書籍圖片
            // 
            this.pictureBox書籍圖片.BackColor = System.Drawing.Color.White;
            this.pictureBox書籍圖片.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox書籍圖片.Location = new System.Drawing.Point(625, 51);
            this.pictureBox書籍圖片.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox書籍圖片.Name = "pictureBox書籍圖片";
            this.pictureBox書籍圖片.Size = new System.Drawing.Size(200, 200);
            this.pictureBox書籍圖片.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox書籍圖片.TabIndex = 47;
            this.pictureBox書籍圖片.TabStop = false;
            // 
            // lblBookId
            // 
            this.lblBookId.AutoSize = true;
            this.lblBookId.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblBookId.Location = new System.Drawing.Point(864, 9);
            this.lblBookId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookId.Name = "lblBookId";
            this.lblBookId.Size = new System.Drawing.Size(43, 34);
            this.lblBookId.TabIndex = 45;
            this.lblBookId.Text = "ID";
            this.lblBookId.Visible = false;
            // 
            // txt商品價格
            // 
            this.txt商品價格.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt商品價格.Location = new System.Drawing.Point(160, 280);
            this.txt商品價格.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt商品價格.Name = "txt商品價格";
            this.txt商品價格.Size = new System.Drawing.Size(307, 47);
            this.txt商品價格.TabIndex = 62;
            this.txt商品價格.TextChanged += new System.EventHandler(this.txt商品價格_TextChanged);
            // 
            // txt庫存
            // 
            this.txt庫存.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt庫存.Location = new System.Drawing.Point(160, 465);
            this.txt庫存.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt庫存.Name = "txt庫存";
            this.txt庫存.Size = new System.Drawing.Size(313, 47);
            this.txt庫存.TabIndex = 61;
            this.txt庫存.TextChanged += new System.EventHandler(this.txt庫存_TextChanged);
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtId.Location = new System.Drawing.Point(904, 9);
            this.txtId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(113, 47);
            this.txtId.TabIndex = 60;
            this.txtId.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(13, 46);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 35);
            this.label5.TabIndex = 59;
            this.label5.Text = "商品名稱";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(5, 282);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 35);
            this.label1.TabIndex = 58;
            this.label1.Text = "商品價格";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(639, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 35);
            this.label6.TabIndex = 63;
            this.label6.Text = "商品圖片";
            // 
            // txt作者
            // 
            this.txt作者.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt作者.Location = new System.Drawing.Point(160, 335);
            this.txt作者.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt作者.Name = "txt作者";
            this.txt作者.Size = new System.Drawing.Size(313, 47);
            this.txt作者.TabIndex = 65;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(13, 348);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 34);
            this.label2.TabIndex = 64;
            this.label2.Text = "作者";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(13, 418);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 34);
            this.label3.TabIndex = 66;
            this.label3.Text = "商品狀況";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(24, 216);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 34);
            this.label8.TabIndex = 68;
            this.label8.Text = "分類";
            // 
            // cbox分類欄位
            // 
            this.cbox分類欄位.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox分類欄位.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbox分類欄位.FormattingEnabled = true;
            this.cbox分類欄位.Location = new System.Drawing.Point(160, 218);
            this.cbox分類欄位.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbox分類欄位.Name = "cbox分類欄位";
            this.cbox分類欄位.Size = new System.Drawing.Size(221, 42);
            this.cbox分類欄位.TabIndex = 69;
            // 
            // 選取圖片
            // 
            this.選取圖片.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.選取圖片.Location = new System.Drawing.Point(877, 214);
            this.選取圖片.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.選取圖片.Name = "選取圖片";
            this.選取圖片.Size = new System.Drawing.Size(139, 36);
            this.選取圖片.TabIndex = 70;
            this.選取圖片.Text = "選取圖片";
            this.選取圖片.UseVisualStyleBackColor = true;
            this.選取圖片.Click += new System.EventHandler(this.選取圖片_Click);
            // 
            // cbox商品狀況
            // 
            this.cbox商品狀況.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox商品狀況.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbox商品狀況.FormattingEnabled = true;
            this.cbox商品狀況.Location = new System.Drawing.Point(160, 410);
            this.cbox商品狀況.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbox商品狀況.Name = "cbox商品狀況";
            this.cbox商品狀況.Size = new System.Drawing.Size(221, 42);
            this.cbox商品狀況.TabIndex = 71;
            // 
            // btn修改商品庫
            // 
            this.btn修改商品庫.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn修改商品庫.Location = new System.Drawing.Point(869, 491);
            this.btn修改商品庫.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn修改商品庫.Name = "btn修改商品庫";
            this.btn修改商品庫.Size = new System.Drawing.Size(139, 38);
            this.btn修改商品庫.TabIndex = 72;
            this.btn修改商品庫.Text = "修改商品庫";
            this.btn修改商品庫.UseVisualStyleBackColor = true;
            this.btn修改商品庫.Click += new System.EventHandler(this.btn修改商品庫_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(547, 251);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 35);
            this.label4.TabIndex = 74;
            this.label4.Text = "簡介";
            // 
            // btn進貨
            // 
            this.btn進貨.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn進貨.Location = new System.Drawing.Point(686, 490);
            this.btn進貨.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn進貨.Name = "btn進貨";
            this.btn進貨.Size = new System.Drawing.Size(139, 36);
            this.btn進貨.TabIndex = 76;
            this.btn進貨.Text = "刪除商品";
            this.btn進貨.UseVisualStyleBackColor = true;
            this.btn進貨.Click += new System.EventHandler(this.btn進貨_Click);
            // 
            // txt簡介
            // 
            this.txt簡介.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt簡介.Location = new System.Drawing.Point(589, 288);
            this.txt簡介.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt簡介.Multiline = true;
            this.txt簡介.Name = "txt簡介";
            this.txt簡介.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt簡介.Size = new System.Drawing.Size(415, 188);
            this.txt簡介.TabIndex = 77;
            // 
            // FormAddNewProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 542);
            this.Controls.Add(this.txt簡介);
            this.Controls.Add(this.btn進貨);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn修改商品庫);
            this.Controls.Add(this.cbox商品狀況);
            this.Controls.Add(this.選取圖片);
            this.Controls.Add(this.cbox分類欄位);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt作者);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt商品價格);
            this.Controls.Add(this.txt庫存);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl庫存);
            this.Controls.Add(this.btn加入商品庫);
            this.Controls.Add(this.txt商品名稱);
            this.Controls.Add(this.pictureBox書籍圖片);
            this.Controls.Add(this.lblBookId);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormAddNewProduct";
            this.Text = "新增商品";
            this.Load += new System.EventHandler(this.FormAddNewProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox書籍圖片)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label lbl庫存;
        public System.Windows.Forms.Button btn加入商品庫;
        public System.Windows.Forms.TextBox txt商品名稱;
        public System.Windows.Forms.PictureBox pictureBox書籍圖片;
        public System.Windows.Forms.Label lblBookId;
        private System.Windows.Forms.TextBox txt商品價格;
        private System.Windows.Forms.TextBox txt庫存;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt作者;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbox分類欄位;
        public System.Windows.Forms.Button 選取圖片;
        private System.Windows.Forms.ComboBox cbox商品狀況;
        public System.Windows.Forms.Button btn修改商品庫;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button btn進貨;
        private System.Windows.Forms.TextBox txt簡介;
    }
}