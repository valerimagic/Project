namespace DAL.Entities
{
    using System.ComponentModel.DataAnnotations;

    public class RegistrationDetail : BaseClass
    {
        [Required]
        [MaxLength(20)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(20)]
        public string LastName { get; set; }

        [Required]
        [MaxLength(15)]
        public string PhoneNumber { get; set; }

        [Required]
        [MaxLength(30)]
        public string Email { get; set; }

        public Airplanes Airplane { get; set; }
    }
}
