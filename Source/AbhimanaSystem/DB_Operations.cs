using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbhimanaSystem
{
    class DB_Operations
    {

        /*--------------------------------------------------------
                           LOGIN USER QUERY SECTION
        --------------------------------------------------------*/

        //SELECT USER
        public SqlDataReader selectUser(string uName)
        {
            string selectQuery = "SELECT userName FROM tbl_user WHERE userName='" + uName + "'";
            SqlCommand cmd = new SqlCommand(selectQuery, ConnectionDB.connection());
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }
        //LOGIN USERNAME AND PASSWORD
        public SqlDataReader loginUser(string uName, string pass)
        {
            string selectQuery = "SELECT * FROM tbl_user WHERE userName='" + uName + "' AND password='" + pass + "'";
            SqlCommand cmd = new SqlCommand(selectQuery, ConnectionDB.connection());
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

         //ADD USER
        public void addUser(string un, string pass)
        {
            string insertQuery = @"INSERT INTO tbl_user VALUES ('" + un + "','" + pass + "')";
            SqlCommand cmd = new SqlCommand(insertQuery, ConnectionDB.connection());
            cmd.ExecuteNonQuery();
        }

        //CHANGE LOGIN PASSWORD
        public void ChangePassword(string user,string pass)
        {
            SqlCommand cmd = new SqlCommand("UPDATE tbl_user SET password='" + pass + "' WHERE userName='" + user + "'", ConnectionDB.connection());
            cmd.ExecuteNonQuery();
        }


        /*--------------------------------------------------------
                        NEW CHILD QUERY SECTION
        --------------------------------------------------------*/

        string child_no;
        public string getChildNo()
        {
            string MaxChildNo = "SELECT MAX(child_no) FROM tbl_cbrdata";
            SqlCommand com = new SqlCommand(MaxChildNo, ConnectionDB.connection());
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read() == true)
            {
                child_no = dr[0].ToString();
            }
            return child_no;
        }

        //ADD NEW CHILD
        public void NewChildRegister
            (
                int _chilNo,
                string _childName,
                int _age,
                string _gender,
                string _address,
                string _gnDivision,
                string _motherName,
                string _motherEdu,
                string _fatherName,
                string _fatherEdu,
                decimal _income,
                string _childInEdu,
                int _contactNo,
                string _disabilities,
                DateTime _birthday,
                string _rehabilitationAct, 
                string _house,
                string _sanitationFacilities,
                string _donationGOV,
                string _donation_NGO
            )
        {
            SqlCommand cmd = new SqlCommand(@"INSERT INTO tbl_cbrdata VALUES('" + _chilNo + "','" + _childName + "','" + _age + "','" + _gender + "','" + _address + "','" + _gnDivision + "','" + _motherName + "','" + _motherEdu + "','" + _fatherName + "','" + _fatherEdu + "','" + _income + "','" + _childInEdu + "','" + _contactNo + "','" + _disabilities + "','" + _birthday + "','" + _rehabilitationAct + "','" + _house + "','" + _sanitationFacilities + "','" + _donationGOV + "','" + _donation_NGO + "')", ConnectionDB.connection());
            cmd.ExecuteNonQuery();
        }

        public void UpdateChild
                        (
                int _childNo,
                string _childName,
                int _age,
                string _gender,
                string _address,
                string _gnDivision,
                string _motherName,
                string _motherEdu,
                string _fatherName,
                string _fatherEdu,
                decimal _income,
                string _childInEdu,
                int _contactNo,
                string _disabilities,
                DateTime _birthday,
                string _rehabilitationAct,
                string _house,
                string _sanitationFacilities,
                string _donationGOV,
                string _donation_NGO
            )
        {
            SqlCommand cmd = new SqlCommand("UPDATE tbl_cbrdata SET child_name='" + _childName + "', age='" + _age + "', gender='" + _gender + "', address='" + _address + "', gn_division='" + _gnDivision + "', mother_name='" + _motherName + "', mother_edu='" + _motherEdu + "', father_name='" + _fatherName + "', father_edu='" + _fatherEdu + "', income='" + _income + "', child_in_edu='" + _childInEdu + "', contact_no='" + _contactNo + "', disabilities='" + _disabilities + "' , birthday='" + _birthday + "' , rehabilitation_act='" + _rehabilitationAct + "' , house='" + _house + "' , sanitation_facilities='" + _sanitationFacilities + "' , donation_gov='" + _donationGOV + "' , donation_ngo='" + _donation_NGO + "' WHERE child_no='" + _childNo + "'", ConnectionDB.connection());
            cmd.ExecuteNonQuery();
        }
    }
}
