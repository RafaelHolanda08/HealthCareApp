using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Common.DTOs.Base {
    public class PersonDTO {
        public string FullName { get; set; }
        public string SocialSecurity { get; set; }  
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string BirthDate { get; set; }
        public string ZipCode { get; set; }
        public string StreetName { get; set; }
        public int State { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string ExtraInformation { get; set; }
    }
}
