using System;
using System.ComponentModel.DataAnnotations;

namespace FirstResponsiveWebAppChaudhary.Models
{
    public class User
    {
        // Constant for minimum year allowed
        private const int MinimumBirthYear = 1900;

        [Required(ErrorMessage = "Please enter your name.")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Please enter your birth year.")]
        [Range(MinimumBirthYear, int.MaxValue, ErrorMessage = "Invalid birth year.")]
        public int BirthYear { get; set; }

        [DataType(DataType.Date)]
        public DateTime? BirthDate { get; set; } // Nullable

        // Current year age method 
        public int AgeThisYear(int currentYear)
        {
            return currentYear - BirthYear;
        }

        // Current age based on DOB method
        public int AgeToday()
        {
            if (BirthDate.HasValue)
            {
                var today = DateTime.Today;
                var age = today.Year - BirthDate.Value.Year;
                if (BirthDate.Value.Date > today.AddYears(-age)) // Adjust if DOB hasn't occured this year
                {
                    age--;
                }
                return age;
            }
            return 0; // Default for missing DOB
        }
    }
}
