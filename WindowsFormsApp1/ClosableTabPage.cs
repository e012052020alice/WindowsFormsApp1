using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class ClosableTabPage : TabPage
    {
        public event EventHandler CloseButtonClick;

        public ClosableTabPage(string text) : base(text) { }

        protected override void OnPaint(PaintEventArgs e)
        {
            //base.OnPaint(e);

            //// 在標籤文字的右邊繪製關閉按鈕
            //int textWidth = TextRenderer.MeasureText(Text, Font).Width;
            //Button closeButton = new Button
            //{
            //    Text = "關閉",
            //    Size = new Size(35, 20),
            //    Location = new Point(textWidth + 5, 5),
            //    FlatStyle = FlatStyle.Flat,
            //    Font = new Font("微軟正黑體", 8),
            //    Parent = this
            //};
            //closeButton.FlatAppearance.BorderSize = 0;
            //closeButton.BackColor = Color.Pink;
            //closeButton.ForeColor = Color.Blue;
            //closeButton.Click += (sender, args) => CloseButtonClick?.Invoke(this, EventArgs.Empty);



            //ClosableTabPage newTabPage = new ClosableTabPage(tabPageText);

            //// 訂閱關閉按鈕的點擊事件
            //newTabPage.CloseButtonClick += (sender, e) =>
            //{
            //    tabControl1.TabPages.Remove(newTabPage);
            //};

            //// 將新的 TabPage 加入到 TabControl 中
            //tabControl1.TabPages.Add(newTabPage);
        }
    }
}
