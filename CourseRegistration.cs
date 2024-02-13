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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace _391CollegeRegSystem
{
    public partial class CourseRegistration : Form
    {
        // For Connection String:
        // Copy and paste this line but replace server/dbname with your info,
        // and then just comment mine out... that way whenever we pull we all don't
        // have to manually re-input our server names. Just uncomment yours to use, leave everyone else's commented out.

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


            this.AutoScroll = true;
            LoadEnrolledCourses();
            LoadCart();

        }

        private const string ConnectionString = "Server=localhost; Database=CourseRegistration; Integrated Security=True;";



        private void term_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Implementation needed or event handler can be removed if not used
        }

        private void courseSearch_TextChanged(object sender, EventArgs e)
        {
            // Implementation needed or event handler can be removed if not used
        }
        
        
        
        // this is for the search button functionality -- FIXED (ayub)
        
        private void search_button_Click(object sender, EventArgs e)
        {
            // Ensures a term is selected and a course prefix is entered
            if (term.SelectedItem == null || string.IsNullOrWhiteSpace(courseSearch.Text))
            {
                MessageBox.Show("Please select a term and enter a course prefix.");
                return;
            }

            string selectedTerm = term.SelectedItem.ToString(); // Use the selected item from the ComboBox
            string coursePrefix = courseSearch.Text.Trim().ToUpper(); // Use text from the TextBox and convert it to uppercase

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    // Open the connection
                    connection.Open();


                    using (SqlCommand command = new SqlCommand("spSearchClass", connection))
                    {
                        // Prevent SQL injection by using parameters
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@sem", selectedTerm);  // the term selected
                        command.Parameters.AddWithValue("@CoursePrefix", coursePrefix); // Append '%' to allow for prefix searching, responsible for the Course selected

                        // Execute the query and load the results into a DataTable
                        DataTable dt = new DataTable();
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(dt);
                            //MessageBox.Show($"Results Found: {dt.Rows.Count}"); // Display the number of rows found in a pop up (can be removed later)
                        }

                        // Check for data before setting the DataSource
                        if (dt.Rows.Count > 0)
                        {
                            coursesView.DataSource = dt; // Populate the coursesView grid box.. 
                        }
                        else
                        {
                            MessageBox.Show("No courses found. Please adjust your search criteria.");
                            coursesView.DataSource = null; // Clear previous results if any
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while querying the database: {ex.Message}\n{ex.StackTrace}");
            }
        }





        private void coursesView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Implementation needed or event handler can be removed if not used
        }


        // This works, it won't allow the user to add the course to the cart if the pre req is not in takes. 
        // however it can be improve if we can check the terms and year as well.. 

        private bool CheckPrerequisites(string courseID)
        {
            int count;
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                //string sql = @"SELECT COUNT(*) FROM Prereq WHERE course_id = @CourseID;";
                using (SqlCommand command = new SqlCommand("spCheckIfClassHasAPrereq", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@CourseID", courseID);
                    count = Convert.ToInt32(command.ExecuteScalar());

                    //return count == 0; // Returns true if there are no prerequisites
                }
                if (count >= 1)
                {
                    using (SqlCommand command = new SqlCommand("spCheckPrereqInTakes", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@CourseID", courseID);
                        command.Parameters.AddWithValue("@SID", studentID);
                        count = Convert.ToInt32(command.ExecuteScalar());
                        return count == 1;
                        //return count == 0; // Returns true if there are no prerequisites
                    }
                }
                else
                {
                    return count == 0;
                }
            }
        }
        


        // This is the addcourse to cart fuctionality
        private void AddCourseToCart(int studentID, string courseID, string secID, string semester, int year)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                //string sql = @"INSERT INTO Cart (SID, CourseID, SecID, Sem, Year) VALUES (@SID, @CourseID, @SecID, @Sem, @Year);"; // insert the selected to the table
                using (SqlCommand command = new SqlCommand("AddCourseToCart", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@SID", studentID);
                    command.Parameters.AddWithValue("@CourseID", courseID);
                    command.Parameters.AddWithValue("@SecID", secID);
                    command.Parameters.AddWithValue("@Sem", semester);
                    command.Parameters.AddWithValue("@Year", year);
                    command.ExecuteNonQuery();
                }
            }
        }

        // Projecting the dbo.cart in the grid view except for student id.. 
        private void LoadCart()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                //string sql = @"SELECT CourseID, SecID, Sem, Year FROM Cart WHERE SID = @SID;";
                using (SqlCommand command = new SqlCommand("LoadCart", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@SID", studentID);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        cart_gridView.DataSource = dt;
                    }
                }
            }
        }



        // Add to cart button functionality : 
        private void addToCart_button_Click(object sender, EventArgs e)
        {
            // Check if any row is selected 
            if (coursesView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = coursesView.SelectedRows[0];
                string courseID = selectedRow.Cells["course_id"].Value.ToString();
                string secID = selectedRow.Cells["sec_ID"].Value.ToString();
                string semester = selectedRow.Cells["semester"].Value.ToString();
                int year = Convert.ToInt32(selectedRow.Cells["year"].Value);

                // Check prerequisites using helper function above
                if (CheckPrerequisites(courseID))
                {
                    if (CheckCourseCapacity(courseID, secID, semester, year))
                    {
                        // Add to Cart using the helper function above aswell
                        AddCourseToCart(studentID, courseID, secID, semester, year);

                        // Refresh Cart View using helper function
                        LoadCart();
                    }
                    else
                    {
                        MessageBox.Show("No Seats Available");

                    }

                }
                else
                {
                    MessageBox.Show("Prerequisite not met.");
                }
            }
            // if no row is selected we will let the user know.. 
            else
            {
                MessageBox.Show("Please select a course to add.");
            }
        }


        // Delete the course selected and then remove it from the cartView
        private void delete_button_Click(object sender, EventArgs e)
        {
            // Check if any row is selected in the cart grid view
            if (cart_gridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = cart_gridView.SelectedRows[0];
                string courseID = selectedRow.Cells["CourseID"].Value.ToString();
                string secID = selectedRow.Cells["SecID"].Value.ToString();
                string semester = selectedRow.Cells["Sem"].Value.ToString();
                int year = Convert.ToInt32(selectedRow.Cells["Year"].Value);

                // Remove the selected course from Cart
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    //string sql = @"DELETE FROM Cart WHERE SID = @SID AND CourseID = @CourseID AND SecID = @SecID AND Sem = @Sem AND Year = @Year;";
                    using (SqlCommand command = new SqlCommand("delete_button", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@SID", studentID);
                        command.Parameters.AddWithValue("@CourseID", courseID);
                        command.Parameters.AddWithValue("@SecID", secID);
                        command.Parameters.AddWithValue("@Sem", semester);
                        command.Parameters.AddWithValue("@Year", year);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Course removed from cart.");
                        }
                        else
                        {
                            MessageBox.Show("Failed to remove the course from cart. Please try again.");
                        }
                    }
                }

                // Refresh the cart view to reflect the change
                LoadCart();
            }
            else
            {
                MessageBox.Show("Please select a course to remove.");
            }
        }


        // This is the one i use for checking capacity, however for some reason the query is not showing anything.. 
        // Need to fix it... So for now, this is not used. 
        private bool CheckCourseCapacity(string courseID, string secID, string semester, int year)
        {

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                //string sql = @"
//SELECT cr.capacity - COUNT(*) AS availableSeats
//FROM dbo.Section s
//JOIN dbo.Classroom cr ON s.building = cr.building AND s.room_no = cr.room_number
//LEFT JOIN dbo.Takes t ON s.course_ID = t.course_ID AND s.sec_ID = t.sec_ID AND s.semester = t.semester AND s.year = t.year
//WHERE s.course_ID = @CourseID AND s.sec_ID = @SecID AND s.semester = @Semester AND s.year = @Year
//GROUP BY cr.capacity";

                using (SqlCommand command = new SqlCommand("spCheckSectionAvailableSeats", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@CourseID", courseID);
                    command.Parameters.AddWithValue("@SecID", secID);
                    command.Parameters.AddWithValue("@Semester", semester);
                    command.Parameters.AddWithValue("@Year", year);

                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        return Convert.ToInt32(result) > 0;
                    }
                }
            }
            return false;
        }








        // add courses that is selected to dbo.Takes helper function
        
        private void AddCourseToTakes(int studentID, string courseID, string secID, string semester, int year)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();

                    string SIDString = studentID.ToString();
                    string yearString = year.ToString();
                    string storedProcedureName = "spEnrollStudent";
                    //string sqlQuery = $"EXEC {storedProcedureName} @SID, @CourseID, @SecID, @Semester, @Year";

                    using (SqlCommand command = new SqlCommand(storedProcedureName, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@SID", SIDString);
                        command.Parameters.AddWithValue("@CourseID", courseID);
                        command.Parameters.AddWithValue("@SecID", secID);
                        command.Parameters.AddWithValue("@sem", semester);
                        command.Parameters.AddWithValue("@Year", yearString);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Successfully enrolled in course.");
                    }
                    

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to enroll in course: {ex.Message}");
                }
            }
        }

  


        // Project the enrolled courses in the enrolledView 

        private void LoadEnrolledCourses()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                //string sql = @"SELECT course_ID, sec_ID, semester, year FROM Takes WHERE SID = @SID;";
                using (SqlCommand command = new SqlCommand("LoadEnrolledCourses", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@SID", studentID);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        enrolledView.DataSource = dt; // Assuming enrolledView is your DataGridView for enrolled courses
                    }
                }
            }
        }



        // Implementation of enroll button by calling the helpers above.. 

        private void enroll_button_Click(object sender, EventArgs e)
        {
            if (cart_gridView.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow selectedRow in cart_gridView.SelectedRows)
                {
                    string courseID = selectedRow.Cells["CourseID"].Value.ToString();
                    string secID = selectedRow.Cells["SecID"].Value.ToString();
                    string semester = selectedRow.Cells["Sem"].Value.ToString();
                    int year = Convert.ToInt32(selectedRow.Cells["Year"].Value);

                    // Directly add the course to Takes without checking capacity for now.. 
                    AddCourseToTakes(studentID, courseID, secID, semester, year);

                    // Remove the course from Cart took this out (ayub)
                    //RemoveCourseFromCart(studentID, courseID, secID, semester, year);
                }

                // Refresh Cart and Enrolled Courses Views
                LoadCart();
                LoadEnrolledCourses();
            }
            else
            {
                MessageBox.Show("Please select a course to enroll.");
            }
        }


    }
}