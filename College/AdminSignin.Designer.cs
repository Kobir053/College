namespace College
{
    partial class AdminSignin
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
            label1 = new Label();
            textBox_signin_name = new TextBox();
            textBox_signin_password = new TextBox();
            button_signin_enter = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(332, 78);
            label1.Name = "label1";
            label1.Size = new Size(213, 20);
            label1.TabIndex = 0;
            label1.Text = "enter your name and password";
            // 
            // textBox_signin_name
            // 
            textBox_signin_name.Location = new Point(383, 135);
            textBox_signin_name.Name = "textBox_signin_name";
            textBox_signin_name.PlaceholderText = "name";
            textBox_signin_name.Size = new Size(125, 27);
            textBox_signin_name.TabIndex = 1;
            // 
            // textBox_signin_password
            // 
            textBox_signin_password.Location = new Point(383, 196);
            textBox_signin_password.Name = "textBox_signin_password";
            textBox_signin_password.PlaceholderText = "password";
            textBox_signin_password.Size = new Size(125, 27);
            textBox_signin_password.TabIndex = 2;
            // 
            // button_signin_enter
            // 
            button_signin_enter.Location = new Point(401, 258);
            button_signin_enter.Name = "button_signin_enter";
            button_signin_enter.Size = new Size(94, 29);
            button_signin_enter.TabIndex = 3;
            button_signin_enter.Text = "sign in";
            button_signin_enter.UseVisualStyleBackColor = true;
            button_signin_enter.Click += button_signin_enter_Click;
            // 
            // AdminSignin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_signin_enter);
            Controls.Add(textBox_signin_password);
            Controls.Add(textBox_signin_name);
            Controls.Add(label1);
            Name = "AdminSignin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminSignin";
            FormClosed += AdminSignin_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox_signin_name;
        private TextBox textBox_signin_password;
        private Button button_signin_enter;
    }
}