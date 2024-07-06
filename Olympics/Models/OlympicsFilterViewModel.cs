namespace Olympics.Models
{
    public class OlympicsFilterViewModel
    {
        public string Game { get; set; }
        public string SportType { get; set; }
        public List<Country> Countries { get; set; }
    }
}
