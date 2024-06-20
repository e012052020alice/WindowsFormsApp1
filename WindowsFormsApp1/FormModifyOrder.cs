using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace WindowsFormsApp1
{
    public partial class FormModifyOrder : Form
    {
        public long orderNumbers = 0;
        List<string> list訂購書籍 = new List<string>();
        List<int> list訂購數量 = new List<int>();
        List<int> list訂購金額 = new List<int>();
        List<int> list書籍庫存 = new List<int>();
        List<int> list書籍庫存ID = new List<int>();
        List <string> list商品狀況 =new List<string>();
        string str處理狀態 = "";
        bool is庫存減訂購 = false;//true:減掉庫存
        //bool is出貨後取消訂單 = false;
        public bool is訂單管理=false;
        public FormModifyOrder()
        {
            InitializeComponent();
        }

        private void FormModifyOrder_Load(object sender, EventArgs e)
        {//待處理->已審核，出貨處理中->已出貨->已結單
            cbox處理狀態.Items.Add("待處理");
            cbox處理狀態.Items.Add("已審核，出貨處理中");
            cbox處理狀態.Items.Add("已出貨");
            cbox處理狀態.Items.Add("已結單");
            cbox處理狀態.Items.Add("延遲出貨");
            cbox處理狀態.Items.Add("取消訂單");
            cbox處理狀態.SelectedIndex = 0;
            讀取訂單詳情();
            顯示訂單詳情();
            if (!is訂單管理)
            {
                btn審核確認.Visible = false;
                btn延遲出貨.Visible=false;
                btn修改訂單.Visible=false;
            }
        }
        void 讀取訂單詳情()
        {
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            string strSQL = "select * from orders " +
                "join productBook on  orders.bookId=productBook.BookID " +
                "join customers on orders.customerId=customers.customerID " +
                "where orders.Ordernumbers =@SerarchOrdernumber; ";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@SerarchOrdernumber", orderNumbers);
            SqlDataReader reader = cmd.ExecuteReader();
            int count = 0;
            while (reader.Read())
            {
                txtI訂單編號.Text = reader["OrdersId"].ToString();
                txt訂購時間.Text = reader["Time"].ToString();
                txt訂購人.Text = reader["姓名"].ToString();
                list訂購書籍.Add(reader["BookName"].ToString());
                list訂購數量.Add((int)reader["Amount"]);
                list訂購金額.Add((int)reader["price"]);
                list書籍庫存.Add((int)reader["inventory"]);
                list書籍庫存ID.Add((int)reader["bookId"]);
                list商品狀況.Add(reader["ProductStatus"].ToString());
                str處理狀態 = reader["ProcessingStatus"].ToString();
                //listdte訂單時間.Add((DateTime)reader["Time"]);
                count++;
            }
            reader.Close();
            con.Close();
            //Console.WriteLine($"讀取{count}筆資料");
            cbox處理狀態.SelectedIndex = cbox處理狀態.Items.IndexOf(str處理狀態);
            處理狀態(str處理狀態);
        }
        void 顯示訂單詳情()
        {

            listView商品詳請.Clear();
            //listView商品詳請.View = View.LargeIcon;
            //listView商品詳請.View = View.SmallIcon;
            listView商品詳請.View = View.Details;
            //imglist書籍圖檔.ImageSize = new Size(120, 120);
            listView商品詳請.Columns.Add("訂購書籍", 400);
            listView商品詳請.Columns.Add("訂購數量", 100);
            listView商品詳請.Columns.Add("訂購金額", 100);
            listView商品詳請.Columns.Add("商品庫存", 100);
            //listView商品詳請.Columns.Add("變更明細");
            listView商品詳請.GridLines = true;//顯示格線
            listView商品詳請.FullRowSelect = true;//可以整行選取
            //listView商品詳請.LargeImageList = imglist書籍圖檔;
            //listView商品詳請.SmallImageList = imglist書籍圖檔;//List,SmallIcon
            for (int i = 0; i < list訂購書籍.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                //item.ImageIndex = i;
                item.Text = list訂購書籍[i].ToString();
                item.SubItems.Add(list訂購數量[i].ToString());
                item.SubItems.Add(list訂購金額[i].ToString());
                item.SubItems.Add(list書籍庫存[i].ToString());
                //item.SubItems.Add(list商品數量[i].ToString());
                //item.SubItems.Add(list處理狀態[i]);
                item.Font = new Font("微軟正黑體", 14, FontStyle.Regular);

                //item.Tag = list訂單編號[i];

                listView商品詳請.Items.Add(item);
                //listView訂單詳情.CheckBoxes = true;
            }
        }

        void 處理狀態(string str處理狀態)
        {
            switch (str處理狀態)
            {
                case "待處理"://0
                    btn修改訂單.Visible = true;
                    btn審核確認.Visible = true;
                    btn取消訂單.Visible = true;
                    btn審核確認.Enabled = true;
                    btn審核確認.Text = "審核確認";
                    btn延遲出貨.Visible = false;
                    //is庫存減訂購 = true;
                    break;
                case "已審核，出貨處理中"://1
                    btn修改訂單.Visible = true;
                    btn審核確認.Visible = true;
                    btn取消訂單.Visible = true;
                    btn審核確認.Enabled = true;
                    btn審核確認.Text = "出貨確認";
                    btn延遲出貨.Visible = true;
                    //is庫存減訂購 = false;//?
                    break;
                case "已出貨"://2
                    btn修改訂單.Visible = true;
                    btn審核確認.Visible = true;
                    btn取消訂單.Visible = true;
                    btn審核確認.Enabled = true;
                    btn審核確認.Text = "結單確認";
                    btn延遲出貨.Visible = false;
                    //is庫存減訂購 = true;
                    break;
                case "已結單"://3
                    btn審核確認.Visible = false;
                    btn延遲出貨.Visible = false;
                    btn取消訂單.Visible = false;
                    btn修改訂單.Visible = false;
                    //is庫存減訂購 = true;
                    break;
                case "延遲出貨"://4
                    btn修改訂單.Visible = true;
                    btn審核確認.Visible = true;
                    btn取消訂單.Visible = true;
                    btn審核確認.Enabled = true;
                    btn審核確認.Text = "出貨確認";
                    btn延遲出貨.Visible = false;
                    //is庫存減訂購 = false;
                    break;
                case "取消訂單"://5
                    btn審核確認.Visible = false;
                    btn延遲出貨.Visible = false;
                    btn取消訂單.Visible = false;
                    btn修改訂單.Visible = false;
                    //is庫存減訂購= true;
                    break;
                default:
                    break;
            }
        }

        private void btn審核確認_Click(object sender, EventArgs e)
        {
            if (cbox處理狀態.SelectedIndex == 1 || cbox處理狀態.SelectedIndex == 4)
            {
                is庫存減訂購 = true;
            }

            if (cbox處理狀態.SelectedIndex < 3)
            {
                cbox處理狀態.SelectedIndex++;
            }
            else if (cbox處理狀態.SelectedIndex == 4)
            {
                cbox處理狀態.SelectedIndex -= 2;
            }
            //處理狀態(str處理狀態);
            btn審核確認.Enabled = false;
            Console.WriteLine(cbox處理狀態.SelectedItem.ToString());
        }

        private void btn延遲出貨_Click(object sender, EventArgs e)
        {
            cbox處理狀態.SelectedIndex = 4;
            btn審核確認.Enabled = true;
            //處理狀態(str處理狀態);
        }

        private void btn取消訂單_Click(object sender, EventArgs e)
        {
                    
            
            DialogResult result = MessageBox.Show("是否取消訂單?", "訂單取消確認",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result ==DialogResult.OK)
            {
                
                if (cbox處理狀態.SelectedIndex == 2)
                {
                    出貨後取消訂單();
                }
                else
                {
                    出貨前取消訂單();
                }
                MessageBox.Show("訂單已取消");
                cbox處理狀態.SelectedIndex = 5;
                處理狀態(cbox處理狀態.SelectedItem.ToString());
            }
            //清楚list記錄();
            //讀取訂單詳情();
            //顯示訂單詳情();
        }
        void 出貨後取消訂單()//出貨後
        {
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            string strSQL = "update orders set " +
                //"OrdersId=@NewID,Time=@NewDateTime,姓名=@NewName," +
                //"BookName=@NewBookName,Amount=@NewAmount,price=@Newprice,inventory=@Newinventory," +
                "ProcessingStatus=@NewProcessingStatus where Ordernumbers=@NewOrdernumbers;";
            strSQL += "update productBook set inventory =@Newinventory,ProductStatus=@NewProductStatus" +
                " where bookId=@NewbookId";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@NewProcessingStatus", "取消訂單");
            cmd.Parameters.AddWithValue("@NewOrdernumbers", orderNumbers);

            for (int i = 0; i < list訂購書籍.Count; i++)
            {
                list書籍庫存[i] += list訂購數量[i];
                
            }
            for (int i = 0; i < list書籍庫存ID.Count; i++)//需在出貨處理中設定同時
            {
                if (list商品狀況[i] == "缺貨中")
                {
                    if (list書籍庫存[i] > 0)
                    {
                        list商品狀況[i] = "正常";
                    }
                }
                cmd.Parameters.AddWithValue("@NewbookId", list書籍庫存ID[i]);
                cmd.Parameters.AddWithValue("@Newinventory", list書籍庫存[i]);
                cmd.Parameters.AddWithValue("@NewProductStatus", list商品狀況[i]);
            }
            int rows = cmd.ExecuteNonQuery();
            con.Close();
            清除llist記錄();
            讀取訂單詳情();
            顯示訂單詳情();
        }
        void 出貨前取消訂單()//出貨前
        {
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            string strSQL = "update orders set " +
                //"OrdersId=@NewID,Time=@NewDateTime,姓名=@NewName," +
                //"BookName=@NewBookName,Amount=@NewAmount,price=@Newprice,inventory=@Newinventory," +
                "ProcessingStatus=@NewProcessingStatus where Ordernumbers=@NewOrdernumbers;";
            //strSQL += "update productBook set inventory =@Newinventory,ProductStatus=@NewProductStatus" +
            //    " where bookId=@NewbookId";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@NewProcessingStatus", "取消訂單");
            cmd.Parameters.AddWithValue("@NewOrdernumbers", orderNumbers);           
            int rows = cmd.ExecuteNonQuery();
            con.Close();
            清除llist記錄();
            讀取訂單詳情();
            顯示訂單詳情();
        }
        private void btn修改訂單_Click(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            string strSQL = "update orders set " +
                //"OrdersId=@NewID,Time=@NewDateTime,姓名=@NewName," +
                //"BookName=@NewBookName,Amount=@NewAmount,price=@Newprice,inventory=@Newinventory," +
                "ProcessingStatus=@NewProcessingStatus where Ordernumbers=@NewOrdernumbers;";
            strSQL += "update productBook set inventory =@Newinventory,ProductStatus=@NewProductStatus " +
                " where bookId=@NewbookId";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            
            if (is庫存減訂購)
            {
                for (int i = 0; i < list訂購書籍.Count; i++)
                {
                    list書籍庫存[i] -= list訂購數量[i];
                    if (list書籍庫存[i] > 0)
                    {
                        list商品狀況[i] = "正常";
                    }
                    else if(list書籍庫存[i] <= 0){//
                        list商品狀況[i] = "缺貨中";
                    }
                }
                for (int i = 0; i < list書籍庫存ID.Count; i++)//需在出貨處理中設定同時
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@NewProcessingStatus", cbox處理狀態.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@NewOrdernumbers", orderNumbers);
                    cmd.Parameters.AddWithValue("@NewbookId", list書籍庫存ID[i]);
                    cmd.Parameters.AddWithValue("@Newinventory", list書籍庫存[i]);
                    cmd.Parameters.AddWithValue("@NewProductStatus", list商品狀況[i]);
                    int rows = cmd.ExecuteNonQuery();
                }
                is庫存減訂購 = false;
            }
            else
            {
                cmd.Parameters.AddWithValue("@NewProcessingStatus", cbox處理狀態.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@NewOrdernumbers", orderNumbers);
                cmd.Parameters.AddWithValue("@NewbookId", 0);
                cmd.Parameters.AddWithValue("@Newinventory", 0);
                cmd.Parameters.AddWithValue("@NewProductStatus", 0);
                int rows = cmd.ExecuteNonQuery();
            }
            
            con.Close();
            //    txtI訂單編號.Text = reader["OrdersId"].ToString();
            //txt訂購時間.Text = reader["Time"].ToString();
            //txt訂購人.Text = reader["姓名"].ToString();
            //list訂購書籍.Add(reader["BookName"].ToString());
            //list訂購數量.Add((int)reader["Amount"]);
            //list訂購金額.Add((int)reader["price"]);
            //list書籍庫存.Add((int)reader["inventory"]);
            //str處理狀態 = reader["ProcessingStatus"].ToString();
            MessageBox.Show("訂單修改完成");
            str處理狀態 = cbox處理狀態.SelectedItem.ToString();
            處理狀態(str處理狀態);
            清除llist記錄();
            讀取訂單詳情();
            顯示訂單詳情();
        }
        void 清除llist記錄()
        {
            list訂購書籍.Clear();
            list訂購數量.Clear();
            list訂購金額.Clear();
            list書籍庫存.Clear();
            list書籍庫存ID.Clear();
        }

        private void cbox處理狀態_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if(cbox處理狀態.SelectedIndex!= 5|| cbox處理狀態.SelectedIndex != 3)
            //{
            //    處理狀態(cbox處理狀態.SelectedItem.ToString());
            //}
            
        }
    }
}
