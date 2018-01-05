using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Project.Models.ViewModel
{

    
    public class UserSignUpView
    {
        [Key]
        public int UserID { get; set; }

        
        [Required(ErrorMessage ="Name Required")]
        [Display(Name = "Name")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password Required")]
        [Display(Name = "Password")]
        public string password { get; set; }


        [Required(ErrorMessage = "City Required")]
        [Display(Name = "City")]
        public string cityName { get; set; }

        [Required(ErrorMessage = "Email Required")]
        [Display(Name = "Email")]
        public string email { get; set; }


    }
}