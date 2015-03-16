using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Week6CodeChallenge.Models
{
    public partial class Contact
    {
        public int ContactID { get; set; }
        [Required(ErrorMessage = "First Name is required")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last Name is required")]

        public string LastName { get; set; }
        [Required(ErrorMessage = "E-mail is required")]

        public string Email { get; set; }
        [Required(ErrorMessage = "Phone number is required")]

        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Company name is required")]

        public string CompanyName { get; set; }
        [Required(ErrorMessage = "Project Description is required")]

        public string ProjectDescription { get; set; }
        [Required(ErrorMessage = "Comment is required")]

        public string Comment { get; set; }
    }
}