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
    public partial class FormRegisteredMember : Form
    {
        public int int權限 = 1000;
        public FormRegisteredMember()
        {
            InitializeComponent();
        }

        private void FormRegisteredMember_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult R = MessageBox.Show("確認資料輸入無誤?", "資料確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (R == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                con.Open();
                string strSQL = "insert into customers values" +
                    "(@NewName,@NewPhoneNum,@NewAddress,@NewEmail,@NewPassword,@NewBirth" +
                    ",@NewMarried,@NewPoint,@NewPermissions ,@NewStatus);";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@NewName", txt姓名.Text);
                cmd.Parameters.AddWithValue("@NewPhoneNum", txt電話.Text);
                cmd.Parameters.AddWithValue("@NewAddress", txt地址.Text);
                cmd.Parameters.AddWithValue("@NewEmail", txtEmail.Text);
                cmd.Parameters.AddWithValue("@NewPassword", txt密碼.Text);
                cmd.Parameters.AddWithValue("@NewBirth", dtp生日.Value);
                cmd.Parameters.AddWithValue("@NewMarried", chk婚姻狀態.Checked);
                cmd.Parameters.AddWithValue("@NewPoint", 0);
                cmd.Parameters.AddWithValue("@NewPermissions", int權限);
                cmd.Parameters.AddWithValue("@NewStatus", "審核");
                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("註冊成功");
                this.Close();
            }
            

        }
    }
}
