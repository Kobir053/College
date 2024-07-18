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
    public partial class AdminSignin : Form
    {
        private bool _close = true;
        private FormHandler _formHandler;
        private DBContext _dbContext;
        private Queries _queries;

        public AdminSignin(DBContext dbContext, FormHandler formHandler)
        {
            InitializeComponent();
            _dbContext = dbContext;
            _formHandler = formHandler;
            _queries = new Queries(_dbContext);
        }

        private void button_signin_enter_Click(object sender, EventArgs e)
        {
            string name = textBox_signin_name.Text;
            string password = textBox_signin_password.Text;
            if(string.IsNullOrEmpty(name) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("you have to enter your details");
                return;
            }

            bool isAdmin = _queries.CheckAdmin(name, password);
            _close = false;
            if (!isAdmin)
            {
                MessageBox.Show("wrong details");
                _formHandler.Show("Form1");
                return;
            }
            MessageBox.Show("signed in successfuly");
            _formHandler.Show("AdminForm");
            return;
        }

        private void AdminSignin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(_close)
                Application.Exit();
        }
    }
}
