using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RameezSajidUnit15
{
    class Course
    {
        private string courseName;
        private string unitName;
        private string unitGrade;
        private string unitNameTwo;
        private string unitGradeTwo;
        private string unitNameThree;
        private string unitGradeThree;
        private string unitNameFour;
        private string unitGradeFour;

        private int unitPoints;
        private int unitPointsTwo;
        private int unitPointsThree;
        private int unitPointsFour;
        private int lengthOfCourse;


        public Course(string courseName, string unitName, string unitNameTwo, string unitNameThree, string unitNameFour, string unitGrade, string unitGradeTwo, 
                      string unitGradeThree, string unitGradeFour, int lengthOfCourse, int unitPoints, int unitPointsTwo, int unitPointsThree, int unitPointsFour)
        {
            this.courseName = courseName;
            this.unitName = unitName;
            this.unitNameTwo = unitNameTwo;
            this.unitNameThree = unitNameThree;
            this.unitNameFour = unitNameFour;
            this.unitGrade = unitGrade;
            this.unitGradeTwo = unitGradeTwo;
            this.unitGradeThree = unitGradeThree;
            this.unitGradeFour = unitGradeFour;

            this.lengthOfCourse = lengthOfCourse;
            this.unitPoints = unitPoints;
            this.unitPointsTwo = unitPointsTwo;
            this.unitPointsThree = unitPointsThree;
            this.unitPointsFour = unitPointsFour;
        }

        // get set methods

        public string CourseName
        {
            get { return courseName; }
            set { courseName = value; }
        }
        public string UnitName
        {
            get { return unitName; }
            set { unitName = value; }
        }
        public string UnitGrade
        {
            get { return unitGrade; }
            set { unitGrade = value; }
        }
        public int LengthOfCourse
        {
            get { return lengthOfCourse; }
            set { lengthOfCourse = value; }
        }
        public int UnitPoints
        {
            get { return unitPoints; }
            set { unitPoints = value; }
        }

        // method starts here

        public string DisplayCourseName()
        {
            string coursename = courseName;

            return coursename;
        }

        public int DisplayLengthOfCourse()
        {
            int lengthcourse = lengthOfCourse;

            return lengthcourse;
        }

        public string DisplayUnitName()
        {
            string unitname = unitName;

            return unitname;
        }

        public string DisplayUnitNameTwo()
        {
            string unitnametwo = unitNameTwo;

            return unitnametwo;
        }

        public string DisplayUnitNameThree()
        {
            string unitnamethree = unitNameThree;

            return unitnamethree;
        }

        public string DisplayUnitNameFour()
        {
            string unitnamefour = unitNameFour;

            return unitnamefour;
        }

        public string DisplayUnitGrade()
        {
            string unitgrade = unitGrade;

            return unitgrade;
        }

        public string DisplayUnitGradeTwo()
        {
            string unitgradeTwo = unitGradeTwo;

            return unitgradeTwo;
        }

        public string DisplayUnitGradeThree()
        {
            string unitgradethree = unitGradeThree;

            return unitgradethree;
        }

        public string DisplayUnitGradeFour()
        {
            string unitgradefour = unitGradeFour;

            return unitgradefour;
        }

        public int DisplayUnitPoints()
        {
            int unitpoints = unitPoints;

            return unitpoints;
        }

        public int DisplayUnitPointsTwo()
        {
            int unitpointstwo = unitPointsTwo;

            return unitpointstwo;
        }

        public int DisplayUnitPointsThree()
        {
            int unitpointsthree = unitPointsThree;

            return unitpointsthree;
        }

        public int DisplayUnitPointsFour()
        {
            int unitpointsfour = unitPointsFour;

            return unitpointsfour;
        }
    }
}
