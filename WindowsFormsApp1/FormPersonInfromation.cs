using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormPersonInfromation : Form
    {
        public int PersonID = 0;
        List<string> list歷史訂單=new List<string>();
        List<string> list訂單狀況 = new List<string>();
        List<string> list訂購書籍 = new List<string>();
        //List<int> list訂購數量 = new List<int>();
        //List<int> list訂購金額 = new List<int>();
        string long歷史訂單 = null;
        int int權限 = 0;
        public FormPersonInfromation()
        {
            InitializeComponent();
        }

        private void FormPersonInfromation_Load(object sender, EventArgs e)
        {

            if (GlobalVar.使用者權限 < 100)
            {
                txt權限.Enabled = true;
            }
            cbox狀態欄位.Items.Add("審核");
            cbox狀態欄位.Items.Add("正常使用");
            cbox狀態欄位.Items.Add("停權");
            cbox狀態欄位.SelectedIndex = 0;
            讀取會員詳細資訊();
            顯示訂單詳情();
        }
        void 讀取會員詳細資訊()
        {
            清除list();
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            string strSQL = $"select * from customers " +
                $"LEFT OUTER join orders on customers.customerID=orders.customerId " +
                $"LEFT OUTER join productBook on orders.bookId=productBook.BookID " +
                $"where customers.customerID=@SearchID;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@SearchID", PersonID);
            SqlDataReader reader = cmd.ExecuteReader();
            int count = 0;
            while (reader.Read())
            {
                txtID.Text = reader["customerID"].ToString();
                txt姓名.Text = reader["姓名"].ToString();
                txt電話.Text = reader["電話"].ToString();
                txt地址.Text = reader["地址"].ToString();
                txtEmail.Text = reader["Email"].ToString();
                dtp生日.Value = (DateTime)reader["生日"];
                chk婚姻狀態.Checked = (bool)reader["婚姻狀態"];
                txt點數.Text = reader["點數"].ToString();
                cbox狀態欄位.SelectedIndex = cbox狀態欄位.Items.IndexOf(reader["使用狀態"].ToString());
                //cbox狀態欄位.SelectedIndex = 0;
                txt密碼.Text = reader["密碼"].ToString();
                txt權限.Text = reader["權限"].ToString();
                long歷史訂單 = reader["Ordernumbers"].ToString();
                if (long歷史訂單 !=null)
                {
                    list歷史訂單.Add(long歷史訂單);
                    list訂單狀況.Add(reader["ProcessingStatus"].ToString());
                    list訂購書籍.Add(reader["BookName"].ToString());
                    //list訂購數量.Add((int)reader["Amount"]);
                    //list訂購金額.Add((int)reader["price"]);
                }

                count++;

            }
            reader.Close();
            con.Close();
            Console.WriteLine($"讀取{count}筆資料");
        }
        void 顯示訂單詳情()
        {

            listView歷史訂單.Clear();
            listView歷史訂單.View = View.Details;
            listView歷史訂單.Columns.Add("訂單編號", 150);
            listView歷史訂單.Columns.Add("訂購狀況", 130);
            listView歷史訂單.Columns.Add("訂購書籍", 500);
            
            //listView歷史訂單.Columns.Add("訂購數量", 100);
            //listView歷史訂單.Columns.Add("訂購金額", 100);
            //listView歷史訂單.Columns.Add("商品庫存", 100);
            listView歷史訂單.GridLines = true;//顯示格線
            listView歷史訂單.FullRowSelect = true;//可以整行選取

            for (int i = 0; i < list歷史訂單.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                //item.ImageIndex = i;
                
                item.Text = list歷史訂單[i].ToString();
                item.SubItems.Add(list訂單狀況[i].ToString());
                item.SubItems.Add(list訂購書籍[i].ToString());               
                //item.SubItems.Add(list訂購數量[i].ToString());
                //item.SubItems.Add(list訂購金額[i].ToString());

                //item.SubItems.Add(list商品數量[i].ToString());
                //item.SubItems.Add(list處理狀態[i]);
                item.Font = new Font("微軟正黑體", 12, FontStyle.Regular);

                item.Tag = list歷史訂單[i];

                listView歷史訂單.Items.Add(item);
                //listView訂單詳情.CheckBoxes = true;
                
            }
        }
        void 清除list()
        {
            list歷史訂單.Clear();
            list訂單狀況.Clear();
            list訂購書籍.Clear();
            //list訂購數量.Clear();
            //list訂購金額.Clear();
        }
        private void btn修改_Click(object sender, EventArgs e)
        {
            Console.WriteLine($"cbox狀態欄位.SelectedItem:{cbox狀態欄位.SelectedItem}");
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            string strSQL = "update customers  set 姓名=@NewName,電話=@NewPhoneNum,地址=@NewAddress,Email=@NewEmail," +
                "生日=@NewBirth,婚姻狀態=@NewMarried,點數=@NewPoint,密碼=@NewPassword,權限=@NewPermissions," +
                "使用狀態=@NewProcessingStatus where customerID=@SearchID;";
            SqlCommand cmd=new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@SearchID",txtID.Text);
            cmd.Parameters.AddWithValue("@NewName", txt姓名.Text);
            cmd.Parameters.AddWithValue("NewPhoneNum",txt電話.Text);
            cmd.Parameters.AddWithValue("@NewAddress",txt地址.Text);
            cmd.Parameters.AddWithValue("@NewEmail",txtEmail.Text);
            cmd.Parameters.AddWithValue("@NewBirth", dtp生日.Value);
            cmd.Parameters.AddWithValue("@NewMarried",chk婚姻狀態.Checked );
            cmd.Parameters.AddWithValue("@NewPoint",txt點數.Text);
            cmd.Parameters.AddWithValue("@NewPassword",txt密碼.Text);
            cmd.Parameters.AddWithValue("@NewPermissions",txt權限.Text);
            cmd.Parameters.AddWithValue("@NewProcessingStatus", cbox狀態欄位.SelectedItem);

            int rows =cmd.ExecuteNonQuery();
            con.Close();
            //?
            MessageBox.Show("修改完成");

            //long歷史訂單 = reader["Ordernumbers"].ToString();
            //if (long歷史訂單 != null)
            //{
            //    list歷史訂單.Add(long歷史訂單);
            //    list訂單狀況.Add(reader["ProcessingStatus"].ToString());
            //    list訂購書籍.Add(reader["BookName"].ToString());
            //    //list訂購數量.Add((int)reader["Amount"]);
            //    //list訂購金額.Add((int)reader["price"]);
            //}
        }

        private void listView歷史訂單_ItemActivate(object sender, EventArgs e)
        {
            FormModifyOrder myformModifyOrder = new FormModifyOrder();
            string str訂單編號=listView歷史訂單.SelectedItems[0].Tag.ToString();
            long.TryParse(str訂單編號, out long longNum);
            myformModifyOrder.orderNumbers = longNum;
            myformModifyOrder.ShowDialog();
            讀取會員詳細資訊();
            顯示訂單詳情();
        }

        private void btn刪除_Click(object sender, EventArgs e)
        {
            DialogResult R = MessageBox.Show("確定刪除此會員?", "會員刪除再次確認", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
           if(R == DialogResult.Yes)
            {
                SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                con.Open();
                string strSQL = $"DELETE shoppingCart FROM shoppingCart " +
                    $"JOIN customers ON customers.customerID = shoppingCart.customerId " +
                    $"WHERE customers.customerID = @SearchID; " +
                    $"DELETE orders FROM orders " +
                    $"JOIN customers ON customers.customerID = orders.customerId " +
                    $"WHERE customers.customerID = @SearchID; " +
                    $"delete from customers where customerID=@SearchID;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchID", PersonID);
                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("會員已刪除");
                this.Close();
            }
           
        }
    }
}
