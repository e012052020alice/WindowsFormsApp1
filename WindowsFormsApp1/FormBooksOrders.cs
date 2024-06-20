using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Policy;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace WindowsFormsApp1
{
    public partial class FormBooksOrders : Form
    {

        List<string> list書籍名稱 = new List<string>();
        List<int> list書籍價格 = new List<int>();
        List<int> listId = new List<int>();
        string str欄位名稱 = "";
        string str書籍Name = "";
        string str圖檔名稱 = "";
        public FormBooksOrders()
        {
            InitializeComponent();
        }

        private void AddClosableTabPage(Form childForm)//創建新頁面和關閉頁面按鈕
        {
            // 創建新的 TabPage
            TabPage newTabPage = new TabPage();
            newTabPage.Text = str書籍Name;
            newTabPage.Size = tabControl1.ClientSize;
            // 在 TabPage 中加入控制項或其他 UI 元素
            //Label label = new Label();
            //label.Text = $"這是 {tabPageText} 頁面";
            //newTabPage.Controls.Add(label);

            Panel panel = new Panel();
            panel.Dock = DockStyle.Fill;
            ////panel.BackColor = Color.Green;
            panel.Padding = new Padding(0);
            panel.AutoScroll = true;


            // 在 TabPage 加入一個關閉按鈕
            Button closeButton = new Button();
            closeButton.BackColor = Color.Pink;
            closeButton.ForeColor = Color.Blue;
            closeButton.Font = new Font("微軟正黑體", 9);
            closeButton.Text = "關閉";
            closeButton.Size = new Size(40, 40);
            closeButton.Name = string.Format("btn0");

            //closeButton.Dock = DockStyle.None;
            //int textWidth = TextRenderer.MeasureText(tabPageText, Font).Width;
            // 設定位置，放在文字的右邊
            closeButton.Location = new Point(800, 10);

            ////加入購物車按鈕
            //Button addShoppingCartButton = new Button();
            //addShoppingCartButton.BackColor = Color.Gray;
            //addShoppingCartButton.ForeColor = Color.Blue;
            //addShoppingCartButton.Font = new Font("微軟正黑體", 12);
            //addShoppingCartButton.Text = "加入購物車";
            //addShoppingCartButton.Size = new Size(100, 40);
            //addShoppingCartButton.Name = string.Format("btn1");
            //addShoppingCartButton.Location = new Point(750, 50);

            ////查看購物車按鈕
            //Button shoppingcartButton = new Button();
            //shoppingcartButton.BackColor = Color.Gray;
            //shoppingcartButton.ForeColor = Color.Blue;
            //shoppingcartButton.Font = new Font("微軟正黑體", 12);
            //shoppingcartButton.Text = "購物車";
            //shoppingcartButton.Size = new Size(100, 40);
            //shoppingcartButton.Name = string.Format("btn2");
            //shoppingcartButton.Location = new Point(750, 90);

            //closeButton.Location = new Point(newTabPage.Width - closeButton.Width - 10, 10);
            //childForm.TopLevel = false;
            //childForm.FormBorderStyle = FormBorderStyle.None;
            //childForm.Dock = DockStyle.Fill;
            //newTabPage.Controls.Add(childForm);


            childForm.Dock = DockStyle.None;
            //childForm.Size = panel.Size;
            childForm.Location = new Point(childForm.Margin.Left, childForm.Margin.Top);
            // 顯示子表單
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            //childForm.Dock = DockStyle.Fill;
            //childForm.Padding = new Padding(0);
            childForm.Parent = panel;
            //// 啟用 Panel 的自動捲動
            //panel.AutoScroll = true;

            //childForm.BringToFront();
            //childForm.Show();

            closeButton.Click += (sender, e) =>
            {
                tabControl1.TabPages.Remove(newTabPage);
            };
            //addShoppingCartButton.Click += (sender, e) =>
            //{

            //};
            //shoppingcartButton.Click += (sender, e) =>
            //{

            //};

            newTabPage.Controls.Add(closeButton);
            //newTabPage.Controls.Add(addShoppingCartButton);
            //newTabPage.Controls.Add(shoppingcartButton);
            newTabPage.Controls.Add(panel);
            panel.Controls.Add(childForm);
            childForm.Size = panel.Size;
            tabControl1.TabPages.Add(newTabPage);


            // 將新的 TabPage 加入到 TabControl 中
            //tabControl1.TabPages.Add(newTabPage);
            //activeForm = childForm;

            childForm.Show();

        }
        private void FormBooksOrders_Load(object sender, EventArgs e)
        {
            Console.WriteLine(123);
            cbox書籍分類欄位.Items.Add("文學小說");
            cbox書籍分類欄位.Items.Add("心理勵志");
            cbox書籍分類欄位.Items.Add("商業理財");
            cbox書籍分類欄位.Items.Add("電腦資訊");
            cbox書籍分類欄位.Items.Add("輕小說");                      
            cbox書籍分類欄位.SelectedIndex = 0;

            tabControl1.TabPages.Remove(tabPage3);
            tabControl1.TabPages.Remove(tabPage4);
            //int tabPageIndexToHide = 1; // 要隱藏的 TabPage 的索引
            //tabControl1.TabPages[tabPageIndexToHide].Hide();
            //// 或者使用頁面的名稱
            //string tabPageNameToHide = "tabPage3"; // 要隱藏的 TabPage 的名稱
            //TabPage tabPageToHide = tabControl1.TabPages[tabPageNameToHide];
            //tabPageToHide.Hide();


            //FormBooksDetail myFormBooksDetail = new FormBooksDetail();
            //AddClosableTabPage(myFormBooksDetail);

            //TabPage newTabPage = new TabPage("新的頁面");
            //// 在 TabPage 中加入控制項或其他 UI 元素
            //Label label = new Label();
            //label.Text = "這是新的頁面";
            //newTabPage.Controls.Add(label);

            //// 將新的 TabPage 加入到 TabControl 中
            //tabControl1.TabPages.Add(newTabPage);
        }
        void 讀取商品資料庫()
        {
            //listView書籍展示.Clear();
            imageList書籍圖檔.Images.Clear();
            listId.Clear();
            list書籍名稱.Clear();
            list書籍價格.Clear();
            str欄位名稱 = cbox書籍分類欄位.SelectedItem.ToString();
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            string strSQL = "";
            //Console.WriteLine(strSQL );
            strSQL = $"select * from productBook where BookClassification='{str欄位名稱}';";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();
            int count = 0;
            //Image img書籍圖檔 = Image.FromFile(@"D:\全端工程師就業養成班\期中個人專題\書籍圖片\刻意練習：原創者全面解析，比天賦更關鍵的學習法.png");
            //imageList書籍圖檔.Images.Add(img書籍圖檔);
            while (reader.Read())
            {
                listId.Add((int)reader["BookID"]);
                list書籍名稱.Add((string)reader["BookName"]);
                list書籍價格.Add((int)reader["BookPrice"]);
                string image_name = ((string)reader["BookImage"]);
                string 完整圖片路徑 = $"{GlobalVar.image_dir}\\{image_name}";
                //Console.WriteLine(完整圖片路徑);
                Image img書籍圖檔 = Image.FromFile(完整圖片路徑);
                imageList書籍圖檔.Images.Add(img書籍圖檔);
                count++;
            }

            reader.Close();
            con.Close();
            Console.WriteLine($"讀取{count}筆資料");
        }
        void 顯示listView_圖片模式()
        {
            listView書籍展示.Clear();
            listView書籍展示.View = View.LargeIcon;
            imageList書籍圖檔.ImageSize = new Size(120, 120);
            listView書籍展示.LargeImageList = imageList書籍圖檔;
            for (int i = 0; i < listId.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = i;
                item.Text = $"{list書籍名稱[i]} {list書籍價格[i]}元";
                item.Font = new Font("微軟正黑體", 14, FontStyle.Regular);
                item.Tag = listId[i];
                listView書籍展示.Items.Add(item);
            }

        }

        private void cbox書籍分類欄位_SelectedIndexChanged(object sender, EventArgs e)
        {
            讀取商品資料庫();
            顯示listView_圖片模式();
        }
        private TabPage CloneTabPage(TabPage originalTabPage)
        {
            // 創建新的 TabPage
            TabPage newTabPage = new TabPage();

            //Console.WriteLine(str書籍Name);
            // 複製原始 TabPage 的屬性
            newTabPage.Text = originalTabPage.Text;
            newTabPage.ImageIndex = originalTabPage.ImageIndex;
            newTabPage.BackColor = originalTabPage.BackColor;
            newTabPage.ForeColor = originalTabPage.ForeColor;

            // 複製原始 TabPage 中的控制項
            foreach (Control control in originalTabPage.Controls)
            {
                Control newControl = CloneControl(control);
                newTabPage.Controls.Add(newControl);
            }
            //顯示加入商品詳細資訊();
            newTabPage.Text = str書籍Name;
            return newTabPage;

        }
        private Control CloneControl(Control originalControl)
        {
            // 根據控制項的類型創建新的控制項
            Control newControl;

            if (originalControl is TextBox)
            {
                // 如果是 TextBox，創建新的 TextBox 並複製相關屬性
                TextBox originalTextBox = (TextBox)originalControl;
                TextBox newTextBox = new TextBox();
                newTextBox.Text = originalTextBox.Text;
                newTextBox.Size = originalTextBox.Size;
                // 其他相關屬性...

                newControl = newTextBox;
            }
            else if (originalControl is CheckBox)
            {
                // 如果是 CheckBox，創建新的 CheckBox 並複製相關屬性
                CheckBox originalCheckBox = (CheckBox)originalControl;
                CheckBox newCheckBox = new CheckBox();
                newCheckBox.Checked = originalCheckBox.Checked;
                newCheckBox.Text = originalCheckBox.Text;
                // 其他相關屬性...

                newControl = newCheckBox;
            }
            else if (originalControl is Label)
            {
                Label originalLabel = (Label)originalControl;
                Label newLabel = new Label();
                newLabel.Text = originalLabel.Text;
                newLabel.Size = originalLabel.Size;
                newControl = newLabel;
            }
            else if (originalControl is PictureBox)
            {
                PictureBox originalPictureBox = (PictureBox)originalControl;
                PictureBox newPictureBox = new PictureBox();
                if (originalPictureBox.Image != null)
                {
                    newPictureBox.Image = new Bitmap(originalPictureBox.Image);
                }
                newPictureBox.Size = originalPictureBox.Size;
                newControl = newPictureBox;
            }
            else if (originalControl is ShoppingCart3)//複製shoppingcart
            {
                // 其他控制項的處理方式，可以根據需要添加更多的控制項類型

                // 如果不是已知的控制項類型，則創建一個新的控制項，但不複製特定的屬性
                //UserControl originalUserControl = (UserControl)originalControl;
                //UserControl newUserControl = new UserControl();
                ////newUserControl.Text = originalUserControl.Text;
                //newUserControl.Size = originalUserControl.Size;
                //newControl = newUserControl;

                ShoppingCart3 originalUserControl = (ShoppingCart3)originalControl;
                ShoppingCart3 newUserControl = CloneUserControl(originalUserControl);
                顯示加入商品詳細資訊(newUserControl);
                newControl = newUserControl;

            }
            else
            {
                newControl = new Control();
            }
            // 複製通用屬性
            newControl.Location = originalControl.Location;
            newControl.Size = originalControl.Size;
            // 其他通用屬性...

            return newControl;
        }
        private ShoppingCart3 CloneUserControl(ShoppingCart3 originalUserControl)
        {
            // 根據原始 UserControl 的類型創建新的 UserControl
            // 這裡假設所有的 UserControl 都有預設的無參數建構函式
            ShoppingCart3 newUserControl = (ShoppingCart3)Activator.CreateInstance(originalUserControl.GetType());

            // 可以根據需要複製其他相關屬性

            return newUserControl;
        }
        void 顯示商品詳細資訊()
        {
            TabPage newTabPage = new TabPage();
            newTabPage.Text = str書籍Name;
            newTabPage.Size = tabControl1.ClientSize;
            ShoppingCart myShhoppingCart = new ShoppingCart();//
            //Console.WriteLine(myShhoppingCart.Size);
            myShhoppingCart.Dock = DockStyle.Fill;

            Panel panel = new Panel();
            panel.AutoScroll = true;
            panel.AutoScroll = true;
            panel.Dock = DockStyle.Fill;
            panel.Controls.Add(myShhoppingCart);

            newTabPage.Controls.Add(panel);
            tabControl1.TabPages.Add(newTabPage);
            myShhoppingCart.btn關閉.Click += (sender, e) =>
            {
                tabControl1.TabPages.Remove(newTabPage);
            };
        }

        private void btn購物車_Click(object sender, EventArgs e)
        {
            if (GlobalVar.使用者使用狀態 == "審核")
            {
                MessageBox.Show("您目前的會員資格仍在審核中\n在審核結束後才能使用此功能\n請在等一下下喔~");
            }
            else if(GlobalVar.使用者使用狀態 == "停權")
            {
                MessageBox.Show("您目前的會員資格被停權\n請等停權期結束後\n再做使用");
            }
            else if (GlobalVar.使用者使用狀態 == "正常使用")
            {
                FormOrderList myformOrderList = new FormOrderList();
                myformOrderList.ShowDialog();
            }
            
        }

        private void listView書籍展示_ItemActivate(object sender, EventArgs e)
        {
            this.BeginInvoke(new MethodInvoker(() =>
            {
                Console.WriteLine(listView書籍展示.SelectedItems.Count);
            }));
            //FormBooksDetail myFormBooksDetail = new FormBooksDetail();
            Console.WriteLine(listView書籍展示.SelectedItems.Count);
            ////myFormBooksDetail.loadId = (int)listView書籍展示.SelectedItems[0].Tag;
            GlobalVar.loadId2 = (int)listView書籍展示.SelectedItems[0].Tag;
            str書籍Name = (string)listView書籍展示.SelectedItems[0].Text.Substring(0, 4);
            //Console.WriteLine(str書籍Name);

            //myFormBooksDetail.ShowDialog();
            //AddClosableTabPage(myFormBooksDetail);
            int tabPageCount = tabControl1.TabPages.Count;
            if (tabPageCount < 10)
            {
                tabControl1.TabPages.Add(CloneTabPage(tabPage3));
            }
            else
            {
                MessageBox.Show("頁面過多，請先關閉一些頁面~");
            }


            //顯示商品詳細資訊();


            //Console.WriteLine(myShhoppingCart.Size);
        }
        void 顯示加入商品詳細資訊(ShoppingCart3 myUserControl)
        {
            string str商品狀態 = "";
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            string strSQL = $"select * from productBook where BookID=@SearchId;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@SearchId", GlobalVar.loadId2);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {

                //myUserControl.label1.Text = reader["BookID"].ToString();
                myUserControl.txtBookName.Tag = reader["BookID"].ToString();
                myUserControl.txtBookName.Text = reader["BookName"].ToString();
                myUserControl.lblBookPrice.Text = reader["BookPrice"].ToString();
                myUserControl.lblWriter.Text = reader["BookWriter"].ToString();
                myUserControl.lbl庫存.Text = reader["inventory"].ToString();
                myUserControl.txt簡介.Text = reader["BookDesc"].ToString();
                str圖檔名稱 = reader["BookImage"].ToString();
                string 完整圖片路徑 = $"{GlobalVar.image_dir}\\{str圖檔名稱}";
                myUserControl.pictureBox書籍資訊.Image = Image.FromFile(完整圖片路徑);
                str商品狀態 = reader["ProductStatus"].ToString();
                if (str商品狀態 == "下架停賣" || str商品狀態 == "缺貨中")
                {
                    myUserControl.lbl庫存.Text = "0";
                    myUserControl.btn加入購物車.Enabled = false;
                    myUserControl.btn加入購物車.Text = $"{str商品狀態}";
                    myUserControl.btnadd1.Visible = false;
                    myUserControl.btnminus1.Visible = false;
                }
                if (GlobalVar.使用者使用狀態 == "審核")
                {
                    MessageBox.Show("您目前的會員資格仍在審核中\n在審核結束後才能使用此功能\n請在等一下下喔~");
                    myUserControl.btnadd1.Visible = false;
                    myUserControl.btnminus1.Visible = false;
                    myUserControl.btn加入購物車.Enabled = false;
                }
                else if (GlobalVar.使用者使用狀態 == "停權")
                {
                    MessageBox.Show("您目前的會員資格被停權\n請等停權期結束後\n再做使用");
                    myUserControl.btnadd1.Visible = false;
                    myUserControl.btnminus1.Visible = false;
                    myUserControl.btn加入購物車.Enabled = false;
                }
            }
            reader.Close();
            con.Close();
            //str書籍Name = lblBookName.Text;
        }

        private void btn訂單查詢_Click(object sender, EventArgs e)
        {
            shoppingordersForm myshoppingorders = new shoppingordersForm();
            myshoppingorders.ShowDialog();
        }
    }
}
