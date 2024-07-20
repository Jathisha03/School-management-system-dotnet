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
using static System.Net.WebRequestMethods;

namespace Student_Registration
{
    public partial class Student_List : Form
    {
        string connectionString = "Data Source=DESKTOP-S3E7KHQ\\SQLEXPRESS;Initial Catalog= StudentRegistration;Trusted_Connection=True";
        string id;
        DataTable dt;
        DataView dv = new DataView();

        public Student_List()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string gender = null;
            if (rbtnStudentMale.Checked == true)
            {
                gender = "Male";
            }
            else if (rbtnStudentFemale.Checked == true)
            {
                gender = "Female";
            }
            string admission_no = txtStudentAdmissionNo.Text;
            string first_name = txtStudentFirstName.Text;
            string last_name = txtStudentLastname.Text;
            string full_name = txtStudentFullName.Text; 
            //string date_of_birth = dtStudentDateOfBirth.Value.ToString("YYYY-MM-DD");
            string date_of_birth = dtStudentDateOfBirth.Text;
            string student_nic_no = txtStudentStuNicNo.Text;
            string tp_no = txtStudentPhoneNo.Text;
            string grade_id = comStudentGradeId.Text;
            string medium = txtStudentMedium.Text;
            //string date_of_admission = dtStudentDateOfAdmission.Value.ToString("YYYY-MM-DD");
            string date_of_admission = dtStudentDateOfAdmission.Text;
            string resident_address = txtStudentAddress.Text;

            try
            {
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand($"insert into students (admission_no,first_name,last_name,full_name,gender,date_of_birth,stu_nic_no,tp_no,grade_id,medium,date_of_admission,resident_address) values('{admission_no}','{first_name}','{last_name}','{full_name}','{gender}','{date_of_birth}','{student_nic_no}','{tp_no}','{grade_id}','{medium}','{date_of_admission}','{resident_address}')", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Save successfully");

                cmd.Dispose();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:  " +ex.Message);
                throw;

            }
        }

        private void btnStudentEdit_Click(object sender, EventArgs e)
        {

            string gender = null;
            if (rbtnStudentMale.Checked == true)
            {
                gender = "Male";
            }
            else if (rbtnStudentFemale.Checked == true)
            {
                gender = "Female";
            }
            string admission_no = txtStudentAdmissionNo.Text;
            string first_name = txtStudentFirstName.Text;
            string last_name = txtStudentLastname.Text;
            string full_name = txtStudentFullName.Text;
            //string date_of_birth = dtStudentDateOfBirth.Value.ToString("YYYY-MM-DD");
            string date_of_birth = dtStudentDateOfBirth.Text;
            string student_nic_no = txtStudentStuNicNo.Text;
            string tp_no = txtStudentPhoneNo.Text;
            string grade_id = comStudentGradeId.Text;
            string medium = txtStudentMedium.Text;
            //string date_of_admission = dtStudentDateOfAdmission.Value.ToString("YYYY-MM-DD");
            string date_of_admission = dtStudentDateOfAdmission.Text;
            string resident_address = txtStudentAddress.Text;

            try
            {
                SqlConnection con = new SqlConnection(connectionString);

                con.Open();

                string sql = $"UPDATE grades SET admission_no='{admission_no}',first_name='{first_name}',last_name='{last_name}',full_name='{full_name}',gender='{gender}',date_of_birth='{date_of_birth}',student_nic_no='{student_nic_no}',tp_no='{tp_no}',grade_id='{grade_id}',medium='{medium}',date_of_admission='{date_of_admission}',resident_address='{resident_address}' where id='{this.id}'";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                MessageBox.Show("Update Successfully!.");
                //refresh();
                //reset();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:  " + ex.Message);
                throw;
            }
        }
    }
}
