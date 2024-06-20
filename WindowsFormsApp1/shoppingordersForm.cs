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
    public partial class shoppingordersForm : Form
    {
        public List<int> listshoppingdartid = new List<int>();
        List<string> list訂單編號 = new List<string>();
        List<string> list商品名稱 = new List<string>();
        List<int> list訂單金額 = new List<int>();
        List<int> list商品數量 = new List<int>();
        List<string> list處理狀態 = new List<string>();
        List<DateTime> listdte訂單時間= new List<DateTime>();
          
        int int訂單編號 = 2;

        public shoppingordersForm()
        {
            InitializeComponent();
        }

        private void shoppingordersForm_Load(object sender, EventArgs e)
        {
            顯示訂單詳情();
        }
        void 顯示訂單詳情()
        {
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            string strSQL = $"select * from orders " +
                $"join customers on orders.customerId=customers.customerID " +
                $"join productBook on orders.bookId=productBook.BookID " +
                //$"join shoppingCart on orders.shoppincartId=shoppingCart.shoppingCartID " +
                $"where orders.customerId=@SearchID;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@SearchID", GlobalVar.使用者id);
            SqlDataReader reader = cmd.ExecuteReader();
            int count = 0;
            while (reader.Read())
            {
                //int書籍Id = (int)reader["BookID"];
                //if (list書籍Id.Contains(int書籍Id))//書籍ID一樣，加入之前的list，只加上數量和價格
                //{
                //    Console.WriteLine(int書籍Id);

                //    int intindex = list書籍Id.IndexOf(int書籍Id);
                //    list書籍數量[intindex] += (int)reader["bookAmount"];
                //    list書籍價格[intindex] += (int)reader["price"];
                //}
                //else
                //{
                //    listId.Add((int)reader["shoppingCartID"]);//功能?
                //listshoppingdartid.Add(int書籍Id);
                list訂單編號.Add(reader["Ordernumbers"].ToString());//orders
                list商品名稱.Add((string)reader["BookName"]);//productbook
                list訂單金額.Add((int)reader["price"]);//shoppingcart
                list商品數量.Add((int)reader["Amount"]);//shoppingcart
                list處理狀態.Add(reader["ProcessingStatus"].ToString());//orders
                listdte訂單時間.Add((DateTime)reader["Time"]);
                //Console.WriteLine(list訂單編號[0] + list處理狀態[0]);

                //}

                count++;

            }
            //if(reader.HasRows == true)//HasRows:有沒有資料筆
            //{
            //    //reader->DataTable->DataSource
            //    DataTable dt = new DataTable();
            //    dt.Load(reader);//用dataTable的物件的Load()方法將reader的資料全部讀進來
            //    //DGV筆數 = dt.Rows.Count;
            //    //dt.Rows[0];
            //    dataGridView1.DataSource = dt;
            //}
            reader.Close();
            con.Close();
            Console.WriteLine($"讀取{count}筆資料");
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
            listView訂單詳情.Columns.Add("處理狀態");
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
        private void listView訂單詳情_ItemActivate(object sender, EventArgs e)
        {
            FormModifyOrder myformModifyOrder = new FormModifyOrder();
            //Console.WriteLine((int)listView訂單詳情.SelectedItems[0].Tag);
            long.TryParse(listView訂單詳情.SelectedItems[0].Tag.ToString(), out long longNum);
            myformModifyOrder.orderNumbers = longNum;
            myformModifyOrder.ShowDialog();
        }
        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            //int mergeColumnIndex = 1; // 假設要合併第二個欄位的內容

            //if (e.ColumnIndex == mergeColumnIndex)
            //{
            //    // 檢查相鄰儲存格內容是否相同
            //    if (e.RowIndex > 0 && dataGridView1.Rows[e.RowIndex - 1].Cells[e.ColumnIndex].Value != null &&
            //        dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null &&
            //        dataGridView1.Rows[e.RowIndex - 1].Cells[e.ColumnIndex].Value.ToString() == dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString())
            //    {
            //        // 若相同，則取消繪製當前儲存格的內容
            //        e.Handled = true;
            //    }
            //}
            // 確定要合併內容的欄位索引

            //int mergeColumnIndex = 1; // 假設要合併第二個欄位的內容

            //if (e.ColumnIndex == mergeColumnIndex)
            //{
            //    // 檢查相鄰儲存格內容是否相同
            //    if (e.RowIndex > 0 && dataGridView1.Rows[e.RowIndex - 1].Cells[e.ColumnIndex].Value != null &&
            //        dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null &&
            //        dataGridView1.Rows[e.RowIndex - 1].Cells[e.ColumnIndex].Value.ToString() == dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString())
            //    {
            //        // 取消繪製當前儲存格的內容
            //        e.Handled = true;
            //        dataGridView1.CellBorderStyle =DataGridViewCellBorderStyle.None;
            //        // 繪製左側邊框、右側邊框和下方邊框
            //        using (Pen pen = new Pen(dataGridView1.GridColor, 1))
            //        {
            //            e.Graphics.DrawLine(pen, e.CellBounds.Left, e.CellBounds.Top, e.CellBounds.Left, e.CellBounds.Bottom); // 左邊框
            //            e.Graphics.DrawLine(pen, e.CellBounds.Right - 1, e.CellBounds.Top, e.CellBounds.Right - 1, e.CellBounds.Bottom); // 右邊框
            //            e.Graphics.DrawLine(pen, e.CellBounds.Left, e.CellBounds.Bottom - 1, e.CellBounds.Right, e.CellBounds.Bottom - 1); // 下邊框

            //            // 如果是第一列，則繪製上邊框
            //            if (e.RowIndex == 0)
            //            {
            //                e.Graphics.DrawLine(pen, e.CellBounds.Left, e.CellBounds.Top, e.CellBounds.Right, e.CellBounds.Top); // 上邊框
            //            }
            //        }
            //    }
            //    else
            //    {
            //        // 若內容不相同，則按正常方式繪製儲存格
            //        e.Handled = false;
            //    }
            //}
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex >= 0 && (e.RowIndex < DGV筆數))
            //{
            //    string strID = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();//點擊的那一列的第一個儲存格
            //    int selectID = 0;
            //    Int32.TryParse(strID, out selectID);
            //    產生會員資料欄位(selectID);
            //}
        }

        
    }
}
