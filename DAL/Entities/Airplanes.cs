using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Newtonsoft.Json;

namespace DAL.Entities
{
    public class Airplanes : BaseClass
    {
        [Required]
        [MaxLength(20)]
        public string Model { get; set; }

        [Required]
        [MaxLength(20)]
        public string SerialNumber { get; set; }

        public string Name { get; set; }

        public ICollection<Flights> Flights { get; set; } = new HashSet<Flights>();
    }
}
