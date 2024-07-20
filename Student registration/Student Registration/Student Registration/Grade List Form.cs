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

namespace Student_Registration
{
    public partial class Grade_List_Form : Form
    {
        string connectionString = "Data Source=DESKTOP-S3E7KHQ\\SQLEXPRESS;Initial Catalog= StudentRegistration;Trusted_Connection=True";

        public Grade_List_Form()
        {
            InitializeComponent();
        }

        private void btnGradeSave_Click(object sender, EventArgs e)
        {
            string grade_name = txtGradeName.Text;
            string grade_group = txtGradeGroup.Text;
            string grade_order = txtGradeOrder.Text;
            
            try
            {
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand($"insert into grades (grade_name,grade_group,grade_order) values('{grade_name}','{grade_group}','{grade_order}')", con);
                //SqlCommand cmd = new SqlCommand($"insert into students (admission_no,first_name,last_name,full_name,gender,date_of_birth,stu_nic_no,tp_no,grade_id,medium,date_of_admission,resident_address) values('{txtStudentAdmissionNo.Text }','{ txtStudentFirstName.Text}','{txtStudentLastname.Text}','{txtStudentFullName.Text}','{gender}','{dtStudentDateOfBirth.Text}','{txtStudentStuNicNo.Text}','{txtStudentPhoneNo.Text}','{comStudentGradeId.Text}','{txtStudentMedium.Text}','{dtStudentDateOfAdmission.Text}','{txtStudentAddress.Text}')", con);


                cmd.ExecuteNonQuery();
                MessageBox.Show("Save successfully");

                cmd.Dispose();
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
