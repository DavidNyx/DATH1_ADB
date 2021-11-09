using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace DBSM_Project
{
    public partial class InsertBill : Form
    {
        SqlConnection sqlCon = DataContainer.sqlCon;
        SqlDataAdapter adapter = null;
        DataSet ds = null;
        
        public InsertBill()
        {
            InitializeComponent();
        }

        /*private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlCon == null)
                {
                    sqlCon = new SqlConnection(connString);
                }

                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                    MessageBox.Show("Kết nối thành công");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (sqlCon != null && sqlCon.State == ConnectionState.Open)
            {
                sqlCon.Close();
                MessageBox.Show("Đóng kết nối thành công");
            }
            else
            {
                MessageBox.Show("Không đóng kết nối được");
            }
        }*/

        private void InsertData_Click(object sender, EventArgs e)
        {
            
            try
            {
                string query = "SELECT * FROM HOADON";
                adapter = new SqlDataAdapter(query, sqlCon);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                ds = new DataSet();
                adapter.Fill(ds, "tblHoaDon");

                DataRow row = ds.Tables["tblHoaDon"].NewRow();

                row["MAHD"] = txtMAHD.Text.Trim();
                row["MAKH"] = txtMAKH.Text.Trim();
                row["NGAYLAP"] = txtNGAYLAP.Text.Trim();
                row["TONGTIEN"] = txtTONGTIEN.Text.Trim();

                ds.Tables["tblHoaDon"].Rows.Add(row);
                int res = adapter.Update(ds.Tables["tblHoaDon"]);

                if (res > 0)
                {
                    MessageBox.Show("Thêm dữ liệu thành công!");
                    txtMAHD.Clear();
                    txtMAKH.Clear();
                    txtNGAYLAP.Clear();
                    txtTONGTIEN.Clear();
                }
                else
                {
                    MessageBox.Show("Thêm dữ liệu thất bại. Xin vui lòng thử lại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtMAHD_Enter(object sender, EventArgs e)
        {
            if (txtMAHD.Text == "Mã hóa đơn")
            {
                txtMAHD.Text = "";
                txtMAHD.ForeColor = Color.Black;
            }
        }

        private void txtMAHD_Leave(object sender, EventArgs e)
        {
            if (txtMAHD.Text == "")
            {
                txtMAHD.Text = "Mã hóa đơn";
                txtMAHD.ForeColor = Color.Silver;
            }
        }

        private void txtMAKH_Enter(object sender, EventArgs e)
        {
            if (txtMAKH.Text == "Mã khách hàng")
            {
                txtMAKH.Text = "";
                txtMAKH.ForeColor = Color.Black;
            }
        }

        private void txtMAKH_Leave(object sender, EventArgs e)
        {
            if (txtMAKH.Text == "")
            {
                txtMAKH.Text = "Mã khách hàng";
                txtMAKH.ForeColor = Color.Silver;
            }
        }

        private void txtNGAYLAP_Enter(object sender, EventArgs e)
        {
            if (txtNGAYLAP.Text == "dd-mm-yy (vd: 20-5-21)")
            {
                txtNGAYLAP.Text = "";
                txtNGAYLAP.ForeColor = Color.Black;
            }
        }

        private void txtNGAYLAP_Leave(object sender, EventArgs e)
        {
            if (txtNGAYLAP.Text == "")
            {
                txtNGAYLAP.Text = "dd-mm-yy (vd: 20-5-21)";
                txtNGAYLAP.ForeColor = Color.Silver;
            }
        }

        private void txtTONGTIEN_Enter(object sender, EventArgs e)
        {
            if (txtTONGTIEN.Text == "Tổng tiền (số)")
            {
                txtTONGTIEN.Text = "";
                txtTONGTIEN.ForeColor = Color.Black;
            }
        }

        private void txtTONGTIEN_Leave(object sender, EventArgs e)
        {
            if (txtTONGTIEN.Text == "")
            {
                txtTONGTIEN.Text = "Tổng tiền (số)";
                txtTONGTIEN.ForeColor = Color.Silver;
            }
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
