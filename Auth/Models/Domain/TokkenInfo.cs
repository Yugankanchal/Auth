namespace Auth.Models.Domain
{
    public class TokkenInfo
    {
        public int Id { get; set; } 
        public string UserName { get; set; }
        public string RefreshTokken { get; set; }
        public DateTime RefreshTokkenExpiry { get; set; }
    }
}
