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
    public partial class frmChangePass : MetroForm
    {
        public frmChangePass()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNewPass.Clear();
            txtReEnterPass.Clear();
        }
        DB_Operations ObjDB_Op = new DB_Operations();
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNewPass.Text != "" && txtReEnterPass.Text != "")
                {
                    if (txtNewPass.Text == txtReEnterPass.Text)
                    {
                        ObjDB_Op.ChangePassword("Abhimana", txtNewPass.Text);
                        MessageBox.Show("Update successfully.", "SUCCESSFULLY", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Application.Restart();
                    }
                    else
                    {
                        MessageBox.Show("Please enter same password!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtNewPass.Clear();
                        txtReEnterPass.Clear();
                    }
                }
                else
                    MessageBox.Show("Please enter password!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }


        }
    }
}
