using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace MuiscStore_EFCore.Models
{
    public class Promotion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PromotionId { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        [Required]
        public int Discount { get; set; } = 0!;

        public ICollection<Record> Records { get; set; } = new List<Record>();
    }
}
