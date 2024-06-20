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
namespace WindowsFormsApp1
{
    public partial class FormBooksDetail : Form
    {
        public int loadId = 0;
        string str圖檔名稱 = "";
        
        public FormBooksDetail()
        {
            InitializeComponent();
        }

        private void FormBooksDetail_Load(object sender, EventArgs e)
        {
            顯示商品詳細資訊();
        }
        void 顯示商品詳細資訊()
        {
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            string strSQL = $"select * from productBook where BookID=@SearchId;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@SearchId", loadId);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                lblBookId.Text = reader["BookID"].ToString();
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

        private void txtBookName_TextChanged(object sender, EventArgs e)
        {
            AutoResizeTextBox(txtBookName);//自動調整textBox高度
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

        private void btn加入購物車_Click(object sender, EventArgs e)
        {
            //
        }

        private void pictureBox書籍資訊_Click(object sender, EventArgs e)
        {

        }
    }
}
