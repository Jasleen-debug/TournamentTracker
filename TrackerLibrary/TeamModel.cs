using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    public class TeamModel
    {
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();
        public String TeamName { get; set; }

        /*public TeamModel()//initialise the property
        {
            TeamMembers = new List<Person>();
        }*/


    }
}
