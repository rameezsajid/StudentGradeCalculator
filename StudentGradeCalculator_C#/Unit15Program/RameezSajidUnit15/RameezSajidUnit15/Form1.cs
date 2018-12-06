using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RameezSajidUnit15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Student> people = new List<Student>();
        List<Course> course = new List<Course>();
        List<Campus> campus = new List<Campus>();
        //List<Sandwich> sandwich = new List<Sandwich>();

        int personDisplayed = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            
            course.Add(new Sandwich("Yes", "Programming", "Software Development", "Databases", "Information Theory", "Project Unit", "Pass", "Pass", "Pass", "Pass", 2, 6, 6, 6, 12));
            course.Add(new Sandwich("Yes", "Programming", "Software Development", "Databases", "Information Theory", "Project Unit", "Pass", "Pass", "Pass", "Pass", 3, 6, 6, 6 ,12));
            course.Add(new Sandwich("No", "Networking", "Networking", "Information Theory", "PC System Support", "Project Unit", "Pass", "Fail", "Pass", "Pass", 2, 6, 0, 6, 12));
            course.Add(new Sandwich("Yes", "Networking", "Networking", "Information Theory", "PC System Support", "Project Unit", "Pass", "Pass", "Pass", "Pass", 2, 6, 6, 6, 12));
            course.Add(new Sandwich("No", "Programming", "Software Development", "Databases", "Information Theory", "Project Unit", "Pass", "Pass", "Pass", "Fail", 2, 6, 6, 6, 0));
            course.Add(new Sandwich("Yes", "Networking", "Networking", "Information Theory", "PC System Support", "Project Unit", "Pass", "Pass", "Pass", "Pass", 2, 6, 6, 6, 12));
            course.Add(new Sandwich("No", "Programming", "Software Development", "Databases", "Information Theory", "Project Unit", "Pass", "Pass", "Pass", "Pass", 3, 6, 6, 6, 12));
            course.Add(new Sandwich("Yes", "Networking", "Networking", "Information Theory", "PC System Support", "Project Unit", "Pass", "Pass", "Pass", "Pass", 2, 6, 6, 6, 12));
            course.Add(new Sandwich("Yes", "Networking", "Networking", "Information Theory", "PC System Support", "Project Unit", "Pass", "Fail", "Fail", "Pass", 2, 6, 0, 0, 12));
            course.Add(new Sandwich("No", "Programming", "Software Development", "Databases", "Information Theory", "Project Unit", "Pass", "Pass", "Pass", "Pass", 3, 6, 6, 6, 12));

            campus.Add(new Campus("Abbey Park"));
            campus.Add(new Campus("Abbey Park"));
            campus.Add(new Campus("Abbey Park"));
            campus.Add(new Campus("Freeman's Park"));
            campus.Add(new Campus("Freeman's Park"));
            campus.Add(new Campus("Abbey Park"));
            campus.Add(new Campus("Freeman's Park"));
            campus.Add(new Campus("Abbey Park"));
            campus.Add(new Campus("Freeman's Park"));
            campus.Add(new Campus("Freeman's Park"));

            people.Add(new Student("Rameez Sajid", 498974, 2012, "PASS", course[0], campus[0]));
            people.Add(new Student("Lionel Messi", 532851, 2010, "PASS", course[1], campus[1]));
            people.Add(new Student("Mesut Ozil", 781092, 2013, "FAIL", course[2], campus[2]));
            people.Add(new Student("Fred Flinstone", 452780, 2007, "PASS", course[3], campus[3]));
            people.Add(new Student("Scooby Doo", 327588, 2011, "FAIL", course[4], campus[4]));
            people.Add(new Student("Barney Rubble", 723922, 2014, "PASS", course[5], campus[5]));
            people.Add(new Student("David Beckham", 823613, 2009, "PASS", course[6], campus[6]));
            people.Add(new Student("Thierry Henry", 142298, 2008, "PASS", course[7], campus[7]));
            people.Add(new Student("Tom Jerry", 138247, 2005, "FAIL", course[8], campus[8]));
            people.Add(new Student("Wayne Rooney", 971829, 2013, "PASS", course[9], campus[9]));

            

            DisplayPersonFromList(personDisplayed);
            
            
           
        }



        public void DisplayPersonFromList(int studentIndex)
        {
            textBoxStudentName.Text = people[studentIndex].DisplayStudentName();
            textBoxStudentID.Text = Convert.ToString(people[studentIndex].DisplayStudentID());
            textBoxYearStarted.Text = Convert.ToString(people[studentIndex].DisplayYearStarted());
            textBoxPassOrFail.Text = people[studentIndex].DisplayPassOrFail();
            textBoxCourseName.Text = people[studentIndex].CourseStudying.DisplayCourseName();
            textBoxLengthOfCourse.Text = Convert.ToString(people[studentIndex].CourseStudying.DisplayLengthOfCourse());
            textBoxUnitName.Text = people[studentIndex].CourseStudying.DisplayUnitName();
            textBoxUnitGrade.Text = people[studentIndex].CourseStudying.DisplayUnitGrade();
            textBoxUnitPoints.Text = Convert.ToString(people[studentIndex].CourseStudying.DisplayUnitPoints());
            textBoxCampusName.Text = people[studentIndex].CampusStudying.DisplayCampusName();
            

            Course courseOn = people[studentIndex].CourseStudying;

            if (courseOn.GetType() == typeof(Sandwich))
            {

                textBoxSandwichCourse.Text = ((Sandwich)courseOn).DisplayWorkExperience();

            }

            else
            {

            }

            


            textBoxUnitNameTwo.Text = people[studentIndex].CourseStudying.DisplayUnitNameTwo();
            textBoxUnitGradeTwo.Text = people[studentIndex].CourseStudying.DisplayUnitGradeTwo();
            textBoxUnitPointsTwo.Text = Convert.ToString(people[studentIndex].CourseStudying.DisplayUnitPointsTwo());
            textBoxUnitNameThree.Text = people[studentIndex].CourseStudying.DisplayUnitNameThree();
            textBoxUnitGradeThree.Text = people[studentIndex].CourseStudying.DisplayUnitGradeThree();
            textBoxUnitPointsThree.Text = Convert.ToString(people[studentIndex].CourseStudying.DisplayUnitPointsThree());
            textBoxUnitNameFour.Text = people[studentIndex].CourseStudying.DisplayUnitNameFour();
            textBoxUnitGradeFour.Text = people[studentIndex].CourseStudying.DisplayUnitGradeFour();
            textBoxUnitPointsFour.Text = Convert.ToString(people[studentIndex].CourseStudying.DisplayUnitPointsFour());

            
        }

       


        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            personDisplayed -= 1;
            if (personDisplayed == -1)
            {
                personDisplayed = people.Count - 1;
            }

            DisplayPersonFromList(personDisplayed);
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            personDisplayed += 1;
            if (personDisplayed == people.Count)
            {
                personDisplayed = 0;
            }
            DisplayPersonFromList(personDisplayed);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please press next to check the next students information");
        }


     

    }
}
