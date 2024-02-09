namespace _391CollegeRegSystem
{
    partial class CourseRegistration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.courseSearch = new System.Windows.Forms.TextBox();
            this.coursesView = new System.Windows.Forms.DataGridView();
            this.course_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.course_title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semester = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.section = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instructor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.days = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.times = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prereq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cart_gridView = new System.Windows.Forms.DataGridView();
            this.cart_course_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cart_course_title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cart_semester = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cart_year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addToCart_button = new System.Windows.Forms.Button();
            this.search_button = new System.Windows.Forms.Button();
            this.title_cart = new System.Windows.Forms.Label();
            this.courseSearchLabel = new System.Windows.Forms.Label();
            this.search_title_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.delete_button = new System.Windows.Forms.Button();
            this.enroll_button = new System.Windows.Forms.Button();
            this.Terms = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.term = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.coursesView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cart_gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Terms)).BeginInit();
            this.SuspendLayout();
            // 
            // courseSearch
            // 
            this.courseSearch.Location = new System.Drawing.Point(617, 121);
            this.courseSearch.Name = "courseSearch";
            this.courseSearch.Size = new System.Drawing.Size(164, 20);
            this.courseSearch.TabIndex = 0;
            this.courseSearch.TextChanged += new System.EventHandler(this.courseSearch_TextChanged);
            // 
            // coursesView
            // 
            this.coursesView.BackgroundColor = System.Drawing.Color.Tan;
            this.coursesView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.coursesView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.course_id,
            this.course_title,
            this.semester,
            this.year,
            this.section,
            this.instructor,
            this.days,
            this.times,
            this.capacity,
            this.prereq});
            this.coursesView.Location = new System.Drawing.Point(60, 191);
            this.coursesView.Name = "coursesView";
            this.coursesView.Size = new System.Drawing.Size(1043, 176);
            this.coursesView.TabIndex = 1;
            this.coursesView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.coursesView_CellContentClick);
            // 
            // course_id
            // 
            this.course_id.HeaderText = "CourseNo";
            this.course_id.Name = "course_id";
            // 
            // course_title
            // 
            this.course_title.HeaderText = "Title";
            this.course_title.Name = "course_title";
            // 
            // semester
            // 
            this.semester.HeaderText = "Semester";
            this.semester.Name = "semester";
            // 
            // year
            // 
            this.year.HeaderText = "Year";
            this.year.Name = "year";
            // 
            // section
            // 
            this.section.HeaderText = "Section";
            this.section.Name = "section";
            // 
            // instructor
            // 
            this.instructor.HeaderText = "Instructor";
            this.instructor.Name = "instructor";
            // 
            // days
            // 
            this.days.HeaderText = "Days";
            this.days.Name = "days";
            // 
            // times
            // 
            this.times.HeaderText = "Times";
            this.times.Name = "times";
            // 
            // capacity
            // 
            this.capacity.HeaderText = "Capacity";
            this.capacity.Name = "capacity";
            // 
            // prereq
            // 
            this.prereq.HeaderText = "Prerequisites";
            this.prereq.Name = "prereq";
            // 
            // cart_gridView
            // 
            this.cart_gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cart_gridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cart_course_id,
            this.cart_course_title,
            this.cart_semester,
            this.cart_year});
            this.cart_gridView.Location = new System.Drawing.Point(76, 439);
            this.cart_gridView.Name = "cart_gridView";
            this.cart_gridView.Size = new System.Drawing.Size(442, 266);
            this.cart_gridView.TabIndex = 2;
            // 
            // cart_course_id
            // 
            this.cart_course_id.HeaderText = "CourseNo";
            this.cart_course_id.Name = "cart_course_id";
            // 
            // cart_course_title
            // 
            this.cart_course_title.HeaderText = "Title";
            this.cart_course_title.Name = "cart_course_title";
            // 
            // cart_semester
            // 
            this.cart_semester.HeaderText = "Semester";
            this.cart_semester.Name = "cart_semester";
            // 
            // cart_year
            // 
            this.cart_year.HeaderText = "Year";
            this.cart_year.Name = "cart_year";
            // 
            // addToCart_button
            // 
            this.addToCart_button.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addToCart_button.Location = new System.Drawing.Point(524, 379);
            this.addToCart_button.Name = "addToCart_button";
            this.addToCart_button.Size = new System.Drawing.Size(118, 25);
            this.addToCart_button.TabIndex = 3;
            this.addToCart_button.Text = "Add to Cart";
            this.addToCart_button.UseVisualStyleBackColor = true;
            // 
            // search_button
            // 
            this.search_button.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_button.Location = new System.Drawing.Point(524, 146);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(70, 27);
            this.search_button.TabIndex = 4;
            this.search_button.Text = "Search";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // title_cart
            // 
            this.title_cart.AutoSize = true;
            this.title_cart.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_cart.Location = new System.Drawing.Point(176, 408);
            this.title_cart.Name = "title_cart";
            this.title_cart.Size = new System.Drawing.Size(228, 23);
            this.title_cart.TabIndex = 5;
            this.title_cart.Text = "Your Shopping Cart:";
            // 
            // courseSearchLabel
            // 
            this.courseSearchLabel.AutoSize = true;
            this.courseSearchLabel.BackColor = System.Drawing.Color.Transparent;
            this.courseSearchLabel.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseSearchLabel.Location = new System.Drawing.Point(442, 38);
            this.courseSearchLabel.Name = "courseSearchLabel";
            this.courseSearchLabel.Size = new System.Drawing.Size(293, 32);
            this.courseSearchLabel.TabIndex = 6;
            this.courseSearchLabel.Text = "Course Enrollment";
            // 
            // search_title_label
            // 
            this.search_title_label.AutoSize = true;
            this.search_title_label.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_title_label.Location = new System.Drawing.Point(625, 92);
            this.search_title_label.Name = "search_title_label";
            this.search_title_label.Size = new System.Drawing.Size(145, 16);
            this.search_title_label.TabIndex = 8;
            this.search_title_label.Text = "Enter Course Title: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(569, 391);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 9;
            // 
            // delete_button
            // 
            this.delete_button.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_button.Location = new System.Drawing.Point(156, 711);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(92, 26);
            this.delete_button.TabIndex = 10;
            this.delete_button.Text = "Delete";
            this.delete_button.UseVisualStyleBackColor = true;
            // 
            // enroll_button
            // 
            this.enroll_button.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enroll_button.Location = new System.Drawing.Point(303, 711);
            this.enroll_button.Name = "enroll_button";
            this.enroll_button.Size = new System.Drawing.Size(92, 26);
            this.enroll_button.TabIndex = 11;
            this.enroll_button.Text = "Enroll";
            this.enroll_button.UseVisualStyleBackColor = true;
            // 
            // Terms
            // 
            this.Terms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Terms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.Terms.Location = new System.Drawing.Point(664, 439);
            this.Terms.Name = "Terms";
            this.Terms.Size = new System.Drawing.Size(439, 266);
            this.Terms.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "CourseNo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Title";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Semester";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Year";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Section";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Instructor";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Days";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Times";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Capacity";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "Prerequisites";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(789, 408);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "Enrolled Courses: ";
            // 
            // term
            // 
            this.term.FormattingEnabled = true;
            this.term.Items.AddRange(new object[] {
            "Fall Term",
            "Winter Term",
            "Spring",
            "Summer"});
            this.term.Location = new System.Drawing.Point(342, 121);
            this.term.Name = "term";
            this.term.Size = new System.Drawing.Size(169, 21);
            this.term.TabIndex = 14;
            this.term.SelectedIndexChanged += new System.EventHandler(this.term_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(370, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Select a Term:";
            // 
            // CourseRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(1201, 749);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.term);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Terms);
            this.Controls.Add(this.enroll_button);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.search_title_label);
            this.Controls.Add(this.courseSearchLabel);
            this.Controls.Add(this.title_cart);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.addToCart_button);
            this.Controls.Add(this.cart_gridView);
            this.Controls.Add(this.coursesView);
            this.Controls.Add(this.courseSearch);
            this.ForeColor = System.Drawing.Color.Maroon;
            this.Name = "CourseRegistration";
            this.Text = "CourseRegistration";
            ((System.ComponentModel.ISupportInitialize)(this.coursesView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cart_gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Terms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox courseSearch;
        private System.Windows.Forms.DataGridView coursesView;
        private System.Windows.Forms.DataGridViewTextBoxColumn course_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn course_title;
        private System.Windows.Forms.DataGridViewTextBoxColumn semester;
        private System.Windows.Forms.DataGridViewTextBoxColumn year;
        private System.Windows.Forms.DataGridViewTextBoxColumn section;
        private System.Windows.Forms.DataGridViewTextBoxColumn instructor;
        private System.Windows.Forms.DataGridViewTextBoxColumn days;
        private System.Windows.Forms.DataGridViewTextBoxColumn times;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn prereq;
        private System.Windows.Forms.DataGridView cart_gridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn cart_course_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cart_course_title;
        private System.Windows.Forms.DataGridViewTextBoxColumn cart_semester;
        private System.Windows.Forms.DataGridViewTextBoxColumn cart_year;
        private System.Windows.Forms.Button addToCart_button;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.Label title_cart;
        private System.Windows.Forms.Label courseSearchLabel;
        private System.Windows.Forms.Label search_title_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button enroll_button;
        private System.Windows.Forms.DataGridView Terms;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox term;
        private System.Windows.Forms.Label label2;
    }
}