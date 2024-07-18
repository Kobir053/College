using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.ApplicationServices;

namespace College
{
    public class Queries
    {
        private DBContext _dbContext;

        public Queries(DBContext dBContext)
        {
            _dbContext = dBContext;
        }

        public bool InsertInterested(string name, string phone)
        {
            string query = @"INSERT INTO CallBack (RegisterName, RegisterPhone) Values (@name, @phone);";
            List<SqlParameter> sqlParameters = new List<SqlParameter>()
            {
                new SqlParameter("@name", SqlDbType.VarChar) {Value = name},
                new SqlParameter("@phone", SqlDbType.VarChar) {Value = phone},
            };
            int rowsAffected = _dbContext.ExecuteNonQuery(query, sqlParameters.ToArray());
            return rowsAffected > 0;
        }

        public DataTable GetCourses()
        {
            string query = @"SELECT CourseName From Courses;";
            DataTable res = _dbContext.MakeQuery(query, null!);
            return res;
        }

        public int GetCourseID(string courseName)
        {
            string query = "SELECT ID FROM Courses WHERE CourseName = @courseName";
            SqlParameter[] parameters = { new SqlParameter("@courseName", courseName) };
            int res = _dbContext.ExecScalar(query, parameters);
            return res;
        }

        public DataTable GetDaysOfCourse(int courseID)
        {
            string query = @"select d.NameOfDay as name, d.StartTime as start, d.EndTime as endTime from Days d
                            inner join Cycles cy on d.CycleID = cy.ID
                            where cy.CourseID = @courseID;";
            SqlParameter[] parameters = { new SqlParameter("@courseID", courseID) };
            DataTable res = _dbContext.MakeQuery(query, parameters);
            return res;
        }

        public DataTable GetSubjectsOfCourse(int courseID)
        {
            string query = @"select s.SubjectName as name from Subjects s where s.CourseID = @courseID;";
            SqlParameter[] parameters = { new SqlParameter("@courseID", courseID) };
            DataTable res = _dbContext.MakeQuery(query, parameters);
            return res;
        }

        public DataTable GetLecturersOfCourse(int courseID)
        {
            string query = @"select l.LecturerName as name from Lecturers l
                            inner join Subjects s on s.LecturerID = l.ID
                            inner join Courses c on c.ID = s.CourseID
                            where s.CourseID = @courseID;";
            SqlParameter[] parameters = { new SqlParameter("@courseID", courseID) };
            DataTable res = _dbContext.MakeQuery(query, parameters);
            return res;
        }

        public int GetPricePerSubject(string lecturer)
        {
            string query = @"SELECT l.RateForHour * s.AmountOfHours as price from Lecturers l
                            inner join Subjects s on s.LecturerID = l.ID
                            where l.LecturerName = @lecturerName;";
            SqlParameter[] parameters = { new SqlParameter("@lecturerName", lecturer) };
            int price = _dbContext.ExecScalar(query, parameters);
            return price;
        }

        public bool AddStudentToCourse(string studentName, int price, int courseID)
        {
            string query = @"insert into Students (StudentName, CostOfCourse, CourseID) values (@studentName, @price, @courseID);";
            SqlParameter[] parameters = { new SqlParameter("@studentName", studentName),
                                          new SqlParameter("@courseID", courseID),
                                          new SqlParameter("@price", price)};
            int rowsAffected = _dbContext.ExecuteNonQuery(query, parameters);
            return rowsAffected > 0;
        }

        public DataTable GetDebtsPerCourse(int studentID)
        {
            string query = @"select s.CostOfCourse as price, c.CourseName as course from Students s
                            inner join Courses c on c.ID = s.CourseID where s.ID = @studentID;";
            SqlParameter[] parameters = { new SqlParameter("@studentID", studentID) };
            DataTable dt = _dbContext.MakeQuery(query,parameters);
            return dt;
        }

        public int GetStudentTotalDebt(string studentName)
        {
            string query = @"select CostOfCourse from Students where StudentName = @studentName;";
            SqlParameter[] parameters = { new SqlParameter("@studentName", studentName) };
            int debt = _dbContext.ExecScalar(query,parameters);
            return debt;
        }

        public int GetStudentID(string studentName)
        {
            string query = @"select ID from Students where StudentName = @studentName;";
            SqlParameter[] parameters = { new SqlParameter("@studentName", studentName)} ;
            int id = _dbContext.ExecScalar(query,parameters);
            return id;
        }

        public bool StudentPay(int money, int studentID)
        {
            string query = @"insert into Debts (StudentID, Payed) values (@studentID, @money);";
            SqlParameter[] parameters = { new SqlParameter("@studentID", studentID),
                                          new SqlParameter("@money", money) };
            int rowsAffected = _dbContext.ExecuteNonQuery(query, parameters);
            return rowsAffected > 0;
        }

        public int GetStudentPayed(int studentID)
        {
            string query = @"select Payed from Debts where StudentID = @studentID;";
            SqlParameter[] parameters = { new SqlParameter("@studentID", studentID) };
            int payed = _dbContext.ExecScalar(query, parameters);
            return payed;
        }

        public bool CheckAdmin(string name, string password)
        {
            string query = @"select AdminName, AdminPassword from Admin where AdminName = @AdminName and AdminPassword = @AdminPassword;";
            SqlParameter[] parameters = { new SqlParameter("AdminName", name),
                                          new SqlParameter("AdminPassword", password) };
            DataTable res = _dbContext.MakeQuery(query);
            return res.Rows.Count > 0;
        }
    }
}
