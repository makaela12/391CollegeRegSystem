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
            this.cart_gridView = new System.Windows.Forms.DataGridView();
            this.addToCart_button = new System.Windows.Forms.Button();
            this.search_button = new System.Windows.Forms.Button();
            this.title_cart = new System.Windows.Forms.Label();
            this.courseSearchLabel = new System.Windows.Forms.Label();
            this.search_title_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.delete_button = new System.Windows.Forms.Button();
            this.enroll_button = new System.Windows.Forms.Button();
            this.enrolledView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.term = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.coursesView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cart_gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enrolledView)).BeginInit();
            this.SuspendLayout();
            // 
            // courseSearch
            // 
            this.courseSearch.Location = new System.Drawing.Point(708, 112);
            this.courseSearch.Name = "courseSearch";
            this.courseSearch.Size = new System.Drawing.Size(164, 20);
            this.courseSearch.TabIndex = 0;
            this.courseSearch.TextChanged += new System.EventHandler(this.courseSearch_TextChanged);
            // 
            // coursesView
            // 
            this.coursesView.BackgroundColor = System.Drawing.Color.White;
            this.coursesView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.coursesView.Location = new System.Drawing.Point(135, 164);
            this.coursesView.Name = "coursesView";
            this.coursesView.Size = new System.Drawing.Size(942, 176);
            this.coursesView.TabIndex = 1;
            this.coursesView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.coursesView_CellContentClick);
            // 
            // cart_gridView
            // 
            this.cart_gridView.BackgroundColor = System.Drawing.Color.White;
            this.cart_gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cart_gridView.Location = new System.Drawing.Point(114, 410);
            this.cart_gridView.Name = "cart_gridView";
            this.cart_gridView.Size = new System.Drawing.Size(442, 266);
            this.cart_gridView.TabIndex = 2;
            // 
            // addToCart_button
            // 
            this.addToCart_button.BackColor = System.Drawing.Color.Linen;
            this.addToCart_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addToCart_button.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addToCart_button.Location = new System.Drawing.Point(557, 363);
            this.addToCart_button.Name = "addToCart_button";
            this.addToCart_button.Size = new System.Drawing.Size(118, 25);
            this.addToCart_button.TabIndex = 3;
            this.addToCart_button.Text = "Add to Cart";
            this.addToCart_button.UseVisualStyleBackColor = false;
            this.addToCart_button.Click += new System.EventHandler(this.addToCart_button_Click);
            // 
            // search_button
            // 
            this.search_button.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_button.Location = new System.Drawing.Point(586, 131);
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
            this.title_cart.Location = new System.Drawing.Point(224, 365);
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
            this.courseSearchLabel.Location = new System.Drawing.Point(499, 36);
            this.courseSearchLabel.Name = "courseSearchLabel";
            this.courseSearchLabel.Size = new System.Drawing.Size(293, 32);
            this.courseSearchLabel.TabIndex = 6;
            this.courseSearchLabel.Text = "Course Enrollment";
            // 
            // search_title_label
            // 
            this.search_title_label.AutoSize = true;
            this.search_title_label.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_title_label.Location = new System.Drawing.Point(718, 92);
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
            this.delete_button.BackColor = System.Drawing.Color.Linen;
            this.delete_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.delete_button.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_button.Location = new System.Drawing.Point(197, 696);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(92, 26);
            this.delete_button.TabIndex = 10;
            this.delete_button.Text = "Delete";
            this.delete_button.UseVisualStyleBackColor = false;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // enroll_button
            // 
            this.enroll_button.BackColor = System.Drawing.Color.Linen;
            this.enroll_button.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enroll_button.Location = new System.Drawing.Point(349, 696);
            this.enroll_button.Name = "enroll_button";
            this.enroll_button.Size = new System.Drawing.Size(92, 26);
            this.enroll_button.TabIndex = 11;
            this.enroll_button.Text = "Enroll";
            this.enroll_button.UseVisualStyleBackColor = false;
            this.enroll_button.Click += new System.EventHandler(this.enroll_button_Click);
            // 
            // enrolledView
            // 
            this.enrolledView.BackgroundColor = System.Drawing.Color.White;
            this.enrolledView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.enrolledView.GridColor = System.Drawing.Color.Snow;
            this.enrolledView.Location = new System.Drawing.Point(694, 410);
            this.enrolledView.Name = "enrolledView";
            this.enrolledView.Size = new System.Drawing.Size(439, 266);
            this.enrolledView.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(802, 365);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "Enrolled Courses: ";
            // 
            // term
            // 
            this.term.FormattingEnabled = true;
            this.term.Location = new System.Drawing.Point(349, 111);
            this.term.Name = "term";
            this.term.Size = new System.Drawing.Size(169, 21);
            this.term.TabIndex = 14;
            this.term.SelectedIndexChanged += new System.EventHandler(this.term_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(385, 92);
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
            this.Controls.Add(this.enrolledView);
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
            ((System.ComponentModel.ISupportInitialize)(this.enrolledView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox courseSearch;
        private System.Windows.Forms.DataGridView coursesView;
        private System.Windows.Forms.DataGridView cart_gridView;
        private System.Windows.Forms.Button addToCart_button;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.Label title_cart;
        private System.Windows.Forms.Label courseSearchLabel;
        private System.Windows.Forms.Label search_title_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button enroll_button;
        private System.Windows.Forms.DataGridView enrolledView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox term;
        private System.Windows.Forms.Label label2;
    }
}