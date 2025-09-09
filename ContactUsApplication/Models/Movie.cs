using System.ComponentModel.DataAnnotations;

namespace ContactUsApplication.Models
{
    public class Movie
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Genre { get; set; }
        public int ReleaseYear { get; set; }

    }
}
