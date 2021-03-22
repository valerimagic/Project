namespace DAL.Entities
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Flights : BaseClass
    {
        [Required]
        [MaxLength(10)]
        public string FlightNumber { get; set; }

        [Required]
        [MaxLength(20)]
        public string Departure { get; set; }

        [Required]
        [MaxLength(20)]
        public string Arrival { get; set; }

        public Airplanes AirplaneId { get; set; }

        public ICollection<Passengers> Passenger { get; set; } = new HashSet<Passengers>();
    }
}
