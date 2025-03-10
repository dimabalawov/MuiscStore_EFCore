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
        public int RecordId { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        [Required]
        public int AuthorId { get; set; }

        [Required]
        public string Publisher { get; set; } = null!;

        [Required]
        public int AmountOfTracks { get; set; } = 0!;

        [Required]
        public int GenreId { get; set; }

        [Required]
        [Column(TypeName = "money")]
        [Range(0, double.MaxValue)]
        public decimal PrimeCost { get; set; } = 0;

        [Required]
        [Column(TypeName = "money")]
        [Range(0, double.MaxValue)]
        public decimal Price { get; set; } = 0;

        public int PromotionId { get; set; }

        public int UserId { get; set; }

        public int DailyBestId { get; set; }
        public int WeeklyBestId { get; set; }
        public int MonthlyBestId { get; set; }
        public int YearlyBestId { get; set; }


    }
}
