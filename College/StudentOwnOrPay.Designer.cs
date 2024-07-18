namespace College
{
    partial class StudentOwnOrPay
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
            label_studentOwe = new Label();
            button_studentOwe_wantToPay = new Button();
            textBox_studentOwe_money = new TextBox();
            button_studentOwe_pay = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(372, 91);
            label1.Name = "label1";
            label1.Size = new Size(146, 20);
            label1.TabIndex = 0;
            label1.Text = "you owe the college:";
            // 
            // label_studentOwe
            // 
            label_studentOwe.AutoSize = true;
            label_studentOwe.Location = new Point(425, 136);
            label_studentOwe.Name = "label_studentOwe";
            label_studentOwe.Size = new Size(30, 20);
            label_studentOwe.TabIndex = 1;
            label_studentOwe.Text = "lab";
            label_studentOwe.Visible = false;
            // 
            // button_studentOwe_wantToPay
            // 
            button_studentOwe_wantToPay.Location = new Point(397, 212);
            button_studentOwe_wantToPay.Name = "button_studentOwe_wantToPay";
            button_studentOwe_wantToPay.Size = new Size(94, 29);
            button_studentOwe_wantToPay.TabIndex = 2;
            button_studentOwe_wantToPay.Text = "to pay:";
            button_studentOwe_wantToPay.UseVisualStyleBackColor = true;
            button_studentOwe_wantToPay.Click += button_studentOwe_wantToPay_Click;
            // 
            // textBox_studentOwe_money
            // 
            textBox_studentOwe_money.Location = new Point(382, 305);
            textBox_studentOwe_money.Name = "textBox_studentOwe_money";
            textBox_studentOwe_money.Size = new Size(125, 27);
            textBox_studentOwe_money.TabIndex = 3;
            textBox_studentOwe_money.Visible = false;
            textBox_studentOwe_money.KeyPress += textBox_studentOwe_money_KeyPress;
            // 
            // button_studentOwe_pay
            // 
            button_studentOwe_pay.Location = new Point(397, 352);
            button_studentOwe_pay.Name = "button_studentOwe_pay";
            button_studentOwe_pay.Size = new Size(94, 29);
            button_studentOwe_pay.TabIndex = 4;
            button_studentOwe_pay.Text = "pay";
            button_studentOwe_pay.UseVisualStyleBackColor = true;
            button_studentOwe_pay.Visible = false;
            button_studentOwe_pay.Click += button_studentOwe_pay_Click;
            // 
            // StudentOwnOrPay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_studentOwe_pay);
            Controls.Add(textBox_studentOwe_money);
            Controls.Add(button_studentOwe_wantToPay);
            Controls.Add(label_studentOwe);
            Controls.Add(label1);
            Name = "StudentOwnOrPay";
            Text = "StudentOwnOrPay";
            FormClosed += StudentOwnOrPay_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label_studentOwe;
        private Button button_studentOwe_wantToPay;
        private TextBox textBox_studentOwe_money;
        private Button button_studentOwe_pay;
    }
}