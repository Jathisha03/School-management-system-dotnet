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
            //string full_name = first_name + last_name;
            //txtStudentFullName.Text = full_name;
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
                //SqlCommand cmd = new SqlCommand($"insert into students (admission_no,first_name,last_name,full_name,gender,date_of_birth,stu_nic_no,tp_no,grade_id,medium,date_of_admission,resident_address) values('{txtStudentAdmissionNo.Text }','{ txtStudentFirstName.Text}','{txtStudentLastname.Text}','{txtStudentFullName.Text}','{gender}','{dtStudentDateOfBirth.Text}','{txtStudentStuNicNo.Text}','{txtStudentPhoneNo.Text}','{comStudentGradeId.Text}','{txtStudentMedium.Text}','{dtStudentDateOfAdmission.Text}','{txtStudentAddress.Text}')", con);



                //   string sql = "INSERT INTO [students] (admission_no, first_name, last_name, full_name, gender, date_of_birth, student_nic_no, tp_no, grade_id, medium, date_of_admission, resident_address) " +
                //"VALUES (@admission_no, @first_name, @last_name, @full_name, @gender, @date_of_birth, @student_nic_no, @tp_no, @grade_id, @medium, @date_of_admission, @resident_address)";
                //   SqlCommand cmd = new SqlCommand(sql, con);
                //   cmd.Parameters.AddWithValue("@admission_no", txtStudentAdmissionNo.Text);
                //   cmd.Parameters.AddWithValue("@first_name", txtStudentFirstName.Text);
                //   cmd.Parameters.AddWithValue("@last_name", txtStudentLastname.Text);
                //   cmd.Parameters.AddWithValue("@full_name", txtStudentFullName.Text);
                //   cmd.Parameters.AddWithValue("@gender", gender);
                //   cmd.Parameters.AddWithValue("@date_of_birth", dtStudentDateOfBirth.Value.ToString("yyyy-MM-dd"));
                //   cmd.Parameters.AddWithValue("@student_nic_no", txtStudentStuNicNo.Text);
                //   cmd.Parameters.AddWithValue("@tp_no", txtStudentPhoneNo.Text);
                //   cmd.Parameters.AddWithValue("@grade_id", comStudentGradeId.Text);
                //   cmd.Parameters.AddWithValue("@medium", txtStudentMedium.Text);
                //   cmd.Parameters.AddWithValue("@date_of_admission", dtStudentDateOfAdmission.Value.ToString("yyyy-MM-dd"));
                //   cmd.Parameters.AddWithValue("@resident_address", txtStudentAddress.Text);


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
    }
}
