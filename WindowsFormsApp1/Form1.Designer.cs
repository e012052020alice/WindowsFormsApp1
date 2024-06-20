namespace WindowsFormsApp1
{
    partial class Form1
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

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn系統管理 = new System.Windows.Forms.Button();
            this.btn商品管理 = new System.Windows.Forms.Button();
            this.btn訂單管理 = new System.Windows.Forms.Button();
            this.btn會員資料管理 = new System.Windows.Forms.Button();
            this.btn書籍訂購單 = new System.Windows.Forms.Button();
            this.btn註冊 = new System.Windows.Forms.Button();
            this.btn登入 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn系統管理
            // 
            this.btn系統管理.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn系統管理.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn系統管理.Location = new System.Drawing.Point(376, 243);
            this.btn系統管理.Margin = new System.Windows.Forms.Padding(4);
            this.btn系統管理.Name = "btn系統管理";
            this.btn系統管理.Size = new System.Drawing.Size(239, 149);
            this.btn系統管理.TabIndex = 10;
            this.btn系統管理.Text = "系統管理";
            this.btn系統管理.UseVisualStyleBackColor = false;
            // 
            // btn商品管理
            // 
            this.btn商品管理.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn商品管理.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn商品管理.Location = new System.Drawing.Point(87, 243);
            this.btn商品管理.Margin = new System.Windows.Forms.Padding(4);
            this.btn商品管理.Name = "btn商品管理";
            this.btn商品管理.Size = new System.Drawing.Size(239, 149);
            this.btn商品管理.TabIndex = 9;
            this.btn商品管理.Text = "商品管理";
            this.btn商品管理.UseVisualStyleBackColor = false;
            this.btn商品管理.Click += new System.EventHandler(this.btn商品管理_Click);
            // 
            // btn訂單管理
            // 
            this.btn訂單管理.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn訂單管理.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn訂單管理.Location = new System.Drawing.Point(698, 67);
            this.btn訂單管理.Margin = new System.Windows.Forms.Padding(4);
            this.btn訂單管理.Name = "btn訂單管理";
            this.btn訂單管理.Size = new System.Drawing.Size(239, 149);
            this.btn訂單管理.TabIndex = 8;
            this.btn訂單管理.Text = "訂單管理";
            this.btn訂單管理.UseVisualStyleBackColor = false;
            this.btn訂單管理.Click += new System.EventHandler(this.btn訂單管理_Click);
            // 
            // btn會員資料管理
            // 
            this.btn會員資料管理.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn會員資料管理.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn會員資料管理.Location = new System.Drawing.Point(376, 67);
            this.btn會員資料管理.Margin = new System.Windows.Forms.Padding(4);
            this.btn會員資料管理.Name = "btn會員資料管理";
            this.btn會員資料管理.Size = new System.Drawing.Size(239, 149);
            this.btn會員資料管理.TabIndex = 7;
            this.btn會員資料管理.Text = "會員資料管理";
            this.btn會員資料管理.UseVisualStyleBackColor = false;
            this.btn會員資料管理.Click += new System.EventHandler(this.btn會員資料管理_Click);
            // 
            // btn書籍訂購單
            // 
            this.btn書籍訂購單.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn書籍訂購單.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn書籍訂購單.Location = new System.Drawing.Point(87, 67);
            this.btn書籍訂購單.Margin = new System.Windows.Forms.Padding(4);
            this.btn書籍訂購單.Name = "btn書籍訂購單";
            this.btn書籍訂購單.Size = new System.Drawing.Size(239, 149);
            this.btn書籍訂購單.TabIndex = 6;
            this.btn書籍訂購單.Text = "書籍訂購單";
            this.btn書籍訂購單.UseVisualStyleBackColor = false;
            this.btn書籍訂購單.Click += new System.EventHandler(this.btn書籍訂購單_Click);
            // 
            // btn註冊
            // 
            this.btn註冊.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn註冊.Location = new System.Drawing.Point(957, 321);
            this.btn註冊.Name = "btn註冊";
            this.btn註冊.Size = new System.Drawing.Size(138, 54);
            this.btn註冊.TabIndex = 11;
            this.btn註冊.Text = "註冊";
            this.btn註冊.UseVisualStyleBackColor = true;
            // 
            // btn登入
            // 
            this.btn登入.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn登入.Location = new System.Drawing.Point(957, 401);
            this.btn登入.Name = "btn登入";
            this.btn登入.Size = new System.Drawing.Size(138, 54);
            this.btn登入.TabIndex = 12;
            this.btn登入.Text = "登入";
            this.btn登入.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1128, 538);
            this.Controls.Add(this.btn登入);
            this.Controls.Add(this.btn註冊);
            this.Controls.Add(this.btn系統管理);
            this.Controls.Add(this.btn商品管理);
            this.Controls.Add(this.btn訂單管理);
            this.Controls.Add(this.btn會員資料管理);
            this.Controls.Add(this.btn書籍訂購單);
            this.Name = "Form1";
            this.Text = "書光光系統";
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 1128, 538);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn系統管理;
        private System.Windows.Forms.Button btn商品管理;
        private System.Windows.Forms.Button btn訂單管理;
        private System.Windows.Forms.Button btn會員資料管理;
        private System.Windows.Forms.Button btn書籍訂購單;
        private System.Windows.Forms.Button btn註冊;
        private System.Windows.Forms.Button btn登入;
    }
}

