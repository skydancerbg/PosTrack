using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PosTrack.Data.Models
{
    public class Lot
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public int StatusId { get; set; }

        public int? ColorId { get; set; }

        [Required]
        public int LotDetailId { get; set; }

        [Column(TypeName = "decimal(8,3)")]
        public decimal? WaterContent { get; set; }

        [Required]
        public DateTime TimeCreatedId { get; set; }

        public DateTime? LastModified { get; set; }

        [Required]
        public int ModifiedById { get; set; }

    }
}
