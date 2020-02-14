namespace DraftSiteModels.ViewModels
{
    public class DraftViewModel
    {
        public string DraftStatus { get; set; }
        public bool IsComputerTeams { get; set; }
        public bool IsMultiSelect { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string PickTime { get; set; }
        public bool IsPublic { get; set; }
        public int RoundCount { get; set; }
        public string DraftStartType { get; set; }
        public string StartTime { get; set; }
        public string Username { get; set; }
    }
}
