using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BinaryPlanet.Models
{
    public class Poem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public int Sequence { get; set; }

        [Required]
        public int Section { get; set; }

        [Required]
        [StringLength(128)]
        public string Name { get; set; }

        [StringLength(128)]
        public string SpecialName { get; set; }

        [StringLength(128)]
        public string TagLine { get; set; }

    }
}

