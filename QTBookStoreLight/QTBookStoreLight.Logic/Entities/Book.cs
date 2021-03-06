using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QTBookStoreLight.Logic.Entities
{
    [Table("Books", Schema = "App")]
    [Index(nameof(ISBNNumber), IsUnique = true)]
    public class Book : VersionEntity
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

        // Navigation properties
    }
}
