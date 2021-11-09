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
    public partial class Connect : Form
    {
        public Connect()
        {
            InitializeComponent();
        }

        private void ServerConnectBtn_Click(object sender, EventArgs e)
        {

            string connString = @"Data Source=" + txtServerName.Text.Trim() +
                ";Initial Catalog=" + txtDBName.Text.Trim() + ";Integrated Security=True";
            SqlConnection sqlCon = null;

            try
            {
                if (sqlCon == null)
                {
                    DataContainer.sqlCon = new SqlConnection(connString);
                    sqlCon = DataContainer.sqlCon;
                }

                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                    MessageBox.Show("Kết nối thành công");

                    this.Hide();
                    Menu menu = new Menu();
                    menu.ShowDialog();
                    this.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
    public static class DataContainer
    {
        public static SqlConnection sqlCon = null;
    }
}
