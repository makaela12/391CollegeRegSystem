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
    public partial class Login : Form
    {
        /*  For Connection String:
            Copy and paste this line but replace server/dbname with your info,
            and then just comment mine out... that way  whenever we pull we all dont 
            have to manually re-input our server names. Just uncomment yours to use, leave everyone elses commented out. 
        */
        private const string ConnectionString = "Server = KIPP-LAPTOP; Database = CourseRegistration; Trusted_Connection = yes;"; 
        public Login()
        {
            InitializeComponent();
        }

        private void signinBtn_Click(object sender, EventArgs e)
        {
            int studentID;
            // tries to parse as integer, if successful stores int value in studentID
            if (int.TryParse(sidBox.Text, out studentID))
            {
                // get text from usernameBox, store it as lastName
                string lastName = usernameBox.Text;

                // if credentials are valid, navigate to CourseRegistration form
                if (CheckLoginCredentials(studentID, lastName))
                {
                    CourseRegistration courseRegistrationForm = new CourseRegistration(studentID, lastName);
                    courseRegistrationForm.Show();
                    this.Hide(); // Hide the login form
                }
                // if creds invalid, display error message
                else
                {
                    MessageBox.Show("Invalid Login Credentials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            // if parsing id fails (the value isnt an int), then also display error message
            else
            {
                MessageBox.Show("Invalid Login Credentials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        // method to check the login creds 
        private bool CheckLoginCredentials(int studentID, string lastName)
        {
            // creates connection to the sql server
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                // opens the connection
                connection.Open();
                // "CheckLoginCredentials" is the name of the stored procedure; associating it with the open connection
                using (SqlCommand command = new SqlCommand("CheckLoginCredentials", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@StudentID", studentID); // adds value of sid to stored procedure
                    command.Parameters.AddWithValue("@LastName", lastName); // adds value of lastName to stored procedure

                    // executes stored procedure and retrieves either a 1 (valid) or 0 (invalid)
                    int result = (int)command.ExecuteScalar();

                    // if result is 1, then creds are valid, otherwise invalid
                    return result == 1;
                }
            }
        }
    


        private void Form1_Load(object sender, EventArgs e) 
        {

        }
    }
}
