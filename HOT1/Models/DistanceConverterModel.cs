using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace HOT1.Models
{
    public class DistanceConverterModel
    {
        public const decimal CM_PER_IN = 2.54M;

        [Required(ErrorMessage = "Please enter a distance in inches")]
        [Range(1, 500, ErrorMessage = "Please enter a value between 1 and 500.")]
        public decimal? DistanceInInches { get; set; }
        public decimal? DistanceInCentimeters { get; set; }

        public decimal? InchesToCM()
        {
            decimal? DistanceConverted = DistanceInInches * CM_PER_IN;
            return DistanceConverted;
        }
    }
}
