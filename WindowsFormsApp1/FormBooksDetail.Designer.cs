namespace WindowsFormsApp1
{
    partial class FormBooksDetail
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
            this.lblBookId = new System.Windows.Forms.Label();
            this.lblBookPrice = new System.Windows.Forms.Label();
            this.pictureBox書籍資訊 = new System.Windows.Forms.PictureBox();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn加入購物車 = new System.Windows.Forms.Button();
            this.lbl庫存 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox書籍資訊)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBookId
            // 
            this.lblBookId.AutoSize = true;
            this.lblBookId.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblBookId.Location = new System.Drawing.Point(12, 16);
            this.lblBookId.Name = "lblBookId";
            this.lblBookId.Size = new System.Drawing.Size(31, 27);
            this.lblBookId.TabIndex = 0;
            this.lblBookId.Text = "Id";
            // 
            // lblBookPrice
            // 
            this.lblBookPrice.AutoSize = true;
            this.lblBookPrice.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblBookPrice.Location = new System.Drawing.Point(12, 184);
            this.lblBookPrice.Name = "lblBookPrice";
            this.lblBookPrice.Size = new System.Drawing.Size(110, 27);
            this.lblBookPrice.TabIndex = 2;
            this.lblBookPrice.Text = "BookPrice";
            // 
            // pictureBox書籍資訊
            // 
            this.pictureBox書籍資訊.BackColor = System.Drawing.Color.White;
            this.pictureBox書籍資訊.Location = new System.Drawing.Point(263, 12);
            this.pictureBox書籍資訊.Name = "pictureBox書籍資訊";
            this.pictureBox書籍資訊.Size = new System.Drawing.Size(256, 256);
            this.pictureBox書籍資訊.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox書籍資訊.TabIndex = 3;
            this.pictureBox書籍資訊.TabStop = false;
            this.pictureBox書籍資訊.Click += new System.EventHandler(this.pictureBox書籍資訊_Click);
            // 
            // txtBookName
            // 
            this.txtBookName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtBookName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBookName.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtBookName.Location = new System.Drawing.Point(8, 46);
            this.txtBookName.Multiline = true;
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(178, 109);
            this.txtBookName.TabIndex = 4;
            this.txtBookName.TextChanged += new System.EventHandler(this.txtBookName_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(388, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 34);
            this.button1.TabIndex = 5;
            this.button1.Text = "低界線";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.Location = new System.Drawing.Point(17, 300);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 34);
            this.button2.TabIndex = 6;
            this.button2.Text = "加入購物車";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btn加入購物車
            // 
            this.btn加入購物車.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn加入購物車.Location = new System.Drawing.Point(411, 357);
            this.btn加入購物車.Name = "btn加入購物車";
            this.btn加入購物車.Size = new System.Drawing.Size(66, 30);
            this.btn加入購物車.TabIndex = 7;
            this.btn加入購物車.Text = "加入購物車";
            this.btn加入購物車.UseVisualStyleBackColor = true;
            this.btn加入購物車.Click += new System.EventHandler(this.btn加入購物車_Click);
            // 
            // lbl庫存
            // 
            this.lbl庫存.AutoSize = true;
            this.lbl庫存.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl庫存.Location = new System.Drawing.Point(12, 224);
            this.lbl庫存.Name = "lbl庫存";
            this.lbl庫存.Size = new System.Drawing.Size(54, 27);
            this.lbl庫存.TabIndex = 8;
            this.lbl庫存.Text = "庫存";
            // 
            // FormBooksDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(650, 540);
            this.Controls.Add(this.lbl庫存);
            this.Controls.Add(this.btn加入購物車);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBookName);
            this.Controls.Add(this.pictureBox書籍資訊);
            this.Controls.Add(this.lblBookPrice);
            this.Controls.Add(this.lblBookId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBooksDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormBooksDetail";
            this.Load += new System.EventHandler(this.FormBooksDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox書籍資訊)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBookId;
        private System.Windows.Forms.Label lblBookPrice;
        private System.Windows.Forms.PictureBox pictureBox書籍資訊;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn加入購物車;
        private System.Windows.Forms.Label lbl庫存;
    }
}