using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuiscStore_EFCore.Models
{
    public class Record
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        [Required]
        public int AuthorId { get; set; }

        [ForeignKey("AuthorId")]
        public Author Author { get; set; } = null!;

        [Required]
        public string Publisher { get; set; } = null!;

        [Required]
        public int AmountOfTracks { get; set; } = 0!;

        [Required]
        public int GenreId { get; set; }

        [ForeignKey("GenreId")]
        public Genre Genre { get; set; } = null!;

        [Required]
        [Column(TypeName = "money")]
        [Range(0, double.MaxValue)]
        public decimal PrimeCost { get; set; } = 0;

        [Required]
        [Column(TypeName = "money")]
        [Range(0, double.MaxValue)]
        public decimal Price { get; set; } = 0;

        [ForeignKey("PromotionId")]
        public virtual Promotion Promotion { get; set; }
        public int PromotionId { get; set; }
    }
}
