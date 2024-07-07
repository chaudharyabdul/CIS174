using System.ComponentModel.DataAnnotations;

namespace Olympics.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        public int SprintNumber { get; set; }
        public int PointValue { get; set; }
        public string Status { get; set; }
    }
}
