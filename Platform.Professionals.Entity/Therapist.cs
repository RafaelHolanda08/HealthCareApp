using Platform.Base.Entities;
using Platform.Professionals.Entity.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Platform.Professionals.Entity {
    [Table("Therapist")]
    public class Therapist : Person, IProfessional{
        [Required]
        public string CRP { get; set; }
    }
}