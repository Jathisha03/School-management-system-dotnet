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
    public partial class Student_List : Form
    {
        string connectionString = "Data Source=DESKTOP-S3E7KHQ\\SQLEXPRESS;Initial Catalog= StudentRegistration;Trusted_Connection=True";

        public Student_List()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    SqlConnection con = new SqlConnection(connectionString);
            //    ConnectionState state = con.State;
            //    if (state != ConnectionState.Open)
            //    {
            //        con.Open();

            //    }
            //    SqlCommand cmd = new SqlCommand("insert into students(admission_no,first_name,last_name,full_name,gender,date_of_birth,stu_nic_no,tp_no,grade_id,medium,date_of_addmission,resident_address) values('" + txtBookName.Text + "','" + txtPrice.Text + "','" + txtStock.Text + "','" + txtColour.Text + "')", con);
            //    cmd.ExecuteNonQuery();
            //    cmd.Dispose();
            //    con.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message.ToString());
            //    throw;

            //}
        }
    }
}
