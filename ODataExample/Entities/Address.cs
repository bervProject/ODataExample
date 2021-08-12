using System.ComponentModel.DataAnnotations;

namespace ODataExample.Entities
{
    public class Address
    {
        [Required]
        [MaxLength(256)]
        public string City { get; set; }
        [Required]
        [MaxLength(512)]
        public string Street { get; set; }
    }
}