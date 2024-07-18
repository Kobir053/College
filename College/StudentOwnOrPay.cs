using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace College
{
    public partial class StudentOwnOrPay : Form
    {
        private bool _close = true;
        private FormHandler _formHandler;
        private DBContext _dbContext;
        private Queries _queries;
        private string _studentName;
        private int _studentID;

        public StudentOwnOrPay(DBContext dBContext, FormHandler formHandler, string name)
        {
            InitializeComponent();
            _dbContext = dBContext;
            _formHandler = formHandler;
            _queries = new Queries(_dbContext);
            _studentName = name;
            GetStudentID();
            LoadCharges();
        }

        public void LoadCharges()
        {
            //int debt = _queries.GetStudentTotalDebt(_studentName);
            //if (debt == -1)
            //{
            //    MessageBox.Show("no debts ");
            //    return;
            //}
            //label_studentOwe.Visible = true;
            //label_studentOwe.Text = debt.ToString();
            //return;

            DataTable res = _queries.GetDebtsPerCourse(_studentID);
            if (res.Rows.Count <= 0)
            {
                MessageBox.Show("failed to load them both the course and its price");
                return;
            }
            string insert = "";
            foreach (DataRow row in res.Rows)
            {
                string s = row["course"].ToString() + "  -  " + row["price"].ToString() + ". \r";
                insert += s;
            }
            label_studentOwe.Visible = true;
            label_studentOwe.Text = insert;
            return;
        }

        public void GetStudentID()
        {
            int id = _queries.GetStudentID(_studentName);
            if (id == -1)
            {
                MessageBox.Show("failed to get your id");
                return;
            }
            _studentID = id;
        }

        private void button_studentOwe_wantToPay_Click(object sender, EventArgs e)
        {
            textBox_studentOwe_money.Visible = true;
            button_studentOwe_pay.Visible = true;
        }

        private void button_studentOwe_pay_Click(object sender, EventArgs e)
        {
            string input = textBox_studentOwe_money.Text;
            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("you need to enter money");
                return;
            }
            int payment = Convert.ToInt32(input);
            int owe = Convert.ToInt32(label_studentOwe.Text);
            if(payment > owe)
            {
                MessageBox.Show("you don't need to pay that mutch haha");
                return;
            }
            bool success = _queries.StudentPay(payment, _studentID);
            if (!success)
            {
                MessageBox.Show("cant pay");
                return;
            }
            MessageBox.Show("payed successfuly");
            _close = false;
            _formHandler.Show("Form1");
            return;

        }

        private void textBox_studentOwe_money_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void StudentOwnOrPay_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(_close)
                Application.Exit();
        }
    }
}
