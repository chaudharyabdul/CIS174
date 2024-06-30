using System.ComponentModel.DataAnnotations;

namespace Olympics.Models
{
    public class SportType
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public ICollection<Country> Countries { get; set; }
    }
}
