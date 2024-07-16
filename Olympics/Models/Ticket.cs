using System.ComponentModel.DataAnnotations;

namespace Olympics.Models
{
    public class Ticket
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(100, ErrorMessage = "Name cannot be longer than 100 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Description is required")]
        [StringLength(500, ErrorMessage = "Description cannot be longer than 500 characters")]
        public string Description { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Sprint Number must be greater than 0")]
        public int SprintNumber { get; set; }

        [Range(1, 100, ErrorMessage = "Point Value must be between 1 and 100")]
        public int PointValue { get; set; }

        [Required(ErrorMessage = "Status is required")]
        [RegularExpression("to do|in progress|quality assurance|done", ErrorMessage = "Invalid Status")]
        public string Status { get; set; }
    }
}