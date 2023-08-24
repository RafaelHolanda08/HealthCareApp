using Platform.Base.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Platform.Base.Entities {
    [Table("Address")]
    public class Address : BaseEntity {
        [Required]
        [StringLength(9)]
        public string ZipCode { get; set; }
        [Required]
        [StringLength(50)]
        public string StreetName { get; set; }
        [Required]
        public State State { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string District { get; set; }
        [StringLength(50)]
        public string ExtraInformation { get; set; }
        
    }
}
