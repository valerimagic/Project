using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.Entities
{
    public class Passengers : BaseClass
    {
        [Required]
        [MaxLength(20)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(20)]
        public string LastName { get; set; }

        [Required]
        [MaxLength(15)]
        public string PassportNumber { get; set; }

        [Required]
        [MaxLength(3)]
        public string LuggageKg { get; set; }

        public Flights FlightId { get; set; }

    }
}
