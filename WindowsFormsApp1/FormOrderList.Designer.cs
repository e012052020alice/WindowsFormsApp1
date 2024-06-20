namespace WindowsFormsApp1
{
    partial class FormOrderList
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
            this.components = new System.ComponentModel.Container();
            this.listView購物車資訊 = new System.Windows.Forms.ListView();
            this.imglist書籍圖檔 = new System.Windows.Forms.ImageList(this.components);
            this.lbl總價格 = new System.Windows.Forms.Label();
            this.btn結帳 = new Sunny.UI.UIButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView購物車資訊
            // 
            this.listView購物車資訊.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView購物車資訊.CausesValidation = false;
            this.listView購物車資訊.HideSelection = false;
            this.listView購物車資訊.Location = new System.Drawing.Point(26, 27);
            this.listView購物車資訊.MultiSelect = false;
            this.listView購物車資訊.Name = "listView購物車資訊";
            this.listView購物車資訊.Size = new System.Drawing.Size(618, 404);
            this.listView購物車資訊.TabIndex = 0;
            this.listView購物車資訊.UseCompatibleStateImageBehavior = false;
            this.listView購物車資訊.View = System.Windows.Forms.View.Details;
            this.listView購物車資訊.DrawSubItem += new System.Windows.Forms.DrawListViewSubItemEventHandler(this.listView購物車資訊_DrawSubItem);
            this.listView購物車資訊.ItemActivate += new System.EventHandler(this.listView購物車資訊_ItemActivate_1);
            this.listView購物車資訊.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listView購物車資訊_ItemChecked);
            this.listView購物車資訊.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView購物車資訊_MouseClick);
            // 
            // imglist書籍圖檔
            // 
            this.imglist書籍圖檔.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imglist書籍圖檔.ImageSize = new System.Drawing.Size(16, 16);
            this.imglist書籍圖檔.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // lbl總價格
            // 
            this.lbl總價格.AutoSize = true;
            this.lbl總價格.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl總價格.Location = new System.Drawing.Point(367, 450);
            this.lbl總價格.Name = "lbl總價格";
            this.lbl總價格.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl總價格.Size = new System.Drawing.Size(27, 30);
            this.lbl總價格.TabIndex = 1;
            this.lbl總價格.Text = "0";
            // 
            // btn結帳
            // 
            this.btn結帳.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn結帳.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn結帳.Location = new System.Drawing.Point(476, 446);
            this.btn結帳.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn結帳.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn結帳.Name = "btn結帳";
            this.btn結帳.Size = new System.Drawing.Size(74, 38);
            this.btn結帳.TabIndex = 2;
            this.btn結帳.Text = "結帳";
            this.btn結帳.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn結帳.Click += new System.EventHandler(this.btn結帳_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(433, 450);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "元";
            // 
            // FormOrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 508);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn結帳);
            this.Controls.Add(this.lbl總價格);
            this.Controls.Add(this.listView購物車資訊);
            this.Name = "FormOrderList";
            this.Text = "FormOrderList";
            this.Load += new System.EventHandler(this.FormOrderList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView購物車資訊;
        private System.Windows.Forms.ImageList imglist書籍圖檔;
        private System.Windows.Forms.Label lbl總價格;
        private Sunny.UI.UIButton btn結帳;
        private System.Windows.Forms.Label label1;
    }
}