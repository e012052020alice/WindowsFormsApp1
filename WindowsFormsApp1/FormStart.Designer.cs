namespace WindowsFormsApp1
{
    partial class FormStart
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
            this.btn登入 = new System.Windows.Forms.Button();
            this.btn註冊 = new System.Windows.Forms.Button();
            this.btn系統管理 = new System.Windows.Forms.Button();
            this.btn商品管理 = new System.Windows.Forms.Button();
            this.btn訂單管理 = new System.Windows.Forms.Button();
            this.btn會員資料管理 = new System.Windows.Forms.Button();
            this.btn書籍訂購單 = new System.Windows.Forms.Button();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.lbl系統維護 = new Sunny.UI.UILabel();
            this.txt密碼 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl姓名 = new Sunny.UI.UILabel();
            this.lbl權限 = new Sunny.UI.UILabel();
            this.btn登出 = new Sunny.UI.UIButton();
            this.panelChildForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn登入
            // 
            this.btn登入.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn登入.Location = new System.Drawing.Point(479, 525);
            this.btn登入.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn登入.Name = "btn登入";
            this.btn登入.Size = new System.Drawing.Size(139, 54);
            this.btn登入.TabIndex = 19;
            this.btn登入.Text = "登入";
            this.btn登入.UseVisualStyleBackColor = true;
            this.btn登入.Click += new System.EventHandler(this.btn登入_Click);
            // 
            // btn註冊
            // 
            this.btn註冊.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn註冊.Location = new System.Drawing.Point(479, 604);
            this.btn註冊.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn註冊.Name = "btn註冊";
            this.btn註冊.Size = new System.Drawing.Size(139, 54);
            this.btn註冊.TabIndex = 18;
            this.btn註冊.Text = "註冊";
            this.btn註冊.UseVisualStyleBackColor = true;
            this.btn註冊.Click += new System.EventHandler(this.btn註冊_Click);
            // 
            // btn系統管理
            // 
            this.btn系統管理.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn系統管理.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn系統管理.Location = new System.Drawing.Point(3, 368);
            this.btn系統管理.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn系統管理.Name = "btn系統管理";
            this.btn系統管理.Size = new System.Drawing.Size(207, 50);
            this.btn系統管理.TabIndex = 17;
            this.btn系統管理.Text = "系統管理";
            this.btn系統管理.UseVisualStyleBackColor = false;
            this.btn系統管理.Visible = false;
            this.btn系統管理.Click += new System.EventHandler(this.btn系統管理_Click);
            // 
            // btn商品管理
            // 
            this.btn商品管理.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn商品管理.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn商品管理.Location = new System.Drawing.Point(3, 208);
            this.btn商品管理.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn商品管理.Name = "btn商品管理";
            this.btn商品管理.Size = new System.Drawing.Size(207, 50);
            this.btn商品管理.TabIndex = 16;
            this.btn商品管理.Text = "商品管理";
            this.btn商品管理.UseVisualStyleBackColor = false;
            this.btn商品管理.Visible = false;
            this.btn商品管理.Click += new System.EventHandler(this.btn商品管理_Click);
            // 
            // btn訂單管理
            // 
            this.btn訂單管理.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn訂單管理.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn訂單管理.Location = new System.Drawing.Point(3, 284);
            this.btn訂單管理.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn訂單管理.Name = "btn訂單管理";
            this.btn訂單管理.Size = new System.Drawing.Size(207, 50);
            this.btn訂單管理.TabIndex = 15;
            this.btn訂單管理.Text = "訂單管理";
            this.btn訂單管理.UseVisualStyleBackColor = false;
            this.btn訂單管理.Visible = false;
            this.btn訂單管理.Click += new System.EventHandler(this.btn訂單管理_Click);
            // 
            // btn會員資料管理
            // 
            this.btn會員資料管理.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn會員資料管理.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn會員資料管理.Location = new System.Drawing.Point(3, 128);
            this.btn會員資料管理.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn會員資料管理.Name = "btn會員資料管理";
            this.btn會員資料管理.Size = new System.Drawing.Size(207, 50);
            this.btn會員資料管理.TabIndex = 14;
            this.btn會員資料管理.Text = "會員資料管理";
            this.btn會員資料管理.UseVisualStyleBackColor = false;
            this.btn會員資料管理.Visible = false;
            this.btn會員資料管理.Click += new System.EventHandler(this.btn會員資料管理_Click);
            // 
            // btn書籍訂購單
            // 
            this.btn書籍訂購單.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn書籍訂購單.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn書籍訂購單.Location = new System.Drawing.Point(3, 51);
            this.btn書籍訂購單.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn書籍訂購單.Name = "btn書籍訂購單";
            this.btn書籍訂購單.Size = new System.Drawing.Size(207, 50);
            this.btn書籍訂購單.TabIndex = 13;
            this.btn書籍訂購單.Text = "書籍訂購單";
            this.btn書籍訂購單.UseVisualStyleBackColor = false;
            this.btn書籍訂購單.Visible = false;
            this.btn書籍訂購單.Click += new System.EventHandler(this.btn書籍訂購單_Click);
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelChildForm.Controls.Add(this.lbl系統維護);
            this.panelChildForm.Controls.Add(this.txt密碼);
            this.panelChildForm.Controls.Add(this.label2);
            this.panelChildForm.Controls.Add(this.txtEmail);
            this.panelChildForm.Controls.Add(this.label9);
            this.panelChildForm.Controls.Add(this.btn註冊);
            this.panelChildForm.Controls.Add(this.btn登入);
            this.panelChildForm.Location = new System.Drawing.Point(211, 61);
            this.panelChildForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1207, 750);
            this.panelChildForm.TabIndex = 20;
            // 
            // lbl系統維護
            // 
            this.lbl系統維護.Font = new System.Drawing.Font("微軟正黑體", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl系統維護.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lbl系統維護.Location = new System.Drawing.Point(100, 218);
            this.lbl系統維護.Name = "lbl系統維護";
            this.lbl系統維護.Size = new System.Drawing.Size(1067, 305);
            this.lbl系統維護.TabIndex = 121;
            this.lbl系統維護.Text = "uiLabel1";
            this.lbl系統維護.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl系統維護.Visible = false;
            // 
            // txt密碼
            // 
            this.txt密碼.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt密碼.Location = new System.Drawing.Point(427, 314);
            this.txt密碼.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt密碼.Name = "txt密碼";
            this.txt密碼.PasswordChar = '*';
            this.txt密碼.Size = new System.Drawing.Size(348, 43);
            this.txt密碼.TabIndex = 120;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(325, 318);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 35);
            this.label2.TabIndex = 119;
            this.label2.Text = "密碼";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEmail.Location = new System.Drawing.Point(427, 226);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(343, 43);
            this.txtEmail.TabIndex = 118;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(309, 236);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 35);
            this.label9.TabIndex = 117;
            this.label9.Text = "Email";
            // 
            // lbl姓名
            // 
            this.lbl姓名.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl姓名.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lbl姓名.Location = new System.Drawing.Point(1211, 18);
            this.lbl姓名.Name = "lbl姓名";
            this.lbl姓名.Size = new System.Drawing.Size(100, 22);
            this.lbl姓名.TabIndex = 21;
            this.lbl姓名.Text = "uiLabel1";
            this.lbl姓名.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl姓名.Visible = false;
            // 
            // lbl權限
            // 
            this.lbl權限.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl權限.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lbl權限.Location = new System.Drawing.Point(1112, 18);
            this.lbl權限.Name = "lbl權限";
            this.lbl權限.Size = new System.Drawing.Size(100, 22);
            this.lbl權限.TabIndex = 22;
            this.lbl權限.Text = "uiLabel2";
            this.lbl權限.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl權限.Visible = false;
            // 
            // btn登出
            // 
            this.btn登出.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn登出.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn登出.Location = new System.Drawing.Point(1327, 12);
            this.btn登出.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn登出.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn登出.Name = "btn登出";
            this.btn登出.Size = new System.Drawing.Size(67, 35);
            this.btn登出.TabIndex = 23;
            this.btn登出.Text = "登出";
            this.btn登出.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn登出.Visible = false;
            this.btn登出.Click += new System.EventHandler(this.btn登出_Click);
            // 
            // FormStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1416, 811);
            this.Controls.Add(this.btn登出);
            this.Controls.Add(this.lbl權限);
            this.Controls.Add(this.lbl姓名);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.btn系統管理);
            this.Controls.Add(this.btn商品管理);
            this.Controls.Add(this.btn訂單管理);
            this.Controls.Add(this.btn會員資料管理);
            this.Controls.Add(this.btn書籍訂購單);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormStart";
            this.Text = "書籍銷售系統";
            this.Load += new System.EventHandler(this.FormStart_Load);
            this.panelChildForm.ResumeLayout(false);
            this.panelChildForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn登入;
        private System.Windows.Forms.Button btn註冊;
        private System.Windows.Forms.Button btn系統管理;
        private System.Windows.Forms.Button btn商品管理;
        private System.Windows.Forms.Button btn訂單管理;
        private System.Windows.Forms.Button btn會員資料管理;
        private System.Windows.Forms.Button btn書籍訂購單;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.TextBox txt密碼;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label9;
        private Sunny.UI.UILabel lbl姓名;
        private Sunny.UI.UILabel lbl權限;
        private Sunny.UI.UIButton btn登出;
        private Sunny.UI.UILabel lbl系統維護;
    }
}