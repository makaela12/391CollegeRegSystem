using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        private const string ConnectionString = "Server = DESKTOP-NAMNLUT; Database = CollegeReg391; Trusted_Connection = yes;";

        // pass sid and last name from login screen
        private int studentID;
        private string lastName;
        public CourseRegistration(int studentID, string lastName)
        {
            InitializeComponent();

            this.studentID = studentID;
            this.lastName = lastName;
        }

  

      
    }
}
