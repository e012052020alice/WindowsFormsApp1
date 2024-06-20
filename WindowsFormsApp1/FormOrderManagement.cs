using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormOrderManagement : Form
    {
        List<long> list訂單編號 = new List<long>();
        List<string> list商品名稱 = new List<string>();
        List<int> list訂單金額 = new List<int>();
        List<int> list商品數量 = new List<int>();
        List<string> list處理狀態 = new List<string>();
        List<DateTime> listdte訂單時間 = new List<DateTime>();
        int int營業額 = 0;
        public FormOrderManagement()
        {
            InitializeComponent();
        }

        private void FormOrderManagement_Load(object sender, EventArgs e)
        {
            cbox欄位名稱.Items.Add("顧客ID");//ID or Name?
            cbox欄位名稱.Items.Add("訂單編號");
            cbox欄位名稱.Items.Add("處理狀態");
            cbox欄位名稱.SelectedIndex = 0;
            讀取訂單詳情();
            顯示訂單詳情();
        }
        void 讀取訂單詳情()
        {
            清除list();
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            string strSQL = $"select * from orders " +
                //$"join customers on orders.customerId=customers.customerID " +
                $"join productBook on orders.bookId=productBook.BookID ";
            //$"join shoppingCart on orders.shoppincartId=shoppingCart.shoppingCartID " +
            //$"where orders.customerId=@SearchID;"
            SqlCommand cmd = new SqlCommand(strSQL, con);
            //cmd.Parameters.AddWithValue("@SearchID", GlobalVar.使用者id);
            SqlDataReader reader = cmd.ExecuteReader();
            int count = 0;
            while (reader.Read())
            {

                list訂單編號.Add((long)reader["Ordernumbers"]);//orders
                list商品名稱.Add((string)reader["BookName"]);//productbook
                list訂單金額.Add((int)reader["price"]);//shoppingcart
                list商品數量.Add((int)reader["Amount"]);//shoppingcart
                list處理狀態.Add(reader["ProcessingStatus"].ToString());//orders
                listdte訂單時間.Add((DateTime)reader["Time"]);

                count++;

            }
            reader.Close();
            con.Close();
            Console.WriteLine($"讀取{count}筆資料");

        }
        void 顯示訂單詳情()
        {
            listView訂單詳情.Clear();
            //listView購物車資訊.View = View.LargeIcon;
            //listView購物車資訊.View = View.SmallIcon;
            listView訂單詳情.View = View.Details;
            //imglist書籍圖檔.ImageSize = new Size(120, 120);
            listView訂單詳情.Columns.Add("訂單編號", 150); // 第一列寬度 100
            listView訂單詳情.Columns.Add("訂購時間", 200);
            listView訂單詳情.Columns.Add("商品名稱", 300); // 第二列寬度 200
            listView訂單詳情.Columns.Add("訂單金額");
            listView訂單詳情.Columns.Add("商品數量");
            listView訂單詳情.Columns.Add("處理狀態",130);
            //listView購物車資訊.Columns.Add("變更明細");
            listView訂單詳情.GridLines = true;//顯示格線
            listView訂單詳情.FullRowSelect = true;//可以整行選取
            //listView購物車資訊.LargeImageList = imglist書籍圖檔;
            //listView訂單詳情.SmallImageList = imglist書籍圖檔;//List,SmallIcon
            for (int i = 0; i < list訂單編號.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                //item.ImageIndex = i;
                item.Text = list訂單編號[i].ToString();
                item.SubItems.Add(listdte訂單時間[i].ToString());
                item.SubItems.Add(list商品名稱[i]);
                item.SubItems.Add(list訂單金額[i].ToString());
                item.SubItems.Add(list商品數量[i].ToString());
                item.SubItems.Add(list處理狀態[i]);

                item.Font = new Font("微軟正黑體", 10, FontStyle.Regular);

                item.Tag = list訂單編號[i];

                listView訂單詳情.Items.Add(item);
                //listView訂單詳情.CheckBoxes = true;
            }
        }
        void 清除list()
        {
            list訂單編號.Clear();
            list商品名稱.Clear();
            list訂單金額.Clear();
            list商品數量.Clear();
            list處理狀態.Clear();
            listdte訂單時間.Clear();
        }
        private void listView訂單詳情_ItemActivate(object sender, EventArgs e)
        {
            FormModifyOrder myformModifyOrder = new FormModifyOrder();
            //Console.WriteLine((int)listView訂單詳情.SelectedItems[0].Tag);
            myformModifyOrder.is訂單管理 = true;
            myformModifyOrder.orderNumbers = (long)listView訂單詳情.SelectedItems[0].Tag;
            myformModifyOrder.ShowDialog();
            讀取訂單詳情();
            顯示訂單詳情();
        }

        private void btn搜尋_Click(object sender, EventArgs e)
        {
            清除list();
            if (txt搜尋關鍵字.Text != "")
            {
                listView訂單詳情.Items.Clear();

                string str欄位名稱 = cbox欄位名稱.SelectedItem.ToString();
                switch (str欄位名稱)//尚未進行防呆
                {
                    case "顧客ID":
                        str欄位名稱 = "customerId";
                        break;
                    case "訂單編號":
                        str欄位名稱 = "Ordernumbers";
                        break;
                    case "處理狀態":
                        str欄位名稱 = "ProcessingStatus";
                        break;

                }
                SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                con.Open();
                string strSQL = $"select * from orders join productBook on orders.bookId=productBook.BookID " +
                    $"where(Time>=@StartTime and Time<=@EndTime) and " +
                    $"({str欄位名稱} like @SearchKeyword) ;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@StartTime", dtp搜尋開始時間.Value);
                cmd.Parameters.AddWithValue("@EndTime", dtp搜尋結束時間.Value);
                cmd.Parameters.AddWithValue("@SearchKeyword", $"%{txt搜尋關鍵字.Text}%");
                SqlDataReader reader = cmd.ExecuteReader();

                int count = 0;

                while (reader.Read() == true)
                {
                    list訂單編號.Add((long)reader["Ordernumbers"]);//orders
                    list商品名稱.Add((string)reader["BookName"]);//productbook
                    list訂單金額.Add((int)reader["price"]);//shoppingcart
                    list商品數量.Add((int)reader["Amount"]);//shoppingcart
                    list處理狀態.Add(reader["ProcessingStatus"].ToString());//orders
                    listdte訂單時間.Add((DateTime)reader["Time"]);
                    count++;
                }
                if (count == 0)
                {
                    MessageBox.Show("查無此訂單");
                }
                顯示訂單詳情();
            }
            else
            {
                MessageBox.Show("請輸入搜尋關鍵字");
            }

        }

        private void cbox欄位名稱_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt搜尋關鍵字.Clear();
            txt營業額.Clear();
        }

        private void btn計算營業額_Click(object sender, EventArgs e)//出貨後-取消訂單
        {
            txt搜尋關鍵字.Clear();
            清除list();
            txt營業額.Clear();
            int營業額 = 0;
            listView訂單詳情.Items.Clear();

            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            string strSQL = $"select * from orders join productBook on orders.bookId=productBook.BookID " +
                $"where(Time>=@StartTime and Time<=@EndTime) and ProcessingStatus in (@SearchShipped ,@SearchClosedOrder,@SearchCancelOrder);";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@StartTime", dtp營業額開始時間.Value);
            cmd.Parameters.AddWithValue("@EndTime", dtp營業額結束時間.Value);
            cmd.Parameters.AddWithValue("@SearchShipped", "已出貨");
            cmd.Parameters.AddWithValue("@SearchClosedOrder", "已結單");
            cmd.Parameters.AddWithValue("@SearchCancelOrder", "取消訂單");

            SqlDataReader reader = cmd.ExecuteReader();

            int count = 0;

            while (reader.Read() == true)
            {
                list訂單編號.Add((long)reader["Ordernumbers"]);//orders
                list商品名稱.Add((string)reader["BookName"]);//productbook
                list訂單金額.Add((int)reader["price"]);//shoppingcart
                list商品數量.Add((int)reader["Amount"]);//shoppingcart
                list處理狀態.Add(reader["ProcessingStatus"].ToString());//orders
                listdte訂單時間.Add((DateTime)reader["Time"]);
                count++;
            }
            if (count == 0)
            {
                MessageBox.Show("查無此訂單");
            }
            顯示訂單詳情();

            for (int i = 0; i < list訂單金額.Count; i++)
            {
                if (list處理狀態[i] == "已出貨"|| list處理狀態[i] == "已結單")
                {
                    int營業額 += list訂單金額[i];
                }
                else if (list處理狀態[i] == "取消訂單")
                {
                    int營業額 -= list訂單金額[i];
                }


            }
            txt營業額.Text = $"{int營業額}元";
        }

        private void btn回到全部_Click(object sender, EventArgs e)
        {
            讀取訂單詳情();
            顯示訂單詳情();
        }
    }
}
