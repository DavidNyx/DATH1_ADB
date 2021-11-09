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

namespace DBSM_Project
{
    public partial class ShowBill : Form
    {
        SqlConnection sqlCon = DataContainer.sqlCon;
        SqlDataAdapter adapter = null;
        DataSet ds = null;
        public ShowBill()
        {
            InitializeComponent();
        }
        private void ShowBill_Load(object sender, EventArgs e)
        {
            ShowBillList();
        }

        private void ShowBillList()
        {
            string query = "SELECT * FROM HOADON";
            adapter = new SqlDataAdapter(query, sqlCon);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            ds = new DataSet();

            adapter.Fill(ds, "tblHoaDon");
            BillList.DataSource = ds.Tables["tblHoaDon"];
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.ShowDialog();
            this.Close();
        }

    }
}
