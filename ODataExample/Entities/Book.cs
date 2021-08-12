using System.ComponentModel.DataAnnotations;

namespace ODataExample.Entities
{
    public class Book
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(256)]
        public string ISBN { get; set; }
        [Required]
        [MaxLength(512)]
        public string Title { get; set; }
        [Required]
        [MaxLength(512)]
        public string Author { get; set; }
        public decimal Price { get; set; }
        [Required]
        public Address Location { get; set; }
        [Required]
        public Press Press { get; set; }
    }
}