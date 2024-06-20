using Sunny.UI;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace WindowsFormsApp1
{
    public partial class FormMemberInformationManagement : Form
    {
        List<int> list會員ID = new List<int>();
        List<string> list會員姓名 = new List<string>();
        List<string> list會員電話 = new List<string>();
        List<string> list會員地址= new List<string>();
        List<string> list會員Email = new List<string>();
        List<string> list會員密碼 = new List<string>();
        List<DateTime> list會員生日 = new List<DateTime>();
        List<bool > list婚姻狀態 = new List<bool>();
        List<int> list會員點數 = new List<int>();
        //List<int> list會員權限 = new List<int>();
        List<string> list使用狀態 = new List<string>();//10
        List<int> list權限 = new List<int>();

        int int婚姻狀態 = 0;//0:全部,1:單身,2:已婚;搜尋用
        public FormMemberInformationManagement()
        {
            InitializeComponent();
        }

        private void FormMemberInformationManagement_Load(object sender, EventArgs e)
        {
            讀取會員詳情();
            顯示會員詳情();
            cbox欄位名稱.Items.Add("會員ID");
            cbox欄位名稱.Items.Add("姓名");
            cbox欄位名稱.Items.Add("電話");
            cbox欄位名稱.Items.Add("地址");
            cbox欄位名稱.Items.Add("Email");
            cbox欄位名稱.Items.Add("使用狀態");
            cbox欄位名稱.Items.Add("員工");
            cbox欄位名稱.SelectedIndex = 0;
            radio婚姻全部.Checked = true;
        }

        void 讀取會員詳情()
        {
            清空list();
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            string strSQL = $"select * from customers;" ;          
            SqlCommand cmd = new SqlCommand(strSQL, con);
            //cmd.Parameters.AddWithValue("@SearchID", GlobalVar.使用者id);
            SqlDataReader reader = cmd.ExecuteReader();
            int count = 0;
            while (reader.Read())
            {

                list會員ID.Add((int)reader["customerID"]);
                list會員姓名.Add(reader["姓名"].ToString());
                list會員電話.Add(reader["電話"].ToString());
                list會員地址.Add(reader["地址"].ToString());
                list會員Email.Add(reader["Email"].ToString());
                list會員密碼.Add(reader["密碼"].ToString());
                list會員生日.Add((DateTime)reader["生日"]);
                list婚姻狀態.Add((bool)reader["婚姻狀態"]);
                list會員點數.Add((int)reader["點數"]);
                list使用狀態.Add(reader["使用狀態"].ToString());
                list權限.Add((int)reader["權限"]);
                //list會員權限 
                count++;

            }
            reader.Close();
            con.Close();
            Console.WriteLine($"讀取{count}筆資料");
            
        }
        void 顯示會員詳情()
        {
            listView會員資訊.Clear();
            //listView會員資訊.View = View.LargeIcon;
            //listView會員資訊.View = View.SmallIcon;
            listView會員資訊.View = View.Details;
            //imglist書籍圖檔.ImageSize = new Size(120, 120);
            listView會員資訊.Columns.Add("會員ID"); // 第一列寬度 100
            listView會員資訊.Columns.Add("姓名");
            listView會員資訊.Columns.Add("電話", 150); // 第二列寬度 200
            listView會員資訊.Columns.Add("地址", 150);
            listView會員資訊.Columns.Add("Email", 150);
            listView會員資訊.Columns.Add("密碼", 100);
            listView會員資訊.Columns.Add("生日", 120);
            listView會員資訊.Columns.Add("婚姻狀態");
            listView會員資訊.Columns.Add("點數");
            listView會員資訊.Columns.Add("使用狀態", 100);
            listView會員資訊.Columns.Add("身分", 100);

            listView會員資訊.GridLines = true;//顯示格線
            listView會員資訊.FullRowSelect = true;//可以整行選取
            //listView會員資訊.LargeImageList = imglist書籍圖檔;
            //listView會員資訊.SmallImageList = imglist書籍圖檔;//List,SmallIcon
            for (int i = 0; i < list會員ID.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                //item.ImageIndex = i;
                item.Text = list會員ID[i].ToString();
                item.SubItems.Add(list會員姓名[i].ToString());
                item.SubItems.Add(list會員電話[i].ToString());
                item.SubItems.Add(list會員地址[i].ToString());
                item.SubItems.Add(list會員Email[i].ToString());
                item.SubItems.Add(list會員密碼[i].ToString());
                item.SubItems.Add(list會員生日[i].ToString("yyyy/MM/dd"));
                switch (list婚姻狀態[i])
                {
                    case false:
                        item.SubItems.Add("單身");
                        break;
                    case true:
                        item.SubItems.Add("已婚");
                        break;
                }
                //item.SubItems.Add(list婚姻狀態[i].ToString());
                item.SubItems.Add(list會員點數[i].ToString());
                item.SubItems.Add(list使用狀態[i].ToString());
                if (list權限[i] >= 1000)
                {
                    item.SubItems.Add("一般會員");
                }
                else if (list權限[i] < 1000 && list權限[i] >= 100)
                {
                    item.SubItems.Add("店員");
                }
                else if (list權限[i] < 100 && list權限[i] >= 10)
                {
                    item.SubItems.Add("店長");
                }
                else if ((list權限[i] >= 1) && (list權限[i] < 10))
                {
                    item.SubItems.Add("系統管理員");
                }
                item.Font = new Font("微軟正黑體", 10, FontStyle.Regular);

                item.Tag = list會員ID[i];

                listView會員資訊.Items.Add(item);
                //listView訂單詳情.CheckBoxes = true;
            }
        }
        void 清空list()
        {
            list會員ID.Clear();
            list會員姓名.Clear();
            list會員電話.Clear();
            list會員地址.Clear();
            list會員Email.Clear();
            list會員密碼.Clear();
            list會員生日.Clear();
            list婚姻狀態.Clear();
            list會員點數.Clear();
            //list會員權限.Clear();
            list使用狀態.Clear();
            list權限.Clear();
        }
        private void btn搜尋_Click(object sender, EventArgs e)
        {
            清空list();
            if (txt搜尋關鍵字.Text != "")
            {

                string str欄位名稱 = cbox欄位名稱.SelectedItem.ToString();
                if (cbox欄位名稱.SelectedIndex == 0)
                {
                    str欄位名稱 = "customerID";
                }
                string strSQL婚姻狀態查詢語法 = "";
                switch (int婚姻狀態)
                {
                    case 0://全部
                        strSQL婚姻狀態查詢語法 = "";
                        break;
                    case 1://單身
                        strSQL婚姻狀態查詢語法 = "and 婚姻狀態=0";
                        break;
                    case 2://已婚
                        strSQL婚姻狀態查詢語法 = "and 婚姻狀態=1";
                        break;
                    default:
                        strSQL婚姻狀態查詢語法 = "";
                        break;
                }
                SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                con.Open();
                string strSQL = $"select * from customers where(生日>=@StartBirth and 生日<=@EndBirth) and " +
                    $"({str欄位名稱} like @SearchKeyword) {strSQL婚姻狀態查詢語法}";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@StartBirth", dtp開始時間.Value);
                cmd.Parameters.AddWithValue("@EndBirth", dtp結束時間.Value);
                cmd.Parameters.AddWithValue("@SearchKeyword", $"%{txt搜尋關鍵字.Text}%");
                SqlDataReader reader = cmd.ExecuteReader();

                int count = 0;

                while (reader.Read() == true)
                {
                    list會員ID.Add((int)reader["customerID"]);
                    list會員姓名.Add(reader["姓名"].ToString());
                    list會員電話.Add(reader["電話"].ToString());
                    list會員地址.Add(reader["地址"].ToString());
                    list會員Email.Add(reader["email"].ToString());
                    list會員密碼.Add(reader["密碼"].ToString());
                    list會員生日.Add((DateTime)reader["生日"]);
                    list婚姻狀態.Add((bool)reader["婚姻狀態"]);
                    list會員點數.Add((int)reader["點數"]);
                    list使用狀態.Add(reader["使用狀態"].ToString());
                    list權限.Add((int)reader["權限"]);
                    //list會員權限 
                    count++;
                }
                if (count == 0)
                {
                    MessageBox.Show("查無此人");
                }       

                reader.Close();
                con.Close();
                顯示會員詳情();
            }
            else if (cbox欄位名稱.SelectedIndex == 6)//查看員工
            {
                string strSQL婚姻狀態查詢語法 = "";
                switch (int婚姻狀態)
                {
                    case 0://全部
                        strSQL婚姻狀態查詢語法 = "";
                        break;
                    case 1://單身
                        strSQL婚姻狀態查詢語法 = "and 婚姻狀態=0";
                        break;
                    case 2://已婚
                        strSQL婚姻狀態查詢語法 = "and 婚姻狀態=1";
                        break;
                    default:
                        strSQL婚姻狀態查詢語法 = "";
                        break;
                }
                SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                con.Open();
                string strSQL = $"select * from customers where (生日>=@StartBirth and 生日<=@EndBirth) " +
                    $"{strSQL婚姻狀態查詢語法} and 權限<1000;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@StartBirth", dtp開始時間.Value);
                cmd.Parameters.AddWithValue("@EndBirth", dtp結束時間.Value);
                SqlDataReader reader = cmd.ExecuteReader();

                int count = 0;

                while (reader.Read() == true)
                {
                    list會員ID.Add((int)reader["customerID"]);
                    list會員姓名.Add(reader["姓名"].ToString());
                    list會員電話.Add(reader["電話"].ToString());
                    list會員地址.Add(reader["地址"].ToString());
                    list會員Email.Add(reader["email"].ToString());
                    list會員密碼.Add(reader["密碼"].ToString());
                    list會員生日.Add((DateTime)reader["生日"]);
                    list婚姻狀態.Add((bool)reader["婚姻狀態"]);
                    list會員點數.Add((int)reader["點數"]);
                    list使用狀態.Add(reader["使用狀態"].ToString());
                    list權限.Add((int)reader["權限"]);
                    count++;
                }
                reader.Close();
                con.Close();
                顯示會員詳情();
            }
            else
            {
                MessageBox.Show("請輸入搜尋關鍵字");
            }
        }

        private void radio婚姻全部_CheckedChanged(object sender, EventArgs e)
        {
            int婚姻狀態 = 0;
        }

        private void radio婚姻單身_CheckedChanged(object sender, EventArgs e)
        {
            int婚姻狀態 = 1;
        }

        private void radio婚姻已婚_CheckedChanged(object sender, EventArgs e)
        {
            int婚姻狀態 = 2;
        }

        private void listView會員資訊_ItemActivate(object sender, EventArgs e)
        {
            FormPersonInfromation myformPersonInfromation=new FormPersonInfromation();
            Console.WriteLine((int)listView會員資訊.SelectedItems[0].Tag);
            myformPersonInfromation.PersonID =(int) listView會員資訊.SelectedItems[0].Tag;
            myformPersonInfromation.ShowDialog();
            讀取會員詳情();
            顯示會員詳情();
        }

        private void btn回到全部_Click(object sender, EventArgs e)
        {
            讀取會員詳情();
            顯示會員詳情();
        }
    }
}
