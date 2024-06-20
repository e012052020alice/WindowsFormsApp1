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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net.NetworkInformation;
using Sunny.UI.Demo;
namespace WindowsFormsApp1
{
    public partial class FormOrderList : Form
    {
        List<int> listId = new List<int>();
        List<int> list書籍Id = new List<int>();
        List<string> list書籍名稱 = new List<string>();
        List<int> list書籍價格 = new List<int>();
        List<int> list書籍數量 = new List<int>();
        List<int> list訂購shoppingID= new List<int>();
        bool ischecked = false;
        //要傳進orders
        List<int> list訂單編號 = new List<int>(); 
        List<int> list訂單購物車ID = new List<int>();
        List<int> list商品ID = new List<int>();
        List<string> list商品名稱 = new List<string>();
        List<int> list訂單金額 = new List<int>();
        List<int> list商品數量 = new List<int>();
        List<string> list處理狀態 = new List<string>();
        

        public FormOrderList()
        {
            InitializeComponent();
        }

        private void FormOrderList_Load(object sender, EventArgs e)
        {
            顯示購物車資訊();
        }
        void 顯示購物車資訊()
        {
            //Console.WriteLine("2222222222");
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            string strSQL = $"select * from customers join shoppingCart on customers.customerID = shoppingCart.customerID " +
                $"join  productBook on productBook.BookID=shoppingCart.BookID " +
                $"where shoppingCart.customerID=@SearchID;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@SearchID", GlobalVar.使用者id);
            SqlDataReader reader = cmd.ExecuteReader();
            int count = 0;
            int int書籍Id = 0;
            while (reader.Read())
            {
                int書籍Id = (int)reader["BookID"];
                if (list書籍Id.Contains(int書籍Id))//書籍ID一樣，加入之前的list，只加上數量和價格
                {
                    Console.WriteLine(int書籍Id);

                    int intindex = list書籍Id.IndexOf(int書籍Id);
                    list書籍數量[intindex] += (int)reader["bookAmount"];
                    list書籍價格[intindex] += (int)reader["price"];
                }
                else
                {
                    listId.Add((int)reader["shoppingCartID"]);//功能?
                    list書籍Id.Add(int書籍Id);
                    list書籍名稱.Add((string)reader["BookName"]);
                    list書籍價格.Add((int)reader["price"]);
                    list書籍數量.Add((int)reader["bookAmount"]);
                    string image_name = ((string)reader["BookImage"]);
                    string 完整圖片路徑 = $"{GlobalVar.image_dir}\\{image_name}";
                    //Console.WriteLine(完整圖片路徑);
                    Image img書籍圖檔 = Image.FromFile(完整圖片路徑);
                    imglist書籍圖檔.Images.Add(img書籍圖檔);
                }

                count++;

            }
            reader.Close();
            con.Close();
            Console.WriteLine($"讀取{count}筆資料");
            listView購物車資訊.Clear();
            //listView購物車資訊.View = View.LargeIcon;
            //listView購物車資訊.View = View.SmallIcon;
            listView購物車資訊.View = View.Details;
            imglist書籍圖檔.ImageSize = new Size(120, 120);
            listView購物車資訊.Columns.Add("圖片", 100); // 第一列寬度 100
            listView購物車資訊.Columns.Add("文字", 280); // 第二列寬度 200
            listView購物車資訊.Columns.Add("價格");
            listView購物車資訊.Columns.Add("數量");
            //listView購物車資訊.Columns.Add("變更明細");
            listView購物車資訊.GridLines = true;//顯示格線
            listView購物車資訊.FullRowSelect = true;//可以整行選取
            //listView購物車資訊.LargeImageList = imglist書籍圖檔;
            listView購物車資訊.SmallImageList = imglist書籍圖檔;//List,SmallIcon
            for (int i = 0; i < listId.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = i;
                //string str第一行過長書名 = "";
                //string str第二行過長書名 = "";
                //if ( list書籍名稱[i].Length > 10)
                //{
                //    str第一行過長書名 = list書籍名稱[i].Substring(0, 10);
                //    str第二行過長書名 = list書籍名稱[i].Substring(10, 12);
                //}
                ////item.Text = $"{list書籍名稱[i]} ";
                //item.Text = $"{ str第一行過長書名 }  \n{str第二行過長書名}";
                //item.SubItems.Add(Environment.NewLine + str第二行過長書名);
                //item.Text = list書籍名稱[i];
                item.SubItems.Add(list書籍名稱[i]);
                item.SubItems.Add(list書籍價格[i].ToString());
                item.SubItems.Add(list書籍數量[i].ToString());

                //System.Windows.Forms.Button button1 = new System.Windows.Forms.Button();
                //button1.Text = "Click Me";
                //button1.Click += Button_Click; // 設定按鈕點擊事件

                //Sunny.UI.UIButton button2 = new Sunny.UI.UIButton();
                //button2.Text = "刪除2";
                //button2.Click += Button_Click;
                //item.SubItems.Add(string.Empty); // 添加一個空的 SubItem

                //item.SubItems.Add(button2);
                //item.SubItems.Add("刪除");

                //item.SubItems[3].BackColor = Color.Green;
                //item.SubItems[3].Tag = listView購物車資訊.Columns[3].Tag;
                //item.SubItems[3].BackColor = Color.Green;
                //item.Tag = button1; // 使用 Tag 屬性存儲按鈕

                item.Font = new Font("微軟正黑體", 10, FontStyle.Regular);
                //item.Tag = listId[i];//本來是放購物車ID的
                item.Tag = listId[i];
                //item.SubItems.Add($"其他資訊 {i}");

                ischecked = false;
                listView購物車資訊.Items.Add(item);
                listView購物車資訊.CheckBoxes = true;
            }
        }

        private void listView購物車資訊_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            ListViewItem checkedItem = e.Item;
            int intSum = 0;
            int intprice = 0;
            //Console.WriteLine($"e.Item.Tag:{e.Item.Tag}");
            if (checkedItem.Checked)
            {
                //e.Item.Tag=
                Int32.TryParse(e.Item.SubItems[2].Text, out intprice);
                Int32.TryParse(lbl總價格.Text, out intSum);
                intSum += intprice;
                lbl總價格.Text = intSum.ToString();
                ischecked = true;
            }
            else
            {
                if (ischecked == true)
                {
                    Int32.TryParse(e.Item.SubItems[2].Text, out intprice);
                    Int32.TryParse(lbl總價格.Text, out intSum);
                    intSum -= intprice;
                    lbl總價格.Text = intSum.ToString();
                    ischecked = false;
                }

            }

        }

        private void listView購物車資訊_ItemActivate(object sender, EventArgs e)
        {
            //ListViewItem selectedItem = listView購物車資訊.SelectedItems[0];
            ////Listview
            //string valueToDelete = selectedItem.SubItems[4].Text; // 假設第二個 SubItem 中包含要刪除的資料
            //listView購物車資訊.Items.Remove(selectedItem);

        }

        private void listView購物車資訊_MouseClick(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo hitTest = listView購物車資訊.HitTest(e.Location);
            if (hitTest.Item != null && hitTest.SubItem != null)
            {
                // 取得被點擊的項目和 SubItem
                ListViewItem clickedItem = hitTest.Item;
                ListViewItem.ListViewSubItem clickedSubItem = hitTest.SubItem;

                // 根據點擊的 SubItem 的索引處理相應的邏輯
                int clickedSubItemIndex = hitTest.Item.SubItems.IndexOf(clickedSubItem);

                if (clickedSubItemIndex == 3) // 假設要在點擊第二個 SubItem 時進行刪除
                {
                    //Console.WriteLine(listView購物車資訊.SelectedItems.Count);
                    FEdit myfedit = new FEdit();
                    int intid = 0;
                    Int32.TryParse(clickedItem.Tag.ToString(), out intid);
                    myfedit.shoppingCartId = intid;
                    //Console.WriteLine(intid);
                    myfedit.ShowDialog();
                    // 在這裡處理刪除資料的邏輯，可能是從資料庫中刪除，或者從其他資料結構中移除
                    // ...

                    // 最後，從 ListView 中刪除該項目
                    //listView購物車資訊.Items.Remove(clickedItem);
                }
            }
        }

        private void listView購物車資訊_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine(e.ColumnIndex);
            // 設定第三個 SubItem 為按鈕樣式
            if (e.ColumnIndex == 4)
            {
                e.DrawBackground();

                // 在 SubItem 中間繪製一個簡單的矩形，看起來像按鈕
                Rectangle buttonRect = new Rectangle(
                    e.Bounds.X + (e.Bounds.Width - 50) / 2,
                    e.Bounds.Y + (e.Bounds.Height - 20) / 2,
                    50,
                    20);

                using (SolidBrush brush = new SolidBrush(Color.Blue))
                {
                    e.Graphics.FillRectangle(brush, buttonRect);
                }

                using (Pen pen = new Pen(Color.Green))
                {
                    e.Graphics.DrawRectangle(pen, buttonRect);
                }

                using (SolidBrush brush = new SolidBrush(Color.White))
                {
                    StringFormat sf = new StringFormat();
                    sf.LineAlignment = StringAlignment.Center;
                    sf.Alignment = StringAlignment.Center;
                    for (int i = 0; i < listId.Count; i++)
                    {
                        e.Graphics.DrawString(list書籍價格[i].ToString(), listView購物車資訊.Font, brush, buttonRect, sf);
                    }


                }

            }
            if (e.ColumnIndex == 6)
            {
                e.DrawBackground();

                // 在 SubItem 中間繪製一個簡單的矩形，看起來像按鈕
                Rectangle buttonRect = new Rectangle(
                    e.Bounds.X + (e.Bounds.Width - 50) / 2,
                    e.Bounds.Y + (e.Bounds.Height - 20) / 2,
                    50,
                    20);

                using (SolidBrush brush = new SolidBrush(Color.Green))
                {
                    e.Graphics.FillRectangle(brush, buttonRect);
                }

                using (Pen pen = new Pen(Color.Green))
                {
                    e.Graphics.DrawRectangle(pen, buttonRect);
                }

                using (SolidBrush brush = new SolidBrush(Color.White))
                {
                    StringFormat sf = new StringFormat();
                    sf.LineAlignment = StringAlignment.Center;
                    sf.Alignment = StringAlignment.Center;

                    e.Graphics.DrawString("刪除", listView購物車資訊.Font, brush, buttonRect, sf);

                }

            }
            else
            {
                e.DrawText();
            }

        }

        private void listView購物車資訊_ItemActivate_1(object sender, EventArgs e)
        {
            listView購物車資訊.Clear();
            listId.Clear();
            list書籍Id.Clear();
            list書籍名稱.Clear();
            list書籍數量.Clear();
            list書籍價格.Clear();
            imglist書籍圖檔.Images.Clear();
            顯示購物車資訊();
        }

        private void btn結帳_Click(object sender, EventArgs e)
        {
            Random myRand = new Random();
            //Console.WriteLine(myRand.Next(10,100));          
            //Console.WriteLine(DateTime.Now.ToString("yyMMddHHmmss")+ myRand.Next(1000, 10000));
            
            list訂購shoppingID.Clear();
            if (listView購物車資訊.CheckedItems.Count > 0)
            {
                string strSQLshoppingID = "";
                int chcekcount = 0;
                for (int i = 0; i < listView購物車資訊.Items.Count; i++)
                {
                    if (listView購物車資訊.Items[i].Checked)
                    {
                        chcekcount++;
                        if (chcekcount == listView購物車資訊.CheckedItems.Count)
                        {
                            list訂購shoppingID.Add((int)listView購物車資訊.Items[0].Tag);
                            strSQLshoppingID += $"{listView購物車資訊.Items[i].Tag.ToString()} ) ;";
                        }
                        else
                        {
                            list訂購shoppingID.Add((int)listView購物車資訊.Items[0].Tag);
                            strSQLshoppingID += $"{listView購物車資訊.Items[i].Tag.ToString()},";
                        }
                        
                    }
                    
                }
                
                DialogResult R = MessageBox.Show("確認結帳嗎?", "結帳確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (R == DialogResult.Yes)
                {
                    SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                    con.Open();
                    string strSQL = "select * from shoppingCart join productBook on shoppingCart.BookID=productBook.BookID " +
                        "where shoppingCartID IN (  ";
                    Console.WriteLine(strSQL + strSQLshoppingID);
                    SqlCommand cmd = new SqlCommand(strSQL+strSQLshoppingID, con);
                    
                    //cmd.Parameters.AddWithValue("@SearchshoppingCartID", strSQLshoppingID);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while(reader.Read())
                    {
                        //list訂單編號.Add((int)reader["Ordernumbers"]);//orders
                        //list訂單編號.Add(3);
                        list訂單購物車ID.Add((int)reader["shoppingCartID"]);
                        list商品ID.Add((int)reader["BookID"]);
                        list商品名稱.Add((string)reader["BookName"]);//productbook
                        list訂單金額.Add((int)reader["price"]);//shoppingcart
                        list商品數量.Add((int)reader["bookAmount"]);//shoppingcart
                        //list處理狀態.Add(reader["ProcessingStatus"].ToString());//orders
                    }

                    
                    reader.Close();
                    string strOrderNumbers = DateTime.Now.ToString("yyMMddHHmmss") + myRand.Next(100, 1000);
                    for (int i = 0;i<list訂單購物車ID.Count;i++)//輸入到orders
                    {
                        strSQL = "";
                        strSQL = "insert into orders values" +
                        "(@NewOrdernumbers,@customerId,@bookId,@shoppincartId,@ProcessingStatus,@price,@Amount,@NewTime);";
                        cmd = new SqlCommand(strSQL, con);
                        cmd.Parameters.AddWithValue("@NewOrdernumbers", strOrderNumbers);
                        cmd.Parameters.AddWithValue("@customerId", GlobalVar.使用者id);
                        cmd.Parameters.AddWithValue("@bookId", list商品ID[i]);
                        cmd.Parameters.AddWithValue("@shoppincartId", list訂單購物車ID[i]);
                        cmd.Parameters.AddWithValue("@ProcessingStatus", "待處理");
                        cmd.Parameters.AddWithValue("@price", list訂單金額[i]);
                        cmd.Parameters.AddWithValue("@Amount", list商品數量[i]);
                        cmd.Parameters.AddWithValue("@NewTime", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                        int rows = cmd.ExecuteNonQuery();
                    }

                    for (int i = 0; i < list訂單購物車ID.Count; i++)//移出shoppingcart
                    {
                        strSQL = "";
                        strSQL = "delete from shoppingCart where shoppingCartID=@DeleteshoppincartId";
                        cmd = new SqlCommand(strSQL, con);           
                        cmd.Parameters.AddWithValue("@DeleteshoppincartId", list訂單購物車ID[i]);                       
                        int rows = cmd.ExecuteNonQuery();
                    }

                    con.Close();
                    //Console.WriteLine(listView購物車資訊.Items[0].Tag);
                    this.Close();
                    shoppingordersForm myshoppingorders = new shoppingordersForm();
                    //myshoppingorders.listshoppingdartid.Add((int)listView購物車資訊.Items[0].Tag);
                    myshoppingorders.ShowDialog();
                }
            }
        }
    }
}
