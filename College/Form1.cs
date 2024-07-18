namespace College
{
    public partial class Form1 : Form
    {
        private bool _close = true;
        private DBContext _dbContext;
        private FormHandler _formHandler;

        public Form1(DBContext dBContext, FormHandler formHandler)
        {
            InitializeComponent();
            _dbContext = dBContext;
            _formHandler = formHandler;
        }

        private void button_main_register_Click(object sender, EventArgs e)
        {
            _close = false;
            _formHandler.Show("LeaveDetails");
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_close)
                Application.Exit();
        }

        private void button_main_student_Click(object sender, EventArgs e)
        {
            _close = false;
            _formHandler.Show("Student");
        }

        private void button_main_admin_Click(object sender, EventArgs e)
        {
            _close = false;
            // the name is kobi and the password is 12345//
            _formHandler.Show("AdminSignin");
        }
    }
}
