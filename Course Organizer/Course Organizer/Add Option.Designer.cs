﻿namespace Course_Organizer
{
    partial class Form_Addcourse
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
            this.tx_semester = new System.Windows.Forms.TextBox();
            this.label_semester = new System.Windows.Forms.Label();
            this.label_course_id = new System.Windows.Forms.Label();
            this.labe_course_name = new System.Windows.Forms.Label();
            this.label_add = new System.Windows.Forms.Label();
            this.tx_section = new System.Windows.Forms.TextBox();
            this.label_course_Sec = new System.Windows.Forms.Label();
            this.label_return_signup = new System.Windows.Forms.Label();
            this.Button_course_save = new System.Windows.Forms.Button();
            this.combo_coursename = new System.Windows.Forms.ComboBox();
            this.tx_courseid = new System.Windows.Forms.TextBox();
            this.combo_courseid = new System.Windows.Forms.ComboBox();
            this.combo_section = new System.Windows.Forms.ComboBox();
            this.combo_semester = new System.Windows.Forms.ComboBox();
            this.Prompt = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tx_semester
            // 
            this.tx_semester.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tx_semester.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_semester.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_semester.Location = new System.Drawing.Point(112, 606);
            this.tx_semester.Multiline = true;
            this.tx_semester.Name = "tx_semester";
            this.tx_semester.Size = new System.Drawing.Size(408, 35);
            this.tx_semester.TabIndex = 34;
            this.tx_semester.Visible = false;
            // 
            // label_semester
            // 
            this.label_semester.AutoSize = true;
            this.label_semester.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_semester.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label_semester.Location = new System.Drawing.Point(107, 288);
            this.label_semester.Name = "label_semester";
            this.label_semester.Size = new System.Drawing.Size(87, 28);
            this.label_semester.TabIndex = 33;
            this.label_semester.Text = "Semester";
            // 
            // label_course_id
            // 
            this.label_course_id.AutoSize = true;
            this.label_course_id.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_course_id.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label_course_id.Location = new System.Drawing.Point(107, 208);
            this.label_course_id.Name = "label_course_id";
            this.label_course_id.Size = new System.Drawing.Size(95, 28);
            this.label_course_id.TabIndex = 29;
            this.label_course_id.Text = "Course ID*";
            // 
            // labe_course_name
            // 
            this.labe_course_name.AutoSize = true;
            this.labe_course_name.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labe_course_name.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labe_course_name.Location = new System.Drawing.Point(107, 134);
            this.labe_course_name.Name = "labe_course_name";
            this.labe_course_name.Size = new System.Drawing.Size(128, 28);
            this.labe_course_name.TabIndex = 22;
            this.labe_course_name.Text = "Course Name*";
            // 
            // label_add
            // 
            this.label_add.AutoSize = true;
            this.label_add.BackColor = System.Drawing.Color.RoyalBlue;
            this.label_add.Font = new System.Drawing.Font("Poppins Medium", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_add.ForeColor = System.Drawing.Color.White;
            this.label_add.Location = new System.Drawing.Point(101, 29);
            this.label_add.Name = "label_add";
            this.label_add.Size = new System.Drawing.Size(118, 65);
            this.label_add.TabIndex = 21;
            this.label_add.Text = "Add ";
            // 
            // tx_section
            // 
            this.tx_section.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tx_section.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_section.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_section.Location = new System.Drawing.Point(325, 527);
            this.tx_section.Multiline = true;
            this.tx_section.Name = "tx_section";
            this.tx_section.Size = new System.Drawing.Size(196, 35);
            this.tx_section.TabIndex = 37;
            this.tx_section.Visible = false;
            // 
            // label_course_Sec
            // 
            this.label_course_Sec.AutoSize = true;
            this.label_course_Sec.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_course_Sec.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label_course_Sec.Location = new System.Drawing.Point(319, 208);
            this.label_course_Sec.Name = "label_course_Sec";
            this.label_course_Sec.Size = new System.Drawing.Size(79, 28);
            this.label_course_Sec.TabIndex = 36;
            this.label_course_Sec.Text = "Section*";
            // 
            // label_return_signup
            // 
            this.label_return_signup.AutoSize = true;
            this.label_return_signup.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_return_signup.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label_return_signup.Location = new System.Drawing.Point(108, 564);
            this.label_return_signup.Name = "label_return_signup";
            this.label_return_signup.Size = new System.Drawing.Size(35, 48);
            this.label_return_signup.TabIndex = 35;
            this.label_return_signup.Text = "<";
            this.label_return_signup.Click += new System.EventHandler(this.label_return_signup_Click);
            // 
            // Button_course_save
            // 
            this.Button_course_save.BackColor = System.Drawing.Color.Transparent;
            this.Button_course_save.BackgroundImage = global::Course_Organizer.Properties.Resources.Rectangle_2;
            this.Button_course_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button_course_save.FlatAppearance.BorderSize = 0;
            this.Button_course_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_course_save.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_course_save.ForeColor = System.Drawing.Color.White;
            this.Button_course_save.Location = new System.Drawing.Point(251, 445);
            this.Button_course_save.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button_course_save.Name = "Button_course_save";
            this.Button_course_save.Size = new System.Drawing.Size(123, 41);
            this.Button_course_save.TabIndex = 26;
            this.Button_course_save.Text = "Save";
            this.Button_course_save.UseVisualStyleBackColor = false;
            this.Button_course_save.Click += new System.EventHandler(this.Button_course_save_Click);
            // 
            // combo_coursename
            // 
            this.combo_coursename.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.combo_coursename.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combo_coursename.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_coursename.FormattingEnabled = true;
            this.combo_coursename.Items.AddRange(new object[] {
            "Object Oriented Programming 1",
            "Object Oriented Programming 2",
            "Numerical Methods for Engineering",
            "Computer Graphics"});
            this.combo_coursename.Location = new System.Drawing.Point(112, 166);
            this.combo_coursename.Name = "combo_coursename";
            this.combo_coursename.Size = new System.Drawing.Size(408, 36);
            this.combo_coursename.TabIndex = 38;
            // 
            // tx_courseid
            // 
            this.tx_courseid.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tx_courseid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_courseid.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_courseid.Location = new System.Drawing.Point(112, 526);
            this.tx_courseid.Multiline = true;
            this.tx_courseid.Name = "tx_courseid";
            this.tx_courseid.Size = new System.Drawing.Size(193, 35);
            this.tx_courseid.TabIndex = 37;
            this.tx_courseid.Visible = false;
            // 
            // combo_courseid
            // 
            this.combo_courseid.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.combo_courseid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combo_courseid.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_courseid.FormattingEnabled = true;
            this.combo_courseid.Items.AddRange(new object[] {
            "CSC 2101",
            "CSC 2202",
            "MAT 3101",
            "CSC 2105"});
            this.combo_courseid.Location = new System.Drawing.Point(112, 240);
            this.combo_courseid.Name = "combo_courseid";
            this.combo_courseid.Size = new System.Drawing.Size(182, 36);
            this.combo_courseid.TabIndex = 39;
            // 
            // combo_section
            // 
            this.combo_section.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.combo_section.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combo_section.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_section.FormattingEnabled = true;
            this.combo_section.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J"});
            this.combo_section.Location = new System.Drawing.Point(324, 240);
            this.combo_section.Name = "combo_section";
            this.combo_section.Size = new System.Drawing.Size(196, 36);
            this.combo_section.TabIndex = 40;
            // 
            // combo_semester
            // 
            this.combo_semester.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.combo_semester.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combo_semester.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_semester.FormattingEnabled = true;
            this.combo_semester.Items.AddRange(new object[] {
            "Spring",
            "Summer",
            "Fall"});
            this.combo_semester.Location = new System.Drawing.Point(112, 320);
            this.combo_semester.Name = "combo_semester";
            this.combo_semester.Size = new System.Drawing.Size(409, 36);
            this.combo_semester.TabIndex = 41;
            // 
            // Prompt
            // 
            this.Prompt.AutoSize = true;
            this.Prompt.BackColor = System.Drawing.Color.Transparent;
            this.Prompt.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prompt.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Prompt.Location = new System.Drawing.Point(112, 385);
            this.Prompt.Name = "Prompt";
            this.Prompt.Size = new System.Drawing.Size(58, 23);
            this.Prompt.TabIndex = 42;
            this.Prompt.Text = "Prompt";
            this.Prompt.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.RoyalBlue;
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(3840, 113);
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // Form_Addcourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 681);
            this.Controls.Add(this.Prompt);
            this.Controls.Add(this.combo_semester);
            this.Controls.Add(this.combo_section);
            this.Controls.Add(this.combo_courseid);
            this.Controls.Add(this.combo_coursename);
            this.Controls.Add(this.tx_courseid);
            this.Controls.Add(this.tx_section);
            this.Controls.Add(this.label_course_Sec);
            this.Controls.Add(this.label_return_signup);
            this.Controls.Add(this.tx_semester);
            this.Controls.Add(this.label_semester);
            this.Controls.Add(this.label_course_id);
            this.Controls.Add(this.Button_course_save);
            this.Controls.Add(this.labe_course_name);
            this.Controls.Add(this.label_add);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Addcourse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Course";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tx_semester;
        private System.Windows.Forms.Label label_semester;
        private System.Windows.Forms.Label label_course_id;
        private System.Windows.Forms.Button Button_course_save;
        private System.Windows.Forms.Label labe_course_name;
        private System.Windows.Forms.Label label_add;
        private System.Windows.Forms.TextBox tx_section;
        private System.Windows.Forms.Label label_course_Sec;
        private System.Windows.Forms.Label label_return_signup;
        private System.Windows.Forms.ComboBox combo_coursename;
        private System.Windows.Forms.TextBox tx_courseid;
        private System.Windows.Forms.ComboBox combo_courseid;
        private System.Windows.Forms.ComboBox combo_section;
        private System.Windows.Forms.ComboBox combo_semester;
        private System.Windows.Forms.Label Prompt;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}