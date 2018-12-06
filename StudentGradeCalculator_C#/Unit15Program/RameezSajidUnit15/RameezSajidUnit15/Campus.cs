using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RameezSajidUnit15
{
    class Campus
    {
        private string campusName;

        public Campus(string campusName)
        {
            this.campusName = campusName;
        }
         // get set methods

        public string CampusName
        {
            get { return campusName; }
            set { campusName = value; }
        }

        // method

        public string DisplayCampusName()
        {
            string campusname = campusName;
            return campusname;
        }


    }
}
