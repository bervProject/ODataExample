using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ODataExample.Entities
{
    public class Press
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(512)]
        public string Name { get; set; }
        [Required]
        [MaxLength(512)]
        public string Email { get; set; }
        public Category Category { get; set; }
        public List<Book> Books { get; set; }
    }
}