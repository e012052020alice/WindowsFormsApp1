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
    public partial class Form2ProductManagement : Form
    {
        //
        List<int> list商品ID = new List<int>();
        List<string> list書籍名稱 = new List<string>();
        List<int> list單價 = new List<int>();
        List<string> list作者 = new List<string>();
        List<string> list分類 = new List<string>();
        List<string> list書籍簡介 = new List<string>();
        List<string> list商品狀況 = new List<string>();
        List<int> list商品庫存 = new List<int>();
        string str搜尋SQL = "";
        public Form2ProductManagement()
        {
            InitializeComponent();
        }

        private void Form2ProductManagement_Load(object sender, EventArgs e)
        {
            cbox欄位名稱.Items.Add("商品ID");
            cbox欄位名稱.Items.Add("書名");
            cbox欄位名稱.Items.Add("分類");
            cbox欄位名稱.Items.Add("商品狀況");
            cbox欄位名稱.Items.Add("庫存");
            cbox欄位名稱.SelectedIndex = 0;
            讀取商品資訊();
            顯示商品資訊();
            str搜尋SQL = "select *from productBook where BookID like @SearchKeyword;";
        }
        void 讀取商品資訊()
        {
            清空list();
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            string strSQL = "select * from productBook;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list商品ID.Add((int)reader["BookID"]);
                list書籍名稱.Add(reader["BookName"].ToString());
                list單價.Add((int)reader["BookPrice"]);
                list作者.Add(reader["BookWriter"].ToString());
                list分類.Add(reader["BookClassification"].ToString());
                //list書籍簡介.Add(reader["BookName"].ToString());
                list商品狀況.Add(reader["ProductStatus"].ToString());
                list商品庫存.Add((int)reader["inventory"]);
                string image_name = reader["BookImage"].ToString();
                string 完整圖片路徑 = $"{GlobalVar.image_dir}\\{image_name}";
                foreach(int id in list商品ID){
                    Console.WriteLine(id);
                }
                Console.WriteLine(完整圖片路徑);
                Console.WriteLine($"image_name:{image_name}");
                Image img書籍圖檔 = Image.FromFile(完整圖片路徑);
                imageList商品圖檔.Images.Add(img書籍圖檔);
            }
            reader.Close();
            con.Close();


        }
        void 顯示商品資訊()
        {
            listView商品展示.Clear();
            listView商品展示.View = View.Details;
            imageList商品圖檔.ImageSize = new Size(60, 60);
            listView商品展示.Columns.Add("圖片", 80);
            listView商品展示.Columns.Add("商品ID", 80);

            listView商品展示.Columns.Add("書籍名稱", 200);
            listView商品展示.Columns.Add("單價");
            listView商品展示.Columns.Add("作者", 100);
            listView商品展示.Columns.Add("分類",80);
            //listView商品展示.Columns.Add("書籍簡介");
            listView商品展示.Columns.Add("商品狀況", 80);
            listView商品展示.Columns.Add("商品庫存");
            listView商品展示.GridLines = true;//顯示格線
            listView商品展示.FullRowSelect = true;//可以整行選取
            listView商品展示.SmallImageList = imageList商品圖檔;

            for (int i = 0; i < list商品ID.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                //item.Text = list商品ID[i].ToString();
                item.SubItems.Add(list商品ID[i].ToString());
                item.ImageIndex = i;
                item.SubItems.Add(list書籍名稱[i]);
                item.SubItems.Add(list單價[i].ToString());
                item.SubItems.Add(list作者[i]);
                item.SubItems.Add(list分類[i]);
                item.SubItems.Add(list商品狀況[i]);
                item.SubItems.Add(list商品庫存[i].ToString());
                item.Font = new Font("微軟正黑體", 10, FontStyle.Regular);
                item.Tag = list商品ID[i];
                listView商品展示.Items.Add(item);

            }
        }
        void 清空list()
        {
            listView商品展示.Clear();
            list商品ID.Clear();
            list書籍名稱.Clear();
            list單價.Clear();
            list作者.Clear();
            list分類.Clear();
            list商品狀況.Clear();
            list商品庫存.Clear();
            imageList商品圖檔.Images.Clear();
        }
        private void btn搜尋_Click(object sender, EventArgs e)//
        {
            清空list();
            bool is轉換成功 = true;
            //Console.WriteLine($"str搜尋SQL:{str搜尋SQL}");
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            //string str欄位名稱 = cbox欄位名稱.SelectedItem.ToString();
            //string strSQL = $"select * from productBook where ({str欄位名稱} like @SearchKeyword) ";
            SqlCommand cmd = new SqlCommand(str搜尋SQL, con);
            if (cbox欄位名稱.SelectedIndex == 0 || cbox欄位名稱.SelectedIndex == 4)
            {
                if (Int32.TryParse(txt搜尋關鍵字.Text, out int intNumber))
                {
                    cmd.Parameters.AddWithValue("@SearchKeyword", intNumber);
                }
                else
                {
                    is轉換成功 = false;
                    MessageBox.Show("此欄位搜尋關鍵字需為數字");
                }
            }
            else
            {
                cmd.Parameters.AddWithValue("@SearchKeyword", $"%{txt搜尋關鍵字.Text}%");
            }
            if (is轉換成功)
            {
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list商品ID.Add((int)reader["BookID"]);
                    list書籍名稱.Add(reader["BookName"].ToString());
                    list單價.Add((int)reader["BookPrice"]);
                    list作者.Add(reader["BookWriter"].ToString());
                    list分類.Add(reader["BookClassification"].ToString());
                    //list書籍簡介.Add(reader["BookName"].ToString());
                    list商品狀況.Add(reader["ProductStatus"].ToString());
                    list商品庫存.Add((int)reader["inventory"]);
                    string image_name = (reader["BookImage"].ToString());
                    string 完整圖片路徑 = $"{GlobalVar.image_dir}\\{image_name}";
                    Console.WriteLine(完整圖片路徑);
                    Image img書籍圖檔 = Image.FromFile(完整圖片路徑);
                    imageList商品圖檔.Images.Add(img書籍圖檔);
                }
                reader.Close();
            }
            
            con.Close();
            顯示商品資訊();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAddNewProduct myaddnewproduct = new FormAddNewProduct();
            myaddnewproduct.ShowDialog();
        }

        private void listView商品展示_ItemActivate(object sender, EventArgs e)
        {
            FormAddNewProduct myformAddNewProduct = new FormAddNewProduct();
            myformAddNewProduct.intBookID = (int)listView商品展示.SelectedItems[0].Tag;
            //Console.WriteLine((int)listView商品展示.SelectedItems[0].Tag);
            myformAddNewProduct.is修改模式 = true;
            myformAddNewProduct.ShowDialog();
            讀取商品資訊();
            顯示商品資訊();
        }

        private void cbox欄位名稱_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbox欄位名稱.SelectedIndex == 0)//ID
            {
                str搜尋SQL = "select *from productBook where BookID = @SearchKeyword;";
            }
            else if (cbox欄位名稱.SelectedIndex == 1)//書名
            {
                str搜尋SQL = "select *from productBook where BookName like @SearchKeyword;";
            }
            else if (cbox欄位名稱.SelectedIndex == 2)//分類
            {
                str搜尋SQL = "select *from productBook where BookClassification like @SearchKeyword;";
            }
            else if (cbox欄位名稱.SelectedIndex == 3)//商品狀況
            {
                str搜尋SQL = "select *from productBook where ProductStatus like @SearchKeyword;";
            }
            else if (cbox欄位名稱.SelectedIndex == 4)//庫存
            {
                str搜尋SQL = "select *from productBook where inventory = @SearchKeyword;";
            }
        }

        private void btn全部商品_Click(object sender, EventArgs e)
        {
            清空list();
            讀取商品資訊();
            顯示商品資訊();
        }
    }
}
