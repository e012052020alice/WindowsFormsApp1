using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using WindowsFormsApp1;
using Sunny.UI;

namespace Sunny.UI.Demo
{
    public partial class FEdit : UIEditForm
    {
        public int shoppingCartId = 0;
        int int書本單價 = 0;
        public FEdit()
        {
            InitializeComponent();
        }

        //protected override bool CheckData()
        //{
        //    return CheckEmpty(edtName, "请输入姓名")
        //           && CheckEmpty(edtAmount, "请输入年龄")
        //           && CheckRange(edtAmount, 18, 60, "输入年龄范围18~60");
        //           //&& CheckEmpty(cbDepartment, "请选择部门")
        //           //&& CheckEmpty(edtDate, "请选择生日");
        //}

        private void FEdit_Load(object sender, System.EventArgs e)
        {
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();          
            string strSQL = $"select * from shoppingCart join  productBook on productBook.BookID=shoppingCart.BookID " +
                $"where shoppingCart.shoppingCartID = @SearchID ;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@SearchID", shoppingCartId);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                edtName.Text = (string)reader["BookName"];
                edtAmount.Text = reader["bookAmount"].ToString();
                edtPrice.Text= reader["price"].ToString();
                int書本單價 = (int)reader["BookPrice"];
            }
            reader.Close();
            con.Close();
        }

        private void edtName_TextChanged(object sender, System.EventArgs e)
        {
            AutoResizeTextBox(edtName);
        }

        private void AutoResizeTextBox(Sunny.UI.UITextBox textBox)
        {
            // 測量TextBox的文字行數
            int lineCount = textBox.GetLineFromCharIndex(textBox.TextLength) + 1;

            // 設置TextBox的高度
            int lineHeight = TextRenderer.MeasureText("Sample", textBox.Font).Height; // 取得單行文字高度
            int newHeight = lineHeight * lineCount + textBox.Margin.Vertical;

            textBox.Height = newHeight;
        }

        private void edtAmount_TextChanged(object sender, System.EventArgs e)
        {
            Int32.TryParse(edtAmount.Text, out int intAmount);
            edtPrice.Text = (intAmount * int書本單價).ToString();
        }

        private void btnadd1_Click(object sender, EventArgs e)
        {
            
            Int32.TryParse(edtAmount.Text, out int intAmount);
            
            intAmount++;
            edtAmount.Text = intAmount.ToString();
        }

        private void btnminus1_Click(object sender, EventArgs e)
        {
            Int32.TryParse(edtAmount.Text, out int intAmount);
            if (intAmount > 0)
            {
                intAmount--;
                edtAmount.Text = intAmount.ToString();
            }                          
        }

        private void btn刪除_Click(object sender, EventArgs e)
        {           
            DialogResult R= MessageBox.Show("確定要刪除此商品?", "刪除確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question); ;
            if (R == DialogResult.Yes){
                SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                con.Open();
                string strSQL = $"delete  from shoppingCart  where shoppingCartID=@DeleteID ;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@DeleteID ", shoppingCartId);
                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("商品已刪除");
                this.Close();
            }
            
        }

        private void btn确定_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(edtAmount.Text, out int intAmount))
            {
                SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                con.Open();
                if (intAmount > 0)
                {
                    string strSQL = $"update shoppingCart set bookAmount=@NewAmount,price=@NewPrice where shoppingCartID= @SearchID ;";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@SearchID", shoppingCartId);
                    cmd.Parameters.AddWithValue("@NewAmount", intAmount);
                    cmd.Parameters.AddWithValue("@NewPrice", intAmount * int書本單價);
                    int rows = cmd.ExecuteNonQuery();

                    //strSQL = $"select * from shoppingCart join  productBook on productBook.BookID=shoppingCart.BookID " +
                    //$"where shoppingCart.shoppingCartID = @SearchID ;";
                    //cmd = new SqlCommand(strSQL, con);
                    //cmd.Parameters.AddWithValue("@SearchID", shoppingCartId);
                    //SqlDataReader reader = cmd.ExecuteReader();
                    //if (reader.Read())
                    //{
                    //    edtName.Text = (string)reader["BookName"];
                    //    edtAmount.Text = reader["bookAmount"].ToString();
                    //    edtPrice.Text = reader["price"].ToString();
                    //}
                    //reader.Close();

                }
                else
                {
                    string strSQL = $"delete  from shoppingCart  where shoppingCartID=@DeleteID ;";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@DeleteID ", shoppingCartId);
                    int rows = cmd.ExecuteNonQuery();
                }
                con.Close();
                this.Close();
            }
            else
            {
                MessageBox.Show("書籍數量為數字，請重新確認更改的數量！！");
            }
        }


        private void btn取消_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //private Person person;

        //public Person Person
        //{
        //    get
        //    {
        //        if (person == null)
        //        {
        //            person = new Person();
        //        }

        //        person.Name = edtName.Text;
        //        person.Age = edtAge.IntValue;
        //        person.Birthday = edtDate.Value;
        //        person.Address = edtAddress.Text;
        //        if (rbMale.Checked)
        //            person.Sex = Sex.Male;
        //        if (rbFemale.Checked)
        //            person.Sex = Sex.Female;
        //        person.Department = cbDepartment.Text;
        //        return person;
        //    }

        //    set
        //    {
        //        person = value;
        //        edtName.Text = value.Name;
        //        edtAge.IntValue = value.Age;
        //        edtDate.Value = value.Birthday;
        //        edtAddress.Text = value.Address;
        //        cbDepartment.SelectedIndex = cbDepartment.Items.IndexOf(value.Department);
        //        rbMale.Checked = value.Sex == Sex.Male;
        //        rbFemale.Checked = value.Sex == Sex.Female;
        //    }
        //}
    }
}