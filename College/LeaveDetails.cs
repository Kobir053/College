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
    public partial class LeaveDetails : Form
    {
        private bool _close = true;
        private FormHandler _formHandler;
        private DBContext _dbContext;
        private Queries _queries;

        public LeaveDetails(DBContext dBContext, FormHandler formHandler)
        {
            InitializeComponent();
            _formHandler = formHandler;
            _dbContext = dBContext;
            _queries = new Queries(_dbContext);
        }

        private void button_details_send_Click(object sender, EventArgs e)
        {
            string name = textBox_details_name.Text;
            string phone = textBox_details_phone.Text;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(phone))
            {
                MessageBox.Show("you have to enter your details");
                return;
            }
            bool success = _queries.InsertInterested(name, phone);
            if (!success)
            {
                MessageBox.Show("couldn't enter your name :(");
                return;
            }
            MessageBox.Show("sent successfuly, we will contact you :)");
            _close = false;
            _formHandler.Show("Form1");
            return;
        }

        private void textBox_details_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void LeaveDetails_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(_close)
                Application.Exit();
        }
    }
}
