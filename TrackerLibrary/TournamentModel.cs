using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    public class TournamentModel
    {
        public string TournamentName { get; set; }
        public decimal EntryFee { get; set; }
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>(); // This is the data type of the property. It's a list of lists, where each inner list contains objects of type "MatchupModel." In other words, it's a nested list structure.
    }
}
