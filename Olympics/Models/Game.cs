using System.ComponentModel.DataAnnotations;

namespace Olympics.Models
{
    public class Game
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public ICollection<Country>? Countries { get; set; }
    }
}
