namespace College
{
    partial class LeaveDetails
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
            textBox_details_name = new TextBox();
            textBox_details_phone = new TextBox();
            button_details_send = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(285, 95);
            label1.Name = "label1";
            label1.Size = new Size(294, 20);
            label1.TabIndex = 0;
            label1.Text = "leave your details and we will call you back";
            // 
            // textBox_details_name
            // 
            textBox_details_name.Location = new Point(376, 157);
            textBox_details_name.Name = "textBox_details_name";
            textBox_details_name.PlaceholderText = "enter your name";
            textBox_details_name.Size = new Size(125, 27);
            textBox_details_name.TabIndex = 1;
            // 
            // textBox_details_phone
            // 
            textBox_details_phone.Location = new Point(376, 223);
            textBox_details_phone.Name = "textBox_details_phone";
            textBox_details_phone.PlaceholderText = "enter your phone number";
            textBox_details_phone.Size = new Size(125, 27);
            textBox_details_phone.TabIndex = 2;
            textBox_details_phone.KeyPress += textBox_details_phone_KeyPress;
            // 
            // button_details_send
            // 
            button_details_send.Location = new Point(396, 279);
            button_details_send.Name = "button_details_send";
            button_details_send.Size = new Size(94, 29);
            button_details_send.TabIndex = 3;
            button_details_send.Text = "send";
            button_details_send.UseVisualStyleBackColor = true;
            button_details_send.Click += button_details_send_Click;
            // 
            // LeaveDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_details_send);
            Controls.Add(textBox_details_phone);
            Controls.Add(textBox_details_name);
            Controls.Add(label1);
            Name = "LeaveDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LeaveDetails";
            FormClosed += LeaveDetails_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox_details_name;
        private TextBox textBox_details_phone;
        private Button button_details_send;
    }
}