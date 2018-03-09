using MetroFramework.Forms;
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

namespace AbhimanaSystem
{
    public partial class frmLogin : MetroForm
    {
        //OBJECTS OF THE CLASS FAILES
        DB_Operations Obj_opera = new DB_Operations();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPassword.Text != "" || txtPassword.Text != null)
                {
                    SqlDataReader dr = Obj_opera.loginUser("Abhimana",txtPassword.Text);
                    if (dr.Read() == true)
                    {
                        this.Hide();
                        frmMain frmM = new frmMain();
                        frmM.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Please enter correct password!.", "Login error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtPassword.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Please enter password!.", "Wrong password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Clear();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            /*
             * Automatically create "Abhimana" user account.
             * UserName : Abhimana
             * Password : Abhimana
             */

            try
            {
                SqlDataReader dr = Obj_opera.selectUser("Abhimana");
                if (dr.Read() != true)
                {
                    Obj_opera.addUser("Abhimana", "Abhimana");
                    MessageBox.Show("Default user registration completed!.\nDefault password is \"Abhimana\".", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
