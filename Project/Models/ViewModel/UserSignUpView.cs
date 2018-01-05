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

        //Removed City

        [Required(ErrorMessage = "Email Required")]
        [Display(Name = "Email")]
        public string email { get; set; }

        [Required(ErrorMessage = "Longitutde Required")]
        [Display(Name = "Longitude")]
        public float longitude { get; set; }

        [Required(ErrorMessage = "Latitutde Required")]
        [Display(Name = "Latitude")]
        public float latitude { get; set; }



    }
}