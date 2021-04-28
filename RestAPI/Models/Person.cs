using System;
using System.ComponentModel.DataAnnotations;

namespace RestAPI.Models
{
    public class Person
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public string DisplayName { get; set; }
    }
}
