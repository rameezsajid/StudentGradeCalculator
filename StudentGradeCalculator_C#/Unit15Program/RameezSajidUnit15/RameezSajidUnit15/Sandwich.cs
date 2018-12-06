using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RameezSajidUnit15
{
    class Sandwich : Course
    {
        private string workExperience;

        public Sandwich(string workExperience, string courseName, string unitName, string unitNameTwo, string unitNameThree, string unitNameFour, 
                        string unitGrade, string unitGradeTwo, string unitGradeThree, string unitGradeFour, int lengthOfCourse, 
                        int unitPoints, int unitPointsTwo, int unitPointsThree, int unitPointsFour) :
        base   (courseName, 
                unitName, 
                unitName, 
                unitNameThree, 
                unitNameFour, 
                unitGrade, 
                unitGradeTwo, 
                unitGradeThree, 
                unitGradeFour, 
                lengthOfCourse, 
                unitPoints, 
                unitPointsTwo, 
                unitPointsThree, 
                unitPointsFour)
        {
            this.workExperience = workExperience;
        }

        // get set methods

        public string WorkExperience
        {
            get { return workExperience; }
            set { WorkExperience = value; }
        }


        public string DisplayWorkExperience()
        {
            //string workexperience = WorkExperience;
            return workExperience;
        }


    }
}
