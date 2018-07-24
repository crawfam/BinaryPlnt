using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BinaryPlanet.Models
{
    public class BPUserPoems
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int BPUserId { get; set; }
        public int PoemId { get; set; }

        public virtual BPUser BPUser { get; set; }
        public virtual Poem Poem { get; set; }

    }
}