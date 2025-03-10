using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuiscStore_EFCore.Models
{
    public class WeeklyBest
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int WeekyBestId { get; set; }

        public ICollection<Record> Records { get; set; } = new List<Record>();
        public ICollection<Genre> Genres { get; set; } = new List<Genre>();
        public ICollection<Author> Authors { get; set; } = new List<Author>();
    }
}
