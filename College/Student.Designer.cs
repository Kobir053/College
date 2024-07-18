namespace College
{
    partial class Student
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
            comboBox_student_courses = new ComboBox();
            label1 = new Label();
            label_students_schedule = new Label();
            label_student_subjects = new Label();
            button1 = new Button();
            label_student_lecturers = new Label();
            label_student_price = new Label();
            button_student_toRegister = new Button();
            textBox_student_studentName = new TextBox();
            SuspendLayout();
            // 
            // comboBox_student_courses
            // 
            comboBox_student_courses.FormattingEnabled = true;
            comboBox_student_courses.Location = new Point(340, 67);
            comboBox_student_courses.Name = "comboBox_student_courses";
            comboBox_student_courses.Size = new Size(151, 28);
            comboBox_student_courses.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(328, 30);
            label1.Name = "label1";
            label1.Size = new Size(178, 20);
            label1.TabIndex = 1;
            label1.Text = "what are you looking for?";
            // 
            // label_students_schedule
            // 
            label_students_schedule.AutoSize = true;
            label_students_schedule.Location = new Point(328, 118);
            label_students_schedule.Name = "label_students_schedule";
            label_students_schedule.Size = new Size(21, 20);
            label_students_schedule.TabIndex = 2;
            label_students_schedule.Text = "la";
            label_students_schedule.Visible = false;
            // 
            // label_student_subjects
            // 
            label_student_subjects.AutoSize = true;
            label_student_subjects.Location = new Point(616, 198);
            label_student_subjects.Name = "label_student_subjects";
            label_student_subjects.Size = new Size(50, 20);
            label_student_subjects.TabIndex = 3;
            label_student_subjects.Text = "label3";
            label_student_subjects.Visible = false;
            // 
            // button1
            // 
            button1.Location = new Point(555, 67);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "get details";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label_student_lecturers
            // 
            label_student_lecturers.AutoSize = true;
            label_student_lecturers.Location = new Point(58, 198);
            label_student_lecturers.Name = "label_student_lecturers";
            label_student_lecturers.Size = new Size(50, 20);
            label_student_lecturers.TabIndex = 5;
            label_student_lecturers.Text = "label2";
            label_student_lecturers.Visible = false;
            // 
            // label_student_price
            // 
            label_student_price.AutoSize = true;
            label_student_price.Location = new Point(375, 312);
            label_student_price.Name = "label_student_price";
            label_student_price.Size = new Size(50, 20);
            label_student_price.TabIndex = 6;
            label_student_price.Text = "label3";
            label_student_price.Visible = false;
            // 
            // button_student_toRegister
            // 
            button_student_toRegister.Location = new Point(375, 409);
            button_student_toRegister.Name = "button_student_toRegister";
            button_student_toRegister.Size = new Size(94, 29);
            button_student_toRegister.TabIndex = 7;
            button_student_toRegister.Text = "to register:";
            button_student_toRegister.UseVisualStyleBackColor = true;
            button_student_toRegister.Visible = false;
            button_student_toRegister.Click += button_student_toRegister_Click;
            // 
            // textBox_student_studentName
            // 
            textBox_student_studentName.Location = new Point(357, 376);
            textBox_student_studentName.Name = "textBox_student_studentName";
            textBox_student_studentName.PlaceholderText = "enter your name";
            textBox_student_studentName.Size = new Size(125, 27);
            textBox_student_studentName.TabIndex = 8;
            textBox_student_studentName.Visible = false;
            // 
            // Student
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox_student_studentName);
            Controls.Add(button_student_toRegister);
            Controls.Add(label_student_price);
            Controls.Add(label_student_lecturers);
            Controls.Add(button1);
            Controls.Add(label_student_subjects);
            Controls.Add(label_students_schedule);
            Controls.Add(label1);
            Controls.Add(comboBox_student_courses);
            Name = "Student";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student";
            FormClosed += Student_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox_student_courses;
        private Label label1;
        private Label label_students_schedule;
        private Label label_student_subjects;
        private Button button1;
        private Label label_student_lecturers;
        private Label label_student_price;
        private Button button_student_toRegister;
        private TextBox textBox_student_studentName;
    }
}