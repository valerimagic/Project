namespace DAL.Entities
{
    using System.ComponentModel.DataAnnotations;

    public class BaseClass
    {
        [Key]
        public int ID { get; set; }
    }
}
