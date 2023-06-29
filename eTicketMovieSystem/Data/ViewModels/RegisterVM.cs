using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eTicketMovieSystem.Data.ViewModels
{
    public class RegisterVM
    {
        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Full name is required!")]
        public string FullName { get; set; }

        [Display(Name = "Email address")]
        [Required(ErrorMessage ="Email address is required!")]
        public string EmailAddress { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "Password  is required!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Confirm Password")]
        [Required(ErrorMessage = "Confirm Password  is required!")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Paaswords do not match!")]
        public string ConfirmPassword { get; set; }
    }
}
