using System.ComponentModel.DataAnnotations;

namespace ContactsWebApp.Models
{
    public class Contact
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        public string Address { get; set; }
        public string? Note { get; set; }
    }
}
