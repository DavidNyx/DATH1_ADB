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
    public partial class MonthlyRevenue : Form
    {
        SqlConnection sqlCon = DataContainer.sqlCon;
        SqlDataAdapter adapter = null;
        DataSet ds = null;

        public MonthlyRevenue()
        {
            InitializeComponent();
            ShowRevenueList();
        }

        private void ShowRevenueList()
        {
            string year = YearList.SelectedItem.ToString();

            string query = "SELECT MONTH(NGAYLAP) AS THANG, SUM(TONGTIEN) AS TONGTIEN FROM HOADON WHERE YEAR(NGAYLAP) = " + year + " GROUP BY MONTH(NGAYLAP)";
            adapter = new SqlDataAdapter(query, sqlCon);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            ds = new DataSet();

            adapter.Fill(ds, "tblHoaDon");
            RevenueList.DataSource = ds.Tables["tblHoaDon"];
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.ShowDialog();
            this.Close();
        }

        private void YearList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowRevenueList();
        }
    }
}
