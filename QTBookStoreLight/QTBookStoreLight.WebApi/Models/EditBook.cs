using System.ComponentModel.DataAnnotations;

namespace QTBookStoreLight.WebApi.Models
{
    public class EditBook : VersionModel
    {
        [Required]
        [MaxLength(10)]
        public string Author { get; set; } = string.Empty;

        [Required]
        [MaxLength(10)]
        public string ISBNNumber { get; set; } = string.Empty;

        [Required]
        [MaxLength(2048)]
        public string Description { get; set; } = string.Empty;

        public double Price { get; set; }

        [MaxLength(1024)]
        public string? Note { get; set; }
    }
}
