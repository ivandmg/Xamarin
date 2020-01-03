using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Models
{
    using System.ComponentModel.DataAnnotations;
    public enum TypeContact
    {
        PohoneNumber,
        Email,
        Facebook,
        Twitter,
    }
    public class Phone
    {
        [Key]
        public int PhoneID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public TypeContact Type { get; set; }
        [Required]
        public string Contact { get; set; }
    }
}