using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Registration
{
    public partial class Grade_List_Form : Form
    {
        string connectionString = "Data Source=DESKTOP-S3E7KHQ\\SQLEXPRESS;Initial Catalog= StudentRegistration;Trusted_Connection=True";
        string id;
        DataTable dt;
        DataView dv = new DataView();

        public Grade_List_Form()
        {
            InitializeComponent();
            refresh();
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
                SqlCommand cmd = new SqlCommand($"insert into grades (grade_name,grade_group,grade_order,created_at) values('{grade_name}','{grade_group}','{grade_order}','{DateTime.Now}')", con);
                //SqlCommand cmd = new SqlCommand($"insert into students (admission_no,first_name,last_name,full_name,gender,date_of_birth,stu_nic_no,tp_no,grade_id,medium,date_of_admission,resident_address) values('{txtStudentAdmissionNo.Text }','{ txtStudentFirstName.Text}','{txtStudentLastname.Text}','{txtStudentFullName.Text}','{gender}','{dtStudentDateOfBirth.Text}','{txtStudentStuNicNo.Text}','{txtStudentPhoneNo.Text}','{comStudentGradeId.Text}','{txtStudentMedium.Text}','{dtStudentDateOfAdmission.Text}','{txtStudentAddress.Text}')", con);


                cmd.ExecuteNonQuery();
                MessageBox.Show("Save successfully");
                refresh();
                cmd.Dispose();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:  " + ex.Message);
                throw;

            }
            

        }

        private void btnGradeEdit_Click(object sender, EventArgs e)
        {
            
            string gradeName = txtGradeName.Text;
            string gradeGroup = txtGradeGroup.Text;
            string gradeOrder = txtGradeOrder.Text;
            

            try
            {
                //connectionString = conString;
                SqlConnection con = new SqlConnection(connectionString);

                con.Open();

                string sql = $"UPDATE grades SET grade_name='{gradeName}',grade_group='{gradeGroup}',grade_order='{gradeOrder}' where id='{this.id}'";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                MessageBox.Show("Update Successfully!.");
                refresh();
                reset();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:  " + ex.Message);
                throw;
            }
        }

        private void refresh()
        {
            //connectionString = conString;
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd;
            string sql = "SELECT id,grade_name, grade_group, grade_order, created_at  FROM grades;";

            try
            {
                dt = new DataTable();
                con.Open();
                cmd = new SqlCommand(sql, con);
                SqlDataReader reader = cmd.ExecuteReader();

                dt.Load(reader);
                dv = dt.DefaultView;
                dgvGrade.DataSource = dv;

                reset();

                reader.Close();
                cmd.Dispose();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error    " + ex.Message);
            }
        }

        private void dgvGrade_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvGrade.SelectedRows.Count > 0)
            {
                this.id = dgvGrade.CurrentRow.Cells["id"].Value.ToString();
                string gradeName = dgvGrade.CurrentRow.Cells["grade_name"].Value.ToString();
                string gradeGroup = dgvGrade.CurrentRow.Cells["grade_group"].Value.ToString();
                string gradeOrder = dgvGrade.CurrentRow.Cells["grade_order"].Value.ToString();
                
                txtGradeName.Text = gradeName;
                txtGradeGroup.Text = gradeGroup;
                txtGradeOrder.Text = gradeOrder;
                
            }
        }

        private void btnGradeDelete_Click(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd;
            string sql = $"DELETE FROM grades  where id='{id}' ";

            try
            {
                con.Open();
                cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Delete successfully!");
                refresh();
                reset();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error    " + ex.Message);
            }
        }

        void reset()
        {
            txtGradeName.Text = "";
            txtGradeGroup.Text = "";
            txtGradeOrder.Text = "";
        }
    }
}
