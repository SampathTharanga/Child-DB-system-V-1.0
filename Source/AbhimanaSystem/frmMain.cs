using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Windows.Forms;
using System.Configuration;


namespace AbhimanaSystem
{
    public partial class frmMain : MetroForm
    {
        bool LoadBtnCheck;
        DataTable DT;
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadBtnCheck = false;

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tbl_cbrdata", ConnectionDB.connection());
            DataTable dt2 = new DataTable();
            da.Fill(dt2);
            BindingSource bnsue = new BindingSource();
            bnsue.DataSource = dt2;
            dgvDataList.DataSource = bnsue;
            da.Update(dt2);
            ConnectionDB.connection().Close();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            metroContextMenu1.Show(btnMenu, 0, btnMenu.Height);
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                LoadBtnCheck = false;

                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tbl_cbrdata", ConnectionDB.connection());
                DataTable dt2 = new DataTable();
                da.Fill(dt2);
                BindingSource bnsue = new BindingSource();
                bnsue.DataSource = dt2;
                dgvDataList.DataSource = bnsue;
                da.Update(dt2);
                ConnectionDB.connection().Close();


                txtChildEdu.Clear();
                txtDisabilities.Clear();
                //DateTime_Birthday.Value = DateTime.Now;
                cbx_House.Text = null;
                txtRehabilitation.Clear();
                txtSanitation.Clear();
                txtDonation_Gov.Clear();
                txtDonation_NGO.Clear();


                foreach (int i in checkedListBox1.CheckedIndices)
                {
                    checkedListBox1.SetItemCheckState(i, CheckState.Unchecked);
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void txtChildEdu_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (LoadBtnCheck == true)
                {
                    if (txtChildEdu.Text != "")
                    {
                        string query = string.Empty;
                        foreach (string s in checkedListBox1.CheckedItems)
                            query += s + ",";
                        query = query.Remove(query.Length - 1, 1);
                        string sql = string.Format("SELECT {0} FROM tbl_cbrdata", query);
                        if (ConnectionDB.connection().State == ConnectionState.Closed)
                            ConnectionDB.connection().Open();
                        SqlCommand cmd = new SqlCommand(sql, ConnectionDB.connection()) { CommandType = CommandType.Text };
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        dgvDataList.DataSource = dt;

                        DataView dv = new DataView(dt);
                        dv.RowFilter = "child_in_edu LIKE '%" + txtChildEdu.Text + "%'";
                        dgvDataList.DataSource = dv;
                        ConnectionDB.connection().Close();//Close DB Connection
                    }
                    else
                    {
                        checkedDataLoad();
                    }
                }
                else
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tbl_cbrdata", ConnectionDB.connection());
                    DT = new DataTable();
                    da.Fill(DT);
                    BindingSource bnsue = new BindingSource();
                    bnsue.DataSource = DT;
                    dgvDataList.DataSource = bnsue;
                    da.Update(DT);

                    DataView dv = new DataView(DT);
                    dv.RowFilter = "child_in_edu LIKE '%" + txtChildEdu.Text + "%'";
                    dgvDataList.DataSource = dv;
                    ConnectionDB.connection().Close();//Close DB Connection
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Thlis column is not selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtChildEdu.Clear();
            }

        }

        private void txtDisabilities_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (LoadBtnCheck == true)
                {
                    if (txtDisabilities.Text != "")
                    {
                        string query = string.Empty;
                        foreach (string s in checkedListBox1.CheckedItems)
                            query += s + ",";
                        query = query.Remove(query.Length - 1, 1);
                        string sql = string.Format("SELECT {0} FROM tbl_cbrdata", query);
                        if (ConnectionDB.connection().State == ConnectionState.Closed)
                            ConnectionDB.connection().Open();
                        SqlCommand cmd = new SqlCommand(sql, ConnectionDB.connection()) { CommandType = CommandType.Text };
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        dgvDataList.DataSource = dt;

                        DataView dv = new DataView(dt);
                        dv.RowFilter = "disabilities LIKE '%" + txtDisabilities.Text + "%'";
                        dgvDataList.DataSource = dv;
                        ConnectionDB.connection().Close();//Close DB Connection
                    }

                    else
                    {
                        checkedDataLoad();
                    }
                }
                else
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tbl_cbrdata", ConnectionDB.connection());
                    DT = new DataTable();
                    da.Fill(DT);
                    BindingSource bnsue = new BindingSource();
                    bnsue.DataSource = DT;
                    dgvDataList.DataSource = bnsue;
                    da.Update(DT);

                    DataView dv = new DataView(DT);
                    dv.RowFilter = "disabilities LIKE '%" + txtDisabilities.Text + "%'";
                    dgvDataList.DataSource = dv;
                    ConnectionDB.connection().Close();//Close DB Connection
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thlis column is not selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDisabilities.Clear();
            }

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmChangePass frmCP = new frmChangePass();
            frmCP.ShowDialog();
        }

        private void btnUpdateChild_Click(object sender, EventArgs e)
        {
            try
            {
                ChildUpdateClass UpChil = new ChildUpdateClass();
                UpChil._childNo = dgvDataList.CurrentRow.Cells[0].Value.ToString();
                UpChil._childName = dgvDataList.CurrentRow.Cells[1].Value.ToString();
                UpChil._age = dgvDataList.CurrentRow.Cells[2].Value.ToString();
                UpChil._gender = dgvDataList.CurrentRow.Cells[3].Value.ToString();
                UpChil._address = dgvDataList.CurrentRow.Cells[4].Value.ToString();
                UpChil._gnDivision = dgvDataList.CurrentRow.Cells[5].Value.ToString();
                UpChil._motherName = dgvDataList.CurrentRow.Cells[6].Value.ToString();
                UpChil._motherEdu = dgvDataList.CurrentRow.Cells[7].Value.ToString();
                UpChil._fatherName = dgvDataList.CurrentRow.Cells[8].Value.ToString();
                UpChil._fatherEdu = dgvDataList.CurrentRow.Cells[9].Value.ToString();
                UpChil._income = dgvDataList.CurrentRow.Cells[10].Value.ToString();
                UpChil.childInEdu = dgvDataList.CurrentRow.Cells[11].Value.ToString();
                UpChil._contactNo = dgvDataList.CurrentRow.Cells[12].Value.ToString();
                UpChil.disabilities = dgvDataList.CurrentRow.Cells[13].Value.ToString();
                UpChil._birthday = dgvDataList.CurrentRow.Cells[14].Value.ToString();
                UpChil._rehabilitationAct = dgvDataList.CurrentRow.Cells[15].Value.ToString();
                UpChil._house = dgvDataList.CurrentRow.Cells[16].Value.ToString();
                UpChil._sanitationFacilities = dgvDataList.CurrentRow.Cells[17].Value.ToString();
                UpChil._donationGOV = dgvDataList.CurrentRow.Cells[18].Value.ToString();
                UpChil._donation_NGO = dgvDataList.CurrentRow.Cells[19].Value.ToString();

                frm_UpdateChild frmUC = new frm_UpdateChild(UpChil);
                frmUC.ShowDialog();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnNewChild_Click(object sender, EventArgs e)
        {
            frm_NewChild frmNC = new frm_NewChild();
            frmNC.Show();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void txtRehabilitation_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (LoadBtnCheck == true)
                {
                    if (txtRehabilitation.Text != "")
                    {
                        string query = string.Empty;
                        foreach (string s in checkedListBox1.CheckedItems)
                            query += s + ",";
                        query = query.Remove(query.Length - 1, 1);
                        string sql = string.Format("SELECT {0} FROM tbl_cbrdata", query);
                        if (ConnectionDB.connection().State == ConnectionState.Closed)
                            ConnectionDB.connection().Open();
                        SqlCommand cmd = new SqlCommand(sql, ConnectionDB.connection()) { CommandType = CommandType.Text };
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        dgvDataList.DataSource = dt;

                        DataView dv = new DataView(dt);
                        dv.RowFilter = "rehabilitation_act LIKE '%" + txtRehabilitation.Text + "%'";
                        dgvDataList.DataSource = dv;
                        ConnectionDB.connection().Close();//Close DB Connection
                    }
                    else
                    {
                        checkedDataLoad();
                    }
                }
                else
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tbl_cbrdata", ConnectionDB.connection());
                    DT = new DataTable();
                    da.Fill(DT);
                    BindingSource bnsue = new BindingSource();
                    bnsue.DataSource = DT;
                    dgvDataList.DataSource = bnsue;
                    da.Update(DT);

                    DataView dv = new DataView(DT);
                    dv.RowFilter = "rehabilitation_act LIKE '%" + txtRehabilitation.Text + "%'";
                    dgvDataList.DataSource = dv;
                    ConnectionDB.connection().Close();//Close DB Connection
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thlis column is not selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRehabilitation.Clear();
            }
        }

        private void txtSanitation_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (LoadBtnCheck == true)
                {
                    if (txtSanitation.Text != "")
                    {
                        string query = string.Empty;
                        foreach (string s in checkedListBox1.CheckedItems)
                            query += s + ",";
                        query = query.Remove(query.Length - 1, 1);
                        string sql = string.Format("SELECT {0} FROM tbl_cbrdata", query);
                        if (ConnectionDB.connection().State == ConnectionState.Closed)
                            ConnectionDB.connection().Open();
                        SqlCommand cmd = new SqlCommand(sql, ConnectionDB.connection()) { CommandType = CommandType.Text };
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        dgvDataList.DataSource = dt;

                        DataView dv = new DataView(dt);
                        dv.RowFilter = "sanitation_facilities LIKE '%" + txtSanitation.Text + "%'";
                        dgvDataList.DataSource = dv;
                        ConnectionDB.connection().Close();//Close DB Connection
                    }
                    else
                    {
                        checkedDataLoad();
                    }
                }
                else
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tbl_cbrdata", ConnectionDB.connection());
                    DT = new DataTable();
                    da.Fill(DT);
                    BindingSource bnsue = new BindingSource();
                    bnsue.DataSource = DT;
                    dgvDataList.DataSource = bnsue;
                    da.Update(DT);

                    DataView dv = new DataView(DT);
                    dv.RowFilter = "sanitation_facilities LIKE '%" + txtSanitation.Text + "%'";
                    dgvDataList.DataSource = dv;
                    ConnectionDB.connection().Close();//Close DB Connection
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thlis column is not selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSanitation.Clear();
            }

        }

        private void txtDonation_Gov_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (LoadBtnCheck == true)
                {
                    if (txtDonation_Gov.Text != "")
                    {
                        string query = string.Empty;
                        foreach (string s in checkedListBox1.CheckedItems)
                            query += s + ",";
                        query = query.Remove(query.Length - 1, 1);
                        string sql = string.Format("SELECT {0} FROM tbl_cbrdata", query);
                        if (ConnectionDB.connection().State == ConnectionState.Closed)
                            ConnectionDB.connection().Open();
                        SqlCommand cmd = new SqlCommand(sql, ConnectionDB.connection()) { CommandType = CommandType.Text };
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        dgvDataList.DataSource = dt;

                        DataView dv = new DataView(dt);
                        dv.RowFilter = "donation_gov LIKE '%" + txtDonation_Gov.Text + "%'";
                        dgvDataList.DataSource = dv;
                        ConnectionDB.connection().Close();//Close DB Connection
                    }
                    else
                    {
                        checkedDataLoad();
                    }
                }
                else
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tbl_cbrdata", ConnectionDB.connection());
                    DT = new DataTable();
                    da.Fill(DT);
                    BindingSource bnsue = new BindingSource();
                    bnsue.DataSource = DT;
                    dgvDataList.DataSource = bnsue;
                    da.Update(DT);

                    DataView dv = new DataView(DT);
                    dv.RowFilter = "donation_gov LIKE '%" + txtDonation_Gov.Text + "%'";
                    dgvDataList.DataSource = dv;
                    ConnectionDB.connection().Close();//Close DB Connection
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Thlis column is not selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDonation_Gov.Clear();
            }

        }

        private void txtDonation_NGO_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (LoadBtnCheck == true)
                {
                    if (txtDonation_NGO.Text != "")
                    {
                        string query = string.Empty;
                        foreach (string s in checkedListBox1.CheckedItems)
                            query += s + ",";
                        query = query.Remove(query.Length - 1, 1);
                        string sql = string.Format("SELECT {0} FROM tbl_cbrdata", query);
                        if (ConnectionDB.connection().State == ConnectionState.Closed)
                            ConnectionDB.connection().Open();
                        SqlCommand cmd = new SqlCommand(sql, ConnectionDB.connection()) { CommandType = CommandType.Text };
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        dgvDataList.DataSource = dt;

                        DataView dv = new DataView(dt);
                        dv.RowFilter = "donation_ngo LIKE '%" + txtDonation_NGO.Text + "%'";
                        dgvDataList.DataSource = dv;
                        ConnectionDB.connection().Close();//Close DB Connection
                    }
                    else
                    {
                        checkedDataLoad();
                    }
                }
                else
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tbl_cbrdata", ConnectionDB.connection());
                    DT = new DataTable();
                    da.Fill(DT);
                    BindingSource bnsue = new BindingSource();
                    bnsue.DataSource = DT;
                    dgvDataList.DataSource = bnsue;
                    da.Update(DT);

                    DataView dv = new DataView(DT);
                    dv.RowFilter = "donation_ngo LIKE '%" + txtDonation_NGO.Text + "%'";
                    dgvDataList.DataSource = dv;
                    ConnectionDB.connection().Close();//Close DB Connection
                }
            }
            catch (Exception ex) {
                MessageBox.Show("This column is not selected!.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDonation_NGO.Clear();
            }

        }

        private void DateTime_Birthday_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (LoadBtnCheck == true)
                {
                    string query = string.Empty;
                    foreach (string s in checkedListBox1.CheckedItems)
                        query += s + ",";
                    query = query.Remove(query.Length - 1, 1);
                    string sql = string.Format("SELECT {0} FROM tbl_cbrdata", query);
                    if (ConnectionDB.connection().State == ConnectionState.Closed)
                        ConnectionDB.connection().Open();
                    SqlCommand cmd = new SqlCommand(sql, ConnectionDB.connection()) { CommandType = CommandType.Text };
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dgvDataList.DataSource = dt;

                    DataView dv = new DataView(dt);
                    dv.RowFilter = "Convert([birthday],System.String) LIKE '%" + DateTime_Birthday.Value.Date + "%'";
                    dgvDataList.DataSource = dv;
                    ConnectionDB.connection().Close();//Close DB Connection
                }
                else
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tbl_cbrdata", ConnectionDB.connection());
                    DT = new DataTable();
                    da.Fill(DT);
                    BindingSource bnsue = new BindingSource();
                    bnsue.DataSource = DT;
                    dgvDataList.DataSource = bnsue;
                    da.Update(DT);

                    DataView dv = new DataView(DT);
                    dv.RowFilter = "Convert([birthday],System.String) LIKE '%" + DateTime_Birthday.Value.Date + "%'";
                    dgvDataList.DataSource = dv;
                    ConnectionDB.connection().Close();//Close DB Connection
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thlis column is not selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cbx_House_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (LoadBtnCheck == true)
                {
                    if (cbx_House.Text != "")
                    {
                        string query = string.Empty;
                        foreach (string s in checkedListBox1.CheckedItems)
                            query += s + ",";
                        query = query.Remove(query.Length - 1, 1);
                        string sql = string.Format("SELECT {0} FROM tbl_cbrdata", query);
                        if (ConnectionDB.connection().State == ConnectionState.Closed)
                            ConnectionDB.connection().Open();
                        SqlCommand cmd = new SqlCommand(sql, ConnectionDB.connection()) { CommandType = CommandType.Text };
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        dgvDataList.DataSource = dt;

                        DataView dv = new DataView(dt);
                        dv.RowFilter = "house LIKE '" + cbx_House.Text + "'";
                        dgvDataList.DataSource = dv;
                        ConnectionDB.connection().Close();//Close DB Connection
                    }
                    else
                    {
                        checkedDataLoad();
                    }
                }
                else
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tbl_cbrdata", ConnectionDB.connection());
                    DT = new DataTable();
                    da.Fill(DT);
                    BindingSource bnsue = new BindingSource();
                    bnsue.DataSource = DT;
                    dgvDataList.DataSource = bnsue;
                    da.Update(DT);

                    DataView dv = new DataView(DT);
                    dv.RowFilter = "house LIKE '%" + cbx_House.Text + "%'";
                    dgvDataList.DataSource = dv;
                    ConnectionDB.connection().Close();//Close DB Connection
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thlis column is not selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbx_House.Text = null;
            }

        }


        public void checkedDataLoad()
        {
            try
            {
                string query = string.Empty;
                foreach (string s in checkedListBox1.CheckedItems)
                    query += s + ",";
                query = query.Remove(query.Length - 1, 1);
                string sql = string.Format("SELECT {0} FROM tbl_cbrdata", query);
                if (ConnectionDB.connection().State == ConnectionState.Closed)
                    ConnectionDB.connection().Open();
                SqlCommand cmd = new SqlCommand(sql, ConnectionDB.connection()) { CommandType = CommandType.Text };
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                using (DataTable dt = new DataTable("tbl_cbrdata"))
                {
                    sda.Fill(dt);
                    dgvDataList.DataSource = dt;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            checkedDataLoad();
            LoadBtnCheck = true;
        }

        private void btnExport_Click_1(object sender, EventArgs e)
        {
            try
            {
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                worksheet = workbook.Sheets["Sheet1"];
                worksheet = workbook.ActiveSheet;
                worksheet.Name = "Child Details";

                for (int i = 1; i < dgvDataList.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = dgvDataList.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < dgvDataList.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvDataList.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dgvDataList.Rows[i].Cells[j].Value.ToString();
                    }
                }

                var saveFileDialoge = new SaveFileDialog();
                //saveFileDialoge.FileName = "output";
                saveFileDialoge.FileName = "Abhimana Report(" + "" + DateTime.Now.ToString("dd-MM-yyyy") + ")";
                saveFileDialoge.DefaultExt = ".xlsx";
                if (saveFileDialoge.ShowDialog() == DialogResult.OK)
                {
                    workbook.SaveAs(saveFileDialoge.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                }
                app.Quit();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
