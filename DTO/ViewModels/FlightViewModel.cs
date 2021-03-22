namespace DTO.ViewModels
{
    using System.ComponentModel.DataAnnotations;

    public class FlightViewModel
    {
        [Required]
        [MaxLength(20)]
        public string DepartureDestination { get; set; }

        [Required]
        [MaxLength(20)]
        public string ArrivalDestination { get; set; }
    }
}
