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
    public partial class FormEmployeeManagement : Form
    {
        List<int> list員工ID = new List<int>();
        List<string> list員工姓名 = new List<string>();
        List<DateTime> list打卡時間 = new List<DateTime>();
        List<string> list上下班 = new List<string>();

        public FormEmployeeManagement()
        {
            InitializeComponent();
        }

        private void FormEmployeeManagement_Load(object sender, EventArgs e)
        {
            //// 創建一個新的 DateTimePicker 控件
            //DateTimePicker dateTimePicker1 = new DateTimePicker();

            // 設置 DateTimePicker 控件的顯示格式為日期和時間
            //dateTimePicker開始時間.Format = DateTimePickerFormat.Custom;
            ////dateTimePicker開始時間.CustomFormat = "yyyy/M/d tt hh:mm";// 可以根據需要調整日期時間格式
            //dateTimePicker開始時間.CustomFormat = "yyyy/M/d";
            //Console.WriteLine(dateTimePicker開始時間.Value.ToString());
            //Console.WriteLine(dateTimePicker開始時間.Text);
            dtp開始時間.Text=dtp開始時間.Value.ToString();
            cbox設定();
            txt時間設定();
            讀取資料();
            顯示資料();
            is系統管理員();
        }
        void is系統管理員()
        {
            if((GlobalVar.使用者權限 >= 1) && (GlobalVar.使用者權限 < 10))
            {
                cbox開始小時.Visible = true;
                cbox開始分.Visible = true;
                cbox結束小時.Visible = true;
                cbox結束分.Visible = true;
                dtp開始時間.Visible = true;
                dtp結束時間.Visible = true;
                txt開始時間.Visible = true;
                txt結束時間.Visible = true;
                btn時間設定.Visible = true;
            }
            
        }
        void cbox設定()
        {
            cbox欄位名稱.Items.Add("上下班");
            cbox欄位名稱.Items.Add("上班");
            cbox欄位名稱.Items.Add("下班");
            cbox欄位名稱.SelectedIndex = 0;

            cbox打卡欄位.Items.Add("上班");
            cbox打卡欄位.Items.Add("下班");
            cbox打卡欄位.SelectedIndex = 0;

            for(int i = 0; i < 24; i++)
{
                cbox開始小時.Items.Add(i.ToString());
            }
            for (int i = 0; i < 24; i++)
            {
                cbox結束小時.Items.Add(i.ToString());
            }
            for(int i = 00; i < 60; i++)
            {
                if (i < 10){
                    cbox開始分.Items.Add($"0{i.ToString()}");
                }
                cbox開始分.Items.Add(i.ToString());
            }
            for (int i = 00; i < 60; i++)
            {
                if (i < 10)
                {
                    cbox結束分.Items.Add($"0{i.ToString()}");
                }
                cbox結束分.Items.Add(i.ToString());
            }
            cbox開始小時.SelectedIndex = 0;
            cbox結束小時.SelectedIndex = 0;
            cbox開始分.SelectedIndex = 0;
            cbox結束分.SelectedIndex = 0;

        }
        void txt時間設定()
        {
            txt開始時間.Text=$"{dtp開始時間.Text} {cbox開始小時.SelectedItem}:{cbox開始分.SelectedItem}:00";
            txt結束時間.Text = $"{dtp結束時間.Text} {cbox結束小時.SelectedItem}:{cbox結束分.SelectedItem}:00";           

        }
        void 讀取資料()
        {
            清除list();
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            string strSQL = "select * from attendance " +
                "join customers on attendance.EmployeeID=customers.customerID " +
                "order by attendance.PunchTime;";
            SqlCommand cmd = new SqlCommand(strSQL, con);

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list員工ID.Add((int)reader["customerID"]);
                list員工姓名.Add(reader["姓名"].ToString());
                list打卡時間.Add((DateTime)reader["PunchTime"]);
                list上下班.Add(reader["PunchType"].ToString());
            }
            reader.Close();
            con.Close();
        }
        void 顯示資料()
        {
            listView打卡紀錄.View = View.Details;
            listView打卡紀錄.Columns.Add("員工ID",100);
            listView打卡紀錄.Columns.Add("員工姓名", 100);
            listView打卡紀錄.Columns.Add("打卡時間", 200);
            listView打卡紀錄.Columns.Add("類型");
            listView打卡紀錄.GridLines = true;
            listView打卡紀錄.FullRowSelect = true;
            for (int i = 0; i < list員工ID.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                item.Text = list員工ID[i].ToString();
                item.SubItems.Add(list員工姓名[i].ToString());
                item.SubItems.Add(list打卡時間[i].ToString());
                item.SubItems.Add(list上下班[i].ToString());
                item.Font = new Font("微軟正黑體", 12, FontStyle.Regular);
                item.Tag = list員工ID[i];
                listView打卡紀錄.Items.Add(item);
            }


        }
        void 清除list()
        {
            listView打卡紀錄.Clear();
            list員工ID.Clear();
            list員工姓名.Clear();
            list打卡時間.Clear();
            list上下班.Clear();
        }

        private void btn搜尋_Click(object sender, EventArgs e)
        {
            清除list();
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            string strSQL = "";
            SqlCommand cmd = new SqlCommand(strSQL, con);

            Int32.TryParse(txt搜尋關鍵字.Text, out int intID);

            if (cbox欄位名稱.SelectedIndex == 0)
            {
                if (intID == 0)
                {
                    strSQL = "select * from attendance " +
                "join customers on attendance.EmployeeID=customers.customerID " +
                "where(PunchTime>=@StartTime and PunchTime<=@EndTime) " +
                "order by attendance.PunchTime;";
                }
                else
                {
                    strSQL = "select * from attendance " +
                "join customers on attendance.EmployeeID=customers.customerID " +
                "where(PunchTime>=@StartTime and PunchTime<=@EndTime) and attendance.EmployeeID=@SearchID " +
                "order by attendance.PunchTime;";
                }
                cmd = new SqlCommand(strSQL, con);
                //cmd.Parameters.AddWithValue("@StartTime", dtp搜尋開始時間.Value);
                //cmd.Parameters.AddWithValue("@EndTime", dtp搜尋結束時間.Value);
                if (intID > 0)
                {
                    cmd.Parameters.AddWithValue("@SearchID", intID);
                }


            }
            else if (cbox欄位名稱.SelectedIndex == 1 || cbox欄位名稱.SelectedIndex == 2)
            {
                if (intID == 0)
                {
                    strSQL = "select * from attendance " +
                "join customers on attendance.EmployeeID=customers.customerID " +
                "where(PunchTime>=@StartTime and PunchTime<=@EndTime) and attendance.PunchType=@SearchStatus " +
                "order by attendance.PunchTime;";

                }
                else
                {
                    strSQL = "select * from attendance " +
              "join customers on attendance.EmployeeID=customers.customerID " +
              "where(PunchTime>=@StartTime and PunchTime<=@EndTime) and attendance.PunchType=@SearchStatus " +
              "and attendance.EmployeeID=@SearchID " +
              "order by attendance.PunchTime;";

                }

                cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchStatus", cbox欄位名稱.SelectedItem);
                if (intID > 0)
                {
                    cmd.Parameters.AddWithValue("@SearchID", intID);
                }
            }
            
            cmd.Parameters.AddWithValue("@StartTime", dtp搜尋開始時間.Value);
            cmd.Parameters.AddWithValue("@EndTime", dtp搜尋結束時間.Value);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list員工ID.Add((int)reader["customerID"]);
                list員工姓名.Add(reader["姓名"].ToString());
                list打卡時間.Add((DateTime)reader["PunchTime"]);
                list上下班.Add(reader["PunchType"].ToString());
            }
            reader.Close();
            con.Close();
            顯示資料();
        }

        private void btn回到全部_Click(object sender, EventArgs e)
        {
            txt搜尋關鍵字.Clear();
            cbox欄位名稱.SelectedIndex = 0;
            讀取資料();
            顯示資料();
        }

        private void btn建立帳號_Click(object sender, EventArgs e)
        {
            FormRegisteredMember myformRegisteredMember = new FormRegisteredMember();
            myformRegisteredMember.int權限 = 100;
            myformRegisteredMember.ShowDialog();
        }

        private void btn打卡_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            string strSQL = "INSERT INTO Attendance VALUES(@NewID, @NewTime, @NewType);";
            SqlCommand cmd= new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@NewID",GlobalVar.使用者id);
            //cmd.Parameters.AddWithValue("@NewTime", "2023-01-01 09:05:00");
            cmd.Parameters.AddWithValue("@NewTime", DateTime.Now);
            cmd.Parameters.AddWithValue("@NewType", cbox打卡欄位.SelectedItem);

            int rows = cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("打卡成功");
            讀取資料();
            顯示資料();
        }

        private void dateTimePicker開始時間_ValueChanged(object sender, EventArgs e)
        {
            txt時間設定();
        }

        private void dateTimePicker結束時間_ValueChanged(object sender, EventArgs e)
        {
            txt時間設定();
        }

        private void cbox開始小時_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt時間設定();
        }

        private void cbox結束小時_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt時間設定();
        }

        private void cbox開始分_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt時間設定();
        }

        private void cbox結束分_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt時間設定();
        }

        private void btn時間設定_Click(object sender, EventArgs e)
        {
            string dateString開始 = txt開始時間.Text;
            DateTime date開始 = DateTime.ParseExact(dateString開始, "yyyy/M/d H:mm:ss", CultureInfo.InvariantCulture);
            string dateString結束 = txt結束時間.Text;
            DateTime date結束 = DateTime.ParseExact(dateString結束, "yyyy/M/d H:mm:ss", CultureInfo.InvariantCulture);
            //string dateString = "2024/2/14 00:00:00";
            //DateTime date = DateTime.ParseExact(dateString, "yyyy/M/d H:mm:ss", CultureInfo.InvariantCulture);
            //Console.WriteLine(date.ToString());
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            string strSQL = "insert systemMaintance values(@NewStartTime,@NewEndTime);";
            SqlCommand cmd= new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@NewStartTime", date開始);
            cmd.Parameters.AddWithValue("@NewEndTime", date結束);
            int rows=cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("系統維護時間設定成功!!");

        }
    }
}
