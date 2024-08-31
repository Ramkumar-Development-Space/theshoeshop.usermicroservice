using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace theshoeshop.userservice.domain.Entites
{
    public class User
    {
        [Key] public int Id { get; set; }
        [Required] public string Username { get; set; }

        [Required]
        [JsonIgnore]
        public string Password { get; set; }
        [Required] public string Name { get; set; }
        [Required] public string EmailAddress { get; set; }
        [Required] public string About { get; set; }

        [Required]
        [EnumDataType(typeof(Gender))]
        public string City { get; set; }
        [Required] public string Gender { get; set; }
        [Required] public int Age { get; set; }
        [Required] public double MobileNumber { get; set; }

        [Required]
        [EnumDataType((typeof(Roles)))]
        public string Role { get; set; }
    }

    public enum Roles
    {
        Admin,
        Customer
    }

    public enum Gender
    {
        Male,
        Female
    }
}
