namespace WindowsFormsApp1
{
    partial class FormBooksOrders
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
            this.imageList書籍圖檔 = new System.Windows.Forms.ImageList(this.components);
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn訂單查詢 = new System.Windows.Forms.Button();
            this.btn購物車 = new System.Windows.Forms.Button();
            this.listView書籍展示 = new System.Windows.Forms.ListView();
            this.cbox書籍分類欄位 = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.shoppingCart31 = new WindowsFormsApp1.ShoppingCart3();
            this.shoppingCartUserControl21 = new WindowsFormsApp1.ShoppingCartUserControl2();
            this.tabPage4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList書籍圖檔
            // 
            this.imageList書籍圖檔.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList書籍圖檔.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList書籍圖檔.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.shoppingCartUserControl21);
            this.tabPage4.Location = new System.Drawing.Point(4, 31);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(893, 558);
            this.tabPage4.TabIndex = 2;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            this.tabPage4.UseWaitCursor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.shoppingCart31);
            this.tabPage3.Location = new System.Drawing.Point(4, 31);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(893, 558);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.UseWaitCursor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tabPage1.Controls.Add(this.btn訂單查詢);
            this.tabPage1.Controls.Add(this.btn購物車);
            this.tabPage1.Controls.Add(this.listView書籍展示);
            this.tabPage1.Controls.Add(this.cbox書籍分類欄位);
            this.tabPage1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabPage1.Size = new System.Drawing.Size(893, 558);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "書籍瀏覽區";
            this.tabPage1.UseWaitCursor = true;
            // 
            // btn訂單查詢
            // 
            this.btn訂單查詢.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btn訂單查詢.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn訂單查詢.Location = new System.Drawing.Point(717, 224);
            this.btn訂單查詢.Name = "btn訂單查詢";
            this.btn訂單查詢.Size = new System.Drawing.Size(138, 38);
            this.btn訂單查詢.TabIndex = 3;
            this.btn訂單查詢.Text = "訂單查詢";
            this.btn訂單查詢.UseVisualStyleBackColor = true;
            this.btn訂單查詢.UseWaitCursor = true;
            this.btn訂單查詢.Click += new System.EventHandler(this.btn訂單查詢_Click);
            // 
            // btn購物車
            // 
            this.btn購物車.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btn購物車.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn購物車.Location = new System.Drawing.Point(717, 134);
            this.btn購物車.Name = "btn購物車";
            this.btn購物車.Size = new System.Drawing.Size(138, 38);
            this.btn購物車.TabIndex = 2;
            this.btn購物車.Text = "購物車";
            this.btn購物車.UseVisualStyleBackColor = true;
            this.btn購物車.UseWaitCursor = true;
            this.btn購物車.Click += new System.EventHandler(this.btn購物車_Click);
            // 
            // listView書籍展示
            // 
            this.listView書籍展示.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView書籍展示.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.listView書籍展示.HideSelection = false;
            this.listView書籍展示.Location = new System.Drawing.Point(14, 5);
            this.listView書籍展示.Margin = new System.Windows.Forms.Padding(2);
            this.listView書籍展示.MultiSelect = false;
            this.listView書籍展示.Name = "listView書籍展示";
            this.listView書籍展示.Size = new System.Drawing.Size(684, 535);
            this.listView書籍展示.TabIndex = 0;
            this.listView書籍展示.UseCompatibleStateImageBehavior = false;
            this.listView書籍展示.UseWaitCursor = true;
            this.listView書籍展示.ItemActivate += new System.EventHandler(this.listView書籍展示_ItemActivate);
            // 
            // cbox書籍分類欄位
            // 
            this.cbox書籍分類欄位.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.cbox書籍分類欄位.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox書籍分類欄位.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbox書籍分類欄位.FormattingEnabled = true;
            this.cbox書籍分類欄位.Location = new System.Drawing.Point(717, 24);
            this.cbox書籍分類欄位.Margin = new System.Windows.Forms.Padding(2);
            this.cbox書籍分類欄位.Name = "cbox書籍分類欄位";
            this.cbox書籍分類欄位.Size = new System.Drawing.Size(138, 36);
            this.cbox書籍分類欄位.TabIndex = 1;
            this.cbox書籍分類欄位.UseWaitCursor = true;
            this.cbox書籍分類欄位.SelectedIndexChanged += new System.EventHandler(this.cbox書籍分類欄位_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.tabControl1.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabControl1.HotTrack = true;
            this.tabControl1.Location = new System.Drawing.Point(2, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(901, 593);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 2;
            this.tabControl1.UseWaitCursor = true;
            // 
            // shoppingCart31
            // 
            this.shoppingCart31.BackColor = System.Drawing.Color.White;
            this.shoppingCart31.Location = new System.Drawing.Point(1, 0);
            this.shoppingCart31.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.shoppingCart31.Name = "shoppingCart31";
            this.shoppingCart31.Size = new System.Drawing.Size(886, 553);
            this.shoppingCart31.TabIndex = 0;
            this.shoppingCart31.UseWaitCursor = true;
            // 
            // shoppingCartUserControl21
            // 
            this.shoppingCartUserControl21.Location = new System.Drawing.Point(-1, 0);
            this.shoppingCartUserControl21.Margin = new System.Windows.Forms.Padding(4);
            this.shoppingCartUserControl21.Name = "shoppingCartUserControl21";
            this.shoppingCartUserControl21.Size = new System.Drawing.Size(868, 552);
            this.shoppingCartUserControl21.TabIndex = 0;
            this.shoppingCartUserControl21.UseWaitCursor = true;
            // 
            // FormBooksOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 592);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormBooksOrders";
            this.Text = "FormBooksOrders";
            this.Load += new System.EventHandler(this.FormBooksOrders_Load);
            this.tabPage4.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList書籍圖檔;
        private System.Windows.Forms.TabPage tabPage4;
        private ShoppingCartUserControl2 shoppingCartUserControl21;
        private System.Windows.Forms.TabPage tabPage3;
        private ShoppingCart3 shoppingCart31;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn購物車;
        private System.Windows.Forms.ListView listView書籍展示;
        private System.Windows.Forms.ComboBox cbox書籍分類欄位;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button btn訂單查詢;
    }
}