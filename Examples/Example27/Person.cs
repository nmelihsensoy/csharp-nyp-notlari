using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example27
{
    class Location
    {
        public string locationName;
    }

    class School : Location
    {
        protected string schoolName;
        private int schoolId;

        public string schoolData
        {
            get
            {
                return schoolName + " - " + schoolId;
            }
        }

        private void setSchoolId()
        {
            var rand = new Random();
            schoolId = rand.Next(100, 999);
        }

        public School(string sName)
        {
            schoolName = sName;
            setSchoolId();
        }
    }

    partial class Person : School
    {
        internal string fullName;

        public Person(string fName, string schoolName) : base(schoolName)
        {
            fullName = fName;
            locationName = "Empty";
        }

        public string getAllData()
        {
            return "Name :" + fullName + "\nLocation : " + locationName + "\nSchool : " + base.schoolData;
        }

    }

    partial class Person
    {
        public void setLocation(string location)
        {
            locationName = location;
        }
    }

    partial class Person
    {
        public void showAllData()
        {
            MessageBox.Show(getAllData());
        }

    }
}
