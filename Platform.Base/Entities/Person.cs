using System.ComponentModel.DataAnnotations;


namespace Platform.Base.Entities {
    public abstract class Person : BaseEntity {
        [Required]
        public string FullName { get; set; }
        [Required]
        public string SocialSecurity { get; set; }
        [Required]
        public Address Address { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string BirthDate { get; set;}

    }
}
