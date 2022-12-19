using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace MyFlight.Models
{
    public class AdminUser
    {
        [Required(ErrorMessage = "User name is required")]
        [StringLength(5)]
        [Key]
        public string UserName { get; set; }
        

        [Required(ErrorMessage = "Password is required")]
        [StringLength(5)]
        public string Password { get; set; }
    }
}