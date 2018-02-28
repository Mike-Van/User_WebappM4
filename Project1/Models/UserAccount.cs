//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    public partial class UserAccount
    {
        [Key]
        public int UserId { get; set; }
        [Display(Name = "Username")]
        [Required(ErrorMessage = "Username is required.")]
        public string UserName { get; set; }
        [Display(Name = "Email")]
        [Required(ErrorMessage = "Email is required.")]
        [RegularExpression(@"^([\w-\.]+)@((\[[0-9]{1,3]\.)|(([\w-]+\.)+))([a-zA-Z{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "Please enter valid email.")]
        public string UserEmail { get; set; }
        [Display(Name = "Password")]
        [Required(ErrorMessage = "Password is required.")]
        [DataType(DataType.Password)]
        public string UserPassword { get; set; }
        [Display(Name = "Role")]
        [Required(ErrorMessage = "Please select one role")]
        public string UserRole { get; set; }
    }
}
