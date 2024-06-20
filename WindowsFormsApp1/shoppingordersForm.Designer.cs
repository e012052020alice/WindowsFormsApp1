namespace WindowsFormsApp1
{
    partial class shoppingordersForm
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
            this.listView訂單詳情 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // listView訂單詳情
            // 
            this.listView訂單詳情.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView訂單詳情.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listView訂單詳情.HideSelection = false;
            this.listView訂單詳情.Location = new System.Drawing.Point(10, 35);
            this.listView訂單詳情.MultiSelect = false;
            this.listView訂單詳情.Name = "listView訂單詳情";
            this.listView訂單詳情.Size = new System.Drawing.Size(690, 244);
            this.listView訂單詳情.TabIndex = 0;
            this.listView訂單詳情.UseCompatibleStateImageBehavior = false;
            this.listView訂單詳情.ItemActivate += new System.EventHandler(this.listView訂單詳情_ItemActivate);
            // 
            // shoppingordersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 362);
            this.Controls.Add(this.listView訂單詳情);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "shoppingordersForm";
            this.Text = "shoppingordersForm";
            this.Load += new System.EventHandler(this.shoppingordersForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView訂單詳情;
    }
}