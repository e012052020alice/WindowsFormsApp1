namespace WindowsFormsApp1
{
    partial class ShoppingCart3
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
            this.btn關閉 = new System.Windows.Forms.Button();
            this.btnadd1 = new System.Windows.Forms.Button();
            this.btnminus1 = new System.Windows.Forms.Button();
            this.txt本數 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl庫存 = new System.Windows.Forms.Label();
            this.btn加入購物車 = new System.Windows.Forms.Button();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.pictureBox書籍資訊 = new System.Windows.Forms.PictureBox();
            this.lblBookPrice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblWriter = new System.Windows.Forms.Label();
            this.txt簡介 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox書籍資訊)).BeginInit();
            this.SuspendLayout();
            // 
            // btn關閉
            // 
            this.btn關閉.BackColor = System.Drawing.Color.White;
            this.btn關閉.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.cancel;
            this.btn關閉.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn關閉.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn關閉.ForeColor = System.Drawing.Color.Blue;
            this.btn關閉.Location = new System.Drawing.Point(608, 8);
            this.btn關閉.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn關閉.Name = "btn關閉";
            this.btn關閉.Size = new System.Drawing.Size(23, 28);
            this.btn關閉.TabIndex = 44;
            this.btn關閉.UseVisualStyleBackColor = false;
            this.btn關閉.Click += new System.EventHandler(this.btn關閉_Click);
            // 
            // btnadd1
            // 
            this.btnadd1.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnadd1.Location = new System.Drawing.Point(565, 272);
            this.btnadd1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnadd1.Name = "btnadd1";
            this.btnadd1.Size = new System.Drawing.Size(21, 31);
            this.btnadd1.TabIndex = 43;
            this.btnadd1.Text = "+";
            this.btnadd1.UseVisualStyleBackColor = true;
            this.btnadd1.Click += new System.EventHandler(this.btnadd1_Click);
            // 
            // btnminus1
            // 
            this.btnminus1.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnminus1.Location = new System.Drawing.Point(387, 272);
            this.btnminus1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnminus1.Name = "btnminus1";
            this.btnminus1.Size = new System.Drawing.Size(21, 31);
            this.btnminus1.TabIndex = 42;
            this.btnminus1.Text = "-";
            this.btnminus1.UseVisualStyleBackColor = true;
            this.btnminus1.Click += new System.EventHandler(this.btnminus1_Click);
            // 
            // txt本數
            // 
            this.txt本數.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt本數.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt本數.Location = new System.Drawing.Point(427, 274);
            this.txt本數.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt本數.Name = "txt本數";
            this.txt本數.ReadOnly = true;
            this.txt本數.Size = new System.Drawing.Size(120, 47);
            this.txt本數.TabIndex = 41;
            this.txt本數.Text = "1";
            this.txt本數.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(604, 281);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 34);
            this.label7.TabIndex = 40;
            this.label7.Text = "本";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(435, 240);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 25);
            this.label4.TabIndex = 39;
            this.label4.Text = "庫存:";
            // 
            // lbl庫存
            // 
            this.lbl庫存.AutoSize = true;
            this.lbl庫存.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl庫存.Location = new System.Drawing.Point(493, 240);
            this.lbl庫存.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl庫存.Name = "lbl庫存";
            this.lbl庫存.Size = new System.Drawing.Size(52, 25);
            this.lbl庫存.TabIndex = 38;
            this.lbl庫存.Text = "庫存";
            // 
            // btn加入購物車
            // 
            this.btn加入購物車.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn加入購物車.Location = new System.Drawing.Point(427, 342);
            this.btn加入購物車.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn加入購物車.Name = "btn加入購物車";
            this.btn加入購物車.Size = new System.Drawing.Size(139, 36);
            this.btn加入購物車.TabIndex = 37;
            this.btn加入購物車.Text = "加入購物車";
            this.btn加入購物車.UseVisualStyleBackColor = true;
            this.btn加入購物車.Click += new System.EventHandler(this.btn加入購物車_Click);
            // 
            // txtBookName
            // 
            this.txtBookName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtBookName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBookName.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtBookName.Location = new System.Drawing.Point(4, 8);
            this.txtBookName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBookName.Multiline = true;
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(277, 42);
            this.txtBookName.TabIndex = 36;
            this.txtBookName.TextChanged += new System.EventHandler(this.txtBookName_TextChanged);
            // 
            // pictureBox書籍資訊
            // 
            this.pictureBox書籍資訊.BackColor = System.Drawing.Color.White;
            this.pictureBox書籍資訊.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox書籍資訊.Location = new System.Drawing.Point(409, 24);
            this.pictureBox書籍資訊.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox書籍資訊.Name = "pictureBox書籍資訊";
            this.pictureBox書籍資訊.Size = new System.Drawing.Size(163, 180);
            this.pictureBox書籍資訊.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox書籍資訊.TabIndex = 35;
            this.pictureBox書籍資訊.TabStop = false;
            // 
            // lblBookPrice
            // 
            this.lblBookPrice.AutoSize = true;
            this.lblBookPrice.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblBookPrice.Location = new System.Drawing.Point(100, 106);
            this.lblBookPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookPrice.Name = "lblBookPrice";
            this.lblBookPrice.Size = new System.Drawing.Size(106, 25);
            this.lblBookPrice.TabIndex = 34;
            this.lblBookPrice.Text = "BookPrice";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(13, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 25);
            this.label1.TabIndex = 33;
            this.label1.Text = "作者:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(13, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 25);
            this.label2.TabIndex = 45;
            this.label2.Text = "定價:";
            // 
            // lblWriter
            // 
            this.lblWriter.AutoSize = true;
            this.lblWriter.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblWriter.Location = new System.Drawing.Point(100, 70);
            this.lblWriter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWriter.Name = "lblWriter";
            this.lblWriter.Size = new System.Drawing.Size(118, 25);
            this.lblWriter.TabIndex = 46;
            this.lblWriter.Text = "BookWriter";
            // 
            // txt簡介
            // 
            this.txt簡介.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt簡介.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt簡介.Location = new System.Drawing.Point(19, 170);
            this.txt簡介.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt簡介.Multiline = true;
            this.txt簡介.Name = "txt簡介";
            this.txt簡介.ReadOnly = true;
            this.txt簡介.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt簡介.Size = new System.Drawing.Size(345, 214);
            this.txt簡介.TabIndex = 79;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(19, 141);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 25);
            this.label3.TabIndex = 78;
            this.label3.Text = "簡介";
            // 
            // ShoppingCart3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txt簡介);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblWriter);
            this.Controls.Add(this.label2);
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
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ShoppingCart3";
            this.Size = new System.Drawing.Size(788, 626);
            this.Load += new System.EventHandler(this.ShoppingCart3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox書籍資訊)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btn關閉;
        public System.Windows.Forms.PictureBox pictureBox書籍資訊;
        public System.Windows.Forms.Button btnadd1;
        public System.Windows.Forms.Button btnminus1;
        public System.Windows.Forms.TextBox txt本數;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label lbl庫存;
        public System.Windows.Forms.Button btn加入購物車;
        public System.Windows.Forms.TextBox txtBookName;
        public System.Windows.Forms.Label lblBookPrice;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lblWriter;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txt簡介;
    }
}
