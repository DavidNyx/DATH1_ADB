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

namespace DBSM_Project
{
    
    public partial class Menu : Form
    {
        SqlConnection sqlCon = DataContainer.sqlCon;
        public Menu()
        {
            InitializeComponent();
        }

        private void InsertBill_Click(object sender, EventArgs e)
        {
            this.Hide();
            InsertBill ib = new InsertBill();
            ib.ShowDialog();
            this.Close();
        }

        private void ShowBill_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShowBill sb = new ShowBill();
            sb.ShowDialog();
            this.Close();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Connect conn = new Connect();
            conn.ShowDialog();
            this.Close();
        }

        private void ViewRevenue_Click(object sender, EventArgs e)
        {
            this.Hide();
            MonthlyRevenue conn = new MonthlyRevenue();
            conn.ShowDialog();
            this.Close();
        }
    }
}
