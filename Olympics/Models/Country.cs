using System.ComponentModel.DataAnnotations;

namespace Olympics.Models
{
    public class Country
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string CountryCode { get; set; }  // Add this property
        public string FlagUrl => $"https://flagcdn.com/h120/{CountryCode.ToLower()}.png";
        public int GameId { get; set; }
        public Game Game { get; set; }
        public int SportTypeId { get; set; }
        public SportType SportType { get; set; }
    }
}
