using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PosTrack.Data.Models
{
    public class Trolley
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] public int Id { get; set; }
        public int Label { get; set; }
        //public int LeftTagID { get; set; }
        //public int RightTagID { get; set; }
        public bool InService { get; set; }

        //https://stackoverflow.com/questions/55252077/adding-a-second-one-to-one-relationship-with-the-same-table-in-entity-framework
        public int LeftTagID { get; set; }
        public Tag LeftTag { get; set; }

        public int RightTagID { get; set; }
        public Tag RightTag { get; set; }

        //public virtual Tag LeftTag { get; set; }
        //public virtual Tag RightTag { get; set; }


        //https://entityframework.net/knowledge-base/28570916/defining-multiple-foreign-key-for-the-same-table-in-entity-framework-code-first
        //[ForeignKey("LeftTagID")]
        //[InverseProperty("LeftTagTags")]
        //public virtual Tag LeftTag { get; set; }

        //[ForeignKey("RightTagID")]
        //[InverseProperty("RightTagTags")]
        //public virtual Tag RightTag { get; set; }
    }
}
