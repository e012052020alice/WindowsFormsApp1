namespace WindowsFormsApp1
{
    partial class Form2ProductManagement
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
            this.listView商品展示 = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.btn全部商品 = new System.Windows.Forms.Button();
            this.btn搜尋 = new System.Windows.Forms.Button();
            this.cbox欄位名稱 = new System.Windows.Forms.ComboBox();
            this.txt搜尋關鍵字 = new System.Windows.Forms.TextBox();
            this.imageList商品圖檔 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // listView商品展示
            // 
            this.listView商品展示.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView商品展示.HideSelection = false;
            this.listView商品展示.Location = new System.Drawing.Point(9, 55);
            this.listView商品展示.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listView商品展示.MultiSelect = false;
            this.listView商品展示.Name = "listView商品展示";
            this.listView商品展示.Size = new System.Drawing.Size(757, 487);
            this.listView商品展示.TabIndex = 0;
            this.listView商品展示.UseCompatibleStateImageBehavior = false;
            this.listView商品展示.ItemActivate += new System.EventHandler(this.listView商品展示_ItemActivate);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(785, 164);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "新增商品";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn全部商品
            // 
            this.btn全部商品.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn全部商品.Location = new System.Drawing.Point(785, 105);
            this.btn全部商品.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn全部商品.Name = "btn全部商品";
            this.btn全部商品.Size = new System.Drawing.Size(82, 34);
            this.btn全部商品.TabIndex = 2;
            this.btn全部商品.Text = "全部商品";
            this.btn全部商品.UseVisualStyleBackColor = true;
            this.btn全部商品.Click += new System.EventHandler(this.btn全部商品_Click);
            // 
            // btn搜尋
            // 
            this.btn搜尋.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn搜尋.Location = new System.Drawing.Point(781, 50);
            this.btn搜尋.Name = "btn搜尋";
            this.btn搜尋.Size = new System.Drawing.Size(86, 29);
            this.btn搜尋.TabIndex = 9;
            this.btn搜尋.Text = "搜尋";
            this.btn搜尋.UseVisualStyleBackColor = true;
            this.btn搜尋.Click += new System.EventHandler(this.btn搜尋_Click);
            // 
            // cbox欄位名稱
            // 
            this.cbox欄位名稱.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox欄位名稱.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbox欄位名稱.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbox欄位名稱.FormattingEnabled = true;
            this.cbox欄位名稱.Location = new System.Drawing.Point(760, 10);
            this.cbox欄位名稱.Name = "cbox欄位名稱";
            this.cbox欄位名稱.Size = new System.Drawing.Size(107, 28);
            this.cbox欄位名稱.TabIndex = 8;
            this.cbox欄位名稱.SelectedIndexChanged += new System.EventHandler(this.cbox欄位名稱_SelectedIndexChanged);
            // 
            // txt搜尋關鍵字
            // 
            this.txt搜尋關鍵字.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt搜尋關鍵字.Location = new System.Drawing.Point(609, 11);
            this.txt搜尋關鍵字.Name = "txt搜尋關鍵字";
            this.txt搜尋關鍵字.Size = new System.Drawing.Size(145, 29);
            this.txt搜尋關鍵字.TabIndex = 7;
            // 
            // imageList商品圖檔
            // 
            this.imageList商品圖檔.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList商品圖檔.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList商品圖檔.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Form2ProductManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 553);
            this.Controls.Add(this.btn搜尋);
            this.Controls.Add(this.cbox欄位名稱);
            this.Controls.Add(this.txt搜尋關鍵字);
            this.Controls.Add(this.btn全部商品);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView商品展示);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form2ProductManagement";
            this.Text = "商品管理";
            this.Load += new System.EventHandler(this.Form2ProductManagement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView商品展示;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn全部商品;
        private System.Windows.Forms.Button btn搜尋;
        private System.Windows.Forms.ComboBox cbox欄位名稱;
        private System.Windows.Forms.TextBox txt搜尋關鍵字;
        private System.Windows.Forms.ImageList imageList商品圖檔;
    }
}