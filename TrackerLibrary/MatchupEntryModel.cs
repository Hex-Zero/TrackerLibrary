namespace TrackerLibrary
{
    public class MatchupEntryModel
    {
        public TeamModel TeamCompeting { get; set; }
        public double Score { get; set; }
        public MatchupEntryModel ParentMatchup { get; set; }
    }
}
