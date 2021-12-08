using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PosTrack.Data.Models
{
    public class Tag
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        [Required]
        public int TagLabel { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string Rfid { get; set; }







        //public virtual ICollection<Tag> LeftTags { get; set; }
        //public virtual ICollection<Tag> RightTags { get; set; }
        // Naviagation properties

        //////////
        //public Trolley Trolley { get; set; }

        //public IList<Trolley> Trolleys { get; set; }
        //public ICollection<Trolley> LeftTags { get; set; }
        //public ICollection<Trolley> RightTags { get; set; }
    }
}

