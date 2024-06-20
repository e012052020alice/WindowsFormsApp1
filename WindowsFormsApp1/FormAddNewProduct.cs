using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormAddNewProduct : Form
    {
        string str修改後的圖檔名稱 = "";
        public int intBookID = 0;
        bool is修改圖檔 = false;
        public bool is修改模式 = false;
        public FormAddNewProduct()
        {
            InitializeComponent();
        }

        private void FormAddNewProduct_Load(object sender, EventArgs e)
        {
            cbox分類欄位.Items.Add("文學小說");
            cbox分類欄位.Items.Add("心理勵志");
            cbox分類欄位.Items.Add("商業理財");
            cbox分類欄位.Items.Add("電腦資訊");
            cbox分類欄位.Items.Add("輕小說");
            cbox分類欄位.SelectedIndex = 0;
            cbox商品狀況.Items.Add("正常");
            cbox商品狀況.Items.Add("預售");
            cbox商品狀況.Items.Add("缺貨中");
            cbox商品狀況.Items.Add("下架停賣");
            cbox商品狀況.SelectedIndex = 0;

            if (is修改模式)//修改
            {
                btn加入商品庫.Visible = false;
                修改商品庫();
            }
            else//增加
            {
                btn修改商品庫.Visible = false;
                btn進貨.Visible= false;
            }
        }
        void 修改商品庫()
        {            
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            string strSQL = "select *from productBook where BookID=@SearchID;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@SearchID", intBookID);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txt商品名稱.Text = reader["BookName"].ToString();
                txt商品價格.Text = reader["BookPrice"].ToString();
                txt作者.Text= reader["BookWriter"].ToString();
                //Console.WriteLine(cbox分類欄位.Items.IndexOf(reader["BookClassification"].ToString()));
                int index分類 = cbox分類欄位.Items.IndexOf(reader["BookClassification"].ToString());
                cbox分類欄位.SelectedIndex = index分類;
                
                //cmd.Parameters.AddWithValue("@NewImage", str修改後的圖檔名稱);
                //cmd.Parameters.AddWithValue("@NewDesc", txt商品描述.Text);
                int index品狀況 = cbox商品狀況.Items.IndexOf(reader["ProductStatus"].ToString());
                cbox商品狀況.SelectedIndex = index品狀況;
                txt庫存.Text= reader["inventory"].ToString();
                txt簡介.Text = reader["BookDesc"].ToString();
                string image_name = ((string)reader["BookImage"]);
                str修改後的圖檔名稱 = image_name;
                string str完整圖片路徑 = $"{GlobalVar.image_dir}\\{image_name}";
                pictureBox書籍圖片.Image = Image.FromFile(str完整圖片路徑);
                pictureBox書籍圖片.Tag = str完整圖片路徑;
            }
            reader.Close();
            con.Close();
            //if (is修改圖檔 == true)
            //{
            //    //string 完整圖檔路徑 = GlobalVar.image_dir + @"\" + str修改後的圖檔名稱;
            //    //pictureBox書籍圖片.Image.Save(完整圖檔路徑);
            //    is修改圖檔 = false;
            //    //Task.Delay(1000).Wait();
            //    //pictureBox商品圖片.Image.Dispose();
            //    //System.IO.File.Delete(str修改前的圖檔名稱);
            //}
            
            //this.Close();
        }
        private void 選取圖片_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "檔案類型(JPEG,JPG,PNG)|*.jpeg;*.jpg;*.png";

            DialogResult R = fileDialog.ShowDialog();
            if (R == DialogResult.OK)
            {
                pictureBox書籍圖片.Image = Image.FromFile(fileDialog.FileName);
                //System.IO.FileStream fs = System.IO.File.OpenRead(fileDialog.FileName);
                //pictureBox書籍圖片.Image = Image.FromStream(fs);
                //fs.Close();
                pictureBox書籍圖片.Tag = fileDialog.FileName;
                //Console.WriteLine($"草莓:{fileDialog.FileName}");
                //str修改前的圖檔名稱 = fileDialog.FileName;
                string str圖檔副檔名 = System.IO.Path.GetExtension(fileDialog.SafeFileName).ToLower();
                Random myRannd = new Random();
                //str修改後的圖檔名稱 = DateTime.Now.ToString("yyMMddHHmmss") + myRannd.Next(100, 10000).ToString() + str圖檔副檔名;
                //str修改後的圖檔名稱 = fileDialog.FileName + str圖檔副檔名;
                str修改後的圖檔名稱 = Path.GetFileName(fileDialog.FileName);
                is修改圖檔 = true;
                //Console.WriteLine(str修改後的圖檔名稱);
            }
        }

        void 加入商品庫()
        {
            if ((txt商品名稱.Text != "") && (txt商品價格.Text != "") && (txt作者.Text != "")
                && (txt庫存.Text != "") && (pictureBox書籍圖片.Image != null))
            {
                SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                con.Open();
                string strSQL = "insert into productBook values" +
                    "(@NewBookName,@NewPrice,@NewWriter,@NewClasaificition,@NewImage,@NewDesc,@NewProductStatus,@Inventory);";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@NewBookName", txt商品名稱.Text.Trim());
                int intPrice = 0;
                Int32.TryParse(txt商品價格.Text, out intPrice);
                cmd.Parameters.AddWithValue("@NewPrice", intPrice);
                cmd.Parameters.AddWithValue("@NewWriter", txt作者.Text.Trim());
                cmd.Parameters.AddWithValue("@NewClasaificition", cbox分類欄位.SelectedItem);
                cmd.Parameters.AddWithValue("@NewImage", str修改後的圖檔名稱);
                //cmd.Parameters.AddWithValue("@NewDesc", txt商品描述.Text);
                cmd.Parameters.AddWithValue("@NewDesc", txt簡介.Text);
                cmd.Parameters.AddWithValue("@NewProductStatus", cbox商品狀況.SelectedItem);
                int intInventory = 0;
                Int32.TryParse(txt庫存.Text, out intInventory);
                cmd.Parameters.AddWithValue("@Inventory", intInventory);
                
                int rows = cmd.ExecuteNonQuery();
                con.Close();
                if (is修改圖檔 == true)
                {
                    //string 完整圖檔路徑 = GlobalVar.image_dir + @"\" + str修改後的圖檔名稱;
                    //pictureBox書籍圖片.Image.Save(完整圖檔路徑);
                    is修改圖檔 = false;
                    //Task.Delay(1000).Wait();
                    //pictureBox商品圖片.Image.Dispose();
                    //System.IO.File.Delete(str修改前的圖檔名稱);
                }
                MessageBox.Show("新增儲存成功!!");
                this.Close();
            }
            else
            {
                MessageBox.Show("資料欄位填寫不全!!");
            }
        }
        private void btn加入商品庫_Click(object sender, EventArgs e)
        {
            加入商品庫();
        }

        private void txt商品價格_TextChanged(object sender, EventArgs e)
        {

            if (!Int32.TryParse(txt商品價格.Text, out int intprice))
            {
                MessageBox.Show("價格需為數字!!");
            }
        }

        private void txt庫存_TextChanged(object sender, EventArgs e)
        {
            if (!Int32.TryParse(txt庫存.Text, out int intprice))
            {
                MessageBox.Show("庫存數量需為數字!!");
            }
        }

        private void btn修改商品庫_Click(object sender, EventArgs e)
        {
            if ((txt商品名稱.Text != "") && (txt商品價格.Text != "") && (txt作者.Text != "")
                && (txt庫存.Text != "") && (pictureBox書籍圖片.Image != null))
            {
                SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                con.Open();
                string strSQL = "update productBook set BookName=@NewBookName,BookPrice=@NewPrice,BookWriter=@NewWriter," +
                    "BookClassification=@NewClasaificition,BookImage=@NewImage,BookDesc=@NewDesc,ProductStatus=@NewProductStatus,inventory=@Inventory " +
                    "where BookID=@SerahBookID;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SerahBookID", intBookID);
                cmd.Parameters.AddWithValue("@NewBookName", txt商品名稱.Text.Trim());
                int intPrice = 0;
                Int32.TryParse(txt商品價格.Text, out intPrice);
                cmd.Parameters.AddWithValue("@NewPrice", intPrice);
                cmd.Parameters.AddWithValue("@NewWriter", txt作者.Text.Trim());
                cmd.Parameters.AddWithValue("@NewClasaificition", cbox分類欄位.SelectedItem);
                Console.WriteLine($"BookImage:{str修改後的圖檔名稱}");
                cmd.Parameters.AddWithValue("@NewImage", str修改後的圖檔名稱);
                cmd.Parameters.AddWithValue("@NewDesc", txt簡介.Text);
                cmd.Parameters.AddWithValue("@NewProductStatus", cbox商品狀況.SelectedItem);
                int intInventory = 0;
                Int32.TryParse(txt庫存.Text, out intInventory);
                cmd.Parameters.AddWithValue("@Inventory", intInventory);

                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("修改成功!!");
            }
            else
            {
                MessageBox.Show("資料欄位填寫不全!!");
            }
        }

        private void btn進貨_Click(object sender, EventArgs e)
        {
            DialogResult R=MessageBox.Show("確定要刪除此商品?","刪除確認",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if(R==DialogResult.Yes)
            {
                SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                con.Open();
                string strSQL = "delete from productBook where BookID=@DeleteID;";
                SqlCommand cmd= new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@DeleteID", intBookID);
                int rows= cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("商品已刪除");
                this.Close();
            }
        }
    }
}
