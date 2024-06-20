namespace Sunny.UI.Demo
{
    partial class FEdit
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
            this.edtName = new Sunny.UI.UITextBox();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.edtAmount = new Sunny.UI.UITextBox();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.edtPrice = new Sunny.UI.UITextBox();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.btnadd1 = new Sunny.UI.UIButton();
            this.btnminus1 = new Sunny.UI.UIButton();
            this.btn刪除 = new Sunny.UI.UIButton();
            this.btn确定 = new Sunny.UI.UIButton();
            this.btn取消 = new Sunny.UI.UIButton();
            this.pnlBtm.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBtm
            // 
            this.pnlBtm.Controls.Add(this.btn取消);
            this.pnlBtm.Controls.Add(this.btn刪除);
            this.pnlBtm.Controls.Add(this.btn确定);
            this.pnlBtm.Location = new System.Drawing.Point(1, 304);
            this.pnlBtm.Size = new System.Drawing.Size(518, 55);
            this.pnlBtm.TabIndex = 7;
            this.pnlBtm.Controls.SetChildIndex(this.btn确定, 0);
            this.pnlBtm.Controls.SetChildIndex(this.btn刪除, 0);
            this.pnlBtm.Controls.SetChildIndex(this.btn取消, 0);
            this.pnlBtm.Controls.SetChildIndex(this.btnOK, 0);
            this.pnlBtm.Controls.SetChildIndex(this.btnCancel, 0);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(401, 17);
            this.btnCancel.Visible = false;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(275, 17);
            this.btnOK.Visible = false;
            // 
            // edtName
            // 
            this.edtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtName.EnterAsTab = true;
            this.edtName.Font = new System.Drawing.Font("宋体", 12F);
            this.edtName.Location = new System.Drawing.Point(150, 55);
            this.edtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.edtName.MinimumSize = new System.Drawing.Size(1, 16);
            this.edtName.Multiline = true;
            this.edtName.Name = "edtName";
            this.edtName.Padding = new System.Windows.Forms.Padding(5);
            this.edtName.ReadOnly = true;
            this.edtName.ShowText = false;
            this.edtName.Size = new System.Drawing.Size(304, 29);
            this.edtName.TabIndex = 0;
            this.edtName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.edtName.Watermark = "";
            this.edtName.TextChanged += new System.EventHandler(this.edtName_TextChanged);
            // 
            // uiLabel2
            // 
            this.uiLabel2.AutoSize = true;
            this.uiLabel2.Font = new System.Drawing.Font("宋体", 12F);
            this.uiLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel2.Location = new System.Drawing.Point(56, 59);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(39, 16);
            this.uiLabel2.TabIndex = 4;
            this.uiLabel2.Text = "書名";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // edtAmount
            // 
            this.edtAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtAmount.Font = new System.Drawing.Font("宋体", 12F);
            this.edtAmount.Location = new System.Drawing.Point(150, 135);
            this.edtAmount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.edtAmount.MinimumSize = new System.Drawing.Size(1, 16);
            this.edtAmount.Name = "edtAmount";
            this.edtAmount.Padding = new System.Windows.Forms.Padding(5);
            this.edtAmount.ReadOnly = true;
            this.edtAmount.ShowText = false;
            this.edtAmount.Size = new System.Drawing.Size(170, 29);
            this.edtAmount.TabIndex = 3;
            this.edtAmount.Text = "0";
            this.edtAmount.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.edtAmount.Type = Sunny.UI.UITextBox.UIEditType.Integer;
            this.edtAmount.Watermark = "";
            this.edtAmount.TextChanged += new System.EventHandler(this.edtAmount_TextChanged);
            // 
            // uiLabel4
            // 
            this.uiLabel4.AutoSize = true;
            this.uiLabel4.Font = new System.Drawing.Font("宋体", 12F);
            this.uiLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel4.Location = new System.Drawing.Point(56, 139);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(39, 16);
            this.uiLabel4.TabIndex = 10;
            this.uiLabel4.Text = "數量";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // edtPrice
            // 
            this.edtPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtPrice.Font = new System.Drawing.Font("宋体", 12F);
            this.edtPrice.Location = new System.Drawing.Point(150, 201);
            this.edtPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.edtPrice.MinimumSize = new System.Drawing.Size(1, 16);
            this.edtPrice.Name = "edtPrice";
            this.edtPrice.Padding = new System.Windows.Forms.Padding(5);
            this.edtPrice.ReadOnly = true;
            this.edtPrice.ShowText = false;
            this.edtPrice.Size = new System.Drawing.Size(170, 29);
            this.edtPrice.TabIndex = 6;
            this.edtPrice.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.edtPrice.Watermark = "";
            // 
            // uiLabel1
            // 
            this.uiLabel1.AutoSize = true;
            this.uiLabel1.Font = new System.Drawing.Font("宋体", 12F);
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel1.Location = new System.Drawing.Point(56, 205);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(39, 16);
            this.uiLabel1.TabIndex = 15;
            this.uiLabel1.Text = "價錢";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnadd1
            // 
            this.btnadd1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnadd1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnadd1.Location = new System.Drawing.Point(327, 135);
            this.btnadd1.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnadd1.Name = "btnadd1";
            this.btnadd1.Size = new System.Drawing.Size(26, 31);
            this.btnadd1.TabIndex = 16;
            this.btnadd1.Text = "+";
            this.btnadd1.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnadd1.Click += new System.EventHandler(this.btnadd1_Click);
            // 
            // btnminus1
            // 
            this.btnminus1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnminus1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnminus1.Location = new System.Drawing.Point(117, 135);
            this.btnminus1.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnminus1.Name = "btnminus1";
            this.btnminus1.Size = new System.Drawing.Size(26, 31);
            this.btnminus1.TabIndex = 17;
            this.btnminus1.Text = "-";
            this.btnminus1.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnminus1.Click += new System.EventHandler(this.btnminus1_Click);
            // 
            // btn刪除
            // 
            this.btn刪除.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn刪除.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn刪除.Location = new System.Drawing.Point(26, 17);
            this.btn刪除.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn刪除.Name = "btn刪除";
            this.btn刪除.Size = new System.Drawing.Size(100, 35);
            this.btn刪除.TabIndex = 2;
            this.btn刪除.Text = "刪除";
            this.btn刪除.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn刪除.Click += new System.EventHandler(this.btn刪除_Click);
            // 
            // btn确定
            // 
            this.btn确定.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn确定.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn确定.Location = new System.Drawing.Point(401, 17);
            this.btn确定.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn确定.Name = "btn确定";
            this.btn确定.Size = new System.Drawing.Size(100, 35);
            this.btn确定.TabIndex = 3;
            this.btn确定.Text = "确定";
            this.btn确定.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn确定.Click += new System.EventHandler(this.btn确定_Click);
            // 
            // btn取消
            // 
            this.btn取消.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn取消.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn取消.Location = new System.Drawing.Point(298, 17);
            this.btn取消.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn取消.Name = "btn取消";
            this.btn取消.Size = new System.Drawing.Size(100, 35);
            this.btn取消.TabIndex = 18;
            this.btn取消.Text = "取消";
            this.btn取消.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn取消.Click += new System.EventHandler(this.btn取消_Click);
            // 
            // FEdit
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(520, 362);
            this.Controls.Add(this.btnminus1);
            this.Controls.Add(this.btnadd1);
            this.Controls.Add(this.edtPrice);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.uiLabel4);
            this.Controls.Add(this.edtAmount);
            this.Controls.Add(this.edtName);
            this.Controls.Add(this.uiLabel2);
            this.Name = "FEdit";
            this.Text = "商品明細";
            this.ZoomScaleRect = new System.Drawing.Rectangle(19, 19, 520, 362);
            this.Load += new System.EventHandler(this.FEdit_Load);
            this.Controls.SetChildIndex(this.uiLabel2, 0);
            this.Controls.SetChildIndex(this.edtName, 0);
            this.Controls.SetChildIndex(this.edtAmount, 0);
            this.Controls.SetChildIndex(this.uiLabel4, 0);
            this.Controls.SetChildIndex(this.uiLabel1, 0);
            this.Controls.SetChildIndex(this.edtPrice, 0);
            this.Controls.SetChildIndex(this.btnadd1, 0);
            this.Controls.SetChildIndex(this.btnminus1, 0);
            this.Controls.SetChildIndex(this.pnlBtm, 0);
            this.pnlBtm.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private UITextBox edtName;
        private UILabel uiLabel2;
        private UITextBox edtAmount;
        private UILabel uiLabel4;
        private UITextBox edtPrice;
        private UILabel uiLabel1;
        private UIButton btnadd1;
        private UIButton btnminus1;
        private UIButton btn刪除;
        private UIButton btn确定;
        private UIButton btn取消;
    }
}