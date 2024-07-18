namespace College
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            button_main_admin = new Button();
            button_main_register = new Button();
            button_main_student = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(350, 69);
            label1.Name = "label1";
            label1.Size = new Size(128, 20);
            label1.TabIndex = 0;
            label1.Text = "Kodcode College!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(304, 116);
            label2.Name = "label2";
            label2.Size = new Size(274, 20);
            label2.TabIndex = 1;
            label2.Text = "You are an admin or register or student?";
            // 
            // button_main_admin
            // 
            button_main_admin.Location = new Point(384, 180);
            button_main_admin.Name = "button_main_admin";
            button_main_admin.Size = new Size(94, 29);
            button_main_admin.TabIndex = 2;
            button_main_admin.Text = "Admin";
            button_main_admin.UseVisualStyleBackColor = true;
            button_main_admin.Click += button_main_admin_Click;
            // 
            // button_main_register
            // 
            button_main_register.Location = new Point(277, 265);
            button_main_register.Name = "button_main_register";
            button_main_register.Size = new Size(94, 29);
            button_main_register.TabIndex = 3;
            button_main_register.Text = "Register";
            button_main_register.UseVisualStyleBackColor = true;
            button_main_register.Click += button_main_register_Click;
            // 
            // button_main_student
            // 
            button_main_student.Location = new Point(474, 265);
            button_main_student.Name = "button_main_student";
            button_main_student.Size = new Size(94, 29);
            button_main_student.TabIndex = 4;
            button_main_student.Text = "student";
            button_main_student.UseVisualStyleBackColor = true;
            button_main_student.Click += button_main_student_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_main_student);
            Controls.Add(button_main_register);
            Controls.Add(button_main_admin);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            FormClosed += Form1_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button_main_admin;
        private Button button_main_register;
        private Button button_main_student;
    }
}
