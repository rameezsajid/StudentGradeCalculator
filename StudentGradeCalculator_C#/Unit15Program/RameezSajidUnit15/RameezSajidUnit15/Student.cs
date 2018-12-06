using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RameezSajidUnit15
{
    class Student
    {
        private string studentName;
        private int studentID;
        private int yearStarted;
        private string passOrFail;

        private Course courseStudying;
        private Campus campusStudying;
        //private Sandwich sandwichCourse;

        // constructor

        public Student(string studentName, int studentID, int yearStarted, string passOrFail, Course courseStudying, Campus campusStudying)
        {
            this.studentName = studentName;
            this.studentID = studentID;
            this.yearStarted = yearStarted;
            this.passOrFail = passOrFail;

            this.courseStudying = courseStudying;
            this.campusStudying = campusStudying;
            //this.sandwichCourse = sandwichCourse;

        }

        // get set methods

        public string StudentName
        {
            get { return studentName; }
            set { studentName = value; }
        }
        public int StudentID
        {
            get { return studentID; }
            set { studentID = value; }
        }
        public int YearStarted
        {
            get { return yearStarted; }
            set { yearStarted = value; }
        }
        public string PassOrFail
        {
            get { return passOrFail; }
            set { passOrFail = value; }
        }

        // get set

        public Course CourseStudying
        {
            get { return courseStudying; }
        }

        public Campus CampusStudying
        {
            get { return campusStudying; }
            set { campusStudying = value; }

        }

       // public Sandwich WorkExperience
        //{
          //  get { return sandwichCourse; }
            //set { sandwichCourse = value; }
        //}




        // method starts here

        public string DisplayStudentName()
        {
            string name = studentName;
            return name;
        }

        public int DisplayStudentID()
        {
            int ID = studentID;
            return ID;
        }

        public int DisplayYearStarted()
        {
            int started = yearStarted;
            return started;
        }

        public string DisplayPassOrFail()
        {
            string passfail = passOrFail;
            return passfail;
        }

    

    }
}
