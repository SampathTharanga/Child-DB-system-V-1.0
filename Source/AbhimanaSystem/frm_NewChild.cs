using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbhimanaSystem
{
    public partial class frm_NewChild : MetroForm
    {
        DB_Operations ObjDB = new DB_Operations();
        public frm_NewChild()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void clearMethod()
        {
            txtChildName.Clear();
            dtpBirthDay.Value = DateTime.Now;
            lblAge.Text = "";
            cbxGender.Text = "";
            txtAddress.Clear();
            txtGN_Division.Clear();
            txtMotherName.Clear();
            txtMotherEdu.Clear();
            txtFatherName.Clear();
            txtFatherEdu.Clear();
            txtIncome.Clear();
            txtChildEdu.Clear();
            txtContactNo.Clear();
            txtDisabilities.Clear();
            txtRehabilitation.Clear();
            cbxHouse.Text = "";
            txtSanitationFacilities.Clear();
            txtDonationGOV.Clear();
            txtDonationNGO.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearMethod();
        }

        private static int CalculateAge(DateTime dateOfBirth)
        {
            int age = 0;
            age = DateTime.Now.Year - dateOfBirth.Year;
            if (DateTime.Now.DayOfYear < dateOfBirth.DayOfYear)
                age = age - 1;

            return age;
        }
        decimal defaultValDeci = 0.00M, income = 0.0M;
        int defaultValInt = 0, contactNo = 0, age = 0;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (decimal.TryParse(txtIncome.Text, out defaultValDeci) && int.TryParse(txtContactNo.Text, out defaultValInt) && int.TryParse(lblAge.Text, out defaultValInt) && int.TryParse(lblAge.Text, out defaultValInt))
                {
                    income = Convert.ToDecimal(txtIncome.Text);
                    contactNo = int.Parse(txtContactNo.Text);
                    age = int.Parse(lblAge.Text);
                }


                if (txtChildName.Text != "" && txtAddress.Text != "" && lblAge.Text != "")
                {
                    ObjDB.NewChildRegister
                        (
                            int.Parse(lblChildNo.Text),
                            txtChildName.Text,
                            age,
                            cbxGender.Text,
                            txtAddress.Text,
                            txtGN_Division.Text,
                            txtMotherName.Text,
                            txtMotherEdu.Text,
                            txtFatherName.Text,
                            txtFatherEdu.Text,
                            income,
                            txtChildEdu.Text,
                            contactNo,
                            txtDisabilities.Text,
                            dtpBirthDay.Value.Date,
                            txtRehabilitation.Text,
                            cbxHouse.Text,
                            txtSanitationFacilities.Text,
                            txtDonationGOV.Text,
                            txtDonationNGO.Text
                        );
                    MessageBox.Show("Register successfully.", "SUCCESSFULLY", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearMethod();
                    this.Close();
                }
                else
                    MessageBox.Show("Please enter child details. Atleast Name, Birthday and Address.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

}

        private void frm_NewChild_Load(object sender, EventArgs e)
        {
            //CHILD NUMBER LOAD
            string ChildNo = ObjDB.getChildNo();
            if (ChildNo.Equals("") || ChildNo == null)
                lblChildNo.Text = "1";
            else
                lblChildNo.Text = (int.Parse(ChildNo) + 1).ToString();
        }

        private void dtpBirthDay_ValueChanged(object sender, EventArgs e)
        {
            //AGE DISPLAY LABEL
            lblAge.Text = CalculateAge(dtpBirthDay.Value).ToString();
        }
    }
}
