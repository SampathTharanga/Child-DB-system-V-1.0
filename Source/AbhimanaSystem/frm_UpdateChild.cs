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
    public partial class frm_UpdateChild : MetroForm
    {
        DB_Operations ObjDB_Op = new DB_Operations();
        ChildUpdateClass chilData;
        public frm_UpdateChild(ChildUpdateClass chc)
        {
            InitializeComponent();
            chilData = chc;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearMethod();
        }

        private void txtCancel_Click(object sender, EventArgs e)
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

        decimal defaultValDeci = 0.00M, income = 0.0M;
        int defaultValInt = 0, contactNo = 0, age = 0;
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (decimal.TryParse(txtIncome.Text, out defaultValDeci) && int.TryParse(txtContactNo.Text, out defaultValInt) && int.TryParse(lblAge.Text, out defaultValInt) && int.TryParse(lblAge.Text, out defaultValInt))
                {
                    income = Convert.ToDecimal(txtIncome.Text);
                    contactNo = int.Parse(txtContactNo.Text);
                    age = int.Parse(lblAge.Text);
                }
                ObjDB_Op.UpdateChild
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
                MessageBox.Show("Update successfully.", "SUCCESSFULLY", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }
        private static int CalculateAge(DateTime dateOfBirth)
        {
            int age = 0;
            age = DateTime.Now.Year - dateOfBirth.Year;
            if (DateTime.Now.DayOfYear < dateOfBirth.DayOfYear)
                age = age - 1;

            return age;
        }

        private void dtpBirthDay_ValueChanged(object sender, EventArgs e)
        {
            //AGE DISPLAY LABEL
            lblAge.Text = CalculateAge(dtpBirthDay.Value).ToString();
        }

        private void frm_UpdateChild_Load(object sender, EventArgs e)
        {
            try
            {
                lblChildNo.Text = chilData._childNo.ToString();
                txtChildName.Text = chilData._childName;
                lblAge.Text = chilData._age.ToString();
                cbxGender.Text = chilData._gender;
                txtAddress.Text = chilData._address;
                txtGN_Division.Text = chilData._gnDivision;
                txtMotherName.Text = chilData._motherName;
                txtMotherEdu.Text = chilData._motherEdu;
                txtFatherName.Text = chilData._fatherName;
                txtFatherEdu.Text = chilData._fatherEdu;
                txtIncome.Text = chilData._income.ToString();
                txtChildEdu.Text = chilData.childInEdu;
                txtContactNo.Text = chilData._contactNo.ToString();
                txtDisabilities.Text = chilData.disabilities;
                dtpBirthDay.Value = Convert.ToDateTime(chilData._birthday);
                txtRehabilitation.Text = chilData._rehabilitationAct;
                cbxHouse.Text = chilData._house;
                txtSanitationFacilities.Text = chilData._sanitationFacilities;
                txtDonationGOV.Text = chilData._donationGOV;
                txtDonationNGO.Text = chilData._donation_NGO;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }
    }
}
