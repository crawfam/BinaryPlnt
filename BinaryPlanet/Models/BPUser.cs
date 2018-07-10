using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BinaryPlanet.Models
{
    public class BPUser
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(128)]
        public string AppId { get; set; }   
        
        [Required]
        [StringLength(255)]
        public string FirstName{ get; set; }

        [Required]
        [StringLength(255)]
        public string LastName { get; set; }

    }
}