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
    public partial class Student : Form
    {
        private bool _close = true;
        private DBContext _dbContext;
        private FormHandler _formHandler;
        private Queries _queries;
        private int _courseID;
        private int _total = 0;

        public Student(DBContext dBContext, FormHandler formHandler)
        {
            InitializeComponent();
            _dbContext = dBContext;
            _queries = new Queries(_dbContext);
            _formHandler = formHandler;
            InitComboBox();
        }

        public void InitComboBox()
        {
            DataTable dt = _queries.GetCourses();
            if (dt.Rows.Count <= 0)
            {
                MessageBox.Show("can't get the categories");
                return;
            }
            foreach (DataRow dr in dt.Rows)
            {
                comboBox_student_courses.Items.Add(dr["CourseName"].ToString());
            }
            return;
        }

        private void Student_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_close)
                Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string course = comboBox_student_courses.Text;
            if (string.IsNullOrEmpty(course))
            {
                MessageBox.Show("please chose a course");
                return;
            }
            _courseID = _queries.GetCourseID(course);
            if (_courseID == -1)
            {
                MessageBox.Show("we have a problem now please try again later");
                return;
            }
            DataTable dtOfDays = _queries.GetDaysOfCourse(_courseID);
            if (dtOfDays.Rows.Count <= 0)
            {
                MessageBox.Show("we didn't defined yet a days for this course");
                return;
            }
            DataTable dtOfSubjects = _queries.GetSubjectsOfCourse(_courseID);
            if (dtOfSubjects.Rows.Count <= 0)
            {
                MessageBox.Show("we didn't defined yet a subjects for this course");
                return;
            }
            DataTable dtOfLecturers = _queries.GetLecturersOfCourse(_courseID);
            if (dtOfLecturers.Rows.Count <= 0)
            {
                MessageBox.Show("we didn't defined yet a lecturers for this course");
                return;
            }
            string days = "Schedule: \r";
            foreach (DataRow dr in dtOfDays.Rows)
            {
                days += dr["name"].ToString() + " " + dr["start"].ToString() + " " + dr["endTime"].ToString() + "\r";
            }
            label_students_schedule.Visible = true;
            label_students_schedule.Text = days;

            string subjects = "Subjects: \r";
            foreach (DataRow dr in dtOfSubjects.Rows)
            {
                subjects += dr["name"].ToString() + "\r";
            }
            label_student_subjects.Visible = true;
            label_student_subjects.Text = subjects;

            string lecturers = "Lecturers: \r";
            foreach (DataRow dr in dtOfLecturers.Rows)
            {
                lecturers += dr["name"].ToString() + "\r";
                int res = _queries.GetPricePerSubject(dr["name"].ToString());
                if (res == -1)
                {
                    MessageBox.Show("we didn't defined yet a price for this course");
                    return;
                }
                _total += res;
            }
            label_student_lecturers.Visible = true;
            label_student_lecturers.Text = lecturers;

            label_student_price.Visible = true;
            label_student_price.Text = "the price for the course is: \r" + _total;

            textBox_student_studentName.Visible = true; 
            button_student_toRegister.Visible = true;
        }

        private void button_student_toRegister_Click(object sender, EventArgs e)
        {
            string studentName = textBox_student_studentName.Text;
            bool success = _queries.AddStudentToCourse(studentName, _total, _courseID);
            if (!success)
            {
                MessageBox.Show("couldn't add the student");
                return;
            }
            MessageBox.Show("you added successfuly and "+_total+" NIS added to your debt");
            _close = false;
            _formHandler.Show("StudentOwnOrPay", studentName);
            return;
        }
    }
}
