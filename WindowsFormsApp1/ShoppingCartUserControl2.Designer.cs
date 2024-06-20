namespace WindowsFormsApp1
{
    partial class ShoppingCartUserControl2
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
            this.lblBookId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox書籍資訊)).BeginInit();
            this.SuspendLayout();
            // 
            // btn關閉
            // 
            this.btn關閉.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn關閉.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn關閉.ForeColor = System.Drawing.Color.Blue;
            this.btn關閉.Location = new System.Drawing.Point(564, 19);
            this.btn關閉.Name = "btn關閉";
            this.btn關閉.Size = new System.Drawing.Size(24, 27);
            this.btn關閉.TabIndex = 32;
            this.btn關閉.Text = "關閉";
            this.btn關閉.UseVisualStyleBackColor = false;
            this.btn關閉.Click += new System.EventHandler(this.btn關閉_Click);
            // 
            // btnadd1
            // 
            this.btnadd1.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnadd1.Location = new System.Drawing.Point(485, 230);
            this.btnadd1.Name = "btnadd1";
            this.btnadd1.Size = new System.Drawing.Size(15, 26);
            this.btnadd1.TabIndex = 31;
            this.btnadd1.Text = "+";
            this.btnadd1.UseVisualStyleBackColor = true;
            this.btnadd1.Click += new System.EventHandler(this.btnadd1_Click);
            // 
            // btnminus1
            // 
            this.btnminus1.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnminus1.Location = new System.Drawing.Point(351, 230);
            this.btnminus1.Name = "btnminus1";
            this.btnminus1.Size = new System.Drawing.Size(15, 26);
            this.btnminus1.TabIndex = 30;
            this.btnminus1.Text = "-";
            this.btnminus1.UseVisualStyleBackColor = true;
            this.btnminus1.Click += new System.EventHandler(this.btnminus1_Click);
            // 
            // txt本數
            // 
            this.txt本數.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt本數.Location = new System.Drawing.Point(381, 230);
            this.txt本數.Name = "txt本數";
            this.txt本數.ReadOnly = true;
            this.txt本數.Size = new System.Drawing.Size(90, 39);
            this.txt本數.TabIndex = 29;
            this.txt本數.Text = "1";
            this.txt本數.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(506, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 27);
            this.label7.TabIndex = 28;
            this.label7.Text = "本";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(397, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 27);
            this.label4.TabIndex = 27;
            this.label4.Text = "數量";
            // 
            // lbl庫存
            // 
            this.lbl庫存.AutoSize = true;
            this.lbl庫存.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl庫存.Location = new System.Drawing.Point(20, 268);
            this.lbl庫存.Name = "lbl庫存";
            this.lbl庫存.Size = new System.Drawing.Size(54, 27);
            this.lbl庫存.TabIndex = 26;
            this.lbl庫存.Text = "庫存";
            // 
            // btn加入購物車
            // 
            this.btn加入購物車.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn加入購物車.Location = new System.Drawing.Point(381, 285);
            this.btn加入購物車.Name = "btn加入購物車";
            this.btn加入購物車.Size = new System.Drawing.Size(103, 27);
            this.btn加入購物車.TabIndex = 25;
            this.btn加入購物車.Text = "加入購物車";
            this.btn加入購物車.UseVisualStyleBackColor = true;
            this.btn加入購物車.Click += new System.EventHandler(this.btn加入購物車_Click);
            // 
            // txtBookName
            // 
            this.txtBookName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtBookName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBookName.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtBookName.Location = new System.Drawing.Point(13, 66);
            this.txtBookName.Multiline = true;
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(178, 109);
            this.txtBookName.TabIndex = 24;
            this.txtBookName.TextChanged += new System.EventHandler(this.txtBookName_TextChanged);
            // 
            // pictureBox書籍資訊
            // 
            this.pictureBox書籍資訊.BackColor = System.Drawing.Color.White;
            this.pictureBox書籍資訊.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox書籍資訊.Location = new System.Drawing.Point(362, 19);
            this.pictureBox書籍資訊.Name = "pictureBox書籍資訊";
            this.pictureBox書籍資訊.Size = new System.Drawing.Size(122, 144);
            this.pictureBox書籍資訊.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox書籍資訊.TabIndex = 23;
            this.pictureBox書籍資訊.TabStop = false;
            // 
            // lblBookPrice
            // 
            this.lblBookPrice.AutoSize = true;
            this.lblBookPrice.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblBookPrice.Location = new System.Drawing.Point(20, 207);
            this.lblBookPrice.Name = "lblBookPrice";
            this.lblBookPrice.Size = new System.Drawing.Size(110, 27);
            this.lblBookPrice.TabIndex = 22;
            this.lblBookPrice.Text = "BookPrice";
            // 
            // lblBookId
            // 
            this.lblBookId.AutoSize = true;
            this.lblBookId.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblBookId.Location = new System.Drawing.Point(20, 19);
            this.lblBookId.Name = "lblBookId";
            this.lblBookId.Size = new System.Drawing.Size(31, 27);
            this.lblBookId.TabIndex = 21;
            this.lblBookId.Text = "Id";
            // 
            // ShoppingCartUserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ShoppingCartUserControl2";
            this.Size = new System.Drawing.Size(670, 443);
            this.Load += new System.EventHandler(this.ShoppingCartUserControl2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox書籍資訊)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btn關閉;
        private System.Windows.Forms.Button btnadd1;
        private System.Windows.Forms.Button btnminus1;
        private System.Windows.Forms.TextBox txt本數;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl庫存;
        private System.Windows.Forms.Button btn加入購物車;
        private System.Windows.Forms.TextBox txtBookName;
        public System.Windows.Forms.PictureBox pictureBox書籍資訊;
        private System.Windows.Forms.Label lblBookPrice;
        private System.Windows.Forms.Label lblBookId;
    }
}
