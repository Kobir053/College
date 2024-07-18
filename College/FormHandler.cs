using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College
{
    public class FormHandler
    {
        private DBContext _dbContext;

        public FormHandler(DBContext dBContext)
        {
            _dbContext = dBContext;
        }

        private void CloseAllForms()
        {
            for (int i = 0; i < Application.OpenForms.Count; i++)
            {
                Application.OpenForms[i]?.Hide();
            }
        }

        public void Show(string frm, string studentName = null)
        {

            CloseAllForms();

            Form myForm = frm switch
            {
                "Form1" => new Form1(_dbContext, this),
                "LeaveDetails" => new LeaveDetails(_dbContext, this),
                "Student" => new Student(_dbContext, this),
                "StudentOwnOrPay" => new StudentOwnOrPay(_dbContext, this, studentName),
                "AdminSignin" => new AdminSignin(_dbContext, this),
                "AdminForm" => new AdminForm(),
                _ => throw new ArgumentException("invalid form name ", nameof(frm))
            };
            myForm.Show();
        }
    }
}
