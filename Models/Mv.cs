using System.ComponentModel.DataAnnotations;

namespace MusicVideo_MVC.Models
{
    public class Mv
    {
        public int Id { get; set; }

        [Required]
        public required string MusicName { get; set; }

        public string Artist { get; set; }

        [Required]
        public int ReleaseYear { get; set; }

        [Required]
        [Range(0, 5)]
        public decimal Rate { get; set; }

        public string Comment { get; set; }
    }
}
