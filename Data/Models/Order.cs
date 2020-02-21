using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace E_Com_Website.Data.Models
{
    public class Order
    {
        [Required(ErrorMessage = "Please enter your first name")]
        [Display(Name = "First name")]
        [StringLength(50)]
        [RegularExpression(@"(^[a-zA-Z][a-zA-Z\\s]+$)", ErrorMessage = "The First Name is not entered in a correct format")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter your last name")]
        [Display(Name = "Last name")]
        [StringLength(50)]
        [RegularExpression(@"(^[a-zA-Z][a-zA-Z\\s]+$)", ErrorMessage = "The Last Name is not entered in a correct format")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter your address")]
        [StringLength(100)]
        [Display(Name = "Address")]
        [RegularExpression(@"(^[A-Za-z0-9'\.\-\s\,]*$)", ErrorMessage = "The address is not entered in a correct format")]
        public string AddressLine { get; set; }
        
        [Required(ErrorMessage = "Please enter your zip code")]
        [Display(Name = "Zip code")]
        [StringLength(4, MinimumLength = 4, ErrorMessage = "Zip Code consist of 4 digits")]
        [RegularExpression(@"(^[0-9]+$)", ErrorMessage = "Zip Code consist of 4 digits")]
        public string ZipCode { get; set; }

        [Required(ErrorMessage = "Please enter your card number")]
        [Display(Name = "Card Number")]
        [StringLength(16, MinimumLength = 16, ErrorMessage = "Card number consist of 16 digits")]
        [RegularExpression(@"(^[0-9]+$)", ErrorMessage = "Card number consist of 16 digits")]
        public string CardNumber { get; set; }

        [Required(ErrorMessage = "Please enter your card experation date")]
        [Display(Name = "Card Experation Date")]
        public string CardExpireDate { get; set; }

        [Required(ErrorMessage = "Please enter your phone number")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "Phone number consist of 10 digits")]
        [RegularExpression(@"(^[0-9]+$)", ErrorMessage = "Phone number consist of 10 digits")]
        [Phone]
        public string PhoneNumber { get; set; }

        [Required]
        [StringLength(50)]
        [RegularExpression(@"(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*|""(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21\x23-\x5b\x5d-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])*"")@(?:(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?|\[(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?|[a-z0-9-]*[a-z0-9]:(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21-\x5a\x53-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])+)\])",
            ErrorMessage = "The email address is not entered in a correct format")]
        [EmailAddress]
        public string Email { get; set; }

    }
}
