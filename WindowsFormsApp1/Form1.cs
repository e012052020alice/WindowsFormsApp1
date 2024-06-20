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
using Sunny.UI;
namespace WindowsFormsApp1
{
    public partial class Form1 : UIForm
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @".";
            scsb.InitialCatalog = "mydb";
            scsb.IntegratedSecurity = true;
            GlobalVar.strDBConnectionString = scsb.ConnectionString;
        }

        private void btn書籍訂購單_Click(object sender, EventArgs e)
        {
            FormBooksOrders myFrom1= new FormBooksOrders();
            myFrom1.ShowDialog();
        }

        private void btn商品管理_Click(object sender, EventArgs e)
        {
            Form2ProductManagement myProductManagement=new Form2ProductManagement();
            myProductManagement.ShowDialog();
        }

        private void btn訂單管理_Click(object sender, EventArgs e)
        {
            FormOrderManagement myformOrderManagement=new FormOrderManagement();
            myformOrderManagement.ShowDialog();
        }

        private void btn會員資料管理_Click(object sender, EventArgs e)
        {
            FormMemberInformationManagement myFormMemberInformationManagement=new FormMemberInformationManagement();
            myFormMemberInformationManagement.ShowDialog();
        }
    }
}
