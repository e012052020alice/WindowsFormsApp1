using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormStart : Form
    {
        private Form activeForm = null;
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        public FormStart()
        {
            InitializeComponent();
        }

        private void FormStart_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @".";
            scsb.InitialCatalog = "mydb";
            scsb.IntegratedSecurity = true;
            GlobalVar.strDBConnectionString = scsb.ConnectionString;

            //for (int i = 00; i < 60; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //string dateString = "2024/2/14 0:00:00";
            //DateTime date = DateTime.ParseExact(dateString, "yyyy/M/d H:mm:ss", CultureInfo.InvariantCulture);
            //Console.WriteLine(date.ToString());
            is系統維護時間();
        }
        void is系統維護時間()
        {
            SqlConnection con=new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            string strSQL = " select *from  systemMaintance;";
            DateTime date開始時間= DateTime.Now;
            DateTime date結束時間 = DateTime.Now;
            SqlCommand cmd=new SqlCommand(strSQL, con);
            SqlDataReader reader=cmd.ExecuteReader();
            while (reader.Read())
            {
                date開始時間 = (DateTime)reader["startTime"];
                date結束時間 = (DateTime)reader["endTime"];
            }
            reader.Close();
            con.Close();
            if((DateTime.Now>date開始時間)&&(DateTime.Now < date結束時間))
            {
                lbl系統維護.Visible = true;
                btn登入.Visible= false;
                btn註冊.Visible = false;
                txtEmail.Visible = false;
                txt密碼.Visible = false;
                label2.Visible = false;
                label9.Visible = false;
                lbl系統維護.Text = "系統維護中~";
            }
        }

        void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill; panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        void showInitialForm()
        {
            if (activeForm != null) activeForm.Close();
            txtEmail.Clear();
            txt密碼.Clear();
            //// 關閉當前的活動表單
            //if (activeForm != null) activeForm.Close();

            //// 顯示初始畫面（這裡假設 FormStart 是你的初始畫面）
            //FormStart initialForm = new FormStart();
            //initialForm.TopLevel = false;
            //initialForm.FormBorderStyle = FormBorderStyle.None;
            //initialForm.Dock = DockStyle.Fill;
            //panelChildForm.Controls.Add(initialForm);
            //panelChildForm.Tag = initialForm;
            //initialForm.BringToFront();
            //initialForm.Show();
            lbl姓名.Visible= false;
            lbl權限.Visible = false;
            btn登出.Visible = false;
            btn書籍訂購單.Visible = false;
            btn商品管理.Visible = false;
            btn會員資料管理.Visible = false;
            btn訂單管理.Visible = false;
            btn系統管理.Visible = false;

        }
        private void btn書籍訂購單_Click(object sender, EventArgs e)
        {
            openChildForm(new FormBooksOrders());
        }

        private void btn會員資料管理_Click(object sender, EventArgs e)
        {
            openChildForm(new FormMemberInformationManagement());
        }

        private void btn商品管理_Click(object sender, EventArgs e)
        {
            openChildForm(new Form2ProductManagement());
        }

        private void btn訂單管理_Click(object sender, EventArgs e)
        {
            openChildForm(new FormOrderManagement());
        }

        private void btn系統管理_Click(object sender, EventArgs e)
        {
            openChildForm(new FormEmployeeManagement());
        }

        private void btn註冊_Click(object sender, EventArgs e)
        {
            FormRegisteredMember myformRegisteredMember=new FormRegisteredMember();
            myformRegisteredMember.ShowDialog();
        }

        private void btn登入_Click(object sender, EventArgs e)
        {           
            if ((txtEmail.Text != "") && (txt密碼.Text != ""))
            {
                SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                con.Open();
                string strSQL = "select * from customers where Email=@SearcEmail and 密碼=@SearchPassword;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearcEmail", txtEmail.Text);
                cmd.Parameters.AddWithValue("@SearchPassword", txt密碼.Text);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())//修改?
                {
                    GlobalVar.is登入成功 = true;
                    GlobalVar.使用者名稱 = reader["姓名"].ToString();
                    GlobalVar.使用者id = (int)reader["customerID"];
                    GlobalVar.使用者權限 = (int)reader["權限"];
                    GlobalVar.使用者使用狀態 = reader["使用狀態"].ToString();                   
                    MessageBox.Show($"登入成功!!，歡迎使用本系統~");
                    reader.Close();
                    con.Close();
                    openChildForm(new FormBooksOrders());
                    lbl姓名.Text = GlobalVar.使用者名稱;
                    if (GlobalVar.使用者權限 >= 1000)
                    {
                        lbl權限.Text = "一般會員";
                    }
                    else if(GlobalVar.使用者權限<1000&& GlobalVar.使用者權限 >= 100)
                    {
                        lbl權限.Text = "店員";
                        btn商品管理.Visible = true;
                        btn會員資料管理.Visible = true;
                        btn訂單管理.Visible = true;
                        btn系統管理.Visible = true;
                    }
                    else if (GlobalVar.使用者權限 < 100 && GlobalVar.使用者權限 >= 10)
                    {
                        lbl權限.Text = "店長";
                        btn商品管理.Visible = true;
                        btn會員資料管理.Visible = true;
                        btn訂單管理.Visible = true;
                        btn系統管理.Visible = true;
                    }
                    else if ((GlobalVar.使用者權限 >= 1) && (GlobalVar.使用者權限 < 10))
                    {
                        lbl權限.Text = "系統管理員";
                        btn商品管理.Visible = true;
                        btn會員資料管理.Visible = true;
                        btn訂單管理.Visible = true;
                        btn系統管理.Visible = true;
                    }

                    lbl姓名.Visible= true;
                    lbl權限.Visible = true;
                    btn登出 .Visible = true;
                    btn書籍訂購單.Visible = true;
                    //btn商品管理.Visible = true;
                    //btn會員資料管理.Visible = true;
                    //btn訂單管理.Visible = true;
                    //btn系統管理.Visible = true;
                    //this.Close();
                }
                if (GlobalVar.is登入成功 == false)
                {
                    MessageBox.Show("登入資料有誤，登入失敗");
                    //lbl回應訊息.Text = "登入資料有誤，登入失敗";
                }
                reader.Close();
                con.Close();
            }
            else
            {
                MessageBox.Show("登入資料有誤，登入失敗");
            }
        }

        private void btn登出_Click(object sender, EventArgs e)
        {
            showInitialForm();
        }
    }
}
