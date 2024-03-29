﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AddressBook.Models
{
    public class Contact
    { 
        public int Id { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        
        [Display(Name ="Last Name")]
        public string LastName { get; set; }
        [Display(Name ="Address")]
        public string Address1 { get; set; }
        [Display(Name = "Address(Continued)")]
        public string? Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        [DataType(DataType.PostalCode)]
        public int Zip { get; set; }

        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string? Phone { get; set; }

        public DateTime Created { get; set; }
        
        [NotMapped]
        [Display(Name ="Image")]
        [DataType(DataType.Upload)]
        public IFormFile? ImageFile { get; set; }
        public byte[]? ImageBytes { get; set; }
        public string? ImageType { get; set; }

        [NotMapped]
        public string? FullName { get { return $"{FirstName} {LastName}"; } }
    }
}
