using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace _243557_Windows_From_App___Data_Base__
{
    public partial class Form1 : Form
    {
        // Connection string as specified, using assumed database name "StudentDB"
        private const string ConnectionString =
            "Data Source=DESKTOP-K2S8IVF\\SQLEXPRESS;Initial Catalog=StudentDB;Integrated Security=True;Encrypt=False;Trust Server Certificate=True";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadStudentData();
        }

        #region Task 3: View All Students (SELECT Operation)

        private void LoadStudentData()
        {
            string selectQuery = "SELECT * FROM Students ORDER BY RegId DESC";

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter(selectQuery, conn);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "StudentsTable");
                    dgStudents.DataSource = ds.Tables["StudentsTable"];
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Database Error during load: {ex.Message}\nCheck if the 'StudentDB' database exists.", "SQL Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRefreshView_Click(object sender, EventArgs e)
        {
            LoadStudentData();
        }

        #endregion

        #region Task 2: Add New Student (CREATE Operation)

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSName.Text) || cmbGender.SelectedIndex == -1 || cmbDegreeProgram.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill Name, Gender, and Degree Program fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string insertQuery = @"
                INSERT INTO Students (Name, FatherName, CNIC, Gender, DOB, Address, DegreeProgram, MatricGrade, InterGrade)
                VALUES (@Name, @FatherName, @CNIC, @Gender, @DOB, @Address, @DegreeProgram, @MatricGrade, @InterGrade)";

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(insertQuery, conn);

                    cmd.Parameters.AddWithValue("@Name", txtSName.Text);
                    cmd.Parameters.AddWithValue("@FatherName", txtFatherName.Text);
                    cmd.Parameters.AddWithValue("@CNIC", txtCNIC.Text);
                    cmd.Parameters.AddWithValue("@Gender", cmbGender.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@DOB", dtpDOB.Value.Date);
                    cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@DegreeProgram", cmbDegreeProgram.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@MatricGrade", float.TryParse(txtMatricGrade.Text, out float mGrade) ? mGrade : 0.0f);
                    cmd.Parameters.AddWithValue("@InterGrade", float.TryParse(txtInterGrade.Text, out float iGrade) ? iGrade : 0.0f);

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Student Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadStudentData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Operation Failed: {ex.Message}", "Application Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private void btnUpdateRecord_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtUpdateRegId.Text, out int regId))
            {
                MessageBox.Show("Please enter a valid Registration ID (RegId) to update.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string updateQuery = @"
                UPDATE Students
                SET Name = @Name, Address = @Address, MatricGrade = @MatricGrade, InterGrade = @InterGrade
                WHERE RegId = @RegId";

            SqlConnection conn = new SqlConnection(ConnectionString);
            
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(updateQuery, conn);

                    cmd.Parameters.AddWithValue("@RegId", regId);
                    cmd.Parameters.AddWithValue("@Name", txtUpdateName.Text);
                    cmd.Parameters.AddWithValue("@Address", txtUpdateAddress.Text);
                    cmd.Parameters.AddWithValue("@MatricGrade", float.TryParse(txtUpdateMatricGrade.Text, out float mGrade) ? mGrade : 0.0f);
                    cmd.Parameters.AddWithValue("@InterGrade", float.TryParse(txtUpdateInterGrade.Text, out float iGrade) ? iGrade : 0.0f);

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show($"Record with RegId {regId} Updated Successfully!", "Update Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadStudentData();
                    }
                    else
                    {
                        MessageBox.Show($"No record found with RegId {regId} or no changes were made.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Update Failed: {ex.Message}", "Application Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
        }


        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtDeleteRegId.Text, out int regId))
            {
                MessageBox.Show("Please enter a valid Registration ID (RegId) to delete.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmResult = MessageBox.Show(
                $"Are you sure you want to delete student record with RegId: {regId}?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                string deleteQuery = "DELETE FROM Students WHERE RegId = @RegId";

                SqlConnection conn = new SqlConnection(ConnectionString);
                {
                    try
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand(deleteQuery, conn);
                        cmd.Parameters.AddWithValue("@RegId", regId);

                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Student Record Deleted Successfully.", "Deletion Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadStudentData();
                        }
                        else
                        {
                            MessageBox.Show($"No record found with RegId {regId}. Deletion failed.", "Deletion Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Deletion Failed: {ex.Message}", "Application Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        #endregion

        private void txtFatherName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}