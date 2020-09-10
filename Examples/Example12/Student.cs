using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example12
{
    public class Student
    {
        private string fullName;
        private int studentId;

        public Student(string fullName, int studentId)
        {
            this.fullName = fullName;
            this.studentId = studentId;
        }

        public void showStudent()
        {
            MessageBox.Show(this.fullName + " " + this.studentId, "Student");
        }

    }

}
