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

namespace _391CollegeRegSystem
{
    public partial class CourseRegistration : Form
    {
        /*  For Connection String:
            Copy and paste this line but replace server/dbname with your info,
            and then just comment mine out... that way  whenever we pull we all dont 
            have to manually re-input our server names. Just uncomment yours to use, leave everyone elses commented out. 
        */


        // pass sid and last name from login screen
        private int studentID;
        private string lastName;
        public CourseRegistration(int studentID, string lastName)
        {
            InitializeComponent();

            this.studentID = studentID;
            this.lastName = lastName;

            // Populate the term ComboBox
            term.Items.AddRange(new object[] { "Spring", "Summer", "Fall", "Winter" });
        }

        private const string ConnectionString = "Server=KIPP-LAPTOP; Database=CourseRegistration; Integrated Security=True;";


        private void term_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void courseSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void search_button_Click(object sender, EventArgs e)
        {
            // Ensure a term is selected and a course prefix is entered
            if (term.SelectedItem == null || string.IsNullOrWhiteSpace(courseSearch.Text))
            {
                MessageBox.Show("Please select a term and enter a course prefix.");
                return;
            }

            string selectedTerm = term.SelectedItem.ToString();
            string coursePrefix = courseSearch.Text.Trim().ToUpper(); // Assuming course prefix is case-insensitive

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    // Open the connection
                    connection.Open();

                    // Prepare the SQL query
                    string sql = @"SELECT * FROM dbo.Section WHERE semester = @Term AND course_ID LIKE @CoursePrefix + '%'";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        // Add parameters to prevent SQL injection
                        command.Parameters.AddWithValue("@Term", selectedTerm);
                        command.Parameters.AddWithValue("@CoursePrefix", coursePrefix);

                        // Execute the query and load the results into a DataTable
                        DataTable dt = new DataTable();
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(dt);
                        }

                        // Bind the DataTable to the DataGridView
                        coursesView.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while querying the database: " + ex.Message);
            }
        }


        private void coursesView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
