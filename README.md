Create database in Miscrosoft SQL Management Studio

Create a new database and use the Create Table from the discord from Tarik.

Create a query inside the database and use the Scripts from our design documents in drive and discord to populate the tables

in order to connect the database, in courseregistration.cs you can see the code:

       private const string ConnectionString = "Server=YourServerName; Database=CourseRegistration; Integrated Security=True;"; 

Change YourServerName to the server name in your Microsoft SQL Management Studio. The "CourseRegistration" to whatever you named your database from above

In order to test it, when you run the the program in the log in screen use one of the students in the table that we created
Use their last_name and SID for username and student ID.

For example (you can use this to actually log in just make sure you run the script to populate the student table):

        username   : DOE
        student ID : 100
