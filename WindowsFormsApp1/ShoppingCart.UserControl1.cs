using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ShoppingCart : UserControl
    {
        
        string str圖檔名稱 = "";
        public ShoppingCart()
        {
            InitializeComponent();
        }
        private void ShoppingCart_Load(object sender, EventArgs e)
        {
            //Console.WriteLine(pictureBox書籍資訊.Size);
            顯示商品詳細資訊();
            //Console.WriteLine(pictureBox書籍資訊.Size);

        }
        void 顯示商品詳細資訊()
        {
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            string strSQL = $"select * from productBook where BookID=@SearchId;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@SearchId", GlobalVar.loadId2);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                lblBookId.Text = reader["BookID"].ToString();
                txtBookName.Tag= reader["BookID"].ToString();
                txtBookName.Text = reader["BookName"].ToString();
                lblBookPrice.Text = reader["BookPrice"].ToString();
                str圖檔名稱 = reader["BookImage"].ToString();
                string 完整圖片路徑 = $"{GlobalVar.image_dir}\\{str圖檔名稱}";
                pictureBox書籍資訊.Image = Image.FromFile(完整圖片路徑);

            }
            reader.Close();
            con.Close();
            //str書籍Name = lblBookName.Text;
        }

        private void btn加入購物車_Click(object sender, EventArgs e)//
        {
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            string strSQL = $"select * from shoppingCart where customerID=@CustomerID and BookID=@BookID;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@CustomerID", GlobalVar.使用者id);
            cmd.Parameters.AddWithValue("@BookID", txtBookName.Tag);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                int addAmount =0 ;
                Int32.TryParse(txt本數.Text, out addAmount);
                addAmount += (int)reader["bookAmount"];
                //Console.WriteLine(addAmount);
                //cmd.Parameters.Clear();
                strSQL = $"update shoppingCart set bookAmount=@SumAmount,price=@bookprice ";
                cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SumAmount", addAmount);
                //cmd.Parameters.AddWithValue("@CustomerID", GlobalVar.使用者id);
                //cmd.Parameters.AddWithValue("@BookID", txtBookName.Tag);
                int intPrice = 0;
                Int32.TryParse(lblBookPrice.Text, out intPrice);
                cmd.Parameters.AddWithValue("@bookprice", addAmount * intPrice);
            }
            else
            {
                cmd.Parameters.Clear();
                strSQL = $"insert into shoppingCart values(@NewCustomer,@NewBook,@NewAmount,@NewPrice);";
                cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@NewCustomer", GlobalVar.使用者id);
                cmd.Parameters.AddWithValue("@NewBook", txtBookName.Tag);
                int intAmount = 0;
                Int32.TryParse(txt本數.Text, out intAmount);
                cmd.Parameters.AddWithValue("@NewAmount", intAmount);
                int intPrice = 0;
                Int32.TryParse(lblBookPrice.Text, out intPrice);
                cmd.Parameters.AddWithValue("@NewPrice", intAmount * intPrice);
                
            }
            reader.Close();
            int rows = cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("已加入購物車");
        }

        private void btnminus1_Click(object sender, EventArgs e)
        {
            int intAmount = 0;
            Int32.TryParse(txt本數.Text, out intAmount);
            if (intAmount > 1)
            {
                intAmount--;
                txt本數.Text = intAmount.ToString();
            }
            
        }

        private void btnadd1_Click(object sender, EventArgs e)
        {
            
            int intAmount = 0;
            Int32.TryParse(txt本數.Text,out intAmount);
            intAmount++;
            txt本數.Text = intAmount.ToString();
        }

        private void btn關閉_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private void txtBookName_TextChanged(object sender, EventArgs e)
        {
            AutoResizeTextBox(txtBookName);
        }
        private void AutoResizeTextBox(TextBox textBox)
        {
            // 測量TextBox的文字行數
            int lineCount = textBox.GetLineFromCharIndex(textBox.TextLength) + 1;

            // 設置TextBox的高度
            int lineHeight = TextRenderer.MeasureText("Sample", textBox.Font).Height; // 取得單行文字高度
            int newHeight = lineHeight * lineCount + textBox.Margin.Vertical;

            textBox.Height = newHeight;
        }
    }
}
